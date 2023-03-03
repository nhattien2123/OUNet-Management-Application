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
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void timerComplete_Tick(object sender, EventArgs e)
        {
            pnComplete.Width += 3;
            
            if (pnComplete.Width >= pnFullComplete.Width)
            {
                timerComplete.Stop();
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
