using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUNet_Management_Application.Forms.Second_Forms
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Users_DTO user = new Users_DTO();
            user.UserID = "U" + Guid.NewGuid().ToString();
            user.Username = txtUsername.Text;
            user.Tel = txtTelephone.Text;
            user.Password = BUS.MD5Hash.Hash(txtPassword.Text);
            user.Address = txtAddress.Text;
            user.Role = "User";
            user.M_Account = 0;
            user.S_Account = 0;
            user.LastAccess = DateTime.Now;
            user.Status = true;
            user.Nation = txtNation.Text;
            if (rdMale.Checked)
                user.Sex = rdMale.Text;
            else user.Sex = rdFemale.Text;
            user.HomeTown = txtHomeTown.Text;
            user.BirthDay = dtpBirthDay.Value;

            if (String.IsNullOrEmpty(user.Username) || String.IsNullOrEmpty(user.Tel) ||
                String.IsNullOrEmpty(user.Password) || String.IsNullOrEmpty(user.Address) ||
                String.IsNullOrEmpty(user.Nation) || String.IsNullOrEmpty(user.Sex) ||
                String.IsNullOrEmpty(user.HomeTown) || String.IsNullOrEmpty(user.BirthDay.ToString()))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else if (user.BirthDay.Year < (DateTime.Now.Year - 16))
                MessageBox.Show("Ngày sinh không hợp lệ!");
            else if (user.Tel.Length > 11)
                MessageBox.Show("Số điện thoại không hợp lệ!");
            else
            {
                BUS.Users_BUS.AddUser_BUS(user);
                MessageBox.Show("Đã thêm thành công!");
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbAddress_Click(object sender, EventArgs e)
        {

        }

        private void lbCountry_Click(object sender, EventArgs e)
        {

        }

        private void lbSex_Click(object sender, EventArgs e)
        {

        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNation_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHomeTown_Click(object sender, EventArgs e)
        {

        }

        private void txtHomeTown_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHiddenPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
                txtPassword.PasswordChar = '*';
            else txtPassword.PasswordChar = '\0';
        }
    }
}
