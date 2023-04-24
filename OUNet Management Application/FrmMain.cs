using DTO;
using BUS;
using OUNet_Management_Application.Forms;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace OUNet_Management_Application
{
    public partial class FrmMain : Form
    {
        private Form activeForm;
        Users_DTO user;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        FrmMessage frmMessage;
        private bool isShowMessage = false;

        public static List<DTO.ServiceSensor_DTO> orderListDF = new List<DTO.ServiceSensor_DTO>();
        public static List<DTO.ServiceSensor_DTO> orderListM = new List<DTO.ServiceSensor_DTO>();



        public FrmMain(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
            pnHeader.MouseDown += pnHeader_MouseDown;
            pnHeader.MouseUp += pnHeader_MouseUp;
            pnHeader.MouseMove += pnHeader_MouseMove;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmOUNET_Load(object sender, EventArgs e)
        {
            lbUsername.Text = "(" + user.Username + ")";
            HiddenPanelButton();
            pnSensors.Visible = true;
            OpenChildForm(new Forms.FrmSensor(user), sender);
            this.WindowState = FormWindowState.Maximized;
            frmMessage = new FrmMessage(user);
            frmMessage.Show();
            frmMessage.Hide();
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

        private void HiddenPanelButton()
        {
            pnSensors.Visible = false;
            pnUsers.Visible = false;
            pnServices.Visible = false;
            pnStatistical.Visible = false;
            pnHistory.Visible = false;
            pnMessages.Visible = false;
        }

        private void btnSensor_Click(object sender, EventArgs e)
        {
            HiddenPanelButton();
            pnSensors.Visible = true;
            if (isShowMessage)
            {
                frmMessage.Hide();
                isShowMessage = false;
            }
            OpenChildForm(new Forms.FrmSensor(user), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            HiddenPanelButton();
            pnUsers.Visible = true;
            if (isShowMessage)
            {
                frmMessage.Hide();
                isShowMessage = false;
            }
            OpenChildForm(new Forms.FrmAccount(), sender);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            HiddenPanelButton();
            pnServices.Visible = true;
            if (isShowMessage)
            {
                frmMessage.Hide();
                isShowMessage = false;
            }
            OpenChildForm(new Forms.FrmServices(user), sender);
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FrmMessage(user), sender);
            HiddenPanelButton();
            pnMessages.Visible = true;
            isShowMessage = true;
            frmMessage.Show();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            HiddenPanelButton();
            pnStatistical.Visible = true;
            if (isShowMessage)
            {
                frmMessage.Hide();
                isShowMessage = false;
            }
            OpenChildForm(new Forms.FrmStatistical(), sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HiddenPanelButton();
            pnHistory.Visible = true;
            if (isShowMessage)
            {
                frmMessage.Hide();
                isShowMessage = false;
            }
            OpenChildForm(new Forms.FrmHistory(), sender);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Minimized;
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int xDiff = Cursor.Position.X - lastCursor.X;
                int yDiff = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + xDiff, lastForm.Y + yDiff);
            }
        }

        private void pnHeader_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void timerTimeNow_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }
    }
}
