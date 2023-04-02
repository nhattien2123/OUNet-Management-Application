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
    public partial class FrmMessage : Form
    {
        private SimpleTcpServer _server;
        private Dictionary<string, string> _table;
        Users_DTO user;

        public FrmMessage(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
            _table = new Dictionary<string, string>();
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


                    _server.Send(ipConnection, txtMessage.Text);

                    txtInfo.Text += $@"Server: {txtMessage.Text}{Environment.NewLine}";
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
                _server.Send(e.IpPort, "REQUESTNAME");

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

                    this.Invoke((MethodInvoker)delegate
                    { 
                        lstUsers.Items.Add(clientComputerName);
                    });
                }
            }

            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtInfo.Text += $@"{e.IpPort}: {Encoding.UTF8.GetString(e.Data.ToArray())}{Environment.NewLine}";
                });
            }
        }

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            lbName.Text = user.Username;
            _table = new Dictionary<string, string>();
            btnSend.Enabled = false;

            _server = new SimpleTcpServer("127.0.0.1:9000");
            _server.Events.ClientConnected += Events_ClientConnected;
            _server.Events.ClientDisconnected += Events_ClientDisconnected;
            _server.Events.DataReceived += Events_DataReceived;
            _server.Start();

            txtInfo.Text += $@"Starting...{Environment.NewLine}";
            btnSend.Enabled = true;
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
    }
}
