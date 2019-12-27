namespace MetalAndSementSystem
{
    partial class frmPrevClients
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
            this.dataGridPrevClients = new System.Windows.Forms.DataGridView();
            this.lblClients = new System.Windows.Forms.Label();
            this.btnFullDelete = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateRemoved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetalTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTakenMetal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCementTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTakenCement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAllMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNoteDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrevClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPrevClients
            // 
            this.dataGridPrevClients.AllowUserToAddRows = false;
            this.dataGridPrevClients.AllowUserToDeleteRows = false;
            this.dataGridPrevClients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPrevClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmCountry,
            this.clmDateAdded,
            this.clmDateRemoved,
            this.clmMetal,
            this.clmMetalTon,
            this.clmTakenMetal,
            this.clmCement,
            this.clmCementTon,
            this.clmTakenCement,
            this.clmMoney,
            this.clmAllMoney,
            this.clmNoteDeleted,
            this.Notes});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPrevClients.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPrevClients.Location = new System.Drawing.Point(12, 54);
            this.dataGridPrevClients.Name = "dataGridPrevClients";
            this.dataGridPrevClients.ReadOnly = true;
            this.dataGridPrevClients.Size = new System.Drawing.Size(938, 388);
            this.dataGridPrevClients.TabIndex = 0;
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(12, 9);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(155, 25);
            this.lblClients.TabIndex = 15;
            this.lblClients.Text = "العملاء السابقين";
            // 
            // btnFullDelete
            // 
            this.btnFullDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnFullDelete.Location = new System.Drawing.Point(12, 448);
            this.btnFullDelete.Name = "btnFullDelete";
            this.btnFullDelete.Size = new System.Drawing.Size(145, 23);
            this.btnFullDelete.TabIndex = 28;
            this.btnFullDelete.Text = "حذف العميل للأبد";
            this.btnFullDelete.UseVisualStyleBackColor = false;
            this.btnFullDelete.Click += new System.EventHandler(this.BtnFullDelete_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.BackColor = System.Drawing.Color.Transparent;
            this.btnRecover.Location = new System.Drawing.Point(163, 448);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(145, 23);
            this.btnRecover.TabIndex = 29;
            this.btnRecover.Text = "استعادة العميل";
            this.btnRecover.UseVisualStyleBackColor = false;
            this.btnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.Color.Transparent;
            this.btnDelAll.Location = new System.Drawing.Point(728, 448);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(222, 23);
            this.btnDelAll.TabIndex = 30;
            this.btnDelAll.Text = "حذف كل العملاء السابقين";
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.BtnDelAll_Click);
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmName.DataPropertyName = "Client_Name";
            this.clmName.HeaderText = "الإسم";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 61;
            // 
            // clmCountry
            // 
            this.clmCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCountry.DataPropertyName = "Client_Country";
            this.clmCountry.HeaderText = "البلد";
            this.clmCountry.Name = "clmCountry";
            this.clmCountry.ReadOnly = true;
            this.clmCountry.Width = 52;
            // 
            // clmDateAdded
            // 
            this.clmDateAdded.DataPropertyName = "Date_Added";
            this.clmDateAdded.HeaderText = "تاريخ الإضافة";
            this.clmDateAdded.Name = "clmDateAdded";
            this.clmDateAdded.ReadOnly = true;
            this.clmDateAdded.Width = 89;
            // 
            // clmDateRemoved
            // 
            this.clmDateRemoved.DataPropertyName = "Date_Removed";
            this.clmDateRemoved.HeaderText = "تاريخ الحذف";
            this.clmDateRemoved.Name = "clmDateRemoved";
            this.clmDateRemoved.ReadOnly = true;
            this.clmDateRemoved.Width = 85;
            // 
            // clmMetal
            // 
            this.clmMetal.DataPropertyName = "Metal";
            this.clmMetal.HeaderText = "حجز الحديد";
            this.clmMetal.Name = "clmMetal";
            this.clmMetal.ReadOnly = true;
            this.clmMetal.Width = 82;
            // 
            // clmMetalTon
            // 
            this.clmMetalTon.DataPropertyName = "Metal_Ton_Price";
            this.clmMetalTon.HeaderText = "سعر الطن";
            this.clmMetalTon.Name = "clmMetalTon";
            this.clmMetalTon.ReadOnly = true;
            this.clmMetalTon.Width = 79;
            // 
            // clmTakenMetal
            // 
            this.clmTakenMetal.DataPropertyName = "Taken_Metal";
            this.clmTakenMetal.HeaderText = "الحديد المسحوب";
            this.clmTakenMetal.Name = "clmTakenMetal";
            this.clmTakenMetal.ReadOnly = true;
            this.clmTakenMetal.Width = 109;
            // 
            // clmCement
            // 
            this.clmCement.DataPropertyName = "Cement";
            this.clmCement.HeaderText = "حجز الإسمنت";
            this.clmCement.Name = "clmCement";
            this.clmCement.ReadOnly = true;
            this.clmCement.Width = 74;
            // 
            // clmCementTon
            // 
            this.clmCementTon.DataPropertyName = "Cement_Ton_Price";
            this.clmCementTon.HeaderText = "سعر الطن";
            this.clmCementTon.Name = "clmCementTon";
            this.clmCementTon.ReadOnly = true;
            this.clmCementTon.Width = 79;
            // 
            // clmTakenCement
            // 
            this.clmTakenCement.DataPropertyName = "Taken_Cement";
            this.clmTakenCement.HeaderText = "الإسمنت المسحوب";
            this.clmTakenCement.Name = "clmTakenCement";
            this.clmTakenCement.ReadOnly = true;
            this.clmTakenCement.Width = 123;
            // 
            // clmMoney
            // 
            this.clmMoney.DataPropertyName = "C_Money";
            this.clmMoney.HeaderText = "الفلوس";
            this.clmMoney.Name = "clmMoney";
            this.clmMoney.ReadOnly = true;
            this.clmMoney.ToolTipText = "الفلوس التي كانت لدى العميل او مديون بها عندما تم حذفه";
            this.clmMoney.Width = 48;
            // 
            // clmAllMoney
            // 
            this.clmAllMoney.DataPropertyName = "All_Money";
            this.clmAllMoney.HeaderText = "كل ما دفعه";
            this.clmAllMoney.Name = "clmAllMoney";
            this.clmAllMoney.ReadOnly = true;
            this.clmAllMoney.ToolTipText = "كل الفلوس التي دفعها العميل اثناء تواجده في النظام";
            this.clmAllMoney.Width = 53;
            // 
            // clmNoteDeleted
            // 
            this.clmNoteDeleted.DataPropertyName = "Note_Delete";
            this.clmNoteDeleted.HeaderText = "سبب الحذف";
            this.clmNoteDeleted.Name = "clmNoteDeleted";
            this.clmNoteDeleted.ReadOnly = true;
            this.clmNoteDeleted.Width = 89;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "ملاحظات";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 73;
            // 
            // frmPrevClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(968, 508);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnFullDelete);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.dataGridPrevClients);
            this.Name = "frmPrevClients";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العملاء السابقين";
            this.Load += new System.EventHandler(this.FrmPrevClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrevClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPrevClients;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Button btnFullDelete;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateRemoved;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetalTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTakenMetal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCementTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTakenCement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAllMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNoteDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}