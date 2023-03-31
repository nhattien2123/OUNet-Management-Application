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

namespace OUNet_Management_Application
{
    public partial class FrmLoading : Form
    {
        Users_DTO user;
        FrmMain frmMain;
        FrmMainUser frmMainUser;
        public FrmLoading(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void timerComplete_Tick(object sender, EventArgs e)
        {
            pnComplete.Width += 50;
            
            if (pnComplete.Width >= pnFullComplete.Width)
            {
                timerComplete.Stop();
                if (user.Role == "Admin")
                {
                    frmMain = new FrmMain(user);
                    frmMain.Show();
                }
                else if (user.Role == "User")
                {
                    frmMainUser = new FrmMainUser(user);
                    frmMainUser.Show();
                }
                this.Close();
            }
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {

        }

        private void FrmLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pnComplete.Width < pnFullComplete.Width)
                Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
