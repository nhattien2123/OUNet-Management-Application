namespace OUNet_Management_Application.Forms
{
    partial class FrmSensor
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
            this.pnSensors = new System.Windows.Forms.Panel();
            this.cbSensor = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbSensor = new System.Windows.Forms.Label();
            this.pbSensor = new System.Windows.Forms.PictureBox();
            this.listViewSensors = new System.Windows.Forms.ListView();
            this.colSensorImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDSensor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameSensor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUseTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemainTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHistory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnWaitingService = new System.Windows.Forms.Panel();
            this.listViewWaitingService = new System.Windows.Forms.ListView();
            this.lbWaitingServiceCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbWaitingService = new System.Windows.Forms.Label();
            this.pnRecharge = new System.Windows.Forms.Panel();
            this.listViewRecharge = new System.Windows.Forms.ListView();
            this.lbRechargeCount = new System.Windows.Forms.Label();
            this.lbRecharge = new System.Windows.Forms.Label();
            this.pbRecharge = new System.Windows.Forms.PictureBox();
            this.pnSensors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor)).BeginInit();
            this.pnWaitingService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnRecharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecharge)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSensors
            // 
            this.pnSensors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSensors.BackColor = System.Drawing.Color.White;
            this.pnSensors.Controls.Add(this.cbSensor);
            this.pnSensors.Controls.Add(this.btnRefresh);
            this.pnSensors.Controls.Add(this.lbSensor);
            this.pnSensors.Controls.Add(this.pbSensor);
            this.pnSensors.Controls.Add(this.listViewSensors);
            this.pnSensors.Location = new System.Drawing.Point(12, 12);
            this.pnSensors.Name = "pnSensors";
            this.pnSensors.Size = new System.Drawing.Size(1025, 759);
            this.pnSensors.TabIndex = 1;
            // 
            // cbSensor
            // 
            this.cbSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSensor.FormattingEnabled = true;
            this.cbSensor.Location = new System.Drawing.Point(817, 28);
            this.cbSensor.Name = "cbSensor";
            this.cbSensor.Size = new System.Drawing.Size(121, 24);
            this.cbSensor.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Image = global::OUNet_Management_Application.Properties.Resources.Refresh_Icon;
            this.btnRefresh.Location = new System.Drawing.Point(956, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(42, 38);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbSensor
            // 
            this.lbSensor.AutoSize = true;
            this.lbSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSensor.ForeColor = System.Drawing.Color.Red;
            this.lbSensor.Location = new System.Drawing.Point(80, 29);
            this.lbSensor.Name = "lbSensor";
            this.lbSensor.Size = new System.Drawing.Size(118, 29);
            this.lbSensor.TabIndex = 2;
            this.lbSensor.Text = "Máy trạm";
            // 
            // pbSensor
            // 
            this.pbSensor.Image = global::OUNet_Management_Application.Properties.Resources.Sensor_Icon;
            this.pbSensor.Location = new System.Drawing.Point(24, 18);
            this.pbSensor.Name = "pbSensor";
            this.pbSensor.Size = new System.Drawing.Size(50, 50);
            this.pbSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSensor.TabIndex = 1;
            this.pbSensor.TabStop = false;
            // 
            // listViewSensors
            // 
            this.listViewSensors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSensors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSensorImage,
            this.colIDSensor,
            this.colNameSensor,
            this.colIP,
            this.colStatus,
            this.colUser,
            this.colStartTime,
            this.colUseTime,
            this.colRemainTime,
            this.colHistory});
            this.listViewSensors.HideSelection = false;
            this.listViewSensors.Location = new System.Drawing.Point(24, 74);
            this.listViewSensors.Name = "listViewSensors";
            this.listViewSensors.Size = new System.Drawing.Size(974, 657);
            this.listViewSensors.TabIndex = 0;
            this.listViewSensors.UseCompatibleStateImageBehavior = false;
            this.listViewSensors.View = System.Windows.Forms.View.Details;
            // 
            // colSensorImage
            // 
            this.colSensorImage.Text = "#";
            this.colSensorImage.Width = 20;
            // 
            // colIDSensor
            // 
            this.colIDSensor.Text = "Mã máy";
            // 
            // colNameSensor
            // 
            this.colNameSensor.Text = "Tên máy";
            this.colNameSensor.Width = 100;
            // 
            // colIP
            // 
            this.colIP.Text = "IP";
            this.colIP.Width = 100;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Trạng thái";
            this.colStatus.Width = 100;
            // 
            // colUser
            // 
            this.colUser.Text = "Người dùng";
            this.colUser.Width = 100;
            // 
            // colStartTime
            // 
            this.colStartTime.Text = "Bắt đầu";
            this.colStartTime.Width = 100;
            // 
            // colUseTime
            // 
            this.colUseTime.Text = "Đã sử dụng";
            this.colUseTime.Width = 80;
            // 
            // colRemainTime
            // 
            this.colRemainTime.Text = "Còn lại";
            this.colRemainTime.Width = 80;
            // 
            // colHistory
            // 
            this.colHistory.Text = "";
            // 
            // pnWaitingService
            // 
            this.pnWaitingService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnWaitingService.BackColor = System.Drawing.Color.White;
            this.pnWaitingService.Controls.Add(this.listViewWaitingService);
            this.pnWaitingService.Controls.Add(this.lbWaitingServiceCount);
            this.pnWaitingService.Controls.Add(this.pictureBox1);
            this.pnWaitingService.Controls.Add(this.lbWaitingService);
            this.pnWaitingService.Location = new System.Drawing.Point(1043, 12);
            this.pnWaitingService.Name = "pnWaitingService";
            this.pnWaitingService.Size = new System.Drawing.Size(447, 370);
            this.pnWaitingService.TabIndex = 2;
            // 
            // listViewWaitingService
            // 
            this.listViewWaitingService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewWaitingService.HideSelection = false;
            this.listViewWaitingService.Location = new System.Drawing.Point(24, 74);
            this.listViewWaitingService.Name = "listViewWaitingService";
            this.listViewWaitingService.Size = new System.Drawing.Size(399, 274);
            this.listViewWaitingService.TabIndex = 9;
            this.listViewWaitingService.UseCompatibleStateImageBehavior = false;
            // 
            // lbWaitingServiceCount
            // 
            this.lbWaitingServiceCount.AutoSize = true;
            this.lbWaitingServiceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitingServiceCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbWaitingServiceCount.Location = new System.Drawing.Point(190, 34);
            this.lbWaitingServiceCount.Name = "lbWaitingServiceCount";
            this.lbWaitingServiceCount.Size = new System.Drawing.Size(35, 22);
            this.lbWaitingServiceCount.TabIndex = 8;
            this.lbWaitingServiceCount.Text = "(?)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::OUNet_Management_Application.Properties.Resources.Shopping_White_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbWaitingService
            // 
            this.lbWaitingService.AutoSize = true;
            this.lbWaitingService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitingService.ForeColor = System.Drawing.Color.Red;
            this.lbWaitingService.Location = new System.Drawing.Point(61, 33);
            this.lbWaitingService.Name = "lbWaitingService";
            this.lbWaitingService.Size = new System.Drawing.Size(115, 22);
            this.lbWaitingService.TabIndex = 6;
            this.lbWaitingService.Text = "Dịch vụ chờ";
            // 
            // pnRecharge
            // 
            this.pnRecharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRecharge.BackColor = System.Drawing.Color.White;
            this.pnRecharge.Controls.Add(this.listViewRecharge);
            this.pnRecharge.Controls.Add(this.lbRechargeCount);
            this.pnRecharge.Controls.Add(this.lbRecharge);
            this.pnRecharge.Controls.Add(this.pbRecharge);
            this.pnRecharge.Location = new System.Drawing.Point(1043, 388);
            this.pnRecharge.Name = "pnRecharge";
            this.pnRecharge.Size = new System.Drawing.Size(447, 383);
            this.pnRecharge.TabIndex = 3;
            // 
            // listViewRecharge
            // 
            this.listViewRecharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRecharge.HideSelection = false;
            this.listViewRecharge.Location = new System.Drawing.Point(24, 68);
            this.listViewRecharge.Name = "listViewRecharge";
            this.listViewRecharge.Size = new System.Drawing.Size(399, 274);
            this.listViewRecharge.TabIndex = 10;
            this.listViewRecharge.UseCompatibleStateImageBehavior = false;
            // 
            // lbRechargeCount
            // 
            this.lbRechargeCount.AutoSize = true;
            this.lbRechargeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRechargeCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbRechargeCount.Location = new System.Drawing.Point(152, 19);
            this.lbRechargeCount.Name = "lbRechargeCount";
            this.lbRechargeCount.Size = new System.Drawing.Size(35, 22);
            this.lbRechargeCount.TabIndex = 9;
            this.lbRechargeCount.Text = "(?)";
            // 
            // lbRecharge
            // 
            this.lbRecharge.AutoSize = true;
            this.lbRecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecharge.ForeColor = System.Drawing.Color.Red;
            this.lbRecharge.Location = new System.Drawing.Point(61, 19);
            this.lbRecharge.Name = "lbRecharge";
            this.lbRecharge.Size = new System.Drawing.Size(85, 22);
            this.lbRecharge.TabIndex = 9;
            this.lbRecharge.Text = "Nạp tiền";
            // 
            // pbRecharge
            // 
            this.pbRecharge.BackColor = System.Drawing.Color.Red;
            this.pbRecharge.Image = global::OUNet_Management_Application.Properties.Resources.Cash_Icon;
            this.pbRecharge.Location = new System.Drawing.Point(24, 16);
            this.pbRecharge.Name = "pbRecharge";
            this.pbRecharge.Size = new System.Drawing.Size(30, 30);
            this.pbRecharge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecharge.TabIndex = 0;
            this.pbRecharge.TabStop = false;
            // 
            // FrmSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1502, 783);
            this.Controls.Add(this.pnRecharge);
            this.Controls.Add(this.pnWaitingService);
            this.Controls.Add(this.pnSensors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSensor";
            this.Text = "FrmSensor";
            this.pnSensors.ResumeLayout(false);
            this.pnSensors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor)).EndInit();
            this.pnWaitingService.ResumeLayout(false);
            this.pnWaitingService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnRecharge.ResumeLayout(false);
            this.pnRecharge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecharge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSensors;
        private System.Windows.Forms.Panel pnWaitingService;
        private System.Windows.Forms.Panel pnRecharge;
        private System.Windows.Forms.ListView listViewSensors;
        private System.Windows.Forms.PictureBox pbSensor;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbSensor;
        private System.Windows.Forms.ComboBox cbSensor;
        private System.Windows.Forms.ColumnHeader colSensorImage;
        private System.Windows.Forms.ColumnHeader colNameSensor;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colUser;
        private System.Windows.Forms.ColumnHeader colStartTime;
        private System.Windows.Forms.ColumnHeader colUseTime;
        private System.Windows.Forms.ColumnHeader colRemainTime;
        private System.Windows.Forms.ColumnHeader colHistory;
        private System.Windows.Forms.Label lbWaitingService;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbWaitingServiceCount;
        private System.Windows.Forms.PictureBox pbRecharge;
        private System.Windows.Forms.Label lbRechargeCount;
        private System.Windows.Forms.Label lbRecharge;
        private System.Windows.Forms.ListView listViewWaitingService;
        private System.Windows.Forms.ListView listViewRecharge;
        private System.Windows.Forms.ColumnHeader colIDSensor;
        private System.Windows.Forms.ColumnHeader colIP;
    }
}