using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUNet_Management_Application.Forms.Second_Forms
{
    public partial class FrmChangePasswordUser : Form
    {
        Users_DTO user;
        public FrmChangePasswordUser(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (BUS.Users_BUS.CheckPassword_BUS(user.Tel, BUS.MD5Hash.Hash(txtOldPassword.Text)))
            {
                if (txtNewPassword.Text == txtRePassword.Text)
                {
                    user.Password = BUS.MD5Hash.Hash(txtNewPassword.Text);
                    BUS.Users_BUS.ChangePassword_BUS(user);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                else MessageBox.Show("Nhập lại mật khẩu mới không trùng khớp");
            }
            else MessageBox.Show("Bạn nhập sai mật khẩu cũ");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
