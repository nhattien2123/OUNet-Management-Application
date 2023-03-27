namespace OUNet_Management_Application.Forms.Second_Forms
{
    partial class FrmAddUser
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
            this.pnBackground = new System.Windows.Forms.Panel();
            this.btnHiddenPassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtHomeTown = new System.Windows.Forms.TextBox();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.lbHomeTown = new System.Windows.Forms.Label();
            this.lbBirthDay = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.pbBackground2 = new System.Windows.Forms.Panel();
            this.pnBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.BackColor = System.Drawing.Color.White;
            this.pnBackground.Controls.Add(this.btnHiddenPassword);
            this.pnBackground.Controls.Add(this.txtPassword);
            this.pnBackground.Controls.Add(this.lbPassword);
            this.pnBackground.Controls.Add(this.rdFemale);
            this.pnBackground.Controls.Add(this.rdMale);
            this.pnBackground.Controls.Add(this.btnClose);
            this.pnBackground.Controls.Add(this.btnConfirm);
            this.pnBackground.Controls.Add(this.dtpBirthDay);
            this.pnBackground.Controls.Add(this.txtHomeTown);
            this.pnBackground.Controls.Add(this.txtNation);
            this.pnBackground.Controls.Add(this.lbHomeTown);
            this.pnBackground.Controls.Add(this.lbBirthDay);
            this.pnBackground.Controls.Add(this.lbCountry);
            this.pnBackground.Controls.Add(this.lbSex);
            this.pnBackground.Controls.Add(this.txtAddress);
            this.pnBackground.Controls.Add(this.txtTelephone);
            this.pnBackground.Controls.Add(this.txtUsername);
            this.pnBackground.Controls.Add(this.lbAddress);
            this.pnBackground.Controls.Add(this.lbTelephone);
            this.pnBackground.Controls.Add(this.lbName);
            this.pnBackground.Controls.Add(this.lbDetail);
            this.pnBackground.Controls.Add(this.pbBackground2);
            this.pnBackground.Location = new System.Drawing.Point(12, 12);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(1478, 759);
            this.pnBackground.TabIndex = 1;
            // 
            // btnHiddenPassword
            // 
            this.btnHiddenPassword.BackColor = System.Drawing.Color.DimGray;
            this.btnHiddenPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHiddenPassword.Image = global::OUNet_Management_Application.Properties.Resources.Visible_Eye_Icon;
            this.btnHiddenPassword.Location = new System.Drawing.Point(1271, 264);
            this.btnHiddenPassword.Name = "btnHiddenPassword";
            this.btnHiddenPassword.Size = new System.Drawing.Size(33, 30);
            this.btnHiddenPassword.TabIndex = 38;
            this.btnHiddenPassword.UseVisualStyleBackColor = false;
            this.btnHiddenPassword.Click += new System.EventHandler(this.btnHiddenPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(775, 264);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(490, 30);
            this.txtPassword.TabIndex = 36;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(606, 267);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(99, 25);
            this.lbPassword.TabIndex = 35;
            this.lbPassword.Text = "Mật khẩu:";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(904, 408);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(58, 29);
            this.rdFemale.TabIndex = 34;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(775, 410);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(74, 29);
            this.rdMale.TabIndex = 33;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1431, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(1255, 659);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 59);
            this.btnConfirm.TabIndex = 30;
            this.btnConfirm.Text = "Thêm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDay.Location = new System.Drawing.Point(775, 170);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(490, 30);
            this.dtpBirthDay.TabIndex = 28;
            // 
            // txtHomeTown
            // 
            this.txtHomeTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeTown.Location = new System.Drawing.Point(1077, 362);
            this.txtHomeTown.Name = "txtHomeTown";
            this.txtHomeTown.Size = new System.Drawing.Size(187, 30);
            this.txtHomeTown.TabIndex = 27;
            this.txtHomeTown.TextChanged += new System.EventHandler(this.txtHomeTown_TextChanged);
            // 
            // txtNation
            // 
            this.txtNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNation.Location = new System.Drawing.Point(775, 362);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(187, 30);
            this.txtNation.TabIndex = 25;
            this.txtNation.TextChanged += new System.EventHandler(this.txtNation_TextChanged);
            // 
            // lbHomeTown
            // 
            this.lbHomeTown.AutoSize = true;
            this.lbHomeTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHomeTown.Location = new System.Drawing.Point(968, 365);
            this.lbHomeTown.Name = "lbHomeTown";
            this.lbHomeTown.Size = new System.Drawing.Size(105, 25);
            this.lbHomeTown.TabIndex = 23;
            this.lbHomeTown.Text = "Quê quán:";
            this.lbHomeTown.Click += new System.EventHandler(this.lbHomeTown_Click);
            // 
            // lbBirthDay
            // 
            this.lbBirthDay.AutoSize = true;
            this.lbBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDay.Location = new System.Drawing.Point(606, 175);
            this.lbBirthDay.Name = "lbBirthDay";
            this.lbBirthDay.Size = new System.Drawing.Size(105, 25);
            this.lbBirthDay.TabIndex = 22;
            this.lbBirthDay.Text = "Ngày sinh:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(606, 365);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(101, 25);
            this.lbCountry.TabIndex = 21;
            this.lbCountry.Text = "Quốc tịch:";
            this.lbCountry.Click += new System.EventHandler(this.lbCountry_Click);
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(607, 412);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(88, 25);
            this.lbSex.TabIndex = 20;
            this.lbSex.Text = "Giới tính:";
            this.lbSex.Click += new System.EventHandler(this.lbSex_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(775, 311);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(490, 30);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(775, 217);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(490, 30);
            this.txtTelephone.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(775, 120);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(490, 30);
            this.txtUsername.TabIndex = 11;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(606, 314);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(77, 25);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Địa chỉ:";
            this.lbAddress.Click += new System.EventHandler(this.lbAddress_Click);
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelephone.Location = new System.Drawing.Point(606, 220);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(132, 25);
            this.lbTelephone.TabIndex = 4;
            this.lbTelephone.Text = "Số điện thoại:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(606, 123);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(101, 25);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Họ và tên:";
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbDetail.Location = new System.Drawing.Point(818, 34);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(241, 32);
            this.lbDetail.TabIndex = 1;
            this.lbDetail.Text = "Thông tin chi tiết";
            // 
            // pbBackground2
            // 
            this.pbBackground2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbBackground2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbBackground2.Location = new System.Drawing.Point(0, 0);
            this.pbBackground2.Name = "pbBackground2";
            this.pbBackground2.Size = new System.Drawing.Size(441, 759);
            this.pbBackground2.TabIndex = 29;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1502, 783);
            this.Controls.Add(this.pnBackground);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUser";
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox txtHomeTown;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.Label lbHomeTown;
        private System.Windows.Forms.Label lbBirthDay;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.Panel pbBackground2;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnHiddenPassword;
    }
}