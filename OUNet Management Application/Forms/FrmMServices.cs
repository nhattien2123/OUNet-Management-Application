using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using OUNet_Management_Application.Forms.Second_Forms;

namespace OUNet_Management_Application.Forms
{
    public partial class FrmMServices : Form
    {
        private Users_DTO user;
        private List<Services_DTO> MList = new List<Services_DTO>();
        public FrmMServices(Users_DTO user)
        {
            this.user = user;
            InitializeComponent();
        }
        

        
        private void FrmServices_Load(object sender, EventArgs e)
        {
            this.MList = BUS.Services_BUS.GetListMoney();
            dgvListM.DataSource = this.MList;

            dgvListM.Columns["ServiceImage"].Visible = false;
            dgvListM.Columns["ServiceID"].Visible = false;

            dgvListM.Columns["ServiceImage"].HeaderCell.Value = "Tên dịch vụ";
            dgvListM.Columns["Price"].HeaderCell.Value = "Giá";
            dgvListM.Columns["ServiceQuantity"].HeaderCell.Value = "Khuyến mãi";

            dgvListM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void airList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnServices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DialogResult dr = MessageBox.Show($"Bạn chắc chắn muốn nạp tiền với mệnh giá {MList[idx].Price} ?", "Thông báo!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                DialogResult momo = MessageBox.Show($"Bạn có muốn thanh toán qua momo?", "Thông báo!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (momo == DialogResult.Yes)
                {
                    FrmMomo frmMomo = new FrmMomo(MList[idx].Price.ToString());
                    frmMomo.ShowDialog();
                }
                if (FrmMainUser._client.IsConnected)
                {
                    string txt = BUS.Services_BUS.BillMFromUser(MList[idx], user.UserID, user.Tel, Environment.MachineName);
                    FrmMainUser._client.Send(txt);
                    MessageBox.Show("Order thành công!");
                }
            }
        }
    }
}
