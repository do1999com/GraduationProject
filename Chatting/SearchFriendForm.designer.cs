namespace Chatting
{
    partial class SearchFriendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFriendForm));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tpBaseSearch = new System.Windows.Forms.TabPage();
            this.pnlBaseCondition = new System.Windows.Forms.Panel();
            this.pnlBaseResult = new System.Windows.Forms.Panel();
            this.dgvBasicResult = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBaseResult = new System.Windows.Forms.PictureBox();
            this.lblBaseResult = new System.Windows.Forms.Label();
            this.pnlSearchType = new System.Windows.Forms.Panel();
            this.rdoNicetySearch = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.grpBaseCondition = new System.Windows.Forms.GroupBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.picBaseCondition = new System.Windows.Forms.PictureBox();
            this.lblBaseCondition = new System.Windows.Forms.Label();
            this.tpAdvancedSearch = new System.Windows.Forms.TabPage();
            this.pnlAdvancedCondition = new System.Windows.Forms.Panel();
            this.pnlAdvancedResult = new System.Windows.Forms.Panel();
            this.picAdvancedResult = new System.Windows.Forms.PictureBox();
            this.lblAdvancedResult = new System.Windows.Forms.Label();
            this.dgvAdvancedResult = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAdvancedCondition = new System.Windows.Forms.GroupBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.picAdvancedCondition = new System.Windows.Forms.PictureBox();
            this.lblAdvancedCondion = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.chLoginId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabSearch.SuspendLayout();
            this.tpBaseSearch.SuspendLayout();
            this.pnlBaseCondition.SuspendLayout();
            this.pnlBaseResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseResult)).BeginInit();
            this.pnlSearchType.SuspendLayout();
            this.grpBaseCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseCondition)).BeginInit();
            this.tpAdvancedSearch.SuspendLayout();
            this.pnlAdvancedCondition.SuspendLayout();
            this.pnlAdvancedResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedResult)).BeginInit();
            this.grpAdvancedCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedCondition)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(10, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 215);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // tabSearch
            // 
            this.tabSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSearch.Controls.Add(this.tpBaseSearch);
            this.tabSearch.Controls.Add(this.tpAdvancedSearch);
            this.tabSearch.Location = new System.Drawing.Point(116, 11);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.Size = new System.Drawing.Size(431, 216);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.SelectedIndexChanged += new System.EventHandler(this.tabSearch_SelectedIndexChanged);
            // 
            // tpBaseSearch
            // 
            this.tpBaseSearch.BackColor = System.Drawing.Color.White;
            this.tpBaseSearch.Controls.Add(this.pnlBaseCondition);
            this.tpBaseSearch.ForeColor = System.Drawing.Color.Black;
            this.tpBaseSearch.Location = new System.Drawing.Point(4, 22);
            this.tpBaseSearch.Name = "tpBaseSearch";
            this.tpBaseSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaseSearch.Size = new System.Drawing.Size(423, 190);
            this.tpBaseSearch.TabIndex = 0;
            this.tpBaseSearch.Text = "基本查找";
            // 
            // pnlBaseCondition
            // 
            this.pnlBaseCondition.Controls.Add(this.pnlBaseResult);
            this.pnlBaseCondition.Controls.Add(this.pnlSearchType);
            this.pnlBaseCondition.Controls.Add(this.grpBaseCondition);
            this.pnlBaseCondition.Controls.Add(this.picBaseCondition);
            this.pnlBaseCondition.Controls.Add(this.lblBaseCondition);
            this.pnlBaseCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlBaseCondition.Name = "pnlBaseCondition";
            this.pnlBaseCondition.Size = new System.Drawing.Size(347, 193);
            this.pnlBaseCondition.TabIndex = 4;
            // 
            // pnlBaseResult
            // 
            this.pnlBaseResult.Controls.Add(this.dgvBasicResult);
            this.pnlBaseResult.Controls.Add(this.picBaseResult);
            this.pnlBaseResult.Controls.Add(this.lblBaseResult);
            this.pnlBaseResult.Location = new System.Drawing.Point(17, 14);
            this.pnlBaseResult.Name = "pnlBaseResult";
            this.pnlBaseResult.Size = new System.Drawing.Size(347, 190);
            this.pnlBaseResult.TabIndex = 4;
            this.pnlBaseResult.Visible = false;
            // 
            // dgvBasicResult
            // 
            this.dgvBasicResult.AllowUserToAddRows = false;
            this.dgvBasicResult.AllowUserToDeleteRows = false;
            this.dgvBasicResult.AllowUserToResizeColumns = false;
            this.dgvBasicResult.AllowUserToResizeRows = false;
            this.dgvBasicResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBasicResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvBasicResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBasicResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasicResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nickName,
            this.age,
            this.sex});
            this.dgvBasicResult.GridColor = System.Drawing.Color.White;
            this.dgvBasicResult.Location = new System.Drawing.Point(0, 37);
            this.dgvBasicResult.MultiSelect = false;
            this.dgvBasicResult.Name = "dgvBasicResult";
            this.dgvBasicResult.ReadOnly = true;
            this.dgvBasicResult.RowHeadersVisible = false;
            this.dgvBasicResult.RowTemplate.Height = 23;
            this.dgvBasicResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBasicResult.Size = new System.Drawing.Size(347, 153);
            this.dgvBasicResult.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ChattingID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nickName
            // 
            this.nickName.DataPropertyName = "NickName";
            this.nickName.HeaderText = "昵称";
            this.nickName.Name = "nickName";
            this.nickName.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "Age";
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "Sex";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // picBaseResult
            // 
            this.picBaseResult.Image = ((System.Drawing.Image)(resources.GetObject("picBaseResult.Image")));
            this.picBaseResult.Location = new System.Drawing.Point(30, 8);
            this.picBaseResult.Name = "picBaseResult";
            this.picBaseResult.Size = new System.Drawing.Size(17, 18);
            this.picBaseResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBaseResult.TabIndex = 2;
            this.picBaseResult.TabStop = false;
            // 
            // lblBaseResult
            // 
            this.lblBaseResult.AutoSize = true;
            this.lblBaseResult.Location = new System.Drawing.Point(68, 12);
            this.lblBaseResult.Name = "lblBaseResult";
            this.lblBaseResult.Size = new System.Drawing.Size(161, 12);
            this.lblBaseResult.TabIndex = 3;
            this.lblBaseResult.Text = "Chatting为您找到如下结果：";
            // 
            // pnlSearchType
            // 
            this.pnlSearchType.Controls.Add(this.rdoNicetySearch);
            this.pnlSearchType.Controls.Add(this.rdoAll);
            this.pnlSearchType.Location = new System.Drawing.Point(70, 29);
            this.pnlSearchType.Name = "pnlSearchType";
            this.pnlSearchType.Size = new System.Drawing.Size(200, 49);
            this.pnlSearchType.TabIndex = 2;
            // 
            // rdoNicetySearch
            // 
            this.rdoNicetySearch.AutoSize = true;
            this.rdoNicetySearch.Location = new System.Drawing.Point(12, 30);
            this.rdoNicetySearch.Name = "rdoNicetySearch";
            this.rdoNicetySearch.Size = new System.Drawing.Size(71, 16);
            this.rdoNicetySearch.TabIndex = 1;
            this.rdoNicetySearch.Text = "精确查找";
            this.rdoNicetySearch.UseVisualStyleBackColor = true;
            this.rdoNicetySearch.CheckedChanged += new System.EventHandler(this.rdoNicetySearch_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(12, 9);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(83, 16);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "查找所有人";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // grpBaseCondition
            // 
            this.grpBaseCondition.Controls.Add(this.txtNickName);
            this.grpBaseCondition.Controls.Add(this.txtLoginId);
            this.grpBaseCondition.Controls.Add(this.lblNickName);
            this.grpBaseCondition.Controls.Add(this.lblLoginId);
            this.grpBaseCondition.Location = new System.Drawing.Point(17, 96);
            this.grpBaseCondition.Name = "grpBaseCondition";
            this.grpBaseCondition.Size = new System.Drawing.Size(294, 80);
            this.grpBaseCondition.TabIndex = 3;
            this.grpBaseCondition.TabStop = false;
            this.grpBaseCondition.Text = "精确查找条件";
            this.grpBaseCondition.Visible = false;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(96, 49);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(159, 21);
            this.txtNickName.TabIndex = 3;
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(96, 21);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(159, 21);
            this.txtLoginId.TabIndex = 2;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(25, 52);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(65, 12);
            this.lblNickName.TabIndex = 1;
            this.lblNickName.Text = "对方昵称：";
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Location = new System.Drawing.Point(25, 24);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(65, 12);
            this.lblLoginId.TabIndex = 0;
            this.lblLoginId.Text = "对方帐号：";
            // 
            // picBaseCondition
            // 
            this.picBaseCondition.Image = ((System.Drawing.Image)(resources.GetObject("picBaseCondition.Image")));
            this.picBaseCondition.Location = new System.Drawing.Point(30, 8);
            this.picBaseCondition.Name = "picBaseCondition";
            this.picBaseCondition.Size = new System.Drawing.Size(17, 18);
            this.picBaseCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBaseCondition.TabIndex = 0;
            this.picBaseCondition.TabStop = false;
            // 
            // lblBaseCondition
            // 
            this.lblBaseCondition.AutoSize = true;
            this.lblBaseCondition.Location = new System.Drawing.Point(68, 14);
            this.lblBaseCondition.Name = "lblBaseCondition";
            this.lblBaseCondition.Size = new System.Drawing.Size(173, 12);
            this.lblBaseCondition.TabIndex = 1;
            this.lblBaseCondition.Text = "可以设置精确查询条件查找好友";
            // 
            // tpAdvancedSearch
            // 
            this.tpAdvancedSearch.BackColor = System.Drawing.Color.White;
            this.tpAdvancedSearch.Controls.Add(this.pnlAdvancedCondition);
            this.tpAdvancedSearch.Location = new System.Drawing.Point(4, 22);
            this.tpAdvancedSearch.Name = "tpAdvancedSearch";
            this.tpAdvancedSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvancedSearch.Size = new System.Drawing.Size(423, 190);
            this.tpAdvancedSearch.TabIndex = 1;
            this.tpAdvancedSearch.Text = "高级查找";
            // 
            // pnlAdvancedCondition
            // 
            this.pnlAdvancedCondition.Controls.Add(this.pnlAdvancedResult);
            this.pnlAdvancedCondition.Controls.Add(this.grpAdvancedCondition);
            this.pnlAdvancedCondition.Controls.Add(this.picAdvancedCondition);
            this.pnlAdvancedCondition.Controls.Add(this.lblAdvancedCondion);
            this.pnlAdvancedCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlAdvancedCondition.Name = "pnlAdvancedCondition";
            this.pnlAdvancedCondition.Size = new System.Drawing.Size(347, 194);
            this.pnlAdvancedCondition.TabIndex = 4;
            // 
            // pnlAdvancedResult
            // 
            this.pnlAdvancedResult.Controls.Add(this.picAdvancedResult);
            this.pnlAdvancedResult.Controls.Add(this.lblAdvancedResult);
            this.pnlAdvancedResult.Controls.Add(this.dgvAdvancedResult);
            this.pnlAdvancedResult.Location = new System.Drawing.Point(30, 37);
            this.pnlAdvancedResult.Name = "pnlAdvancedResult";
            this.pnlAdvancedResult.Size = new System.Drawing.Size(348, 194);
            this.pnlAdvancedResult.TabIndex = 4;
            this.pnlAdvancedResult.Visible = false;
            // 
            // picAdvancedResult
            // 
            this.picAdvancedResult.Image = ((System.Drawing.Image)(resources.GetObject("picAdvancedResult.Image")));
            this.picAdvancedResult.Location = new System.Drawing.Point(30, 12);
            this.picAdvancedResult.Name = "picAdvancedResult";
            this.picAdvancedResult.Size = new System.Drawing.Size(17, 18);
            this.picAdvancedResult.TabIndex = 3;
            this.picAdvancedResult.TabStop = false;
            // 
            // lblAdvancedResult
            // 
            this.lblAdvancedResult.AutoSize = true;
            this.lblAdvancedResult.Location = new System.Drawing.Point(65, 17);
            this.lblAdvancedResult.Name = "lblAdvancedResult";
            this.lblAdvancedResult.Size = new System.Drawing.Size(161, 12);
            this.lblAdvancedResult.TabIndex = 4;
            this.lblAdvancedResult.Text = "Chatting为您找到如下结果：";
            // 
            // dgvAdvancedResult
            // 
            this.dgvAdvancedResult.AllowUserToAddRows = false;
            this.dgvAdvancedResult.AllowUserToDeleteRows = false;
            this.dgvAdvancedResult.AllowUserToResizeColumns = false;
            this.dgvAdvancedResult.AllowUserToResizeRows = false;
            this.dgvAdvancedResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdvancedResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdvancedResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdvancedResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvancedResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvAdvancedResult.GridColor = System.Drawing.Color.White;
            this.dgvAdvancedResult.Location = new System.Drawing.Point(0, 42);
            this.dgvAdvancedResult.MultiSelect = false;
            this.dgvAdvancedResult.Name = "dgvAdvancedResult";
            this.dgvAdvancedResult.ReadOnly = true;
            this.dgvAdvancedResult.RowHeadersVisible = false;
            this.dgvAdvancedResult.RowTemplate.Height = 23;
            this.dgvAdvancedResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdvancedResult.Size = new System.Drawing.Size(348, 148);
            this.dgvAdvancedResult.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ChattingID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NickName";
            this.dataGridViewTextBoxColumn2.HeaderText = "昵称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn3.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn4.HeaderText = "性别";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // grpAdvancedCondition
            // 
            this.grpAdvancedCondition.Controls.Add(this.lblSex);
            this.grpAdvancedCondition.Controls.Add(this.cboSex);
            this.grpAdvancedCondition.Controls.Add(this.cboAge);
            this.grpAdvancedCondition.Controls.Add(this.lblAge);
            this.grpAdvancedCondition.Location = new System.Drawing.Point(30, 48);
            this.grpAdvancedCondition.Name = "grpAdvancedCondition";
            this.grpAdvancedCondition.Size = new System.Drawing.Size(266, 115);
            this.grpAdvancedCondition.TabIndex = 3;
            this.grpAdvancedCondition.TabStop = false;
            this.grpAdvancedCondition.Text = "基本条件";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(37, 69);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "性别：";
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(84, 66);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(121, 20);
            this.cboSex.TabIndex = 2;
            // 
            // cboAge
            // 
            this.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Items.AddRange(new object[] {
            "不限",
            "0～10岁",
            "10～20岁",
            "20～30岁",
            "30～40岁",
            "40～50岁",
            "50岁以上"});
            this.cboAge.Location = new System.Drawing.Point(84, 30);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(121, 20);
            this.cboAge.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(37, 33);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 12);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "年龄：";
            // 
            // picAdvancedCondition
            // 
            this.picAdvancedCondition.Image = ((System.Drawing.Image)(resources.GetObject("picAdvancedCondition.Image")));
            this.picAdvancedCondition.Location = new System.Drawing.Point(30, 13);
            this.picAdvancedCondition.Name = "picAdvancedCondition";
            this.picAdvancedCondition.Size = new System.Drawing.Size(17, 18);
            this.picAdvancedCondition.TabIndex = 1;
            this.picAdvancedCondition.TabStop = false;
            // 
            // lblAdvancedCondion
            // 
            this.lblAdvancedCondion.AutoSize = true;
            this.lblAdvancedCondion.Location = new System.Drawing.Point(65, 18);
            this.lblAdvancedCondion.Name = "lblAdvancedCondion";
            this.lblAdvancedCondion.Size = new System.Drawing.Size(185, 12);
            this.lblAdvancedCondion.TabIndex = 2;
            this.lblAdvancedCondion.Text = "您可以通过年龄或者性别进行查找";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(408, 229);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Location = new System.Drawing.Point(268, 230);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Location = new System.Drawing.Point(268, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "加为好友";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(123, 229);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "上一步";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chLoginId
            // 
            this.chLoginId.Text = "Chatting号码";
            this.chLoginId.Width = 80;
            // 
            // chNickName
            // 
            this.chNickName.Text = "Chatting昵称";
            this.chNickName.Width = 80;
            // 
            // chAge
            // 
            this.chAge.Text = "年龄";
            this.chAge.Width = 80;
            // 
            // chSex
            // 
            this.chSex.Text = "性别";
            this.chSex.Width = 80;
            // 
            // SearchFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(559, 268);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabSearch);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchFriendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找/添加好友";
            this.Load += new System.EventHandler(this.SearchFriendForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tpBaseSearch.ResumeLayout(false);
            this.pnlBaseCondition.ResumeLayout(false);
            this.pnlBaseCondition.PerformLayout();
            this.pnlBaseResult.ResumeLayout(false);
            this.pnlBaseResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseResult)).EndInit();
            this.pnlSearchType.ResumeLayout(false);
            this.pnlSearchType.PerformLayout();
            this.grpBaseCondition.ResumeLayout(false);
            this.grpBaseCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseCondition)).EndInit();
            this.tpAdvancedSearch.ResumeLayout(false);
            this.pnlAdvancedCondition.ResumeLayout(false);
            this.pnlAdvancedCondition.PerformLayout();
            this.pnlAdvancedResult.ResumeLayout(false);
            this.pnlAdvancedResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedResult)).EndInit();
            this.grpAdvancedCondition.ResumeLayout(false);
            this.grpAdvancedCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedCondition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tpBaseSearch;
        private System.Windows.Forms.TabPage tpAdvancedSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picBaseCondition;
        private System.Windows.Forms.Label lblBaseCondition;
        private System.Windows.Forms.Panel pnlSearchType;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoNicetySearch;
        private System.Windows.Forms.GroupBox grpBaseCondition;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.PictureBox picAdvancedCondition;
        private System.Windows.Forms.Label lblAdvancedCondion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader chLoginId;
        private System.Windows.Forms.ColumnHeader chNickName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chSex;
        private System.Windows.Forms.DataGridView dgvBasicResult;
        private System.Windows.Forms.Panel pnlBaseCondition;
        private System.Windows.Forms.Panel pnlBaseResult;
        private System.Windows.Forms.PictureBox picBaseResult;
        private System.Windows.Forms.Label lblBaseResult;
        private System.Windows.Forms.Panel pnlAdvancedCondition;
        private System.Windows.Forms.Panel pnlAdvancedResult;
        private System.Windows.Forms.PictureBox picAdvancedResult;
        private System.Windows.Forms.Label lblAdvancedResult;
        private System.Windows.Forms.DataGridView dgvAdvancedResult;
        private System.Windows.Forms.GroupBox grpAdvancedCondition;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}