using DTO;
using OUNet_Management_Application.Forms;
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

namespace OUNet_Management_Application
{
    public partial class FrmMainUser : Form
    {
        FrmMessageUser frmMessageUser;
        FrmChangePasswordUser frmChangePasswordUser;
        Users_DTO user;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public FrmMainUser(Users_DTO user)
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

        private void FrmMainUser_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = 0;
            this.Location = new Point(x, y);

            txtMainAccount.Text = user.M_Account.ToString();
            txtSecondAccount.Text = user.S_Account.ToString();
            txtPrice.Text = "10,000";
            lbUsername.Text = "(" + user.Username + ")";
        }

        private void pbMessage_Click(object sender, EventArgs e)
        {
            frmMessageUser = new FrmMessageUser(user);
            frmMessageUser.ShowDialog();
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

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordUser = new FrmChangePasswordUser(user);
            frmChangePasswordUser.ShowDialog();
        }

        private void pbChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordUser = new FrmChangePasswordUser(user);
            frmChangePasswordUser.ShowDialog();
        }
    }
}
