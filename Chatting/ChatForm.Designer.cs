namespace Chatting
{
    partial class ChatForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.lblFriend = new System.Windows.Forms.Label();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ilFaces = new System.Windows.Forms.ImageList(this.components);
            this.lblMessagesReader = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.pnlMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFriend
            // 
            this.lblFriend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFriend.BackColor = System.Drawing.Color.AliceBlue;
            this.lblFriend.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFriend.Location = new System.Drawing.Point(41, -1);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(354, 24);
            this.lblFriend.TabIndex = 0;
            this.lblFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.AliceBlue;
            this.picFace.Location = new System.Drawing.Point(0, 0);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(24, 24);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFace.TabIndex = 1;
            this.picFace.TabStop = false;
            // 
            // pnlMessages
            // 
            this.pnlMessages.BackColor = System.Drawing.Color.White;
            this.pnlMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessages.Controls.Add(this.txtMessages);
            this.pnlMessages.Controls.Add(this.label1);
            this.pnlMessages.Controls.Add(this.picFace);
            this.pnlMessages.Controls.Add(this.lblFriend);
            this.pnlMessages.Location = new System.Drawing.Point(12, 12);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(396, 202);
            this.pnlMessages.TabIndex = 2;
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(3, 26);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.ShortcutsEnabled = false;
            this.txtMessages.Size = new System.Drawing.Size(388, 171);
            this.txtMessages.TabIndex = 3;
            this.txtMessages.TextChanged += new System.EventHandler(this.txtMessages_TextChanged);
            this.txtMessages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessages_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(25, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 24);
            this.label1.TabIndex = 2;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(14, 235);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(396, 101);
            this.txtChat.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.Location = new System.Drawing.Point(266, 342);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(142, 35);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(125, 342);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ilFaces
            // 
            this.ilFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFaces.ImageStream")));
            this.ilFaces.TransparentColor = System.Drawing.Color.Empty;
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
            // lblMessagesReader
            // 
            this.lblMessagesReader.Enabled = true;
            this.lblMessagesReader.Interval = 2000;
            this.lblMessagesReader.Tick += new System.EventHandler(this.lblMessagesReader_Tick);
            // 
            // ChatForm
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(433, 389);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.pnlMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.ChatForm_Activated);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.pnlMessages.ResumeLayout(false);
            this.pnlMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ilFaces;
        private System.Windows.Forms.Timer lblMessagesReader;
        private System.Windows.Forms.TextBox txtMessages;
    }
}