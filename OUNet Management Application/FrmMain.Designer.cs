namespace OUNet_Management_Application
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnMenuBottom = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnSensor = new System.Windows.Forms.Button();
            this.pnForm = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnMenuBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Brown;
            this.pnHeader.Controls.Add(this.lbUsername);
            this.pnHeader.Controls.Add(this.btnMaximize);
            this.pnHeader.Controls.Add(this.pbLogo);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1500, 39);
            this.pnHeader.TabIndex = 0;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(213, 10);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(48, 16);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Name";
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = global::OUNet_Management_Application.Properties.Resources.Rectangle_Icon;
            this.btnMaximize.Location = new System.Drawing.Point(1412, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::OUNet_Management_Application.Properties.Resources.OU_white_logo;
            this.pbLogo.Location = new System.Drawing.Point(3, 1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(35, 35);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "OUNET Billing Server";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1454, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnMenuBottom
            // 
            this.pnMenuBottom.Controls.Add(this.btnHistory);
            this.pnMenuBottom.Controls.Add(this.btnStatistical);
            this.pnMenuBottom.Controls.Add(this.btnMessage);
            this.pnMenuBottom.Controls.Add(this.btnServices);
            this.pnMenuBottom.Controls.Add(this.btnAccount);
            this.pnMenuBottom.Controls.Add(this.btnSensor);
            this.pnMenuBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuBottom.Location = new System.Drawing.Point(0, 39);
            this.pnMenuBottom.Name = "pnMenuBottom";
            this.pnMenuBottom.Size = new System.Drawing.Size(1500, 59);
            this.pnMenuBottom.TabIndex = 3;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Image = global::OUNet_Management_Application.Properties.Resources.History_Icon;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(656, 0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(176, 59);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "Nhật ký, lịch sử";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStatistical.FlatAppearance.BorderSize = 0;
            this.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistical.Image = global::OUNet_Management_Application.Properties.Resources.Statistical_Icon;
            this.btnStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistical.Location = new System.Drawing.Point(524, 0);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(132, 59);
            this.btnStatistical.TabIndex = 9;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMessage.FlatAppearance.BorderSize = 0;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Image = global::OUNet_Management_Application.Properties.Resources.Message_Icon;
            this.btnMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessage.Location = new System.Drawing.Point(392, 0);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(132, 59);
            this.btnMessage.TabIndex = 8;
            this.btnMessage.Text = "Tin nhắn";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnServices
            // 
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Image = global::OUNet_Management_Application.Properties.Resources.Hamburger_Icon;
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.Location = new System.Drawing.Point(260, 0);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(132, 59);
            this.btnServices.TabIndex = 7;
            this.btnServices.Text = "Dịch vụ";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Image = global::OUNet_Management_Application.Properties.Resources.Group_User_Icon;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(128, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(132, 59);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnSensor
            // 
            this.btnSensor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSensor.FlatAppearance.BorderSize = 0;
            this.btnSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensor.Image = global::OUNet_Management_Application.Properties.Resources.Computer_Icon;
            this.btnSensor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSensor.Location = new System.Drawing.Point(0, 0);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(128, 59);
            this.btnSensor.TabIndex = 4;
            this.btnSensor.Text = "Máy trạm";
            this.btnSensor.UseVisualStyleBackColor = true;
            this.btnSensor.Click += new System.EventHandler(this.btnSensor_Click);
            // 
            // pnForm
            // 
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(0, 98);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(1500, 882);
            this.pnForm.TabIndex = 4;
            // 
            // FrmOUNET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 980);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.pnMenuBottom);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOUNET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOUNET";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmOUNET_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnMenuBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnMenuBottom;
        private System.Windows.Forms.Button btnSensor;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label lbUsername;
    }
}

