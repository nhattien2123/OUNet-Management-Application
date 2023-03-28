using BUS;
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
    public partial class FrmAccount : Form
    {
        FrmAddUser frmAddUser;
        FrmDetailAccount frmDetailAccount;

        public FrmAccount()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser = new FrmAddUser();
            frmAddUser.ShowDialog();
        }

        private void PersonalizeDataGridView()
        {
            dgvUsers.Columns[3].Visible = false;
            dgvUsers.Columns[10].Visible = false;
            dgvUsers.Columns[11].Visible = false;
            dgvUsers.Columns[12].Visible = false;
            dgvUsers.Columns[13].Visible = false;
            dgvUsers.Columns[4].Width = 200;
        }

        public void LoadData()
        {
            dgvUsers.DataSource = Users_BUS.ListUsers_BUS();
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            cbColName.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            LoadData();
            PersonalizeDataGridView();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvUsers.Rows[index];
                string T_UserID = selectedRow.Cells[0].Value.ToString();
                string T_Username = selectedRow.Cells[1].Value.ToString();
                string T_Tel = selectedRow.Cells[2].Value.ToString();
                // Bỏ qua cột selectedRow.Cells[3].Value.ToString() tại vì cột này là Password
                string T_Address = selectedRow.Cells[4].Value.ToString();
                string T_Role = selectedRow.Cells[5].Value.ToString();
                float T_M_Account = float.Parse(selectedRow.Cells[6].Value.ToString());
                float T_S_Account = float.Parse(selectedRow.Cells[7].Value.ToString());
                DateTime T_LastAccess = DateTime.Parse(selectedRow.Cells[8].Value.ToString());
                bool T_Status = bool.Parse(selectedRow.Cells[9].Value.ToString());
                string T_Nation = selectedRow.Cells[10].Value.ToString();
                string T_Sex = selectedRow.Cells[11].Value.ToString();
                string T_HomeTown = selectedRow.Cells[12].Value.ToString();
                DateTime T_BirthDay = DateTime.Parse(selectedRow.Cells[13].Value.ToString());
                frmDetailAccount = new FrmDetailAccount(T_UserID, T_Username, T_Tel, T_Address, T_Role, T_M_Account, T_S_Account, T_LastAccess, T_Status, T_Nation, T_Sex, T_HomeTown, T_BirthDay);
                frmDetailAccount.ShowDialog();
            } catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchData()
        {
            string searchValue = txtSearch.Text.Trim();
            string colName, status;

            if (cbColName.Text == "Họ và tên")
                colName = "Username";
            else if (cbColName.Text == "Địa chỉ")
                colName = "Address";
            else if (cbColName.Text == "Số điện thoại")
                colName = "Tel";
            else colName = "Role";

            if (cbStatus.Text == "Đã kích hoạt")
                status = "1";
            else status = "0";

            dgvUsers.DataSource = Users_BUS.SearchUser_BUS(searchValue, colName, status);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}