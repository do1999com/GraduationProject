namespace Chatting
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cboBloodType = new System.Windows.Forms.ComboBox();
            this.cboStar = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBaseInfo = new System.Windows.Forms.GroupBox();
            this.txtLoginPwdAgain = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.pnlSex = new System.Windows.Forms.Panel();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLoginPwdAgain = new System.Windows.Forms.Label();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.btnSelectAvatar = new System.Windows.Forms.Button();
            this.ilFaces = new System.Windows.Forms.ImageList(this.components);
            this.lblValidCode = new System.Windows.Forms.Label();
            this.txtValidCode = new System.Windows.Forms.TextBox();
            this.picValidCode = new System.Windows.Forms.PictureBox();
            this.llblValidCode = new System.Windows.Forms.LinkLabel();
            this.grpDetails.SuspendLayout();
            this.grpBaseInfo.SuspendLayout();
            this.pnlSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(200, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegist.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegist.BackgroundImage")));
            this.btnRegist.Location = new System.Drawing.Point(51, 495);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(125, 40);
            this.btnRegist.TabIndex = 7;
            this.btnRegist.Text = "注册";
            this.btnRegist.UseVisualStyleBackColor = false;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grpDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpDetails.Controls.Add(this.cboBloodType);
            this.grpDetails.Controls.Add(this.cboStar);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.lblBloodType);
            this.grpDetails.Controls.Add(this.lblStar);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Location = new System.Drawing.Point(110, 342);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(259, 134);
            this.grpDetails.TabIndex = 6;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "选填详细资料";
            // 
            // cboBloodType
            // 
            this.cboBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBloodType.FormattingEnabled = true;
            this.cboBloodType.Location = new System.Drawing.Point(82, 79);
            this.cboBloodType.Name = "cboBloodType";
            this.cboBloodType.Size = new System.Drawing.Size(142, 20);
            this.cboBloodType.TabIndex = 7;
            // 
            // cboStar
            // 
            this.cboStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStar.FormattingEnabled = true;
            this.cboStar.Location = new System.Drawing.Point(82, 50);
            this.cboStar.Name = "cboStar";
            this.cboStar.Size = new System.Drawing.Size(142, 20);
            this.cboStar.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(47, 82);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(29, 12);
            this.lblBloodType.TabIndex = 2;
            this.lblBloodType.Text = "血型";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(47, 54);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(29, 12);
            this.lblStar.TabIndex = 1;
            this.lblStar.Text = "星座";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "真实姓名";
            // 
            // grpBaseInfo
            // 
            this.grpBaseInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grpBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBaseInfo.Controls.Add(this.llblValidCode);
            this.grpBaseInfo.Controls.Add(this.picValidCode);
            this.grpBaseInfo.Controls.Add(this.txtValidCode);
            this.grpBaseInfo.Controls.Add(this.lblValidCode);
            this.grpBaseInfo.Controls.Add(this.txtLoginPwdAgain);
            this.grpBaseInfo.Controls.Add(this.txtLoginPwd);
            this.grpBaseInfo.Controls.Add(this.pnlSex);
            this.grpBaseInfo.Controls.Add(this.txtAge);
            this.grpBaseInfo.Controls.Add(this.txtNickName);
            this.grpBaseInfo.Controls.Add(this.lblAge);
            this.grpBaseInfo.Controls.Add(this.lblLoginPwdAgain);
            this.grpBaseInfo.Controls.Add(this.lblLoginPwd);
            this.grpBaseInfo.Controls.Add(this.lblSex);
            this.grpBaseInfo.Controls.Add(this.lblNickName);
            this.grpBaseInfo.Location = new System.Drawing.Point(110, 49);
            this.grpBaseInfo.Name = "grpBaseInfo";
            this.grpBaseInfo.Size = new System.Drawing.Size(283, 287);
            this.grpBaseInfo.TabIndex = 5;
            this.grpBaseInfo.TabStop = false;
            this.grpBaseInfo.Text = "注册基本资料";
            // 
            // txtLoginPwdAgain
            // 
            this.txtLoginPwdAgain.Location = new System.Drawing.Point(82, 143);
            this.txtLoginPwdAgain.Name = "txtLoginPwdAgain";
            this.txtLoginPwdAgain.PasswordChar = '*';
            this.txtLoginPwdAgain.Size = new System.Drawing.Size(142, 21);
            this.txtLoginPwdAgain.TabIndex = 9;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Location = new System.Drawing.Point(82, 115);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(142, 21);
            this.txtLoginPwd.TabIndex = 8;
            // 
            // pnlSex
            // 
            this.pnlSex.Controls.Add(this.rdoFemale);
            this.pnlSex.Controls.Add(this.rdoMale);
            this.pnlSex.Location = new System.Drawing.Point(82, 81);
            this.pnlSex.Name = "pnlSex";
            this.pnlSex.Size = new System.Drawing.Size(142, 24);
            this.pnlSex.TabIndex = 7;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(55, 5);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(4, 4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(82, 56);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(42, 21);
            this.txtAge.TabIndex = 6;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(82, 26);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(142, 21);
            this.txtNickName.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(47, 60);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 12);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "年龄";
            // 
            // lblLoginPwdAgain
            // 
            this.lblLoginPwdAgain.AutoSize = true;
            this.lblLoginPwdAgain.Location = new System.Drawing.Point(23, 147);
            this.lblLoginPwdAgain.Name = "lblLoginPwdAgain";
            this.lblLoginPwdAgain.Size = new System.Drawing.Size(53, 12);
            this.lblLoginPwdAgain.TabIndex = 3;
            this.lblLoginPwdAgain.Text = "重复密码";
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.AutoSize = true;
            this.lblLoginPwd.Location = new System.Drawing.Point(47, 119);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(29, 12);
            this.lblLoginPwd.TabIndex = 2;
            this.lblLoginPwd.Text = "密码";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(47, 87);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(47, 30);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(29, 12);
            this.lblNickName.TabIndex = 0;
            this.lblNickName.Text = "昵称";
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.Transparent;
            this.picFace.Location = new System.Drawing.Point(10, 49);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(80, 80);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFace.TabIndex = 11;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.btnSelectAvatar_Click);
            // 
            // btnSelectAvatar
            // 
            this.btnSelectAvatar.Location = new System.Drawing.Point(13, 135);
            this.btnSelectAvatar.Name = "btnSelectAvatar";
            this.btnSelectAvatar.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAvatar.TabIndex = 12;
            this.btnSelectAvatar.Text = "选择头像";
            this.btnSelectAvatar.UseVisualStyleBackColor = true;
            this.btnSelectAvatar.Click += new System.EventHandler(this.btnSelectAvatar_Click);
            // 
            // ilFaces
            // 
            this.ilFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFaces.ImageStream")));
            this.ilFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFaces.Images.SetKeyName(0, "51.bmp");
            this.ilFaces.Images.SetKeyName(1, "1.bmp");
            this.ilFaces.Images.SetKeyName(2, "2.bmp");
            this.ilFaces.Images.SetKeyName(3, "3.bmp");
            this.ilFaces.Images.SetKeyName(4, "4.bmp");
            this.ilFaces.Images.SetKeyName(5, "5.bmp");
            this.ilFaces.Images.SetKeyName(6, "6.bmp");
            this.ilFaces.Images.SetKeyName(7, "7.bmp");
            this.ilFaces.Images.SetKeyName(8, "8.bmp");
            this.ilFaces.Images.SetKeyName(9, "9.bmp");
            this.ilFaces.Images.SetKeyName(10, "10.bmp");
            this.ilFaces.Images.SetKeyName(11, "11.bmp");
            this.ilFaces.Images.SetKeyName(12, "12.bmp");
            this.ilFaces.Images.SetKeyName(13, "13.bmp");
            this.ilFaces.Images.SetKeyName(14, "14.bmp");
            this.ilFaces.Images.SetKeyName(15, "15.bmp");
            this.ilFaces.Images.SetKeyName(16, "16.bmp");
            this.ilFaces.Images.SetKeyName(17, "17.bmp");
            this.ilFaces.Images.SetKeyName(18, "18.bmp");
            this.ilFaces.Images.SetKeyName(19, "19.bmp");
            this.ilFaces.Images.SetKeyName(20, "20.bmp");
            this.ilFaces.Images.SetKeyName(21, "21.bmp");
            this.ilFaces.Images.SetKeyName(22, "22.bmp");
            this.ilFaces.Images.SetKeyName(23, "23.bmp");
            this.ilFaces.Images.SetKeyName(24, "24.bmp");
            this.ilFaces.Images.SetKeyName(25, "25.bmp");
            this.ilFaces.Images.SetKeyName(26, "26.bmp");
            this.ilFaces.Images.SetKeyName(27, "27.bmp");
            this.ilFaces.Images.SetKeyName(28, "28.bmp");
            this.ilFaces.Images.SetKeyName(29, "29.bmp");
            this.ilFaces.Images.SetKeyName(30, "30.bmp");
            this.ilFaces.Images.SetKeyName(31, "31.bmp");
            this.ilFaces.Images.SetKeyName(32, "32.bmp");
            this.ilFaces.Images.SetKeyName(33, "33.bmp");
            this.ilFaces.Images.SetKeyName(34, "34.bmp");
            this.ilFaces.Images.SetKeyName(35, "35.bmp");
            this.ilFaces.Images.SetKeyName(36, "36.bmp");
            this.ilFaces.Images.SetKeyName(37, "37.bmp");
            this.ilFaces.Images.SetKeyName(38, "38.bmp");
            this.ilFaces.Images.SetKeyName(39, "39.bmp");
            this.ilFaces.Images.SetKeyName(40, "40.bmp");
            this.ilFaces.Images.SetKeyName(41, "41.bmp");
            this.ilFaces.Images.SetKeyName(42, "42.bmp");
            this.ilFaces.Images.SetKeyName(43, "43.bmp");
            this.ilFaces.Images.SetKeyName(44, "44.bmp");
            this.ilFaces.Images.SetKeyName(45, "45.bmp");
            this.ilFaces.Images.SetKeyName(46, "46.bmp");
            this.ilFaces.Images.SetKeyName(47, "47.bmp");
            this.ilFaces.Images.SetKeyName(48, "48.bmp");
            this.ilFaces.Images.SetKeyName(49, "49.bmp");
            this.ilFaces.Images.SetKeyName(50, "50.bmp");
            // 
            // lblValidCode
            // 
            this.lblValidCode.AutoSize = true;
            this.lblValidCode.Location = new System.Drawing.Point(35, 173);
            this.lblValidCode.Name = "lblValidCode";
            this.lblValidCode.Size = new System.Drawing.Size(41, 12);
            this.lblValidCode.TabIndex = 10;
            this.lblValidCode.Text = "验证码";
            // 
            // txtValidCode
            // 
            this.txtValidCode.Location = new System.Drawing.Point(82, 170);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(142, 21);
            this.txtValidCode.TabIndex = 11;
            // 
            // picValidCode
            // 
            this.picValidCode.Location = new System.Drawing.Point(82, 197);
            this.picValidCode.Name = "picValidCode";
            this.picValidCode.Size = new System.Drawing.Size(142, 39);
            this.picValidCode.TabIndex = 12;
            this.picValidCode.TabStop = false;
            this.picValidCode.Click += new System.EventHandler(this.picValidCode_Click);
            // 
            // llblValidCode
            // 
            this.llblValidCode.AutoSize = true;
            this.llblValidCode.Location = new System.Drawing.Point(141, 252);
            this.llblValidCode.Name = "llblValidCode";
            this.llblValidCode.Size = new System.Drawing.Size(83, 12);
            this.llblValidCode.TabIndex = 13;
            this.llblValidCode.TabStop = true;
            this.llblValidCode.Text = "看不清?换一张";
            this.llblValidCode.Click += new System.EventHandler(this.picValidCode_Click);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegist;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(403, 547);
            this.Controls.Add(this.btnSelectAvatar);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpBaseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "申请号码";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpBaseInfo.ResumeLayout(false);
            this.grpBaseInfo.PerformLayout();
            this.pnlSex.ResumeLayout(false);
            this.pnlSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ComboBox cboBloodType;
        private System.Windows.Forms.ComboBox cboStar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpBaseInfo;
        private System.Windows.Forms.TextBox txtLoginPwdAgain;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Panel pnlSex;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLoginPwdAgain;
        private System.Windows.Forms.Label lblLoginPwd;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Button btnSelectAvatar;
        private System.Windows.Forms.ImageList ilFaces;
        private System.Windows.Forms.LinkLabel llblValidCode;
        private System.Windows.Forms.PictureBox picValidCode;
        private System.Windows.Forms.TextBox txtValidCode;
        private System.Windows.Forms.Label lblValidCode;
    }
}