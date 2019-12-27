namespace MetalAndSementSystem
{
    partial class inputDelWhy
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
            this.txtDelReson = new System.Windows.Forms.TextBox();
            this.lblMetalTitle = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDelReson
            // 
            this.txtDelReson.Location = new System.Drawing.Point(17, 28);
            this.txtDelReson.Multiline = true;
            this.txtDelReson.Name = "txtDelReson";
            this.txtDelReson.Size = new System.Drawing.Size(473, 60);
            this.txtDelReson.TabIndex = 0;
            // 
            // lblMetalTitle
            // 
            this.lblMetalTitle.AutoSize = true;
            this.lblMetalTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetalTitle.Location = new System.Drawing.Point(12, 0);
            this.lblMetalTitle.Name = "lblMetalTitle";
            this.lblMetalTitle.Size = new System.Drawing.Size(121, 25);
            this.lblMetalTitle.TabIndex = 5;
            this.lblMetalTitle.Text = "سبب الحذف";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(496, 28);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 60);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "تأكيد";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // inputDelWhy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(579, 127);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMetalTitle);
            this.Controls.Add(this.txtDelReson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inputDelWhy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سبب الحذف";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InputDelWhy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDelReson;
        private System.Windows.Forms.Label lblMetalTitle;
        private System.Windows.Forms.Button btnOk;
    }
}