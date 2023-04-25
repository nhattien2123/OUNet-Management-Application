using DTO;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace OUNet_Management_Application.Forms
{
    public partial class FrmMessage : Form
    {
        private SimpleTcpServer _server;
        private Dictionary<string, string> _table;
        Users_DTO user;
        Users_DTO s_user;

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int xDiff = Cursor.Position.X - lastCursor.X;
                int yDiff = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + xDiff, lastForm.Y + yDiff);
            }
        }

        public FrmMessage(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
            _table = new Dictionary<string, string>();
            pnHeader.MouseDown += pnHeader_MouseDown;
            pnHeader.MouseUp += pnHeader_MouseUp;
            pnHeader.MouseMove += pnHeader_MouseMove;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            string ipConnection = string.Empty;

            if (_server.IsListening)
            {
                // check if message box is empty or if no client is selected
                if (!string.IsNullOrEmpty(txtMessage.Text) && lstUsers.SelectedItem != null)
                {
                    foreach (var item in _table)
                    {
                        // <socket> <computer name>
                        if (item.Value == lstUsers.SelectedItem.ToString())
                        {
                            ipConnection = item.Key;
                        }
                    }

                    Messages_DTO message = new Messages_DTO();
                    message.MessageID = "M" + Guid.NewGuid().ToString();
                    message.Content = txtMessage.Text;
                    message.Time = DateTime.Now;
                    message.UserID = BUS.Users_BUS.CheckAccount_BUS(lbTel.Text).UserID;
                    message.AdminID = user.UserID;
                    message.UserSend = message.AdminID;

                    BUS.Messages_BUS.AddMessage_BUS(message);

                    txtInfo.Text += $@"Me: {txtMessage.Text}{Environment.NewLine}";
                    try
                    {
                        _server.Send(ipConnection, txtMessage.Text);
                    }
                    catch { }
                    txtMessage.Text = string.Empty;
                }
            }
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $@"{e.IpPort} connected.{Environment.NewLine}";
                //lstClientIP.Items.Add(e.IpPort);
                
                // [HEADER] + [MESSAGE]
                _server.Send(e.IpPort, $@"REQUESTNAME+{user.Tel}");
            });
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            var ipAddressWithPort = e.IpPort;
            var computerToRemove = string.Empty;


            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $@"{e.IpPort} disconnected.{Environment.NewLine}";
                foreach (var item in _table)
                {
                    if (item.Key.Equals(ipAddressWithPort))
                    {
                        computerToRemove = item.Value;

                    }
                }

                lstUsers.Items.Remove(computerToRemove);
                _table.Remove(ipAddressWithPort);
            });
        }
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            string messageReceived = Encoding.UTF8.GetString(e.Data.ToArray());
            if (messageReceived.Contains("NAMEREQUEST"))
            {
                var clientComputerName = string.Empty;
                char[] splitter = { '+' };
                string[] messageSplit = messageReceived.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

                // NAMEREQUEST+COMPUTERNAME

                foreach (var item in messageSplit)
                {
                    if (item.Equals("NAMEREQUEST"))
                    {
                        continue;
                    }
                    clientComputerName = item;

                    // COMPUTERNAME

                    _table.Add(e.IpPort, clientComputerName);

                    //this.Invoke((MethodInvoker)delegate
                    //{
                    //    lstUsers.Items.Add(clientComputerName);
                    //});
                }
            }

            else 
            {
                var tel = string.Empty;
                char[] splitter = { '+' };
                string[] messageSplit = messageReceived.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

                Messages_DTO message = new Messages_DTO();
                message.MessageID = "M" + Guid.NewGuid().ToString();
                message.Content = messageSplit[1];
                message.Time = DateTime.Now;
                message.UserID = BUS.Users_BUS.CheckAccount_BUS(messageSplit[0]).UserID;
                message.AdminID = user.UserID;
                message.UserSend = message.UserID;

                BUS.Messages_BUS.AddMessage_BUS(message);

                if (lstUsers.SelectedItem.ToString() == messageSplit[0])
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtInfo.Text += $@"{BUS.Users_BUS.CheckAccount_BUS(messageSplit[0]).Username}: {messageSplit[1]}{Environment.NewLine}";
                    });
                }
            }
        }

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            lbName.Text = user.Username;
            _table = new Dictionary<string, string>();
            btnSend.Enabled = false;

            try
            {
                _server = new SimpleTcpServer($"{FrmMain.IPLocal}:{FrmMain.PORTMess}");
                _server.Events.ClientConnected += Events_ClientConnected;
                _server.Events.ClientDisconnected += Events_ClientDisconnected;
                _server.Events.DataReceived += Events_DataReceived;
                _server.Start();

                txtInfo.Text += $@"Starting...{Environment.NewLine}";
                btnSend.Enabled = true;

                List<Users_DTO> lstusers_dto = BUS.Users_BUS.ListUsers_BUS();
                foreach (Users_DTO user in lstusers_dto)
                {
                    if (user.Role != "Admin")
                        lstUsers.Items.Add(user.Tel);
                }
            }
            catch (Exception err) {
                MessageBox.Show($"{err.Message}");
            }

        }

        private void FrmMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            _server.Stop();
        }

        public static string GetLocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < lstUsers.Items.Count; i++)
                {
                    // Lấy phần tử thứ i ra kiểm tra
                    string item = lstUsers.Items[i].ToString();

                    // So sánh với chuỗi cần tìm kiếm
                    if (item.Contains(txtSearch.Text))
                    {
                        lstUsers.SetSelected(i, true);
                    }
                }
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInfo.Clear();
            string selectedItem = lstUsers.SelectedItem.ToString();
            s_user = BUS.Users_BUS.CheckAccount_BUS(selectedItem);
            lbUsername.Text = s_user.Username;
            lbTel.Text = s_user.Tel;

            List<Messages_DTO> messages = BUS.Messages_BUS.TwoUsersListMessages_BUS(user, s_user);

            foreach (Messages_DTO message in messages)
            {
                if (message.UserSend == user.UserID)
                    txtInfo.Text += $@"Me: {message.Content}{Environment.NewLine}";
                else txtInfo.Text += $@"{s_user.Username}: {message.Content}{Environment.NewLine}";
            }
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}