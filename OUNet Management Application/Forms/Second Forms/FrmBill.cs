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
    public partial class FrmBill : Form
    {
        int total = 0;
        string HistoryID;
        string UserID;
        string AdminID;
        string Description;
        DateTime Time;

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public FrmBill(string HistoryID, string UserID, string AdminID, string Description, DateTime Time)
        {
            this.HistoryID = HistoryID;
            this.UserID = UserID;
            this.AdminID = AdminID;
            this.Description = Description;
            this.Time = Time;
            InitializeComponent();
            pnHeader.MouseDown += pnHeader_MouseDown;
            pnHeader.MouseUp += pnHeader_MouseUp;
            pnHeader.MouseMove += pnHeader_MouseMove;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBill_Load(object sender, EventArgs e)
        {

            dgvBill.DataSource = BUS.Bill_BUS.SearchBills_BUS(this.HistoryID);
            dgvBill.Columns[0].Visible = false;
            dgvBill.Columns[1].Visible = false;
            dgvBill.Columns["ServiceName"].HeaderCell.Value = "Tên dịch vụ";
            dgvBill.Columns["Price"].HeaderCell.Value = "Giá bán";
            dgvBill.Columns["Quantity"].HeaderCell.Value = "Số lượng";
            dgvBill.Columns["Total"].HeaderCell.Value = "Tổng cộng";
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                int value = Convert.ToInt32(row.Cells["Total"].Value);
                total += value;
            }

            lbTotal.Text = total.ToString() + "đ";

            lbTime.Text = Time.ToString();
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
    }
}
