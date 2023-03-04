namespace OUNet_Management_Application.Forms
{
    partial class FrmHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.lwList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.account = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeAccept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lwList);
            this.panel1.Controls.Add(this.pbSearch);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.cbState);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cbServiceType);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 759);
            this.panel1.TabIndex = 0;
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Đang chờ",
            "Hoàn tất"});
            this.cbState.Location = new System.Drawing.Point(813, 15);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(134, 24);
            this.cbState.TabIndex = 10;
            this.cbState.Text = "Trạng thái";
            // 
            // dtpFrom
            // 
            this.dtpFrom.AllowDrop = true;
            this.dtpFrom.CustomFormat = "MM - dd -  yyyy | hh:mm";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(377, 16);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(170, 17);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 21);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "Tìm kiếm";
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cbServiceType
            // 
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Items.AddRange(new object[] {
            "Nạp tiền",
            "Ăn uống"});
            this.cbServiceType.Location = new System.Drawing.Point(18, 15);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(134, 24);
            this.cbServiceType.TabIndex = 6;
            this.cbServiceType.Text = "Loại dịch vụ";
            // 
            // dtpTo
            // 
            this.dtpTo.AllowDrop = true;
            this.dtpTo.CustomFormat = "MM - dd -  yyyy | hh:mm";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(597, 16);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 11;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.IndianRed;
            this.pbSearch.Image = global::OUNet_Management_Application.Properties.Resources.Search_Icon;
            this.pbSearch.Location = new System.Drawing.Point(967, 11);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pbSearch.Size = new System.Drawing.Size(41, 33);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSearch.TabIndex = 12;
            this.pbSearch.TabStop = false;
            // 
            // lwList
            // 
            this.lwList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.timeOrder,
            this.client,
            this.account,
            this.total,
            this.timeAccept,
            this.admin,
            this.state,
            this.note});
            this.lwList.HideSelection = false;
            this.lwList.Location = new System.Drawing.Point(18, 50);
            this.lwList.Name = "lwList";
            this.lwList.Size = new System.Drawing.Size(1444, 693);
            this.lwList.TabIndex = 13;
            this.lwList.UseCompatibleStateImageBehavior = false;
            this.lwList.View = System.Windows.Forms.View.Details;
            this.lwList.SelectedIndexChanged += new System.EventHandler(this.lwList_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "#";
            this.id.Width = 36;
            // 
            // timeOrder
            // 
            this.timeOrder.Text = "Thời gian";
            this.timeOrder.Width = 211;
            // 
            // client
            // 
            this.client.Text = "Máy trạm";
            this.client.Width = 145;
            // 
            // account
            // 
            this.account.Text = "Tài khoản";
            this.account.Width = 179;
            // 
            // total
            // 
            this.total.Text = "Tổng tiền";
            this.total.Width = 198;
            // 
            // timeAccept
            // 
            this.timeAccept.Text = "Xác nhận lúc";
            this.timeAccept.Width = 232;
            // 
            // admin
            // 
            this.admin.Text = "Người xác nhận";
            this.admin.Width = 178;
            // 
            // state
            // 
            this.state.Text = "Trạng thái";
            this.state.Width = 168;
            // 
            // note
            // 
            this.note.Text = "Ghi chú";
            this.note.Width = 91;
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1502, 783);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.ListView lwList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader timeOrder;
        private System.Windows.Forms.ColumnHeader client;
        private System.Windows.Forms.ColumnHeader account;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader timeAccept;
        private System.Windows.Forms.ColumnHeader admin;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader note;
    }
}