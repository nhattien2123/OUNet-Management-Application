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
            this.components = new System.ComponentModel.Container();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnMenuBottom = new System.Windows.Forms.Panel();
            this.pnHistory = new System.Windows.Forms.Panel();
            this.pnStatistical = new System.Windows.Forms.Panel();
            this.pnMessages = new System.Windows.Forms.Panel();
            this.pnServices = new System.Windows.Forms.Panel();
            this.pnUsers = new System.Windows.Forms.Panel();
            this.pnSensors = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.pnForm = new System.Windows.Forms.Panel();
            this.timerTimeNow = new System.Windows.Forms.Timer(this.components);
            this.pbClock = new System.Windows.Forms.PictureBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnSensor = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnHeader.SuspendLayout();
            this.pnMenuBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Brown;
            this.pnHeader.Controls.Add(this.btnMinimize);
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
            this.pnHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHeader_Paint);
            this.pnHeader.DoubleClick += new System.EventHandler(this.pnHeader_DoubleClick);
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1371, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.pnMenuBottom.Controls.Add(this.pnHistory);
            this.pnMenuBottom.Controls.Add(this.pnStatistical);
            this.pnMenuBottom.Controls.Add(this.pnMessages);
            this.pnMenuBottom.Controls.Add(this.pnServices);
            this.pnMenuBottom.Controls.Add(this.pnUsers);
            this.pnMenuBottom.Controls.Add(this.pnSensors);
            this.pnMenuBottom.Controls.Add(this.pbClock);
            this.pnMenuBottom.Controls.Add(this.lbTime);
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
            // pnHistory
            // 
            this.pnHistory.BackColor = System.Drawing.Color.IndianRed;
            this.pnHistory.Location = new System.Drawing.Point(660, 54);
            this.pnHistory.Name = "pnHistory";
            this.pnHistory.Size = new System.Drawing.Size(172, 5);
            this.pnHistory.TabIndex = 5;
            // 
            // pnStatistical
            // 
            this.pnStatistical.BackColor = System.Drawing.Color.IndianRed;
            this.pnStatistical.Location = new System.Drawing.Point(528, 54);
            this.pnStatistical.Name = "pnStatistical";
            this.pnStatistical.Size = new System.Drawing.Size(128, 5);
            this.pnStatistical.TabIndex = 4;
            // 
            // pnMessages
            // 
            this.pnMessages.BackColor = System.Drawing.Color.IndianRed;
            this.pnMessages.Location = new System.Drawing.Point(396, 54);
            this.pnMessages.Name = "pnMessages";
            this.pnMessages.Size = new System.Drawing.Size(128, 5);
            this.pnMessages.TabIndex = 3;
            // 
            // pnServices
            // 
            this.pnServices.BackColor = System.Drawing.Color.IndianRed;
            this.pnServices.Location = new System.Drawing.Point(264, 54);
            this.pnServices.Name = "pnServices";
            this.pnServices.Size = new System.Drawing.Size(128, 5);
            this.pnServices.TabIndex = 2;
            // 
            // pnUsers
            // 
            this.pnUsers.BackColor = System.Drawing.Color.IndianRed;
            this.pnUsers.Location = new System.Drawing.Point(132, 54);
            this.pnUsers.Name = "pnUsers";
            this.pnUsers.Size = new System.Drawing.Size(128, 5);
            this.pnUsers.TabIndex = 1;
            // 
            // pnSensors
            // 
            this.pnSensors.BackColor = System.Drawing.Color.IndianRed;
            this.pnSensors.Location = new System.Drawing.Point(2, 54);
            this.pnSensors.Name = "pnSensors";
            this.pnSensors.Size = new System.Drawing.Size(126, 5);
            this.pnSensors.TabIndex = 0;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(1277, 31);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(58, 20);
            this.lbTime.TabIndex = 11;
            this.lbTime.Text = "(Time)";
            this.lbTime.Click += new System.EventHandler(this.lbTime_Click);
            // 
            // pnForm
            // 
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(0, 98);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(1500, 882);
            this.pnForm.TabIndex = 4;
            this.pnForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnForm_Paint);
            // 
            // timerTimeNow
            // 
            this.timerTimeNow.Enabled = true;
            this.timerTimeNow.Tick += new System.EventHandler(this.timerTimeNow_Tick);
            // 
            // pbClock
            // 
            this.pbClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClock.Image = global::OUNet_Management_Application.Properties.Resources.Time_Icon;
            this.pbClock.Location = new System.Drawing.Point(1246, 28);
            this.pbClock.Name = "pbClock";
            this.pbClock.Size = new System.Drawing.Size(25, 25);
            this.pbClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClock.TabIndex = 12;
            this.pbClock.TabStop = false;
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
            this.btnHistory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(176, 59);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "   Nhật ký, lịch sử";
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
            this.btnStatistical.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStatistical.Size = new System.Drawing.Size(132, 59);
            this.btnStatistical.TabIndex = 9;
            this.btnStatistical.Text = "   Thống kê";
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
            this.btnMessage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMessage.Size = new System.Drawing.Size(132, 59);
            this.btnMessage.TabIndex = 8;
            this.btnMessage.Text = "  Tin nhắn";
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
            this.btnServices.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnServices.Size = new System.Drawing.Size(132, 59);
            this.btnServices.TabIndex = 7;
            this.btnServices.Text = "   Dịch vụ";
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
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(132, 59);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "   Tài khoản";
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
            this.btnSensor.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSensor.Size = new System.Drawing.Size(128, 59);
            this.btnSensor.TabIndex = 4;
            this.btnSensor.Text = "     Máy trạm";
            this.btnSensor.UseVisualStyleBackColor = true;
            this.btnSensor.Click += new System.EventHandler(this.btnSensor_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.DodgerBlue;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 980);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.pnMenuBottom);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOUNET";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmOUNET_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnMenuBottom.ResumeLayout(false);
            this.pnMenuBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
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
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timerTimeNow;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pbClock;
        private System.Windows.Forms.Panel pnHistory;
        private System.Windows.Forms.Panel pnStatistical;
        private System.Windows.Forms.Panel pnMessages;
        private System.Windows.Forms.Panel pnServices;
        private System.Windows.Forms.Panel pnUsers;
        private System.Windows.Forms.Panel pnSensors;
    }
}

