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
            this.components = new System.ComponentModel.Container();
            this.pnSensors = new System.Windows.Forms.Panel();
            this.dgvSensors = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbSensor = new System.Windows.Forms.Label();
            this.pbSensor = new System.Windows.Forms.PictureBox();
            this.pnWaitingService = new System.Windows.Forms.Panel();
            this.serviceDF = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbWaitingServiceCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbWaitingService = new System.Windows.Forms.Label();
            this.pnRecharge = new System.Windows.Forms.Panel();
            this.serviceM = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRechargeCount = new System.Windows.Forms.Label();
            this.lbRecharge = new System.Windows.Forms.Label();
            this.pbRecharge = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSensors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor)).BeginInit();
            this.pnWaitingService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnRecharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecharge)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSensors
            // 
            this.pnSensors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSensors.BackColor = System.Drawing.Color.White;
            this.pnSensors.Controls.Add(this.dgvSensors);
            this.pnSensors.Controls.Add(this.btnRefresh);
            this.pnSensors.Controls.Add(this.lbSensor);
            this.pnSensors.Controls.Add(this.pbSensor);
            this.pnSensors.Location = new System.Drawing.Point(12, 12);
            this.pnSensors.Name = "pnSensors";
            this.pnSensors.Size = new System.Drawing.Size(856, 610);
            this.pnSensors.TabIndex = 1;
            this.pnSensors.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSensors_Paint);
            // 
            // dgvSensors
            // 
            this.dgvSensors.AllowUserToAddRows = false;
            this.dgvSensors.AllowUserToDeleteRows = false;
            this.dgvSensors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSensors.BackgroundColor = System.Drawing.Color.White;
            this.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvSensors.Location = new System.Drawing.Point(15, 74);
            this.dgvSensors.Name = "dgvSensors";
            this.dgvSensors.ReadOnly = true;
            this.dgvSensors.RowHeadersWidth = 51;
            this.dgvSensors.RowTemplate.Height = 24;
            this.dgvSensors.Size = new System.Drawing.Size(828, 517);
            this.dgvSensors.TabIndex = 6;
            this.dgvSensors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSensors_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Image = global::OUNet_Management_Application.Properties.Resources.Refresh_Icon;
            this.btnRefresh.Location = new System.Drawing.Point(801, 21);
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
            // pnWaitingService
            // 
            this.pnWaitingService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnWaitingService.BackColor = System.Drawing.Color.White;
            this.pnWaitingService.Controls.Add(this.serviceDF);
            this.pnWaitingService.Controls.Add(this.lbWaitingServiceCount);
            this.pnWaitingService.Controls.Add(this.pictureBox1);
            this.pnWaitingService.Controls.Add(this.lbWaitingService);
            this.pnWaitingService.Location = new System.Drawing.Point(874, 12);
            this.pnWaitingService.Name = "pnWaitingService";
            this.pnWaitingService.Size = new System.Drawing.Size(447, 109);
            this.pnWaitingService.TabIndex = 2;
            // 
            // serviceDF
            // 
            this.serviceDF.AllowUserToAddRows = false;
            this.serviceDF.AllowUserToDeleteRows = false;
            this.serviceDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceDF.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.serviceDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.serviceDF.Location = new System.Drawing.Point(6, 49);
            this.serviceDF.Name = "serviceDF";
            this.serviceDF.ReadOnly = true;
            this.serviceDF.RowHeadersWidth = 51;
            this.serviceDF.RowTemplate.Height = 24;
            this.serviceDF.Size = new System.Drawing.Size(435, 47);
            this.serviceDF.TabIndex = 9;
            this.serviceDF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDF_CellContentClick);
            this.serviceDF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDF_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên máy";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Thời gian";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // lbWaitingServiceCount
            // 
            this.lbWaitingServiceCount.AutoSize = true;
            this.lbWaitingServiceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitingServiceCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbWaitingServiceCount.Location = new System.Drawing.Point(178, 18);
            this.lbWaitingServiceCount.Name = "lbWaitingServiceCount";
            this.lbWaitingServiceCount.Size = new System.Drawing.Size(21, 22);
            this.lbWaitingServiceCount.TabIndex = 8;
            this.lbWaitingServiceCount.Text = "0";
            this.lbWaitingServiceCount.Click += new System.EventHandler(this.lbWaitingServiceCount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::OUNet_Management_Application.Properties.Resources.Shopping_White_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
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
            this.lbWaitingService.Location = new System.Drawing.Point(46, 18);
            this.lbWaitingService.Name = "lbWaitingService";
            this.lbWaitingService.Size = new System.Drawing.Size(115, 22);
            this.lbWaitingService.TabIndex = 6;
            this.lbWaitingService.Text = "Dịch vụ chờ";
            // 
            // pnRecharge
            // 
            this.pnRecharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRecharge.BackColor = System.Drawing.Color.White;
            this.pnRecharge.Controls.Add(this.serviceM);
            this.pnRecharge.Controls.Add(this.lbRechargeCount);
            this.pnRecharge.Controls.Add(this.lbRecharge);
            this.pnRecharge.Controls.Add(this.pbRecharge);
            this.pnRecharge.Location = new System.Drawing.Point(874, 127);
            this.pnRecharge.Name = "pnRecharge";
            this.pnRecharge.Size = new System.Drawing.Size(449, 495);
            this.pnRecharge.TabIndex = 3;
            // 
            // serviceM
            // 
            this.serviceM.AllowUserToAddRows = false;
            this.serviceM.AllowUserToDeleteRows = false;
            this.serviceM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceM.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.serviceM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3});
            this.serviceM.Location = new System.Drawing.Point(7, 52);
            this.serviceM.Name = "serviceM";
            this.serviceM.ReadOnly = true;
            this.serviceM.RowHeadersWidth = 51;
            this.serviceM.RowTemplate.Height = 24;
            this.serviceM.Size = new System.Drawing.Size(435, 424);
            this.serviceM.TabIndex = 10;
            this.serviceM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceM_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên máy";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Người dùng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mức nạp";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // lbRechargeCount
            // 
            this.lbRechargeCount.AutoSize = true;
            this.lbRechargeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRechargeCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbRechargeCount.Location = new System.Drawing.Point(144, 19);
            this.lbRechargeCount.Name = "lbRechargeCount";
            this.lbRechargeCount.Size = new System.Drawing.Size(21, 22);
            this.lbRechargeCount.TabIndex = 9;
            this.lbRechargeCount.Text = "0";
            // 
            // lbRecharge
            // 
            this.lbRecharge.AutoSize = true;
            this.lbRecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecharge.ForeColor = System.Drawing.Color.Red;
            this.lbRecharge.Location = new System.Drawing.Point(47, 19);
            this.lbRecharge.Name = "lbRecharge";
            this.lbRecharge.Size = new System.Drawing.Size(85, 22);
            this.lbRecharge.TabIndex = 9;
            this.lbRecharge.Text = "Nạp tiền";
            // 
            // pbRecharge
            // 
            this.pbRecharge.BackColor = System.Drawing.Color.Red;
            this.pbRecharge.Image = global::OUNet_Management_Application.Properties.Resources.Cash_Icon;
            this.pbRecharge.Location = new System.Drawing.Point(10, 16);
            this.pbRecharge.Name = "pbRecharge";
            this.pbRecharge.Size = new System.Drawing.Size(30, 30);
            this.pbRecharge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecharge.TabIndex = 0;
            this.pbRecharge.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã máy";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên máy trạm";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IP";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Trạng thái";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Người dùng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Thời gian bắt đầu";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // FrmSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1333, 667);
            this.Controls.Add(this.pnRecharge);
            this.Controls.Add(this.pnWaitingService);
            this.Controls.Add(this.pnSensors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSensor";
            this.Text = "FrmSensor";
            this.Load += new System.EventHandler(this.FrmSensor_Load);
            this.pnSensors.ResumeLayout(false);
            this.pnSensors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor)).EndInit();
            this.pnWaitingService.ResumeLayout(false);
            this.pnWaitingService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnRecharge.ResumeLayout(false);
            this.pnRecharge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecharge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSensors;
        private System.Windows.Forms.Panel pnWaitingService;
        private System.Windows.Forms.Panel pnRecharge;
        private System.Windows.Forms.PictureBox pbSensor;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbSensor;
        private System.Windows.Forms.Label lbWaitingService;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbWaitingServiceCount;
        private System.Windows.Forms.PictureBox pbRecharge;
        private System.Windows.Forms.Label lbRechargeCount;
        private System.Windows.Forms.Label lbRecharge;
        private System.Windows.Forms.DataGridView dgvSensors;
        private System.Windows.Forms.DataGridView serviceDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView serviceM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}