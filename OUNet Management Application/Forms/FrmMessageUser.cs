using DTO;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUNet_Management_Application.Forms
{
    public partial class FrmMessageUser : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private SimpleTcpClient _client;
        private string _localComputerName;

        Users_DTO user;

        public FrmMessageUser(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
            pnHeader.MouseDown += pnHeader_MouseDown;
            pnHeader.MouseUp += pnHeader_MouseUp;
            pnHeader.MouseMove += pnHeader_MouseMove;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text))
                {
                    _client.Send(txtMessage.Text);
                    txtInfo.Text += $@"Me: {txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = string.Empty;
                }
            }
        }

        private void FrmMessageUser_Load(object sender, EventArgs e)
        {
            _localComputerName = GetNameUser();

            try
            {
                _client = new SimpleTcpClient("127.0.0.1:9000");
                _client.Events.Connected += Events_Connected;
                _client.Events.Disconnected += Events_Disconnected;
                _client.Events.DataReceived += Events_DataReceived;
                _client.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        public string GetNameUser()
        {
            return user.Tel;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            var messageReceived = Encoding.UTF8.GetString(e.Data.ToArray());

            // REQUESTNAME
            if (messageReceived.Contains("REQUESTNAME"))
            {
                _client.Send("NAMEREQUEST+" + _localComputerName);
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtInfo.Text +=
                        $@"{e.IpPort}: {messageReceived}{Environment.NewLine}";
                });
            }
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {

                txtInfo.Text += $@"Server disconnected.{Environment.NewLine}";
                btnSend.Enabled = false;
            });
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                txtInfo.Text += $@"Server connected.{Environment.NewLine}";
            });
        }
    }
}
