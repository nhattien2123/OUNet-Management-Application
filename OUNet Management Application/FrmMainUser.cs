using DTO;
using OUNet_Management_Application.Forms;
using OUNet_Management_Application.Forms.Second_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using SuperSimpleTcp;
using System.Net;
using System.Net.NetworkInformation;

namespace OUNet_Management_Application
{
    public partial class FrmMainUser : Form
    {
        FrmMessageUser frmMessageUser;
        FrmChangePasswordUser frmChangePasswordUser;
        Users_DTO user;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        public static SimpleTcpClient _client;

        public FrmMainUser(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
            pnHeader.MouseDown += pnHeader_MouseDown;
            pnHeader.MouseUp += pnHeader_MouseUp;
            pnHeader.MouseMove += pnHeader_MouseMove;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Owner.Close();
            }
            catch
            {
                this.Owner.Close();
            }
            finally { 
                Application.Exit();
            }
        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        private void FrmMainUser_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = 0;
            this.Location = new Point(x, y);

            frmMessageUser = new FrmMessageUser(user);
            frmMessageUser.Show();
            frmMessageUser.Hide();

            txtMainAccount.Text = user.M_Account.ToString();
            txtSecondAccount.Text = user.S_Account.ToString();
            txtPrice.Text = "10,000";
            lbUsername.Text = "(" + user.Username + ")";

            try
            {
                _client = new SimpleTcpClient("127.0.0.1:9999");
                _client.Connect();

                if (FrmMainUser._client.IsConnected)
                {
                    FrmMainUser._client.Send($"ClientConnected*{user.UserID}*{Environment.MachineName}*{GetLocalIPv4(NetworkInterfaceType.Wireless80211)}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                _client.Send($"ClientDisconnected*{Environment.MachineName}*{Dns.GetHostAddresses(Environment.MachineName)[0]}");
            });
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                
            });
        }

        private void pbMessage_Click(object sender, EventArgs e)
        {
            frmMessageUser.Show();
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
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

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            _client.Disconnect();
            Application.Exit();
        }

        private void lbChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordUser = new FrmChangePasswordUser(user);
            frmChangePasswordUser.ShowDialog();
        }

        private void pbChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordUser = new FrmChangePasswordUser(user);
            frmChangePasswordUser.ShowDialog();
        }

        private void FrmMainUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSecondAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbServices_Click(object sender, EventArgs e)
        {
            FrmServiceUser frmSU = new FrmServiceUser(user);
            frmSU.Owner = this;
            frmSU.Show();
        }

        private void txtMainAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnDetailUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void pbRecharge_Click(object sender, EventArgs e)
        {
            FrmMServices frmMService = new FrmMServices(user);
            frmMService.Owner = this;
            frmMService.Show();
        }
    }
}
