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
    public partial class FrmDetailService : Form
    {
        private string idService;
        private string title;
        private string quantity;
        private string price;
        private string fileName;

        public FrmDetailService(string fileName, string title, string quantity, string price, string id)
        {
            this.idService = id;
            this.title = title;
            this.quantity = quantity;
            this.price = price;
            this.fileName = fileName;
            InitializeComponent();
        }

        private void FrmDetailService_Load(object sender, EventArgs e)
        {
            pictureBoxService.Image = Image.FromFile(Application.StartupPath + @"\Images\ServiceDetails\" + fileName);
            lbTitle.Text = title;
            txtPrice.Text = price;
            txtQuantity.Text = quantity;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                int price = int.Parse(txtPrice.Text.Trim());
                int quantity = int.Parse(txtQuantity.Text.Trim());

                if (price.ToString() == this.price && quantity.ToString() == this.quantity) 
                {
                    MessageBox.Show($"Không có gì để cập nhật!");
                    return;
                }

                if (price <= 0 || quantity < 0)
                {
                    MessageBox.Show($"Dữ liệu đầu vào chưa đúng!");
                    return;
                }

                string text = BUS.Services_BUS.UpdateService(this.idService, quantity, price);
                if (text == "True")
                {
                    MessageBox.Show($"Cập nhật thành công!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}");
            }
            
            
        }

        private void FrmDetailService_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
