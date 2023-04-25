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
    public partial class FrmDetailOrder : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        private Boolean isDF = true;

        DTO.ServiceSensor_DTO serviceSensor = new DTO.ServiceSensor_DTO();
        private int totalBill = 0;
        DTO.Users_DTO user;
        public FrmDetailOrder(DTO.ServiceSensor_DTO serviceS, DTO.Users_DTO user, bool isM)
        {
            InitializeComponent();
            if (isM)
            { 
                isDF = false;
            }
            this.user = user;
            pnHeader.MouseDown += pnHeader_MouseDown;
            pnHeader.MouseUp += pnHeader_MouseUp;
            pnHeader.MouseMove += pnHeader_MouseMove;

            serviceSensor = serviceS;

            lbNamePC.Text = serviceSensor.NamePCOrder;
            lbPhone.Text = serviceSensor.UserPhone;
            lbTime.Text = serviceSensor.Time.ToString();
            lbStatus.Text = "Mới";

            if (isDF)
            {
                txtDes.Text = serviceSensor.Des.ToString();

                foreach (DTO.OrderService_DTO item in serviceSensor.OrderService)
                {
                    totalBill += item.ServiceTotal;
                }

                dgvDataBill.DataSource = serviceSensor.OrderService;
                dgvDataBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDataBill.Columns["ServiceID"].Visible = false;

                dgvDataBill.Columns["ServiceName"].HeaderCell.Value = "Tên dịch vụ";
                dgvDataBill.Columns["ServiceQuantity"].HeaderCell.Value = "Số lượng";
                dgvDataBill.Columns["ServicePrice"].HeaderCell.Value = "Giá";
                dgvDataBill.Columns["ServiceTotal"].HeaderCell.Value = "Tổng tiền";

                lbTotal.Text = $"{totalBill} đ";
            }
            if (!isDF)
            {
                dgvDataBill.DataSource = serviceSensor.OrderService;
                dgvDataBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvDataBill.Columns["ServiceID"].Visible = false;
                dgvDataBill.Columns["ServiceTotal"].Visible = false;
                dgvDataBill.Columns["ServiceQuantity"].Visible = false;

                dgvDataBill.Columns["ServiceName"].HeaderCell.Value = "Tên dịch vụ";
                dgvDataBill.Columns["ServicePrice"].HeaderCell.Value = "Giá";

                lbTotal.Text = $"{serviceSensor.OrderService[0].ServicePrice} đ";
            }
        }

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hành động này không thể hoàn tác!", "Bạn chắc chắn muốn huỷ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (isDF)
                    FrmMain.orderListDF = FrmMain.orderListDF.Where(order => order.ID != serviceSensor.ID).ToList();
                if (!isDF)
                    FrmMain.orderListM = FrmMain.orderListM.Where(order => order.ID != serviceSensor.ID).ToList();
            }
            this.Close();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void successBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Hành động này không thể hoàn tác!", "Bạn chắc chắn muốn hoàn tất hoá đơn?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (isDF)
                    { 
                        string res = BUS.Services_BUS.PayBillService(serviceSensor.OrderService, serviceSensor.UserID, user.UserID, txtDes.Text.Trim());
                        if (res == "True")
                        {
                            FrmMain.orderListDF = FrmMain.orderListDF.Where(order => order.ID != serviceSensor.ID).ToList();
                            MessageBox.Show("Thanh toán thành công!");
                        } else MessageBox.Show("Thanh toán thất bại!");
                    }

                    if (!isDF)
                    {
                        string res = BUS.Services_BUS.PayBillMService(serviceSensor.OrderService, serviceSensor.UserID, user.UserID);
                        MessageBox.Show(res);
                        if (res == "True")
                        {
                            FrmMain.orderListM = FrmMain.orderListM.Where(order => order.ID != serviceSensor.ID).ToList();
                            MessageBox.Show("Nạp tiền thành công!");
                        }
                        else MessageBox.Show("Thanh toán thất bại!");
                    }
                }
                this.Close();
                
            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }
        }

        private void dgvDataBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
