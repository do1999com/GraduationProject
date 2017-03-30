namespace Chatting
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ilMessage = new System.Windows.Forms.ImageList(this.components);
            this.tmrAddFriend = new System.Windows.Forms.Timer(this.components);
            this.tmrMessage = new System.Windows.Forms.Timer(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFriendList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmrChatRequest = new System.Windows.Forms.Timer(this.components);
            this.lblLoginId = new System.Windows.Forms.Label();
            this.sbFriends = new Aptech.UI.SideBar();
            this.ilFaces = new System.Windows.Forms.ImageList(this.components);
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMessageReading = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdateFriendList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearchFriend = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPersonalInfo = new System.Windows.Forms.ToolStripButton();
            this.tsOperation = new System.Windows.Forms.ToolStrip();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lbFeel = new System.Windows.Forms.Label();
            this.txtFeel = new System.Windows.Forms.TextBox();
            this.lbShowWeather = new System.Windows.Forms.Label();
            this.lbWeatherMessage = new System.Windows.Forms.Label();
            this.tTWeatherMessage = new System.Windows.Forms.ToolTip(this.components);
            this.niTaskIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.perosonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFriendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSuggestions = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTaskIcon = new System.Windows.Forms.Timer(this.components);
            this.cmsFriendList.SuspendLayout();
            this.tsOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.cmsForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilMessage
            // 
            this.ilMessage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMessage.ImageStream")));
            this.ilMessage.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMessage.Images.SetKeyName(0, "tsbtnMessages.png");
            this.ilMessage.Images.SetKeyName(1, "Message.gif");
            // 
            // tmrAddFriend
            // 
            this.tmrAddFriend.Interval = 500;
            this.tmrAddFriend.Tick += new System.EventHandler(this.tmrAddFriend_Tick);
            // 
            // tmrMessage
            // 
            this.tmrMessage.Enabled = true;
            this.tmrMessage.Interval = 2000;
            this.tmrMessage.Tick += new System.EventHandler(this.tmrMessage_Tick);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(124, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Visible = false;
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiAddFriend
            // 
            this.tsmiAddFriend.Name = "tsmiAddFriend";
            this.tsmiAddFriend.Size = new System.Drawing.Size(124, 22);
            this.tsmiAddFriend.Text = "加为好友";
            this.tsmiAddFriend.Visible = false;
            this.tsmiAddFriend.Click += new System.EventHandler(this.tsmiAddFriend_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(124, 22);
            this.tsmiView.Text = "紧凑模式";
            this.tsmiView.Click += new System.EventHandler(this.tsmiView_Click);
            // 
            // cmsFriendList
            // 
            this.cmsFriendList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiView,
            this.tsmiAddFriend,
            this.tsmiDelete});
            this.cmsFriendList.Name = "cmsFriendList";
            this.cmsFriendList.Size = new System.Drawing.Size(125, 70);
            this.cmsFriendList.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFriendList_Opening);
            // 
            // tmrChatRequest
            // 
            this.tmrChatRequest.Interval = 500;
            this.tmrChatRequest.Tick += new System.EventHandler(this.tmrChatRequest_Tick);
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLoginId.Location = new System.Drawing.Point(135, 5);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(0, 23);
            this.lblLoginId.TabIndex = 9;
            // 
            // sbFriends
            // 
            this.sbFriends.AllowDragItem = false;
            this.sbFriends.BackColor = System.Drawing.Color.Transparent;
            this.sbFriends.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sbFriends.BackgroundImage")));
            this.sbFriends.ContextMenuStrip = this.cmsFriendList;
            this.sbFriends.FlatStyle = Aptech.UI.SbFlatStyle.Normal;
            this.sbFriends.GroupHeaderBackColor = System.Drawing.Color.LightSkyBlue;
            this.sbFriends.GroupTextColor = System.Drawing.Color.Black;
            this.sbFriends.ImageList = this.ilFaces;
            this.sbFriends.ItemContextMenuStrip = null;
            this.sbFriends.ItemStyle = Aptech.UI.SbItemStyle.PushButton;
            this.sbFriends.ItemTextColor = System.Drawing.Color.Navy;
            this.sbFriends.Location = new System.Drawing.Point(0, 129);
            this.sbFriends.Name = "sbFriends";
            this.sbFriends.RadioSelectedItem = null;
            this.sbFriends.Size = new System.Drawing.Size(292, 382);
            this.sbFriends.TabIndex = 10;
            this.sbFriends.View = Aptech.UI.SbView.LargeIcon;
            this.sbFriends.VisibleGroup = null;
            this.sbFriends.VisibleGroupIndex = -1;
            this.sbFriends.VisibleGroupChanged += new Aptech.UI.SbGroupEventHandler(this.sbFriends_VisibleGroupChanged);
            this.sbFriends.ItemDoubleClick += new Aptech.UI.SbItemEventHandler(this.sbFriends_ItemDoubleClick);
            this.sbFriends.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbFriends_Scroll);
            // 
            // ilFaces
            // 
            this.ilFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFaces.ImageStream")));
            this.ilFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFaces.Images.SetKeyName(0, "1");
            this.ilFaces.Images.SetKeyName(1, "2");
            this.ilFaces.Images.SetKeyName(2, "3");
            this.ilFaces.Images.SetKeyName(3, "4");
            this.ilFaces.Images.SetKeyName(4, "5");
            this.ilFaces.Images.SetKeyName(5, "6");
            this.ilFaces.Images.SetKeyName(6, "7");
            this.ilFaces.Images.SetKeyName(7, "8");
            this.ilFaces.Images.SetKeyName(8, "9");
            this.ilFaces.Images.SetKeyName(9, "10");
            this.ilFaces.Images.SetKeyName(10, "11");
            this.ilFaces.Images.SetKeyName(11, "12");
            this.ilFaces.Images.SetKeyName(12, "13");
            this.ilFaces.Images.SetKeyName(13, "14");
            this.ilFaces.Images.SetKeyName(14, "15");
            this.ilFaces.Images.SetKeyName(15, "16");
            this.ilFaces.Images.SetKeyName(16, "17");
            this.ilFaces.Images.SetKeyName(17, "18");
            this.ilFaces.Images.SetKeyName(18, "19");
            this.ilFaces.Images.SetKeyName(19, "20");
            this.ilFaces.Images.SetKeyName(20, "21");
            this.ilFaces.Images.SetKeyName(21, "22");
            this.ilFaces.Images.SetKeyName(22, "13");
            this.ilFaces.Images.SetKeyName(23, "24");
            this.ilFaces.Images.SetKeyName(24, "25");
            this.ilFaces.Images.SetKeyName(25, "26");
            this.ilFaces.Images.SetKeyName(26, "27");
            this.ilFaces.Images.SetKeyName(27, "28");
            this.ilFaces.Images.SetKeyName(28, "29");
            this.ilFaces.Images.SetKeyName(29, "30");
            this.ilFaces.Images.SetKeyName(30, "31");
            this.ilFaces.Images.SetKeyName(31, "32");
            this.ilFaces.Images.SetKeyName(32, "33");
            this.ilFaces.Images.SetKeyName(33, "34");
            this.ilFaces.Images.SetKeyName(34, "35");
            this.ilFaces.Images.SetKeyName(35, "36");
            this.ilFaces.Images.SetKeyName(36, "37");
            this.ilFaces.Images.SetKeyName(37, "38");
            this.ilFaces.Images.SetKeyName(38, "39");
            this.ilFaces.Images.SetKeyName(39, "40");
            this.ilFaces.Images.SetKeyName(40, "41");
            this.ilFaces.Images.SetKeyName(41, "42");
            this.ilFaces.Images.SetKeyName(42, "43");
            this.ilFaces.Images.SetKeyName(43, "44");
            this.ilFaces.Images.SetKeyName(44, "45");
            this.ilFaces.Images.SetKeyName(45, "46");
            this.ilFaces.Images.SetKeyName(46, "47");
            this.ilFaces.Images.SetKeyName(47, "48");
            this.ilFaces.Images.SetKeyName(48, "49");
            this.ilFaces.Images.SetKeyName(49, "50");
            this.ilFaces.Images.SetKeyName(50, "51");
            this.ilFaces.Images.SetKeyName(51, "52");
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // tsbtnMessageReading
            // 
            this.tsbtnMessageReading.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnMessageReading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMessageReading.Image = global::Chatting.Properties.Resources.tsbtnMessages;
            this.tsbtnMessageReading.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMessageReading.Name = "tsbtnMessageReading";
            this.tsbtnMessageReading.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMessageReading.Text = "系统消息";
            this.tsbtnMessageReading.Click += new System.EventHandler(this.tsbtnMessageReading_Click);
            // 
            // tsbtnUpdateFriendList
            // 
            this.tsbtnUpdateFriendList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUpdateFriendList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdateFriendList.Image")));
            this.tsbtnUpdateFriendList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdateFriendList.Name = "tsbtnUpdateFriendList";
            this.tsbtnUpdateFriendList.Size = new System.Drawing.Size(23, 22);
            this.tsbtnUpdateFriendList.Text = "更新好友列表";
            this.tsbtnUpdateFriendList.Click += new System.EventHandler(this.tsbtnUpdateFriendList_Click);
            // 
            // tsbtnSearchFriend
            // 
            this.tsbtnSearchFriend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearchFriend.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchFriend.Image")));
            this.tsbtnSearchFriend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchFriend.Name = "tsbtnSearchFriend";
            this.tsbtnSearchFriend.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSearchFriend.Text = "查找好友";
            this.tsbtnSearchFriend.Click += new System.EventHandler(this.tsbtnSearchFriend_Click);
            // 
            // tsbtnPersonalInfo
            // 
            this.tsbtnPersonalInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPersonalInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPersonalInfo.Image")));
            this.tsbtnPersonalInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPersonalInfo.Name = "tsbtnPersonalInfo";
            this.tsbtnPersonalInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPersonalInfo.Text = "个人信息";
            this.tsbtnPersonalInfo.Click += new System.EventHandler(this.tsbtnPersonalInfo_Click);
            // 
            // tsOperation
            // 
            this.tsOperation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsOperation.BackgroundImage")));
            this.tsOperation.CanOverflow = false;
            this.tsOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsOperation.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsOperation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPersonalInfo,
            this.tsbtnSearchFriend,
            this.tsbtnUpdateFriendList,
            this.tsbtnMessageReading,
            this.tsbtnExit});
            this.tsOperation.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsOperation.Location = new System.Drawing.Point(0, 518);
            this.tsOperation.Name = "tsOperation";
            this.tsOperation.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsOperation.Size = new System.Drawing.Size(291, 25);
            this.tsOperation.TabIndex = 7;
            this.tsOperation.Text = "toolStrip1";
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.Transparent;
            this.picFace.Location = new System.Drawing.Point(12, 57);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(78, 66);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFace.TabIndex = 8;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.tsbtnPersonalInfo_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 12);
            this.lblId.TabIndex = 6;
            // 
            // lbFeel
            // 
            this.lbFeel.AutoSize = true;
            this.lbFeel.Location = new System.Drawing.Point(147, 41);
            this.lbFeel.Name = "lbFeel";
            this.lbFeel.Size = new System.Drawing.Size(59, 12);
            this.lbFeel.TabIndex = 11;
            this.lbFeel.Text = "个性签名:";
            // 
            // txtFeel
            // 
            this.txtFeel.Location = new System.Drawing.Point(148, 57);
            this.txtFeel.Multiline = true;
            this.txtFeel.Name = "txtFeel";
            this.txtFeel.Size = new System.Drawing.Size(131, 66);
            this.txtFeel.TabIndex = 12;
            this.txtFeel.TextChanged += new System.EventHandler(this.txtFeel_TextChanged);
            // 
            // lbShowWeather
            // 
            this.lbShowWeather.AutoSize = true;
            this.lbShowWeather.Location = new System.Drawing.Point(10, 16);
            this.lbShowWeather.Name = "lbShowWeather";
            this.lbShowWeather.Size = new System.Drawing.Size(59, 12);
            this.lbShowWeather.TabIndex = 13;
            this.lbShowWeather.Text = "今日天气:";
            // 
            // lbWeatherMessage
            // 
            this.lbWeatherMessage.AutoSize = true;
            this.lbWeatherMessage.Location = new System.Drawing.Point(12, 29);
            this.lbWeatherMessage.Name = "lbWeatherMessage";
            this.lbWeatherMessage.Size = new System.Drawing.Size(155, 12);
            this.lbWeatherMessage.TabIndex = 14;
            this.lbWeatherMessage.Text = "请检查与天气服务器的连接!";
            // 
            // niTaskIcon
            // 
            this.niTaskIcon.ContextMenuStrip = this.cmsForm;
            this.niTaskIcon.Text = "notifyIcon1";
            this.niTaskIcon.Visible = true;
            // 
            // cmsForm
            // 
            this.cmsForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perosonInfoToolStripMenuItem,
            this.AddFriendsToolStripMenuItem,
            this.MessagesToolStripMenuItem,
            this.tsmSuggestions,
            this.ExitToolStripMenuItem});
            this.cmsForm.Name = "cmsForm";
            this.cmsForm.Size = new System.Drawing.Size(125, 114);
            // 
            // perosonInfoToolStripMenuItem
            // 
            this.perosonInfoToolStripMenuItem.Name = "perosonInfoToolStripMenuItem";
            this.perosonInfoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.perosonInfoToolStripMenuItem.Text = "个人信息";
            this.perosonInfoToolStripMenuItem.Click += new System.EventHandler(this.perosonInfoToolStripMenuItem_Click);
            // 
            // AddFriendsToolStripMenuItem
            // 
            this.AddFriendsToolStripMenuItem.Name = "AddFriendsToolStripMenuItem";
            this.AddFriendsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.AddFriendsToolStripMenuItem.Text = "添加好友";
            this.AddFriendsToolStripMenuItem.Click += new System.EventHandler(this.AddFriendsToolStripMenuItem_Click);
            // 
            // MessagesToolStripMenuItem
            // 
            this.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem";
            this.MessagesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.MessagesToolStripMenuItem.Text = "系统消息";
            this.MessagesToolStripMenuItem.Click += new System.EventHandler(this.MessagesToolStripMenuItem_Click);
            // 
            // tsmSuggestions
            // 
            this.tsmSuggestions.Name = "tsmSuggestions";
            this.tsmSuggestions.Size = new System.Drawing.Size(124, 22);
            this.tsmSuggestions.Text = "反馈建议";
            this.tsmSuggestions.Click += new System.EventHandler(this.tsmSuggestions_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // tmrTaskIcon
            // 
            this.tmrTaskIcon.Interval = 1000;
            this.tmrTaskIcon.Tick += new System.EventHandler(this.tmrTaskIcon_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(291, 543);
            this.Controls.Add(this.lbWeatherMessage);
            this.Controls.Add(this.lbShowWeather);
            this.Controls.Add(this.txtFeel);
            this.Controls.Add(this.lbFeel);
            this.Controls.Add(this.lblLoginId);
            this.Controls.Add(this.tsOperation);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.sbFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.cmsFriendList.ResumeLayout(false);
            this.tsOperation.ResumeLayout(false);
            this.tsOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.cmsForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ilMessage;
        private System.Windows.Forms.Timer tmrAddFriend;
        private System.Windows.Forms.Timer tmrMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddFriend;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ContextMenuStrip cmsFriendList;
        private System.Windows.Forms.Timer tmrChatRequest;
        private System.Windows.Forms.Label lblLoginId;
        private Aptech.UI.SideBar sbFriends;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripButton tsbtnMessageReading;
        private System.Windows.Forms.ToolStripButton tsbtnUpdateFriendList;
        private System.Windows.Forms.ToolStripButton tsbtnSearchFriend;
        private System.Windows.Forms.ToolStripButton tsbtnPersonalInfo;
        private System.Windows.Forms.ToolStrip tsOperation;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ImageList ilFaces;
        private System.Windows.Forms.Label lbFeel;
        private System.Windows.Forms.TextBox txtFeel;
        private System.Windows.Forms.Label lbShowWeather;
        private System.Windows.Forms.Label lbWeatherMessage;
        private System.Windows.Forms.ToolTip tTWeatherMessage;
        private System.Windows.Forms.NotifyIcon niTaskIcon;
        private System.Windows.Forms.ContextMenuStrip cmsForm;
        private System.Windows.Forms.ToolStripMenuItem AddFriendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perosonInfoToolStripMenuItem;
        private System.Windows.Forms.Timer tmrTaskIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmSuggestions;
    }
}