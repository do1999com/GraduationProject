namespace Chatting
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.llblSuggestions = new System.Windows.Forms.LinkLabel();
            this.llblRegist = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ilFaces = new System.Windows.Forms.ImageList(this.components);
            this.llblResetPassword = new System.Windows.Forms.LinkLabel();
            this.llblMyBlog = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginId
            // 
            this.txtLoginId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginId.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginId.Location = new System.Drawing.Point(132, 144);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(195, 30);
            this.txtLoginId.TabIndex = 1;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginPwd.Location = new System.Drawing.Point(132, 177);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(195, 30);
            this.txtLoginPwd.TabIndex = 2;
            this.txtLoginPwd.Enter += new System.EventHandler(this.txtLoginPwd_Enter);
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.Transparent;
            this.picFace.Location = new System.Drawing.Point(31, 144);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(80, 80);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFace.TabIndex = 10;
            this.picFace.TabStop = false;
            // 
            // llblSuggestions
            // 
            this.llblSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llblSuggestions.AutoSize = true;
            this.llblSuggestions.BackColor = System.Drawing.Color.Transparent;
            this.llblSuggestions.Location = new System.Drawing.Point(343, 187);
            this.llblSuggestions.Name = "llblSuggestions";
            this.llblSuggestions.Size = new System.Drawing.Size(53, 12);
            this.llblSuggestions.TabIndex = 6;
            this.llblSuggestions.TabStop = true;
            this.llblSuggestions.Text = "提交建议";
            this.llblSuggestions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSuggestions_LinkClicked);
            // 
            // llblRegist
            // 
            this.llblRegist.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.llblRegist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llblRegist.AutoSize = true;
            this.llblRegist.BackColor = System.Drawing.Color.Transparent;
            this.llblRegist.Location = new System.Drawing.Point(343, 144);
            this.llblRegist.Name = "llblRegist";
            this.llblRegist.Size = new System.Drawing.Size(53, 12);
            this.llblRegist.TabIndex = 5;
            this.llblRegist.TabStop = true;
            this.llblRegist.Text = "帐号申请";
            this.llblRegist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegist_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(187, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(31, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 38);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "安全登陆";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLogin_MouseMove);
            // 
            // ilFaces
            // 
            this.ilFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFaces.ImageStream")));
            this.ilFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFaces.Images.SetKeyName(0, "DefaultAvatar.png");
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
            // llblResetPassword
            // 
            this.llblResetPassword.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.llblResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llblResetPassword.AutoSize = true;
            this.llblResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.llblResetPassword.Location = new System.Drawing.Point(343, 164);
            this.llblResetPassword.Name = "llblResetPassword";
            this.llblResetPassword.Size = new System.Drawing.Size(53, 12);
            this.llblResetPassword.TabIndex = 5;
            this.llblResetPassword.TabStop = true;
            this.llblResetPassword.Text = "密码找回";
            this.llblResetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblResetPassword_LinkClicked);
            // 
            // llblMyBlog
            // 
            this.llblMyBlog.AutoSize = true;
            this.llblMyBlog.LinkColor = System.Drawing.Color.Silver;
            this.llblMyBlog.Location = new System.Drawing.Point(345, 256);
            this.llblMyBlog.Name = "llblMyBlog";
            this.llblMyBlog.Size = new System.Drawing.Size(53, 12);
            this.llblMyBlog.TabIndex = 11;
            this.llblMyBlog.TabStop = true;
            this.llblMyBlog.Text = "作者官网";
            this.llblMyBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMyBlog_LinkClicked);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(428, 280);
            this.Controls.Add(this.llblMyBlog);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.llblSuggestions);
            this.Controls.Add(this.llblResetPassword);
            this.Controls.Add(this.llblRegist);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.LinkLabel llblSuggestions;
        private System.Windows.Forms.LinkLabel llblRegist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ImageList ilFaces;
        private System.Windows.Forms.LinkLabel llblResetPassword;
        private System.Windows.Forms.LinkLabel llblMyBlog;
    }
}

