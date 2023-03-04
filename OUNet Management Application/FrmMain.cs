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
    public partial class FrmMain : Form
    {
        private Form activeForm;
        private FrmLogin frmLogin;
        private FrmLoading frmLoading;
        public static string username;

        public FrmMain()
        {
            //frmLogin = new FrmLogin();
            //frmLogin.ShowDialog();
            //frmLoading = new FrmLoading();
            //frmLoading.ShowDialog();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmOUNET_Load(object sender, EventArgs e)
        {
            lbUsername.Text = "(" + username + ")";
            OpenChildForm(new Forms.FrmSensor(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnForm.Controls.Add(childForm);
            this.pnForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSensor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmSensor(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmAccount(), sender);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmServices(), sender);
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmMessage(), sender);
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmStatistical(), sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmHistory(), sender);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }
    }
}
