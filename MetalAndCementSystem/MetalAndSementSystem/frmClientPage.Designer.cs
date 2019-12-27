namespace MetalAndSementSystem
{
    partial class frmClientPage
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelClient = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCementTon = new System.Windows.Forms.TextBox();
            this.txtMetalTon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTakenMetal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTakenCement = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtAllMoney = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ButtonHagz = new System.Windows.Forms.Button();
            this.buttonSahb = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDateAdded = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblMetalTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCement = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMetal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitleCountrey = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.dataGridOprerations = new System.Windows.Forms.DataGridView();
            this.clmOpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetalTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCementTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOprerations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(348, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 51);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "حفظ التعديلات";
            this.toolTip1.SetToolTip(this.btnSave, "حفظ التعديلات في حالة إذا قمت بالتعديل على شاشة العميل , مع ذلك ينصح بتجنب التعدي" +
        "لات على الأموال والحجز والإعتماد على الشاشات المخصصة لذلك");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelClient
            // 
            this.btnDelClient.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelClient.ForeColor = System.Drawing.Color.Red;
            this.btnDelClient.Location = new System.Drawing.Point(681, 528);
            this.btnDelClient.Name = "btnDelClient";
            this.btnDelClient.Size = new System.Drawing.Size(139, 29);
            this.btnDelClient.TabIndex = 36;
            this.btnDelClient.Text = "حذف هذا العميل";
            this.btnDelClient.UseVisualStyleBackColor = true;
            this.btnDelClient.Click += new System.EventHandler(this.BtnDelClient_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 497);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNotes);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Controls.Add(this.ButtonHagz);
            this.tabPage1.Controls.Add(this.buttonSahb);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "بيانات العميل";
            this.toolTip1.SetToolTip(this.tabPage1, "السعر الذي سيقترحه النظام عند عمل عملية سحب او حجز جديدة يمكنك تغييره هنا او تغيي" +
        "ره اثناء القيام بالعملية");
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.55844F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.8256F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel5.Controls.Add(this.txtCementTon, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtMetalTon, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label16, 2, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(273, 359);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(540, 78);
            this.tableLayoutPanel5.TabIndex = 49;
            // 
            // txtCementTon
            // 
            this.txtCementTon.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCementTon.Location = new System.Drawing.Point(187, 43);
            this.txtCementTon.Name = "txtCementTon";
            this.txtCementTon.Size = new System.Drawing.Size(125, 27);
            this.txtCementTon.TabIndex = 41;
            this.toolTip1.SetToolTip(this.txtCementTon, "السعر الذي سيقترحه النظام عند عمل عملية سحب او حجز جديدة يمكنك تغييره هنا او تغيي" +
        "ره اثناء القيام بالعملية");
            // 
            // txtMetalTon
            // 
            this.txtMetalTon.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMetalTon.Location = new System.Drawing.Point(187, 4);
            this.txtMetalTon.Name = "txtMetalTon";
            this.txtMetalTon.Size = new System.Drawing.Size(125, 27);
            this.txtMetalTon.TabIndex = 40;
            this.toolTip1.SetToolTip(this.txtMetalTon, "السعر الذي سيقترحه النظام عند عمل عملية سحب او حجز جديدة يمكنك تغييره هنا او تغيي" +
        "ره اثناء القيام بالعملية");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "سعر طن الحديد الإفتراضي";
            this.toolTip1.SetToolTip(this.label5, "السعر الذي سيقترحه النظام عند عمل عملية سحب او حجز جديدة يمكنك تغييره هنا او تغيي" +
        "ره اثناء القيام بالعملية");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "سعر طن الأسمنت الإفتراضي";
            this.toolTip1.SetToolTip(this.label6, "السعر الذي سيقترحه النظام عند عمل عملية سحب او حجز جديدة يمكنك تغييره هنا او تغيي" +
        "ره اثناء القيام بالعملية");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 19);
            this.label14.TabIndex = 50;
            this.label14.Text = "جنيه";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 19);
            this.label16.TabIndex = 50;
            this.label16.Text = "جنيه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(19, 107);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(243, 150);
            this.txtNotes.TabIndex = 47;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.55844F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.8256F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTakenMetal, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTakenCement, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(273, 191);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 78);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 19);
            this.label12.TabIndex = 50;
            this.label12.Text = "طن";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 19);
            this.label11.TabIndex = 50;
            this.label11.Text = "طن";
            // 
            // txtTakenMetal
            // 
            this.txtTakenMetal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTakenMetal.Location = new System.Drawing.Point(187, 4);
            this.txtTakenMetal.Name = "txtTakenMetal";
            this.txtTakenMetal.Size = new System.Drawing.Size(125, 27);
            this.txtTakenMetal.TabIndex = 50;
            this.toolTip1.SetToolTip(this.txtTakenMetal, "كل الحديد الذي قام العميل بسحبه منذ إضافته للنظام");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "الحديد المسحوب";
            this.toolTip1.SetToolTip(this.label3, "كل الحديد الذي قام العميل بسحبه منذ إضافته للنظام");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "الأسمنت المسحوب";
            this.toolTip1.SetToolTip(this.label7, "كل الإسمنت الذي قام العميل بسحبه منذ إضافته للنظام");
            // 
            // txtTakenCement
            // 
            this.txtTakenCement.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTakenCement.Location = new System.Drawing.Point(187, 43);
            this.txtTakenCement.Name = "txtTakenCement";
            this.txtTakenCement.Size = new System.Drawing.Size(125, 27);
            this.txtTakenCement.TabIndex = 50;
            this.toolTip1.SetToolTip(this.txtTakenCement, "كل الإسمنت الذي قام العميل بسحبه منذ إضافته للنظام");
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.55844F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.8256F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel4.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblMoney, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtMoney, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtAllMoney, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label13, 2, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(273, 275);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(540, 78);
            this.tableLayoutPanel4.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "جنيه";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(327, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(209, 19);
            this.label21.TabIndex = 20;
            this.label21.Text = "كل ما دفعه العميل منذ اضافته";
            this.toolTip1.SetToolTip(this.label21, "كل الفلوس التي قام العميل بدفعها منذ إضافته للنظام سواء اثناء السحب او الحجز");
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(388, 1);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(148, 19);
            this.lblMoney.TabIndex = 14;
            this.lblMoney.Text = "فلوس العميل الحالية";
            this.toolTip1.SetToolTip(this.lblMoney, "الأموال الموجودة لدى العميل في النظام الآن والتي على اساسها تتم الحسابات , يمكن ا" +
        "ن يكون العميل لديه مال او ان يكون مديون (عليه فلوس)");
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMoney.Location = new System.Drawing.Point(187, 4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(125, 27);
            this.txtMoney.TabIndex = 50;
            this.toolTip1.SetToolTip(this.txtMoney, "الأموال الموجودة لدى العميل في النظام الآن والتي على اساسها تتم الحسابات , يمكن ا" +
        "ن يكون العميل لديه مال او ان يكون مديون (عليه فلوس)");
            // 
            // txtAllMoney
            // 
            this.txtAllMoney.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAllMoney.Location = new System.Drawing.Point(187, 43);
            this.txtAllMoney.Name = "txtAllMoney";
            this.txtAllMoney.Size = new System.Drawing.Size(125, 27);
            this.txtAllMoney.TabIndex = 50;
            this.toolTip1.SetToolTip(this.txtAllMoney, "كل الفلوس التي قام العميل بدفعها منذ إضافته للنظام سواء اثناء السحب او الحجز");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 19);
            this.label13.TabIndex = 50;
            this.label13.Text = "جنيه";
            // 
            // ButtonHagz
            // 
            this.ButtonHagz.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHagz.Location = new System.Drawing.Point(17, 6);
            this.ButtonHagz.Name = "ButtonHagz";
            this.ButtonHagz.Size = new System.Drawing.Size(106, 51);
            this.ButtonHagz.TabIndex = 44;
            this.ButtonHagz.Text = "حجز";
            this.ButtonHagz.UseVisualStyleBackColor = true;
            this.ButtonHagz.Click += new System.EventHandler(this.ButtonHagz_Click);
            // 
            // buttonSahb
            // 
            this.buttonSahb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSahb.Location = new System.Drawing.Point(156, 6);
            this.buttonSahb.Name = "buttonSahb";
            this.buttonSahb.Size = new System.Drawing.Size(106, 51);
            this.buttonSahb.TabIndex = 43;
            this.buttonSahb.Text = "سحب";
            this.buttonSahb.UseVisualStyleBackColor = true;
            this.buttonSahb.Click += new System.EventHandler(this.ButtonSahb_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtDateAdded, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCountry, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMetalTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(273, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 95);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // txtDateAdded
            // 
            this.txtDateAdded.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDateAdded.Location = new System.Drawing.Point(22, 66);
            this.txtDateAdded.Name = "txtDateAdded";
            this.txtDateAdded.Size = new System.Drawing.Size(416, 24);
            this.txtDateAdded.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCountry.Location = new System.Drawing.Point(22, 35);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(416, 24);
            this.txtCountry.TabIndex = 9;
            // 
            // lblMetalTitle
            // 
            this.lblMetalTitle.AutoSize = true;
            this.lblMetalTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetalTitle.Location = new System.Drawing.Point(486, 1);
            this.lblMetalTitle.Name = "lblMetalTitle";
            this.lblMetalTitle.Size = new System.Drawing.Size(50, 19);
            this.lblMetalTitle.TabIndex = 5;
            this.lblMetalTitle.Text = "الإسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "تاريخ الإضافة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "البلد";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(22, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(416, 23);
            this.txtName.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.55844F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.8256F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtCement, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtMetal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(273, 107);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(540, 78);
            this.tableLayoutPanel3.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 19);
            this.label9.TabIndex = 50;
            this.label9.Text = "طن";
            // 
            // txtCement
            // 
            this.txtCement.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCement.Location = new System.Drawing.Point(187, 43);
            this.txtCement.Name = "txtCement";
            this.txtCement.Size = new System.Drawing.Size(125, 27);
            this.txtCement.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(400, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 19);
            this.label15.TabIndex = 14;
            this.label15.Text = "حجز الحديد الحالي";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(381, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 19);
            this.label18.TabIndex = 20;
            this.label18.Text = "حجز الإسمنت الحالي";
            // 
            // txtMetal
            // 
            this.txtMetal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMetal.Location = new System.Drawing.Point(187, 4);
            this.txtMetal.Name = "txtMetal";
            this.txtMetal.Size = new System.Drawing.Size(125, 27);
            this.txtMetal.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 19);
            this.label10.TabIndex = 50;
            this.label10.Text = "طن";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.lblTitleCountrey);
            this.tabPage2.Controls.Add(this.btnUndo);
            this.tabPage2.Controls.Add(this.dataGridOprerations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "العمليات التي قام بها العميل";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(499, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 23);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblTitleCountrey
            // 
            this.lblTitleCountrey.AutoSize = true;
            this.lblTitleCountrey.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCountrey.Location = new System.Drawing.Point(557, 37);
            this.lblTitleCountrey.Name = "lblTitleCountrey";
            this.lblTitleCountrey.Size = new System.Drawing.Size(257, 25);
            this.lblTitleCountrey.TabIndex = 38;
            this.lblTitleCountrey.Text = "العمليات التي قام بها العميل";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(18, 396);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(128, 23);
            this.btnUndo.TabIndex = 37;
            this.btnUndo.Text = "التراجع عن العملية";
            this.toolTip1.SetToolTip(this.btnUndo, "سوف يتم إلغاء هذة العملية وإعادة الحديد والأسمنت والنقود الى ماكانت عليه قبل العم" +
        "لية");
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // dataGridOprerations
            // 
            this.dataGridOprerations.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOprerations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOpId,
            this.clmDate,
            this.clmOpType,
            this.clmMetal,
            this.clmMetalTon,
            this.clmCement,
            this.clmCementTon,
            this.clmTotal,
            this.clmMoney,
            this.clmNotes});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridOprerations.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOprerations.Location = new System.Drawing.Point(18, 70);
            this.dataGridOprerations.Name = "dataGridOprerations";
            this.dataGridOprerations.Size = new System.Drawing.Size(791, 320);
            this.dataGridOprerations.TabIndex = 36;
            // 
            // clmOpId
            // 
            this.clmOpId.DataPropertyName = "OP_ID";
            this.clmOpId.HeaderText = "op_id";
            this.clmOpId.Name = "clmOpId";
            this.clmOpId.Visible = false;
            // 
            // clmDate
            // 
            this.clmDate.DataPropertyName = "OP_Date";
            this.clmDate.HeaderText = "التاريخ";
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 60;
            // 
            // clmOpType
            // 
            this.clmOpType.DataPropertyName = "OP_Type";
            this.clmOpType.HeaderText = "نوع العملية";
            this.clmOpType.Name = "clmOpType";
            this.clmOpType.Width = 83;
            // 
            // clmMetal
            // 
            this.clmMetal.DataPropertyName = "Metal";
            this.clmMetal.HeaderText = "الحديد";
            this.clmMetal.Name = "clmMetal";
            this.clmMetal.Width = 60;
            // 
            // clmMetalTon
            // 
            this.clmMetalTon.DataPropertyName = "Metal_Ton_Price";
            this.clmMetalTon.HeaderText = "سعر الطن";
            this.clmMetalTon.Name = "clmMetalTon";
            this.clmMetalTon.Width = 79;
            // 
            // clmCement
            // 
            this.clmCement.DataPropertyName = "Cement";
            this.clmCement.HeaderText = "الإسمنت";
            this.clmCement.Name = "clmCement";
            this.clmCement.Width = 74;
            // 
            // clmCementTon
            // 
            this.clmCementTon.DataPropertyName = "Cement_Ton_Price";
            this.clmCementTon.HeaderText = "سعر الطن";
            this.clmCementTon.Name = "clmCementTon";
            this.clmCementTon.Width = 79;
            // 
            // clmTotal
            // 
            this.clmTotal.DataPropertyName = "Total";
            this.clmTotal.HeaderText = "الأجمالي";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Width = 73;
            // 
            // clmMoney
            // 
            this.clmMoney.DataPropertyName = "PMoney";
            this.clmMoney.HeaderText = "فلوس العملية";
            this.clmMoney.Name = "clmMoney";
            this.clmMoney.Width = 48;
            // 
            // clmNotes
            // 
            this.clmNotes.DataPropertyName = "Notes";
            this.clmNotes.HeaderText = "ملاحظات";
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.Width = 73;
            // 
            // frmClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(854, 581);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDelClient);
            this.Controls.Add(this.btnSave);
            this.Name = "frmClientPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "صفحة العميل";
            this.Load += new System.EventHandler(this.FrmClientPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOprerations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelClient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtCementTon;
        private System.Windows.Forms.TextBox txtMetalTon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTakenMetal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTakenCement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtAllMoney;
        private System.Windows.Forms.Button ButtonHagz;
        private System.Windows.Forms.Button buttonSahb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDateAdded;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblMetalTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtCement;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMetal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitleCountrey;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.DataGridView dataGridOprerations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetalTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCementTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}