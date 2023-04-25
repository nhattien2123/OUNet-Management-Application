using DTO;
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

namespace OUNet_Management_Application.Forms
{
    public partial class FrmHistory : Form
    {
        Second_Forms.FrmBill frmBill;
        List<History_DTO> data;
        List<History_DTO> dataFilter = new List<History_DTO>();
        long unixTimeStart;
        long unixTimeEnd;
        DateTimeOffset dateTimeOffsetStart;
        DateTimeOffset dateTimeOffsetEnd;

        public FrmHistory()
        {
            InitializeComponent();
        }

        private void LoadDataWithSearch()
        {
            try
            {
                if (dataFilter.Count != 0 || (dataFilter.Count == 0 && !String.IsNullOrEmpty(txtSearch.Text.Trim().ToLower())))
                    dgvHistory.DataSource = dataFilter;
                else dgvHistory.DataSource = data;
                dgvHistory.Columns[1].Visible = false;
                dgvHistory.Columns[2].Visible = false;
                dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHistory.Columns["HistoryID"].HeaderCell.Value = "Mã lịch sử";
                dgvHistory.Columns["Description"].HeaderCell.Value = "Mô tả";
                dgvHistory.Columns["Time"].HeaderCell.Value = "Thời gian";
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}");
            }
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            cbServiceType.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            data = BUS.History_BUS.ListHistory_BUS();
            if (String.IsNullOrEmpty(txtSearch.Text.Trim().ToLower()))
            {
                dataFilter = data;
            }
            else
            {
                dataFilter = new List<History_DTO>();
                dateTimeOffsetStart = new DateTimeOffset(dtpFrom.Value);
                dateTimeOffsetEnd = new DateTimeOffset(dtpTo.Value);
                unixTimeStart = dateTimeOffsetStart.ToUnixTimeSeconds();
                unixTimeEnd = dateTimeOffsetEnd.ToUnixTimeSeconds();

                foreach (DTO.History_DTO item in data)
                {
                    DateTimeOffset dateTimeOffsetHistory = new DateTimeOffset(item.Time);
                    long unixTimeHistory = dateTimeOffsetHistory.ToUnixTimeSeconds();
                    if (item.Description.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()) && unixTimeHistory >= unixTimeStart && unixTimeHistory <= unixTimeEnd)
                    {
                            dataFilter.Add(item);
                    }
                }
            }
            LoadDataWithSearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataFilter = new List<DTO.History_DTO>();
            dateTimeOffsetStart = new DateTimeOffset(dtpFrom.Value);
            dateTimeOffsetEnd = new DateTimeOffset(dtpTo.Value);
            unixTimeStart = dateTimeOffsetStart.ToUnixTimeSeconds();
            unixTimeEnd = dateTimeOffsetEnd.ToUnixTimeSeconds();

            foreach (DTO.History_DTO item in data)
            {
                DateTimeOffset dateTimeOffsetHistory = new DateTimeOffset(item.Time);
                long unixTimeHistory = dateTimeOffsetHistory.ToUnixTimeSeconds();
                Bill_DTO bill = BUS.Bill_BUS.SearchBillsForFilter_BUS(item.HistoryID);

                if (item.Description.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()) && unixTimeHistory >= unixTimeStart && unixTimeHistory <= unixTimeEnd)
                {
                    if (cbServiceType.SelectedIndex == 0)
                        dataFilter.Add(item);
                    if (cbServiceType.SelectedIndex == 1 && bill.ServiceID[0] == 'M')
                        dataFilter.Add(item);
                    if (cbServiceType.SelectedIndex == 2 && (bill.ServiceID[0] == 'F' || bill.ServiceID[0] == 'D'))
                        dataFilter.Add(item);
                }
            }
            LoadDataWithSearch();
        }

        private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvHistory.Rows[index];
                string T_HistoryID = selectedRow.Cells[0].Value.ToString();
                string T_UserID = selectedRow.Cells[1].Value.ToString();
                string T_AdminID = selectedRow.Cells[2].Value.ToString();
                string T_Description = selectedRow.Cells[3].Value.ToString();
                DateTime T_Time = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
                frmBill = new Second_Forms.FrmBill(T_HistoryID, T_UserID, T_AdminID, T_Description, T_Time);
                frmBill.ShowDialog();
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataFilter = new List<DTO.History_DTO>();
            dateTimeOffsetStart = new DateTimeOffset(dtpFrom.Value);
            dateTimeOffsetEnd = new DateTimeOffset(dtpTo.Value);
            unixTimeStart = dateTimeOffsetStart.ToUnixTimeSeconds();
            unixTimeEnd = dateTimeOffsetEnd.ToUnixTimeSeconds();

            foreach (DTO.History_DTO item in data)
            {
                DateTimeOffset dateTimeOffsetHistory = new DateTimeOffset(item.Time);
                long unixTimeHistory = dateTimeOffsetHistory.ToUnixTimeSeconds();
                Bill_DTO bill = BUS.Bill_BUS.SearchBillsForFilter_BUS(item.HistoryID);

                if (item.Description.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()) && unixTimeHistory >= unixTimeStart && unixTimeHistory <= unixTimeEnd)
                {
                    if (cbServiceType.SelectedIndex == 0)
                        dataFilter.Add(item);
                    if (cbServiceType.SelectedIndex == 1 && bill.ServiceID[0] == 'M')
                        dataFilter.Add(item);
                    if (cbServiceType.SelectedIndex == 2 && (bill.ServiceID[0] == 'F' || bill.ServiceID[0] == 'D'))
                        dataFilter.Add(item);
                }
            }
            LoadDataWithSearch();
        }

        private void cbServiceType_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
