namespace OUNet_Management_Application
{
    partial class MessageControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnBoxMessage = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.pnBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBoxMessage
            // 
            this.pnBoxMessage.BackColor = System.Drawing.Color.LightPink;
            this.pnBoxMessage.Controls.Add(this.lbMessage);
            this.pnBoxMessage.Location = new System.Drawing.Point(94, 12);
            this.pnBoxMessage.Name = "pnBoxMessage";
            this.pnBoxMessage.Size = new System.Drawing.Size(370, 54);
            this.pnBoxMessage.TabIndex = 0;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(25, 20);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(44, 16);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "label1";
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBoxMessage);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(467, 85);
            this.Load += new System.EventHandler(this.MessageControl_Load);
            this.pnBoxMessage.ResumeLayout(false);
            this.pnBoxMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBoxMessage;
        private System.Windows.Forms.Label lbMessage;
    }
}
