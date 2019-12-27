namespace MetalAndSementSystem
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMetalTitle = new System.Windows.Forms.Label();
            this.lblMetalAllSystem = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCementAllSystem = new System.Windows.Forms.Label();
            this.lblCementTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitleRevenue = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.btnRefreshReports = new System.Windows.Forms.Button();
            this.lblReports = new System.Windows.Forms.Label();
            this.btnRemoveReport = new System.Windows.Forms.Button();
            this.btnDeleteAllReports = new System.Windows.Forms.Button();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.btnOpenReport = new System.Windows.Forms.Button();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.chkQuickSearch = new System.Windows.Forms.CheckBox();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.buttonHagzQuick = new System.Windows.Forms.Button();
            this.buttonSahbQuick = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblClients = new System.Windows.Forms.Label();
            this.lblTitleSearch = new System.Windows.Forms.Label();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.btnArchive = new System.Windows.Forms.Button();
            this.DataGridClients = new System.Windows.Forms.DataGridView();
            this.clmClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountrey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelClient = new System.Windows.Forms.Button();
            this.btnOpenClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lnklblChange = new System.Windows.Forms.LinkLabel();
            this.Report_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientIDreports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClients)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMetalTitle);
            this.groupBox3.Controls.Add(this.lblMetalAllSystem);
            this.groupBox3.Location = new System.Drawing.Point(342, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 64);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // lblMetalTitle
            // 
            this.lblMetalTitle.AutoSize = true;
            this.lblMetalTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetalTitle.Location = new System.Drawing.Point(101, -3);
            this.lblMetalTitle.Name = "lblMetalTitle";
            this.lblMetalTitle.Size = new System.Drawing.Size(109, 25);
            this.lblMetalTitle.TabIndex = 3;
            this.lblMetalTitle.Text = "حجز الحديد";
            this.toolTip1.SetToolTip(this.lblMetalTitle, "مجموع حجوزات الحديد لكل المستخدمين");
            // 
            // lblMetalAllSystem
            // 
            this.lblMetalAllSystem.AutoSize = true;
            this.lblMetalAllSystem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetalAllSystem.ForeColor = System.Drawing.Color.Red;
            this.lblMetalAllSystem.Location = new System.Drawing.Point(48, 29);
            this.lblMetalAllSystem.Name = "lblMetalAllSystem";
            this.lblMetalAllSystem.Size = new System.Drawing.Size(28, 25);
            this.lblMetalAllSystem.TabIndex = 18;
            this.lblMetalAllSystem.Text = "M";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCementAllSystem);
            this.groupBox2.Controls.Add(this.lblCementTitle);
            this.groupBox2.Location = new System.Drawing.Point(10, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 64);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // lblCementAllSystem
            // 
            this.lblCementAllSystem.AutoSize = true;
            this.lblCementAllSystem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCementAllSystem.ForeColor = System.Drawing.Color.Red;
            this.lblCementAllSystem.Location = new System.Drawing.Point(45, 29);
            this.lblCementAllSystem.Name = "lblCementAllSystem";
            this.lblCementAllSystem.Size = new System.Drawing.Size(25, 25);
            this.lblCementAllSystem.TabIndex = 17;
            this.lblCementAllSystem.Text = "C";
            // 
            // lblCementTitle
            // 
            this.lblCementTitle.AutoSize = true;
            this.lblCementTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCementTitle.Location = new System.Drawing.Point(84, -3);
            this.lblCementTitle.Name = "lblCementTitle";
            this.lblCementTitle.Size = new System.Drawing.Size(142, 25);
            this.lblCementTitle.TabIndex = 4;
            this.lblCementTitle.Text = "حجز الأسمنت ";
            this.toolTip1.SetToolTip(this.lblCementTitle, "مجموع حجوزات الإسمنت لكل المستخدمين");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitleRevenue);
            this.groupBox1.Controls.Add(this.lblRevenue);
            this.groupBox1.Location = new System.Drawing.Point(670, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 64);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // lblTitleRevenue
            // 
            this.lblTitleRevenue.AutoSize = true;
            this.lblTitleRevenue.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleRevenue.Location = new System.Drawing.Point(124, 0);
            this.lblTitleRevenue.Name = "lblTitleRevenue";
            this.lblTitleRevenue.Size = new System.Drawing.Size(63, 25);
            this.lblTitleRevenue.TabIndex = 22;
            this.lblTitleRevenue.Text = "الأرباح";
            this.toolTip1.SetToolTip(this.lblTitleRevenue, "صافي النقود التي دخلت للنظام من مختلف العملاء");
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.ForeColor = System.Drawing.Color.Red;
            this.lblRevenue.Location = new System.Drawing.Point(58, 29);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(26, 25);
            this.lblRevenue.TabIndex = 23;
            this.lblRevenue.Text = "D";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 524);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 72);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // tabPageReports
            // 
            this.tabPageReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPageReports.Controls.Add(this.btnRefreshReports);
            this.tabPageReports.Controls.Add(this.lblReports);
            this.tabPageReports.Controls.Add(this.btnRemoveReport);
            this.tabPageReports.Controls.Add(this.btnDeleteAllReports);
            this.tabPageReports.Controls.Add(this.dataGridViewReports);
            this.tabPageReports.Controls.Add(this.btnOpenReport);
            this.tabPageReports.Location = new System.Drawing.Point(4, 22);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(981, 484);
            this.tabPageReports.TabIndex = 1;
            this.tabPageReports.Text = "التقارير";
            // 
            // btnRefreshReports
            // 
            this.btnRefreshReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshReports.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshReports.Location = new System.Drawing.Point(11, 11);
            this.btnRefreshReports.Name = "btnRefreshReports";
            this.btnRefreshReports.Size = new System.Drawing.Size(120, 23);
            this.btnRefreshReports.TabIndex = 30;
            this.btnRefreshReports.Text = "تحديث";
            this.btnRefreshReports.UseVisualStyleBackColor = false;
            this.btnRefreshReports.Click += new System.EventHandler(this.BtnRefreshReports_Click);
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(840, 3);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(135, 25);
            this.lblReports.TabIndex = 15;
            this.lblReports.Text = "التقارير الأخيرة";
            // 
            // btnRemoveReport
            // 
            this.btnRemoveReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveReport.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveReport.Location = new System.Drawing.Point(726, 455);
            this.btnRemoveReport.Name = "btnRemoveReport";
            this.btnRemoveReport.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveReport.TabIndex = 29;
            this.btnRemoveReport.Text = "حذف التقرير المحدد";
            this.btnRemoveReport.UseVisualStyleBackColor = false;
            this.btnRemoveReport.Click += new System.EventHandler(this.BtnRemoveReport_Click);
            // 
            // btnDeleteAllReports
            // 
            this.btnDeleteAllReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAllReports.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAllReports.Location = new System.Drawing.Point(6, 455);
            this.btnDeleteAllReports.Name = "btnDeleteAllReports";
            this.btnDeleteAllReports.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteAllReports.TabIndex = 29;
            this.btnDeleteAllReports.Text = "حذف كافة التقارير";
            this.btnDeleteAllReports.UseVisualStyleBackColor = false;
            this.btnDeleteAllReports.Click += new System.EventHandler(this.BtnDeleteAllReports_Click);
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AllowUserToAddRows = false;
            this.dataGridViewReports.AllowUserToDeleteRows = false;
            this.dataGridViewReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReports.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Report_ID,
            this.clmClientIDreports,
            this.clmReportDate,
            this.clmReport});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReports.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReports.Location = new System.Drawing.Point(11, 40);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.ReadOnly = true;
            this.dataGridViewReports.Size = new System.Drawing.Size(959, 409);
            this.dataGridViewReports.TabIndex = 13;
            // 
            // btnOpenReport
            // 
            this.btnOpenReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenReport.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenReport.Location = new System.Drawing.Point(855, 455);
            this.btnOpenReport.Name = "btnOpenReport";
            this.btnOpenReport.Size = new System.Drawing.Size(120, 23);
            this.btnOpenReport.TabIndex = 11;
            this.btnOpenReport.Text = "الذهاب الى العميل";
            this.btnOpenReport.UseVisualStyleBackColor = false;
            this.btnOpenReport.Click += new System.EventHandler(this.BtnOpenReport_Click);
            // 
            // tabPageClients
            // 
            this.tabPageClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPageClients.Controls.Add(this.chkQuickSearch);
            this.tabPageClients.Controls.Add(this.chkAutoUpdate);
            this.tabPageClients.Controls.Add(this.btnSearch);
            this.tabPageClients.Controls.Add(this.buttonHagzQuick);
            this.tabPageClients.Controls.Add(this.buttonSahbQuick);
            this.tabPageClients.Controls.Add(this.btnRefresh);
            this.tabPageClients.Controls.Add(this.lblClients);
            this.tabPageClients.Controls.Add(this.lblTitleSearch);
            this.tabPageClients.Controls.Add(this.txtClientSearch);
            this.tabPageClients.Controls.Add(this.btnArchive);
            this.tabPageClients.Controls.Add(this.DataGridClients);
            this.tabPageClients.Controls.Add(this.btnDelClient);
            this.tabPageClients.Controls.Add(this.btnOpenClient);
            this.tabPageClients.Controls.Add(this.btnAddClient);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(981, 484);
            this.tabPageClients.TabIndex = 0;
            this.tabPageClients.Text = "العملاء";
            // 
            // chkQuickSearch
            // 
            this.chkQuickSearch.AutoSize = true;
            this.chkQuickSearch.Checked = true;
            this.chkQuickSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuickSearch.Location = new System.Drawing.Point(21, 8);
            this.chkQuickSearch.Name = "chkQuickSearch";
            this.chkQuickSearch.Size = new System.Drawing.Size(123, 17);
            this.chkQuickSearch.TabIndex = 33;
            this.chkQuickSearch.Text = "تفعيل البحث التلقائي";
            this.toolTip1.SetToolTip(this.chkQuickSearch, "سوف يتم البحث بمجرد كتابة الإسم في صندوق البحث , ولكن هذا قد يؤدي للتهنيج في حالة" +
        " كثرة العملاء");
            this.chkQuickSearch.UseVisualStyleBackColor = true;
            this.chkQuickSearch.CheckedChanged += new System.EventHandler(this.ChkQuickSearch_CheckedChanged);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Checked = true;
            this.chkAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoUpdate.Location = new System.Drawing.Point(150, 8);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(132, 17);
            this.chkAutoUpdate.TabIndex = 32;
            this.chkAutoUpdate.Text = "تفعيل التحديث التلقائي";
            this.toolTip1.SetToolTip(this.chkAutoUpdate, "سوف يتم تحديث شاشة العملاء تلقائيا بعد كل تعديل , ولكن هذا قد يؤدي للتهنيج في حال" +
        "ة كثرة العملاء");
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            this.chkAutoUpdate.CheckedChanged += new System.EventHandler(this.ChkAutoUpdate_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(19, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 23);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // buttonHagzQuick
            // 
            this.buttonHagzQuick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHagzQuick.BackColor = System.Drawing.Color.Transparent;
            this.buttonHagzQuick.Location = new System.Drawing.Point(477, 437);
            this.buttonHagzQuick.Name = "buttonHagzQuick";
            this.buttonHagzQuick.Size = new System.Drawing.Size(120, 23);
            this.buttonHagzQuick.TabIndex = 30;
            this.buttonHagzQuick.Text = "حجز";
            this.buttonHagzQuick.UseVisualStyleBackColor = false;
            this.buttonHagzQuick.Click += new System.EventHandler(this.ButtonHagzQuick_Click);
            // 
            // buttonSahbQuick
            // 
            this.buttonSahbQuick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSahbQuick.BackColor = System.Drawing.Color.Transparent;
            this.buttonSahbQuick.Location = new System.Drawing.Point(603, 437);
            this.buttonSahbQuick.Name = "buttonSahbQuick";
            this.buttonSahbQuick.Size = new System.Drawing.Size(120, 23);
            this.buttonSahbQuick.TabIndex = 29;
            this.buttonSahbQuick.Text = "سحب";
            this.buttonSahbQuick.UseVisualStyleBackColor = false;
            this.buttonSahbQuick.Click += new System.EventHandler(this.ButtonSahbQuick_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(765, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblClients
            // 
            this.lblClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(909, 3);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(69, 25);
            this.lblClients.TabIndex = 14;
            this.lblClients.Text = "العملاء";
            // 
            // lblTitleSearch
            // 
            this.lblTitleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleSearch.AutoSize = true;
            this.lblTitleSearch.Location = new System.Drawing.Point(729, 34);
            this.lblTitleSearch.Name = "lblTitleSearch";
            this.lblTitleSearch.Size = new System.Drawing.Size(30, 13);
            this.lblTitleSearch.TabIndex = 0;
            this.lblTitleSearch.Text = " بحث";
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientSearch.Location = new System.Drawing.Point(78, 31);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(625, 20);
            this.txtClientSearch.TabIndex = 1;
            this.txtClientSearch.TextChanged += new System.EventHandler(this.TxtClientSearch_TextChanged);
            // 
            // btnArchive
            // 
            this.btnArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnArchive.BackColor = System.Drawing.Color.Transparent;
            this.btnArchive.Location = new System.Drawing.Point(147, 437);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(120, 23);
            this.btnArchive.TabIndex = 27;
            this.btnArchive.Text = "العملاء المحذوفين";
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.BtnArchive_Click);
            // 
            // DataGridClients
            // 
            this.DataGridClients.AllowUserToAddRows = false;
            this.DataGridClients.AllowUserToDeleteRows = false;
            this.DataGridClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridClients.BackgroundColor = System.Drawing.Color.White;
            this.DataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmClientID,
            this.clmName,
            this.clmCountrey,
            this.clmAddedDate,
            this.clmMetal,
            this.clmCement,
            this.clmMoney,
            this.clmNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridClients.Location = new System.Drawing.Point(19, 57);
            this.DataGridClients.Name = "DataGridClients";
            this.DataGridClients.ReadOnly = true;
            this.DataGridClients.Size = new System.Drawing.Size(954, 374);
            this.DataGridClients.TabIndex = 2;
            // 
            // clmClientID
            // 
            this.clmClientID.DataPropertyName = "Client_ID";
            this.clmClientID.HeaderText = "ClientID";
            this.clmClientID.Name = "clmClientID";
            this.clmClientID.ReadOnly = true;
            this.clmClientID.Visible = false;
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Client_Name";
            this.clmName.HeaderText = "الإسم";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 61;
            // 
            // clmCountrey
            // 
            this.clmCountrey.DataPropertyName = "Client_Country";
            this.clmCountrey.HeaderText = "البلد";
            this.clmCountrey.Name = "clmCountrey";
            this.clmCountrey.ReadOnly = true;
            this.clmCountrey.Width = 52;
            // 
            // clmAddedDate
            // 
            this.clmAddedDate.DataPropertyName = "Date_Added";
            this.clmAddedDate.HeaderText = "تاريخ الإضافة";
            this.clmAddedDate.Name = "clmAddedDate";
            this.clmAddedDate.ReadOnly = true;
            this.clmAddedDate.Width = 89;
            // 
            // clmMetal
            // 
            this.clmMetal.DataPropertyName = "Metal";
            this.clmMetal.HeaderText = "حجز الحديد";
            this.clmMetal.Name = "clmMetal";
            this.clmMetal.ReadOnly = true;
            this.clmMetal.Width = 82;
            // 
            // clmCement
            // 
            this.clmCement.DataPropertyName = "Cement";
            this.clmCement.HeaderText = "حجز الإسمنت";
            this.clmCement.Name = "clmCement";
            this.clmCement.ReadOnly = true;
            this.clmCement.Width = 96;
            // 
            // clmMoney
            // 
            this.clmMoney.DataPropertyName = "C_Money";
            this.clmMoney.HeaderText = "الفلوس الحالية";
            this.clmMoney.Name = "clmMoney";
            this.clmMoney.ReadOnly = true;
            this.clmMoney.Width = 48;
            // 
            // clmNotes
            // 
            this.clmNotes.DataPropertyName = "Notes";
            this.clmNotes.HeaderText = "ملاحظات";
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.ReadOnly = true;
            this.clmNotes.Width = 73;
            // 
            // btnDelClient
            // 
            this.btnDelClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelClient.BackColor = System.Drawing.Color.Transparent;
            this.btnDelClient.Location = new System.Drawing.Point(21, 437);
            this.btnDelClient.Name = "btnDelClient";
            this.btnDelClient.Size = new System.Drawing.Size(120, 23);
            this.btnDelClient.TabIndex = 6;
            this.btnDelClient.Text = "حذف العميل";
            this.btnDelClient.UseVisualStyleBackColor = false;
            this.btnDelClient.Click += new System.EventHandler(this.BtnDelClient_Click);
            // 
            // btnOpenClient
            // 
            this.btnOpenClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenClient.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenClient.Location = new System.Drawing.Point(729, 437);
            this.btnOpenClient.Name = "btnOpenClient";
            this.btnOpenClient.Size = new System.Drawing.Size(120, 23);
            this.btnOpenClient.TabIndex = 7;
            this.btnOpenClient.Text = "صفحة العميل";
            this.btnOpenClient.UseVisualStyleBackColor = false;
            this.btnOpenClient.Click += new System.EventHandler(this.BtnOpenClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClient.Location = new System.Drawing.Point(853, 437);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(120, 23);
            this.btnAddClient.TabIndex = 8;
            this.btnAddClient.Text = "اضافة عميل جديد";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageClients);
            this.tabControl1.Controls.Add(this.tabPageReports);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 510);
            this.tabControl1.TabIndex = 30;
            // 
            // lnklblChange
            // 
            this.lnklblChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklblChange.AutoSize = true;
            this.lnklblChange.LinkColor = System.Drawing.Color.Red;
            this.lnklblChange.Location = new System.Drawing.Point(425, 607);
            this.lnklblChange.Name = "lnklblChange";
            this.lnklblChange.Size = new System.Drawing.Size(163, 13);
            this.lnklblChange.TabIndex = 34;
            this.lnklblChange.TabStop = true;
            this.lnklblChange.Text = "تغيير حسابات النظام (يرجى الحذر)";
            this.lnklblChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnklblChange_LinkClicked);
            // 
            // Report_ID
            // 
            this.Report_ID.DataPropertyName = "Report_ID";
            this.Report_ID.HeaderText = "Report_ID";
            this.Report_ID.Name = "Report_ID";
            this.Report_ID.ReadOnly = true;
            this.Report_ID.Visible = false;
            // 
            // clmClientIDreports
            // 
            this.clmClientIDreports.DataPropertyName = "Client_ID";
            this.clmClientIDreports.HeaderText = "Client_ID";
            this.clmClientIDreports.Name = "clmClientIDreports";
            this.clmClientIDreports.ReadOnly = true;
            this.clmClientIDreports.Visible = false;
            // 
            // clmReportDate
            // 
            this.clmReportDate.DataPropertyName = "Date_Added";
            this.clmReportDate.HeaderText = "التاريخ";
            this.clmReportDate.Name = "clmReportDate";
            this.clmReportDate.ReadOnly = true;
            // 
            // clmReport
            // 
            this.clmReport.DataPropertyName = "Report";
            this.clmReport.HeaderText = "التقرير";
            this.clmReport.Name = "clmReport";
            this.clmReport.ReadOnly = true;
            this.clmReport.Width = 916;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1013, 629);
            this.Controls.Add(this.lnklblChange);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسية";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPageReports.ResumeLayout(false);
            this.tabPageReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            this.tabPageClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClients)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMetalTitle;
        private System.Windows.Forms.Label lblMetalAllSystem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCementAllSystem;
        private System.Windows.Forms.Label lblCementTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitleRevenue;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Button btnDeleteAllReports;
        private System.Windows.Forms.DataGridView dataGridViewReports;
        private System.Windows.Forms.Button btnOpenReport;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Label lblTitleSearch;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.DataGridView DataGridClients;
        private System.Windows.Forms.Button btnDelClient;
        private System.Windows.Forms.Button btnOpenClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button buttonHagzQuick;
        private System.Windows.Forms.Button buttonSahbQuick;
        private System.Windows.Forms.Button btnRemoveReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkQuickSearch;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountrey;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.Button btnRefreshReports;
        private System.Windows.Forms.LinkLabel lnklblChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Report_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientIDreports;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReport;
    }
}

