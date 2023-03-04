namespace OUNet_Management_Application.Forms.Second_Forms
{
    partial class FrmDetailAccount
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
            this.lbDetail = new System.Windows.Forms.Label();
            this.lbIDUser = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbMainAccount = new System.Windows.Forms.Label();
            this.lbSecondAccount = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbStatusDetail = new System.Windows.Forms.Label();
            this.lbMainAccountDetail = new System.Windows.Forms.Label();
            this.lbSecondAccountDetail = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbBirthDay = new System.Windows.Forms.Label();
            this.lbHomeTown = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtHomeTown = new System.Windows.Forms.TextBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.pbBackground2 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pbImageUser = new System.Windows.Forms.PictureBox();
            this.lbRoleDetail = new System.Windows.Forms.Label();
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.BackColor = System.Drawing.Color.White;
            this.pnBackground.Controls.Add(this.lbRoleDetail);
            this.pnBackground.Controls.Add(this.btnConfirm);
            this.pnBackground.Controls.Add(this.dtpBirthDay);
            this.pnBackground.Controls.Add(this.txtHomeTown);
            this.pnBackground.Controls.Add(this.txtCountry);
            this.pnBackground.Controls.Add(this.txtSex);
            this.pnBackground.Controls.Add(this.lbHomeTown);
            this.pnBackground.Controls.Add(this.lbBirthDay);
            this.pnBackground.Controls.Add(this.lbCountry);
            this.pnBackground.Controls.Add(this.lbSex);
            this.pnBackground.Controls.Add(this.btnDelete);
            this.pnBackground.Controls.Add(this.btnEdit);
            this.pnBackground.Controls.Add(this.lbSecondAccountDetail);
            this.pnBackground.Controls.Add(this.lbMainAccountDetail);
            this.pnBackground.Controls.Add(this.lbStatusDetail);
            this.pnBackground.Controls.Add(this.txtAddress);
            this.pnBackground.Controls.Add(this.txtTelephone);
            this.pnBackground.Controls.Add(this.txtName);
            this.pnBackground.Controls.Add(this.txtIDUser);
            this.pnBackground.Controls.Add(this.lbStatus);
            this.pnBackground.Controls.Add(this.lbSecondAccount);
            this.pnBackground.Controls.Add(this.lbMainAccount);
            this.pnBackground.Controls.Add(this.lbRole);
            this.pnBackground.Controls.Add(this.lbAddress);
            this.pnBackground.Controls.Add(this.lbTelephone);
            this.pnBackground.Controls.Add(this.lbName);
            this.pnBackground.Controls.Add(this.lbIDUser);
            this.pnBackground.Controls.Add(this.lbDetail);
            this.pnBackground.Controls.Add(this.pbImageUser);
            this.pnBackground.Controls.Add(this.pbBackground2);
            this.pnBackground.Location = new System.Drawing.Point(12, 12);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(1478, 759);
            this.pnBackground.TabIndex = 0;
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.ForeColor = System.Drawing.Color.Red;
            this.lbDetail.Location = new System.Drawing.Point(818, 34);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(241, 32);
            this.lbDetail.TabIndex = 1;
            this.lbDetail.Text = "Thông tin chi tiết";
            // 
            // lbIDUser
            // 
            this.lbIDUser.AutoSize = true;
            this.lbIDUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDUser.Location = new System.Drawing.Point(606, 109);
            this.lbIDUser.Name = "lbIDUser";
            this.lbIDUser.Size = new System.Drawing.Size(148, 25);
            this.lbIDUser.TabIndex = 2;
            this.lbIDUser.Text = "Mã người dùng:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(606, 156);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(101, 25);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Họ và tên:";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelephone.Location = new System.Drawing.Point(606, 253);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(132, 25);
            this.lbTelephone.TabIndex = 4;
            this.lbTelephone.Text = "Số điện thoại:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(606, 302);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(77, 25);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(606, 350);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(74, 25);
            this.lbRole.TabIndex = 6;
            this.lbRole.Text = "Vai trò:";
            // 
            // lbMainAccount
            // 
            this.lbMainAccount.AutoSize = true;
            this.lbMainAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainAccount.Location = new System.Drawing.Point(607, 455);
            this.lbMainAccount.Name = "lbMainAccount";
            this.lbMainAccount.Size = new System.Drawing.Size(157, 25);
            this.lbMainAccount.TabIndex = 7;
            this.lbMainAccount.Text = "Tài khoản chính:";
            // 
            // lbSecondAccount
            // 
            this.lbSecondAccount.AutoSize = true;
            this.lbSecondAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondAccount.Location = new System.Drawing.Point(954, 455);
            this.lbSecondAccount.Name = "lbSecondAccount";
            this.lbSecondAccount.Size = new System.Drawing.Size(143, 25);
            this.lbSecondAccount.TabIndex = 8;
            this.lbSecondAccount.Text = "Tài khoản phụ:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(607, 507);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(106, 25);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Trạng thái:";
            // 
            // txtIDUser
            // 
            this.txtIDUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUser.Location = new System.Drawing.Point(775, 106);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(490, 30);
            this.txtIDUser.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(775, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(490, 30);
            this.txtName.TabIndex = 11;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(775, 250);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(490, 30);
            this.txtTelephone.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(775, 299);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(490, 30);
            this.txtAddress.TabIndex = 13;
            // 
            // lbStatusDetail
            // 
            this.lbStatusDetail.AutoSize = true;
            this.lbStatusDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusDetail.ForeColor = System.Drawing.Color.Lime;
            this.lbStatusDetail.Location = new System.Drawing.Point(770, 507);
            this.lbStatusDetail.Name = "lbStatusDetail";
            this.lbStatusDetail.Size = new System.Drawing.Size(37, 25);
            this.lbStatusDetail.TabIndex = 15;
            this.lbStatusDetail.Text = "(?)";
            // 
            // lbMainAccountDetail
            // 
            this.lbMainAccountDetail.AutoSize = true;
            this.lbMainAccountDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainAccountDetail.ForeColor = System.Drawing.Color.Lime;
            this.lbMainAccountDetail.Location = new System.Drawing.Point(770, 455);
            this.lbMainAccountDetail.Name = "lbMainAccountDetail";
            this.lbMainAccountDetail.Size = new System.Drawing.Size(37, 25);
            this.lbMainAccountDetail.TabIndex = 16;
            this.lbMainAccountDetail.Text = "(?)";
            // 
            // lbSecondAccountDetail
            // 
            this.lbSecondAccountDetail.AutoSize = true;
            this.lbSecondAccountDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondAccountDetail.ForeColor = System.Drawing.Color.Lime;
            this.lbSecondAccountDetail.Location = new System.Drawing.Point(1103, 455);
            this.lbSecondAccountDetail.Name = "lbSecondAccountDetail";
            this.lbSecondAccountDetail.Size = new System.Drawing.Size(37, 25);
            this.lbSecondAccountDetail.TabIndex = 17;
            this.lbSecondAccountDetail.Text = "(?)";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1042, 659);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 59);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Sửa thông tin";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(831, 659);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 59);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xoá thông tin";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(607, 400);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(88, 25);
            this.lbSex.TabIndex = 20;
            this.lbSex.Text = "Giới tính:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(968, 350);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(101, 25);
            this.lbCountry.TabIndex = 21;
            this.lbCountry.Text = "Quốc tịch:";
            // 
            // lbBirthDay
            // 
            this.lbBirthDay.AutoSize = true;
            this.lbBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDay.Location = new System.Drawing.Point(606, 208);
            this.lbBirthDay.Name = "lbBirthDay";
            this.lbBirthDay.Size = new System.Drawing.Size(105, 25);
            this.lbBirthDay.TabIndex = 22;
            this.lbBirthDay.Text = "Ngày sinh:";
            // 
            // lbHomeTown
            // 
            this.lbHomeTown.AutoSize = true;
            this.lbHomeTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHomeTown.Location = new System.Drawing.Point(969, 400);
            this.lbHomeTown.Name = "lbHomeTown";
            this.lbHomeTown.Size = new System.Drawing.Size(105, 25);
            this.lbHomeTown.TabIndex = 23;
            this.lbHomeTown.Text = "Quê quán:";
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Location = new System.Drawing.Point(775, 397);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(187, 30);
            this.txtSex.TabIndex = 24;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(1078, 347);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(187, 30);
            this.txtCountry.TabIndex = 25;
            // 
            // txtHomeTown
            // 
            this.txtHomeTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeTown.Location = new System.Drawing.Point(1078, 397);
            this.txtHomeTown.Name = "txtHomeTown";
            this.txtHomeTown.Size = new System.Drawing.Size(187, 30);
            this.txtHomeTown.TabIndex = 27;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDay.Location = new System.Drawing.Point(775, 203);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(490, 30);
            this.dtpBirthDay.TabIndex = 28;
            // 
            // pbBackground2
            // 
            this.pbBackground2.BackColor = System.Drawing.Color.Tomato;
            this.pbBackground2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbBackground2.Location = new System.Drawing.Point(0, 0);
            this.pbBackground2.Name = "pbBackground2";
            this.pbBackground2.Size = new System.Drawing.Size(441, 759);
            this.pbBackground2.TabIndex = 29;
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
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // pbImageUser
            // 
            this.pbImageUser.Location = new System.Drawing.Point(108, 32);
            this.pbImageUser.Name = "pbImageUser";
            this.pbImageUser.Size = new System.Drawing.Size(225, 275);
            this.pbImageUser.TabIndex = 0;
            this.pbImageUser.TabStop = false;
            // 
            // lbRoleDetail
            // 
            this.lbRoleDetail.AutoSize = true;
            this.lbRoleDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoleDetail.ForeColor = System.Drawing.Color.Lime;
            this.lbRoleDetail.Location = new System.Drawing.Point(770, 350);
            this.lbRoleDetail.Name = "lbRoleDetail";
            this.lbRoleDetail.Size = new System.Drawing.Size(37, 25);
            this.lbRoleDetail.TabIndex = 31;
            this.lbRoleDetail.Text = "(?)";
            // 
            // FrmDetailAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1502, 783);
            this.Controls.Add(this.pnBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetailAccount";
            this.Text = "FrmDetailAccount";
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lbSecondAccountDetail;
        private System.Windows.Forms.Label lbMainAccountDetail;
        private System.Windows.Forms.Label lbStatusDetail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIDUser;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbSecondAccount;
        private System.Windows.Forms.Label lbMainAccount;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbIDUser;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.PictureBox pbImageUser;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox txtHomeTown;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lbHomeTown;
        private System.Windows.Forms.Label lbBirthDay;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Panel pbBackground2;
        private System.Windows.Forms.Label lbRoleDetail;
    }
}