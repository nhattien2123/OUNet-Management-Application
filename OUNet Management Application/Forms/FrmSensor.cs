using BUS;
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
using OUNet_Management_Application.Forms.Second_Forms;

namespace OUNet_Management_Application.Forms
{
    public partial class FrmSensor : Form
    {
        static SimpleTcpServer _server = null;
        private DTO.Users_DTO user;
        private Boolean flagDF = false;
        private Boolean flagM = false;

        public FrmSensor(DTO.Users_DTO user)
        {
            InitializeComponent();
            this.user = user;
            serviceDF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            serviceM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSensors.DataSource = Sensors_BUS.ListSensors_BUS();
        }

        private void LoadData()
        {
            dgvSensors.DataSource = Sensors_BUS.ListSensors_BUS();

            dgvSensors.Columns["SensorID"].HeaderCell.Value = "Mã máy";
            dgvSensors.Columns["SensorName"].HeaderCell.Value = "Tên máy";
            dgvSensors.Columns["AddressIP"].HeaderCell.Value = "IP";
            dgvSensors.Columns["Status"].HeaderCell.Value = "Trạng thái";
            dgvSensors.Columns["UTel"].HeaderCell.Value = "Số điện thoại";
            dgvSensors.Columns["TimeStart"].HeaderCell.Value = "Thời gian bắt đầu";
            dgvSensors.Columns["TimePlayed"].HeaderCell.Value = "Đã dùng";
            dgvSensors.Columns["TimeEnd"].Visible = false;

            dgvSensors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadList();
        }

        private void FrmSensor_Load(object sender, EventArgs e)
        {
            LoadData();
            try
            {
                if (FrmSensor._server == null)
                {
                    _server = new SimpleTcpServer("127.0.0.1:9999");
                    _server.Events.DataReceived += Events_DataReceived;
                    _server.Start();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}");
            }
        }

        private void pnSensors_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                string messageReceived = Encoding.UTF8.GetString(e.Data.ToArray());
                string[] data = messageReceived.Split('*');
                switch (data[0])
                {
                    case "ClientConnected":
                        string userID = data[1];
                        string namePC = data[2];
                        string IP = data[3];
                        if (!String.IsNullOrEmpty(namePC) && !String.IsNullOrEmpty(IP) && !String.IsNullOrEmpty(userID))
                        {
                            string flag = BUS.Sensors_BUS.FindAndCreateSensor(userID, namePC, IP);

                        }
                        break;
                    case "ClientDisconnected":
                        MessageBox.Show($"{data[0]} {data[1]} {data[2]}");
                        break;
                    case "Order":
                        string userIDOrder = data[1].Split('>')[1].Split('&')[0];
                        string userPhone = data[1].Split('>')[1].Split('&')[1];
                        string des = data[2].Split('>')[1];
                        string namePCOrder = data[3].Split('>')[1];
                        string orderD = data[4];
                        string[] orderDataList = orderD.Split(';');

                        List<DTO.OrderService_DTO> orderDF = new List<DTO.OrderService_DTO>();
                        DTO.OrderService_DTO orderService_DTO_M = new DTO.OrderService_DTO();
                        foreach (string order in orderDataList)
                        {
                            if (!String.IsNullOrEmpty(order))
                            {
                                string[] orderArr = order.Split('-');

                                if (orderArr[0] == "DF")
                                {
                                    this.flagDF = true;
                                    DTO.OrderService_DTO orderService_DTO = new DTO.OrderService_DTO()
                                    {
                                        ServiceID = orderArr[1],
                                        ServiceName = orderArr[2],
                                        ServiceQuantity = int.Parse(orderArr[3]),
                                        ServicePrice = int.Parse(orderArr[4]),
                                    };
                                    orderDF.Add(orderService_DTO);
                                }

                                if (orderArr[0] == "M")
                                {
                                    this.flagM = true;
                                    orderService_DTO_M.ServiceID = orderArr[1];
                                    orderService_DTO_M.ServiceName = orderArr[2];
                                    orderService_DTO_M.ServicePrice = int.Parse(orderArr[3]);
                                }
                            }
                        }

                        if (flagDF)
                        {
                            DTO.ServiceSensor_DTO objDF = new DTO.ServiceSensor_DTO()
                            {
                                Des = des,
                                UserID = userIDOrder,
                                NamePCOrder = namePCOrder,
                                OrderService = orderDF,
                                UserPhone = userPhone,
                                Time = DateTime.Now,
                                ID = Guid.NewGuid().ToString(),
                            };
                            FrmMain.orderListDF.Add(objDF);
                            this.flagDF = false;
                        }

                        if (flagM)
                        {
                            DTO.ServiceSensor_DTO objM = new DTO.ServiceSensor_DTO()
                            {
                                UserID = userIDOrder,
                                NamePCOrder = namePCOrder,
                                UserPhone = userPhone,
                                Price = orderService_DTO_M.ServicePrice,
                                Time = DateTime.Now,
                                ID = Guid.NewGuid().ToString(),
                            };
                            FrmMain.orderListM.Add(objM);
                            this.flagM = false;
                        }

                        LoadList();
                        break;
                    default:
                        MessageBox.Show($"{data[0]} {data[1]} {data[2]}");
                        break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}");
            }

        }

        private void LoadList()
        {
            serviceDF.Rows.Clear();
            serviceM.Rows.Clear();

            foreach (DTO.ServiceSensor_DTO item in FrmMain.orderListDF)
            {
                serviceDF.Rows.Add(item.NamePCOrder, item.Time);
            }

            foreach (DTO.ServiceSensor_DTO item2 in FrmMain.orderListM)
            {
                serviceM.Rows.Add(item2.NamePCOrder, item2.Time, item2.Price);
            }

            lbWaitingServiceCount.Text = FrmMain.orderListDF.Count.ToString();
            lbRechargeCount.Text = FrmMain.orderListM.Count.ToString();
        }
        private void dgvSensors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void serviceDF_SizeChanged(object sender, EventArgs e)
        {

            foreach (ColumnHeader column in serviceDF.Columns)
            {
                column.Width = serviceDF.Width / serviceDF.Columns.Count;
            }


        }

        private void lbWaitingServiceCount_Click(object sender, EventArgs e)
        {

        }

        private void serviceDF_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void serviceDF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serviceDF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                FrmDetailOrder frmDetailOrderDF = new FrmDetailOrder(FrmMain.orderListDF[index], user);
                frmDetailOrderDF.ShowDialog();
                LoadList();
            }
        }

        private void serviceDF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void serviceM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                FrmDetailOrder frmDetailOrderM = new FrmDetailOrder(FrmMain.orderListM[index], user);
                frmDetailOrderM.ShowDialog();
                LoadList();
            }
        }
    }
}
