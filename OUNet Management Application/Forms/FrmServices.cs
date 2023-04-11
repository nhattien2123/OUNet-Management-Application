using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using OUNet_Management_Application.Forms.Second_Forms;

namespace OUNet_Management_Application.Forms
{
    public partial class FrmServices : Form
    {
        Users_DTO user;
        private List<DTO.Services_DTO> data;
        private List<DTO.Services_DTO> dataFilter = new List<DTO.Services_DTO>();
        private List<DTO.OrderService_DTO> orderList = new List<DTO.OrderService_DTO>();


        public FrmServices(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                if (dataFilter.Count != 0)
                    dgvService.DataSource = dataFilter;
                else dgvService.DataSource = data;
                dgvService.Columns["ServiceID"].Visible = false;
                dgvService.Columns["ServiceImage"].Visible = false;
                dgvService.Columns["ServiceName"].HeaderCell.Value = "Tên dịch vụ";
                dgvService.Columns["Price"].HeaderCell.Value = "Giá bán";
                dgvService.Columns["ServiceQuantity"].HeaderCell.Value = "Số lượng còn lại";
                dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception e) {
                MessageBox.Show($"{e.Message}");
            }
        }

        private void LoadDataWithSearch()
        {
            data = BUS.Services_BUS.ListServices_BUS();
            if (String.IsNullOrEmpty(txtSearch.Text.Trim().ToLower()))
            {
                dataFilter = data;
            }
            else {
                dataFilter = new List<DTO.Services_DTO>();
                foreach (DTO.Services_DTO item in data)
                {
                    if (item.ServiceName.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()))
                    {
                        dataFilter.Add(item);
                    }
                }
            }
            LoadData();
        }

        private void FrmServices_Load(object sender, EventArgs e)
        {
            LoadDataWithSearch();
        }

        private void dgvService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                string serviceID = dgvService.Rows[index].Cells[0].Value.ToString().Trim();
                string serviceName = dgvService.Rows[index].Cells[1].Value.ToString().Trim();
                int servicePrice = int.Parse(dgvService.Rows[index].Cells[2].Value.ToString());
                int serviceQuantity = int.Parse(dgvService.Rows[index].Cells[4].Value.ToString());

                if (serviceQuantity <= 0)
                {
                    MessageBox.Show("Số lượng còn lại không đủ!");
                    return;
                }

                if (orderList.Count <= 0)
                {
                    if (serviceQuantity <= 0) 
                    {
                        MessageBox.Show("Số lượng còn lại không đủ!");
                    }
                    DTO.OrderService_DTO orderService_DTO = new DTO.OrderService_DTO()
                    {
                        ServiceID = serviceID,
                        ServiceName = serviceName,
                        ServiceQuantity = 1,
                        ServicePrice = servicePrice
                    };
                    this.orderList.Add(orderService_DTO);
                    LoadListView();
                    return;
                }

                bool flag = false;

                foreach (DTO.OrderService_DTO item in orderList)
                {
                    if (serviceID.Equals(item.ServiceID))
                    {
                        flag = true;
                        if (item.ServiceQuantity >= serviceQuantity)
                        {
                            MessageBox.Show($"Số lượng còn lại không đủ!");
                            return;
                        }
                        item.ServiceQuantity += 1;
                        break;
                    }
                }

                if (!flag)
                {
                    DTO.OrderService_DTO orderService_DTO = new DTO.OrderService_DTO()
                    {
                        ServiceID = serviceID,
                        ServiceName = serviceName,
                        ServiceQuantity = 1,
                        ServicePrice = servicePrice
                    };
                    this.orderList.Add(orderService_DTO);
                }
                LoadListView();

            }
            catch (Exception err) {
                MessageBox.Show($"{err.Message}");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataFilter = new List<DTO.Services_DTO>();
            foreach (DTO.Services_DTO item in data)
            {
                if (item.ServiceName.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()))
                {
                    dataFilter.Add(item);
                }
            }
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataWithSearch();
        }

        private void LoadListView()
        {
            listView1.Items.Clear();
            int sum = 0;
            foreach (DTO.OrderService_DTO item in orderList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ServiceName;
                lvi.SubItems.Add(item.ServiceQuantity.ToString());
                lvi.SubItems.Add(item.ServiceTotal.ToString());
                listView1.Items.Add(lvi);
                sum += item.ServiceTotal;
            }
            lbTotal.Text = sum.ToString() + " đ";
            lbPay.Text = sum.ToString() + " đ";
        }

        private void dgvService_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int currRow = dgvService.HitTest(e.X, e.Y).RowIndex;

                    if (currRow >= 0)
                    {
                        DataGridViewRow selectedRow = dgvService.Rows[currRow];
                        string id = selectedRow.Cells[0].Value.ToString().Trim();
                        string title = selectedRow.Cells[1].Value.ToString();
                        string price = selectedRow.Cells[2].Value.ToString();
                        string fileName = selectedRow.Cells[3].Value.ToString();
                        string quantity = selectedRow.Cells[4].Value.ToString();

                        var frmDetailService = new FrmDetailService(fileName, title, quantity, price, id);
                        frmDetailService.ShowDialog();
                        LoadDataWithSearch();
                    }


                }
            }
            catch (Exception er) {
                MessageBox.Show(er.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.orderList.Clear();
            LoadListView();
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Role == "Admin")
                {
                    string res = BUS.Services_BUS.PayBillService(orderList, user.UserID, user.UserID, txtNote.Text.Trim());
                    if (res == "True") {
                        this.orderList.Clear();
                        LoadListView();
                        MessageBox.Show("Thanh toán thành công!");
                    }
            }
            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }
        }
    }
}
