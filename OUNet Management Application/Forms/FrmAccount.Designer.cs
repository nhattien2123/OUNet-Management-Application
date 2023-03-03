namespace OUNet_Management_Application.Forms
{
    partial class FrmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccount));
            this.pnAccount = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbListUser = new System.Windows.Forms.Label();
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.colImageUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMainAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSecondAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAccount
            // 
            this.pnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnAccount.BackColor = System.Drawing.Color.White;
            this.pnAccount.Controls.Add(this.pbSearch);
            this.pnAccount.Controls.Add(this.button1);
            this.pnAccount.Controls.Add(this.textBox1);
            this.pnAccount.Controls.Add(this.btnAddUser);
            this.pnAccount.Controls.Add(this.lbListUser);
            this.pnAccount.Controls.Add(this.pbUser);
            this.pnAccount.Controls.Add(this.listViewAccounts);
            this.pnAccount.Location = new System.Drawing.Point(12, 12);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(1478, 759);
            this.pnAccount.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1135, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 27);
            this.textBox1.TabIndex = 4;
            // 
            // lbListUser
            // 
            this.lbListUser.AutoSize = true;
            this.lbListUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListUser.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbListUser.Location = new System.Drawing.Point(96, 28);
            this.lbListUser.Name = "lbListUser";
            this.lbListUser.Size = new System.Drawing.Size(246, 29);
            this.lbListUser.TabIndex = 2;
            this.lbListUser.Text = "Danh sách tài khoản";
            // 
            // listViewAccounts
            // 
            this.listViewAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colImageUser,
            this.colIDUser,
            this.colTelephone,
            this.colAddress,
            this.colNameUser,
            this.colRole,
            this.colMainAccount,
            this.colSecondAccount,
            this.colDetail});
            this.listViewAccounts.HideSelection = false;
            this.listViewAccounts.Location = new System.Drawing.Point(27, 74);
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.Size = new System.Drawing.Size(1422, 658);
            this.listViewAccounts.TabIndex = 0;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.Details;
            // 
            // colImageUser
            // 
            this.colImageUser.Text = "#";
            // 
            // colIDUser
            // 
            this.colIDUser.Text = "Mã người dùng";
            this.colIDUser.Width = 100;
            // 
            // colTelephone
            // 
            this.colTelephone.Text = "SĐT";
            this.colTelephone.Width = 100;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Địa chỉ";
            this.colAddress.Width = 150;
            // 
            // colNameUser
            // 
            this.colNameUser.Text = "Tên người dùng";
            this.colNameUser.Width = 150;
            // 
            // colRole
            // 
            this.colRole.Text = "Vai trò";
            this.colRole.Width = 100;
            // 
            // colMainAccount
            // 
            this.colMainAccount.Text = "Tài khoản chính";
            this.colMainAccount.Width = 120;
            // 
            // colSecondAccount
            // 
            this.colSecondAccount.Text = "Tài khoản phụ";
            this.colSecondAccount.Width = 120;
            // 
            // colDetail
            // 
            this.colDetail.Text = "Chi tiết";
            // 
            // pbSearch
            // 
            this.pbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSearch.Image = global::OUNet_Management_Application.Properties.Resources.Search_Icon;
            this.pbSearch.Location = new System.Drawing.Point(1104, 34);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(25, 25);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 6;
            this.pbSearch.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::OUNet_Management_Application.Properties.Resources.Delete_User_Icon;
            this.button1.Location = new System.Drawing.Point(1359, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 38);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(1407, 27);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(42, 38);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pbUser
            // 
            this.pbUser.Image = global::OUNet_Management_Application.Properties.Resources.User_Form_Icon;
            this.pbUser.Location = new System.Drawing.Point(27, 18);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(50, 50);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 1;
            this.pbUser.TabStop = false;
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1502, 783);
            this.Controls.Add(this.pnAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAccount";
            this.Text = "FrmAccount";
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAccount;
        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lbListUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.ColumnHeader colImageUser;
        private System.Windows.Forms.ColumnHeader colIDUser;
        private System.Windows.Forms.ColumnHeader colTelephone;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colNameUser;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colMainAccount;
        private System.Windows.Forms.ColumnHeader colSecondAccount;
        private System.Windows.Forms.ColumnHeader colDetail;
    }
}