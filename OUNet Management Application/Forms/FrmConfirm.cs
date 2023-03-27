using BUS;
using DAO;
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
    public partial class FrmConfirm : Form
    {
        FrmDetailAccount frmDetailAccount;
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public float M_Account { get; set; }
        public float S_Account { get; set; }
        public DateTime LastAccess { get; set; }
        public bool Status { get; set; }
        public string Nation { get; set; }
        public string Sex { get; set; }
        public string HomeTown { get; set; }
        public DateTime BirthDay { get; set; }

        public FrmConfirm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Users_DTO user = new Users_DTO();
            user.UserID = UserID;
            user.Username = Username;
            user.Tel = Telephone;
            user.Password = Password;
            user.Address = Address;
            user.Role = Role;
            user.M_Account = M_Account;
            user.S_Account = S_Account;
            user.LastAccess = LastAccess;
            user.Status = Status;
            user.Nation = Nation;
            user.Sex = Sex;
            user.HomeTown = HomeTown;
            user.BirthDay = BirthDay;
            user.UserID = UserID;

            BUS.Users_BUS.EditUser_BUS(user, user.UserID);

            Close();
            frmDetailAccount = (FrmDetailAccount)Application.OpenForms["FrmDetailAccount"];
            frmDetailAccount.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
            frmDetailAccount = (FrmDetailAccount)Application.OpenForms["FrmDetailAccount"];
            frmDetailAccount.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            frmDetailAccount = (FrmDetailAccount)Application.OpenForms["FrmDetailAccount"];
            frmDetailAccount.Close();
        }
    }
}
