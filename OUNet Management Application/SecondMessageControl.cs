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
    public partial class SecondMessageControl : UserControl
    {
        public SecondMessageControl()
        {
            InitializeComponent();
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; lbMessage.Text = _message; AddHeightText(); }
        }

        void AddHeightText()
        {
            MessageControl user = new MessageControl();
            user.BringToFront();
            pnBoxMessage.Height = Uilist.GetTextHeight(lbMessage) + 10;
            user.Height = lbMessage.Top + lbMessage.Height;
            this.Height = user.Bottom + 10;
        }

        private void SecondMessageControl_Load(object sender, EventArgs e)
        {
            AddHeightText();
        }
    }
}
