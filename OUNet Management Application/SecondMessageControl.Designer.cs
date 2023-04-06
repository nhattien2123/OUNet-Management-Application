namespace OUNet_Management_Application
{
    partial class SecondMessageControl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnBoxMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBoxMessage
            // 
            this.pnBoxMessage.BackColor = System.Drawing.Color.LightPink;
            this.pnBoxMessage.Controls.Add(this.lbMessage);
            this.pnBoxMessage.Location = new System.Drawing.Point(79, 15);
            this.pnBoxMessage.Name = "pnBoxMessage";
            this.pnBoxMessage.Size = new System.Drawing.Size(370, 54);
            this.pnBoxMessage.TabIndex = 1;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OUNet_Management_Application.Properties.Resources.User_Message_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SecondMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnBoxMessage);
            this.Name = "SecondMessageControl";
            this.Size = new System.Drawing.Size(467, 85);
            this.Load += new System.EventHandler(this.SecondMessageControl_Load);
            this.pnBoxMessage.ResumeLayout(false);
            this.pnBoxMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBoxMessage;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
