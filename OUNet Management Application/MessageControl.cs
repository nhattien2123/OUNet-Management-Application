using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OUNet_Management_Application
{
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }

        private string _Message;
        public string Message
        {
            get { return _Message; }
            set { _Message = value; lbMessage.Text = value; AddHeightText(); }
        }

        void AddHeightText()
        {
            MessageControl user = new MessageControl();
            user.BringToFront();
            pnBoxMessage.Height = Uilist.GetTextHeight(lbMessage) + 10;
            user.Height = lbMessage.Top + lbMessage.Height;
            this.Height = user.Bottom + 10;
        }

        private void MessageControl_Load(object sender, EventArgs e)
        {
            AddHeightText();
        }
    }
}
