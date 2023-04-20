namespace OUNet_Management_Application.Forms
{
    partial class FrmStatistical
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lwDataList = new System.Windows.Forms.ListView();
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.service = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.lbTo);
            this.panel1.Controls.Add(this.lbFrom);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.lwDataList);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 759);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(429, 316);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "stat";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(660, 407);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // lbTo
            // 
            this.lbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(1142, 20);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(48, 20);
            this.lbTo.TabIndex = 25;
            this.lbTo.Text = "Đến:";
            this.lbTo.Click += new System.EventHandler(this.lbTo_Click);
            // 
            // lbFrom
            // 
            this.lbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(858, 20);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(36, 20);
            this.lbFrom.TabIndex = 24;
            this.lbFrom.Text = "Từ:";
            this.lbFrom.Click += new System.EventHandler(this.lbFrom_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.AllowDrop = true;
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.CustomFormat = "MM - dd -  yyyy | hh:mm";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(1200, 19);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 22;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.AllowDrop = true;
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.CustomFormat = "MM - dd -  yyyy | hh:mm";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(904, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 21;
            this.dtpFrom.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // lwDataList
            // 
            this.lwDataList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.time,
            this.service,
            this.money,
            this.sum});
            this.lwDataList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwDataList.HideSelection = false;
            this.lwDataList.Location = new System.Drawing.Point(16, 58);
            this.lwDataList.Name = "lwDataList";
            this.lwDataList.Size = new System.Drawing.Size(1450, 73);
            this.lwDataList.TabIndex = 13;
            this.lwDataList.UseCompatibleStateImageBehavior = false;
            this.lwDataList.View = System.Windows.Forms.View.Details;
            this.lwDataList.SizeChanged += new System.EventHandler(this.lwDataList_SizeChanged);
            // 
            // time
            // 
            this.time.Text = "Thời gian";
            this.time.Width = 355;
            // 
            // service
            // 
            this.service.Text = "Ăn uống";
            this.service.Width = 362;
            // 
            // money
            // 
            this.money.Text = "Nạp tiền";
            this.money.Width = 362;
            // 
            // sum
            // 
            this.sum.Text = "Tổng doanh thu";
            this.sum.Width = 363;
            // 
            // FrmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1502, 783);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStatistical";
            this.Text = "FrmStatistical";
            this.Load += new System.EventHandler(this.FrmStatistical_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lwDataList;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ColumnHeader service;
        private System.Windows.Forms.ColumnHeader money;
        private System.Windows.Forms.ColumnHeader sum;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}