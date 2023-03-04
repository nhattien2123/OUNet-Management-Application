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
    public partial class FrmHistory : Form
    {
        public FrmHistory()
        {
            InitializeComponent();
            txtSearch.Text = "Tìm kiếm ...";

            txtSearch.GotFocus += RemoveText;
            txtSearch.LostFocus += AddText;
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm ...")
            {
                txtSearch.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                txtSearch.Text = "Tìm kiếm ...";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lwList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
