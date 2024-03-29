﻿using System;
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
    public partial class FrmServiceUser : Form
    {
        private Users_DTO user;
        private List<DTO.Services_DTO> data;
        private List<DTO.Services_DTO> dataFilter = new List<DTO.Services_DTO>();
        private List<DTO.OrderService_DTO> orderList = new List<DTO.OrderService_DTO>();
        private string TYPE_SERVICE = "D";
        public int sum = 0;

        public FrmServiceUser(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                if (dataFilter.Count != 0 || (dataFilter.Count == 0 && !String.IsNullOrEmpty(txtSearch.Text.Trim().ToLower())))
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

        private List<DTO.Services_DTO> CreateDataFilter()
        {
            dataFilter = new List<DTO.Services_DTO>();
            foreach (DTO.Services_DTO item in data)
            {

                if (item.ServiceName.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()))
                { 
                    dataFilter.Add(item);
                }
            }
            return dataFilter;
        }

        private void LoadDataWithSearch()
        {
            data = BUS.Services_BUS.ListServices_BUS(TYPE_SERVICE);
            if (String.IsNullOrEmpty(txtSearch.Text.Trim().ToLower()))
            {
                dataFilter = data;
            }
            else 
            {
                dataFilter = CreateDataFilter();
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
            dataFilter = CreateDataFilter();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.orderList.Clear();
            this.txtNote.Text = "";
            this.sum = 0;
            LoadListView();
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Role == "User")
                {
                    try
                    {
                        foreach (DTO.OrderService_DTO item in orderList)
                        {
                            sum += item.ServiceTotal;
                        }
                        if (sum > FrmMainUser.user.M_Account)
                        {
                            MessageBox.Show("Tài khoản chính không đủ!");
                            return;
                        }
                        if (FrmMainUser._client.IsConnected)
                        {
                            string txt = BUS.Services_BUS.BillDFFromUser(orderList, user.UserID, user.Tel, txtNote.Text.Trim(), Environment.MachineName);
                            if (!String.IsNullOrEmpty(txt))
                            {
                                string txt2 = BUS.Users_BUS.SubMoneyFromUser(sum, FrmMainUser.user.UserID, false);
                                if (txt2.ToLower() == "true")
                                {
                                    FrmMainUser.user.M_Account -= sum;
                                }
                                FrmMainUser._client.Send(txt);
                                orderList.Clear();
                                LoadListView();
                                MessageBox.Show("Order thành công!");
                                this.sum = 0;
                            }
                        }
                    }
                    catch {
                        MessageBox.Show("Có lỗi xảy ra!");
                    }
                }
            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.TYPE_SERVICE = "F";
            LoadDataWithSearch();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            this.TYPE_SERVICE = "D";
            LoadDataWithSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnServices_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
