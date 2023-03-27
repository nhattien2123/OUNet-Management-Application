using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUNet_Management_Application.Forms.Second_Forms
{
    public partial class FrmDetailAccount : Form
    {
        FrmConfirm frmConfirm;
        private string UserID;
        private string Username;
        private string Tel;
        private string Address;
        private string Role;
        private float M_Account;
        private float S_Account;
        private DateTime LastAccess;
        private bool Status;
        private string Nation;
        private string Sex;
        private string HomeTown;
        private DateTime BirthDay;
        public FrmDetailAccount(string UserID, string Username, string Tel, string Address, string Role, float M_Account, float S_Account, DateTime LastAccess, bool Status, string Nation, string Sex, string HomeTown, DateTime BirthDay)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.Tel = Tel;
            this.Address = Address;
            this.Role = Role;
            this.M_Account = M_Account;
            this.S_Account = S_Account;
            this.LastAccess = LastAccess;
            this.Status = Status;
            this.Nation = Nation;
            this.Sex = Sex;
            this.HomeTown = HomeTown;
            this.BirthDay = BirthDay;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDetailAccount_Load(object sender, EventArgs e)
        {
            txtIDUser.Text = UserID;
            txtUsername.Text = Username;
            txtTelephone.Text = Tel;
            txtAddress.Text = Address;
            lbRoleVal.Text = Role;
            lbMainAccountVal.Text = M_Account.ToString();
            lbSecondAccountVal.Text = S_Account.ToString();
            lbLastAccessVal.Text = LastAccess.ToString();
            if (rdMale.Text == Sex)
                rdMale.Checked = true;
            else rdFemale.Checked = false;

            txtNation.Text = Nation;
            txtHomeTown.Text = HomeTown;
            dtpBirthDay.Value = BirthDay;

            if (Status)
            {
                lbStatusVal.Text = "Đã kích hoạt";
            } else { lbStatusVal.Text = "Chưa kích hoạt"; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = !txtUsername.ReadOnly;
            txtTelephone.ReadOnly = !txtTelephone.ReadOnly;
            txtAddress.ReadOnly = !txtAddress.ReadOnly;
            rdMale.Enabled = !rdMale.Enabled;
            rdFemale.Enabled = !rdFemale.Enabled;
            txtNation.ReadOnly = !txtNation.ReadOnly;
            txtHomeTown.ReadOnly = !txtHomeTown.ReadOnly;
            dtpBirthDay.Enabled = !dtpBirthDay.Enabled;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtTelephone.Text) ||
                String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtNation.Text) ||
                String.IsNullOrEmpty(txtHomeTown.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                frmConfirm = new FrmConfirm();
                frmConfirm.UserID = txtIDUser.Text;
                frmConfirm.Username = txtUsername.Text;
                frmConfirm.Telephone = txtTelephone.Text;
                frmConfirm.Address = txtAddress.Text;
                frmConfirm.Role = lbRole.Text;
                frmConfirm.M_Account = float.Parse(lbMainAccountVal.Text);
                frmConfirm.S_Account = float.Parse(lbSecondAccountVal.Text);
                frmConfirm.LastAccess = DateTime.Parse(lbLastAccessVal.Text);

                if (lbStatusVal.Text == "Đã kích hoạt")
                    frmConfirm.Status = true;
                else frmConfirm.Status = false;

                if (rdMale.Checked)
                    frmConfirm.Sex = rdMale.Text;
                else frmConfirm.Sex = rdFemale.Text;

                frmConfirm.Nation = txtNation.Text;
                frmConfirm.HomeTown = txtHomeTown.Text;
                frmConfirm.BirthDay = dtpBirthDay.Value;
                frmConfirm.ShowDialog();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            Users_DTO user = new Users_DTO();
            user.UserID = txtIDUser.Text;
            user.Password = BUS.MD5Hash.Hash("ounetuser");
            BUS.Users_BUS.ChangePassword_BUS(user);
            MessageBox.Show("Reset mật khẩu thành công\nMật khẩu của bạn là: ounetuser");
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Users_DTO user = new Users_DTO();
            user.UserID = UserID;
            user.Username = Username;
            user.Tel = Tel;
            user.Address = Address;
            user.Role = Role;
            user.M_Account = M_Account;
            user.S_Account = S_Account;
            user.LastAccess = LastAccess;
            user.Status = Status;
            user.Sex = Sex;
            user.Nation = Nation;
            user.HomeTown = HomeTown;
            user.BirthDay = BirthDay;

            BUS.Users_BUS.DeleteUser_BUS(user);
            MessageBox.Show("Đã xoá thành công!");
            
            Close();
        }
    }
}
