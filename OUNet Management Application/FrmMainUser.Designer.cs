namespace OUNet_Management_Application
{
    partial class FrmMainUser
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnDetailUser = new System.Windows.Forms.Panel();
            this.lbMainAccount = new System.Windows.Forms.Label();
            this.txtMainAccount = new System.Windows.Forms.TextBox();
            this.txtSecondAccount = new System.Windows.Forms.TextBox();
            this.lbSecondAccount = new System.Windows.Forms.Label();
            this.txtUsedTime = new System.Windows.Forms.TextBox();
            this.lbUsedTime = new System.Windows.Forms.Label();
            this.txtTimeRemaining = new System.Windows.Forms.TextBox();
            this.lbTimeRemaining = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtCombo = new System.Windows.Forms.TextBox();
            this.lbComboDetail = new System.Windows.Forms.Label();
            this.pnFunction = new System.Windows.Forms.Panel();
            this.lbServices = new System.Windows.Forms.Label();
            this.lbCombo = new System.Windows.Forms.Label();
            this.lbRecharge = new System.Windows.Forms.Label();
            this.lbLogOut = new System.Windows.Forms.Label();
            this.lbLockComputer = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbChangePassword = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.pbServices = new System.Windows.Forms.PictureBox();
            this.pbCombo = new System.Windows.Forms.PictureBox();
            this.pbRecharge = new System.Windows.Forms.PictureBox();
            this.pbMessage = new System.Windows.Forms.PictureBox();
            this.pbLockComputer = new System.Windows.Forms.PictureBox();
            this.pbLogOut = new System.Windows.Forms.PictureBox();
            this.pbChangePassword = new System.Windows.Forms.PictureBox();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnDetailUser.SuspendLayout();
            this.pnFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Brown;
            this.pnHeader.Controls.Add(this.lbUsername);
            this.pnHeader.Controls.Add(this.pbLogo);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(439, 39);
            this.pnHeader.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(393, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnDetailUser
            // 
            this.pnDetailUser.BackColor = System.Drawing.Color.White;
            this.pnDetailUser.Controls.Add(this.txtCombo);
            this.pnDetailUser.Controls.Add(this.lbComboDetail);
            this.pnDetailUser.Controls.Add(this.txtPrice);
            this.pnDetailUser.Controls.Add(this.lbPrice);
            this.pnDetailUser.Controls.Add(this.txtTimeRemaining);
            this.pnDetailUser.Controls.Add(this.lbTimeRemaining);
            this.pnDetailUser.Controls.Add(this.txtUsedTime);
            this.pnDetailUser.Controls.Add(this.lbUsedTime);
            this.pnDetailUser.Controls.Add(this.txtSecondAccount);
            this.pnDetailUser.Controls.Add(this.lbSecondAccount);
            this.pnDetailUser.Controls.Add(this.txtMainAccount);
            this.pnDetailUser.Controls.Add(this.lbMainAccount);
            this.pnDetailUser.Location = new System.Drawing.Point(12, 45);
            this.pnDetailUser.Name = "pnDetailUser";
            this.pnDetailUser.Size = new System.Drawing.Size(415, 232);
            this.pnDetailUser.TabIndex = 2;
            // 
            // lbMainAccount
            // 
            this.lbMainAccount.AutoSize = true;
            this.lbMainAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainAccount.Location = new System.Drawing.Point(16, 18);
            this.lbMainAccount.Name = "lbMainAccount";
            this.lbMainAccount.Size = new System.Drawing.Size(131, 20);
            this.lbMainAccount.TabIndex = 0;
            this.lbMainAccount.Text = "Tài khoản chính:";
            // 
            // txtMainAccount
            // 
            this.txtMainAccount.BackColor = System.Drawing.Color.LightGray;
            this.txtMainAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainAccount.Location = new System.Drawing.Point(167, 15);
            this.txtMainAccount.Name = "txtMainAccount";
            this.txtMainAccount.ReadOnly = true;
            this.txtMainAccount.Size = new System.Drawing.Size(230, 27);
            this.txtMainAccount.TabIndex = 1;
            // 
            // txtSecondAccount
            // 
            this.txtSecondAccount.BackColor = System.Drawing.Color.LightGray;
            this.txtSecondAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondAccount.Location = new System.Drawing.Point(167, 48);
            this.txtSecondAccount.Name = "txtSecondAccount";
            this.txtSecondAccount.ReadOnly = true;
            this.txtSecondAccount.Size = new System.Drawing.Size(230, 27);
            this.txtSecondAccount.TabIndex = 3;
            // 
            // lbSecondAccount
            // 
            this.lbSecondAccount.AutoSize = true;
            this.lbSecondAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondAccount.Location = new System.Drawing.Point(16, 51);
            this.lbSecondAccount.Name = "lbSecondAccount";
            this.lbSecondAccount.Size = new System.Drawing.Size(118, 20);
            this.lbSecondAccount.TabIndex = 2;
            this.lbSecondAccount.Text = "Tài khoản phụ:";
            // 
            // txtUsedTime
            // 
            this.txtUsedTime.BackColor = System.Drawing.Color.LightGray;
            this.txtUsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsedTime.Location = new System.Drawing.Point(167, 81);
            this.txtUsedTime.Name = "txtUsedTime";
            this.txtUsedTime.ReadOnly = true;
            this.txtUsedTime.Size = new System.Drawing.Size(230, 27);
            this.txtUsedTime.TabIndex = 5;
            // 
            // lbUsedTime
            // 
            this.lbUsedTime.AutoSize = true;
            this.lbUsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsedTime.Location = new System.Drawing.Point(16, 84);
            this.lbUsedTime.Name = "lbUsedTime";
            this.lbUsedTime.Size = new System.Drawing.Size(146, 20);
            this.lbUsedTime.TabIndex = 4;
            this.lbUsedTime.Text = "Thời gian sử dụng:";
            // 
            // txtTimeRemaining
            // 
            this.txtTimeRemaining.BackColor = System.Drawing.Color.LightGray;
            this.txtTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeRemaining.Location = new System.Drawing.Point(167, 114);
            this.txtTimeRemaining.Name = "txtTimeRemaining";
            this.txtTimeRemaining.ReadOnly = true;
            this.txtTimeRemaining.Size = new System.Drawing.Size(230, 27);
            this.txtTimeRemaining.TabIndex = 7;
            // 
            // lbTimeRemaining
            // 
            this.lbTimeRemaining.AutoSize = true;
            this.lbTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRemaining.Location = new System.Drawing.Point(16, 117);
            this.lbTimeRemaining.Name = "lbTimeRemaining";
            this.lbTimeRemaining.Size = new System.Drawing.Size(136, 20);
            this.lbTimeRemaining.TabIndex = 6;
            this.lbTimeRemaining.Text = "Thời gian còn lại:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.LightGray;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(167, 147);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(230, 27);
            this.txtPrice.TabIndex = 9;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(16, 150);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(97, 20);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Giá (vnđ/h):";
            // 
            // txtCombo
            // 
            this.txtCombo.BackColor = System.Drawing.Color.LightGray;
            this.txtCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo.Location = new System.Drawing.Point(167, 180);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.ReadOnly = true;
            this.txtCombo.Size = new System.Drawing.Size(230, 27);
            this.txtCombo.TabIndex = 11;
            // 
            // lbComboDetail
            // 
            this.lbComboDetail.AutoSize = true;
            this.lbComboDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComboDetail.Location = new System.Drawing.Point(16, 183);
            this.lbComboDetail.Name = "lbComboDetail";
            this.lbComboDetail.Size = new System.Drawing.Size(67, 20);
            this.lbComboDetail.TabIndex = 10;
            this.lbComboDetail.Text = "Combo:";
            // 
            // pnFunction
            // 
            this.pnFunction.BackColor = System.Drawing.Color.White;
            this.pnFunction.Controls.Add(this.pbLogOut);
            this.pnFunction.Controls.Add(this.pbLockComputer);
            this.pnFunction.Controls.Add(this.pbMessage);
            this.pnFunction.Controls.Add(this.pbRecharge);
            this.pnFunction.Controls.Add(this.pbCombo);
            this.pnFunction.Controls.Add(this.pbServices);
            this.pnFunction.Controls.Add(this.lbLogOut);
            this.pnFunction.Controls.Add(this.lbLockComputer);
            this.pnFunction.Controls.Add(this.lbMessage);
            this.pnFunction.Controls.Add(this.lbRecharge);
            this.pnFunction.Controls.Add(this.lbCombo);
            this.pnFunction.Controls.Add(this.lbServices);
            this.pnFunction.Location = new System.Drawing.Point(12, 294);
            this.pnFunction.Name = "pnFunction";
            this.pnFunction.Size = new System.Drawing.Size(415, 246);
            this.pnFunction.TabIndex = 3;
            // 
            // lbServices
            // 
            this.lbServices.AutoSize = true;
            this.lbServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServices.Location = new System.Drawing.Point(15, 92);
            this.lbServices.Name = "lbServices";
            this.lbServices.Size = new System.Drawing.Size(66, 20);
            this.lbServices.TabIndex = 12;
            this.lbServices.Text = "Dịch vụ";
            // 
            // lbCombo
            // 
            this.lbCombo.AutoSize = true;
            this.lbCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombo.Location = new System.Drawing.Point(180, 92);
            this.lbCombo.Name = "lbCombo";
            this.lbCombo.Size = new System.Drawing.Size(62, 20);
            this.lbCombo.TabIndex = 12;
            this.lbCombo.Text = "Combo";
            // 
            // lbRecharge
            // 
            this.lbRecharge.AutoSize = true;
            this.lbRecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecharge.Location = new System.Drawing.Point(328, 92);
            this.lbRecharge.Name = "lbRecharge";
            this.lbRecharge.Size = new System.Drawing.Size(71, 20);
            this.lbRecharge.TabIndex = 12;
            this.lbRecharge.Text = "Nạp tiền";
            // 
            // lbLogOut
            // 
            this.lbLogOut.AutoSize = true;
            this.lbLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogOut.Location = new System.Drawing.Point(320, 204);
            this.lbLogOut.Name = "lbLogOut";
            this.lbLogOut.Size = new System.Drawing.Size(84, 20);
            this.lbLogOut.TabIndex = 13;
            this.lbLogOut.Text = "Đăng xuất";
            // 
            // lbLockComputer
            // 
            this.lbLockComputer.AutoSize = true;
            this.lbLockComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLockComputer.Location = new System.Drawing.Point(169, 204);
            this.lbLockComputer.Name = "lbLockComputer";
            this.lbLockComputer.Size = new System.Drawing.Size(83, 20);
            this.lbLockComputer.TabIndex = 14;
            this.lbLockComputer.Text = "Khoá máy";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(11, 204);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(73, 20);
            this.lbMessage.TabIndex = 15;
            this.lbMessage.Text = "Tin nhắn";
            // 
            // lbChangePassword
            // 
            this.lbChangePassword.AutoSize = true;
            this.lbChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangePassword.Location = new System.Drawing.Point(40, 553);
            this.lbChangePassword.Name = "lbChangePassword";
            this.lbChangePassword.Size = new System.Drawing.Size(107, 20);
            this.lbChangePassword.TabIndex = 16;
            this.lbChangePassword.Text = "Đổi mật khẩu";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(370, 553);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(57, 20);
            this.lbVersion.TabIndex = 17;
            this.lbVersion.Text = "2.0.1.0";
            // 
            // pbServices
            // 
            this.pbServices.Location = new System.Drawing.Point(13, 19);
            this.pbServices.Name = "pbServices";
            this.pbServices.Size = new System.Drawing.Size(70, 70);
            this.pbServices.TabIndex = 16;
            this.pbServices.TabStop = false;
            // 
            // pbCombo
            // 
            this.pbCombo.Location = new System.Drawing.Point(176, 19);
            this.pbCombo.Name = "pbCombo";
            this.pbCombo.Size = new System.Drawing.Size(70, 70);
            this.pbCombo.TabIndex = 17;
            this.pbCombo.TabStop = false;
            // 
            // pbRecharge
            // 
            this.pbRecharge.Location = new System.Drawing.Point(327, 19);
            this.pbRecharge.Name = "pbRecharge";
            this.pbRecharge.Size = new System.Drawing.Size(70, 70);
            this.pbRecharge.TabIndex = 18;
            this.pbRecharge.TabStop = false;
            // 
            // pbMessage
            // 
            this.pbMessage.Location = new System.Drawing.Point(13, 131);
            this.pbMessage.Name = "pbMessage";
            this.pbMessage.Size = new System.Drawing.Size(70, 70);
            this.pbMessage.TabIndex = 19;
            this.pbMessage.TabStop = false;
            // 
            // pbLockComputer
            // 
            this.pbLockComputer.Location = new System.Drawing.Point(176, 131);
            this.pbLockComputer.Name = "pbLockComputer";
            this.pbLockComputer.Size = new System.Drawing.Size(70, 70);
            this.pbLockComputer.TabIndex = 20;
            this.pbLockComputer.TabStop = false;
            // 
            // pbLogOut
            // 
            this.pbLogOut.Location = new System.Drawing.Point(327, 131);
            this.pbLogOut.Name = "pbLogOut";
            this.pbLogOut.Size = new System.Drawing.Size(70, 70);
            this.pbLogOut.TabIndex = 21;
            this.pbLogOut.TabStop = false;
            // 
            // pbChangePassword
            // 
            this.pbChangePassword.Location = new System.Drawing.Point(12, 547);
            this.pbChangePassword.Name = "pbChangePassword";
            this.pbChangePassword.Size = new System.Drawing.Size(25, 26);
            this.pbChangePassword.TabIndex = 18;
            this.pbChangePassword.TabStop = false;
            // 
            // FrmMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(439, 588);
            this.Controls.Add(this.pbChangePassword);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbChangePassword);
            this.Controls.Add(this.pnFunction);
            this.Controls.Add(this.pnDetailUser);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainUser";
            this.Text = "FrmMainUser";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnDetailUser.ResumeLayout(false);
            this.pnDetailUser.PerformLayout();
            this.pnFunction.ResumeLayout(false);
            this.pnFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnDetailUser;
        private System.Windows.Forms.TextBox txtCombo;
        private System.Windows.Forms.Label lbComboDetail;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtTimeRemaining;
        private System.Windows.Forms.Label lbTimeRemaining;
        private System.Windows.Forms.TextBox txtUsedTime;
        private System.Windows.Forms.Label lbUsedTime;
        private System.Windows.Forms.TextBox txtSecondAccount;
        private System.Windows.Forms.Label lbSecondAccount;
        private System.Windows.Forms.TextBox txtMainAccount;
        private System.Windows.Forms.Label lbMainAccount;
        private System.Windows.Forms.Panel pnFunction;
        private System.Windows.Forms.Label lbLogOut;
        private System.Windows.Forms.Label lbLockComputer;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbRecharge;
        private System.Windows.Forms.Label lbCombo;
        private System.Windows.Forms.Label lbServices;
        private System.Windows.Forms.Label lbChangePassword;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.PictureBox pbLogOut;
        private System.Windows.Forms.PictureBox pbLockComputer;
        private System.Windows.Forms.PictureBox pbMessage;
        private System.Windows.Forms.PictureBox pbRecharge;
        private System.Windows.Forms.PictureBox pbCombo;
        private System.Windows.Forms.PictureBox pbServices;
        private System.Windows.Forms.PictureBox pbChangePassword;
    }
}