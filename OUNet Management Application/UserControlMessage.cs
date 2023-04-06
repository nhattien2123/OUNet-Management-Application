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
    public partial class UserControlMessage : UserControl
    {
        public UserControlMessage()
        {
            InitializeComponent();
        }

        private string _Username;
        private string _Tel;

        public string Username
        {
            get { return _Username; } 
            set { _Username = value; lbName.Text = value; }
        }

        public string Tel
        {
            get { return _Tel; }
            set { _Tel = value; lbTel.Text = value; }
        }

        private void UserControlMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
