using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetalAndSementSystem;

namespace MetalAndSementSystem
{
    public partial class frmTotals : Form
    {
        public frmTotals()
        {
            InitializeComponent();
        }

        private void BtnChng_Click(object sender, EventArgs e)
        {

            string metal = txtMetalAllSystem.Text;
            string cement = txtCementAllSystem.Text;
            string revenue = txtRevenue.Text;
            TotalsHandler.change(metal, cement, revenue);
            MessageBox.Show("تم تغيير حسابات النظام");
            Close();
        }

        private void FrmTotals_Load(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("أنت على وشك ان تقوم بالتعديل يدويا في حسابات النظام , سوف يؤدي ذلك الى تخريب الحسابات , هل أنت متأكد من هذا ؟",
                "التعديل يدويا في حسابات النظام", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)

            {
                Close();
            }
            TotalsHandler.loadData();
            txtMetalAllSystem.Text = TotalsHandler.getMetal();
            txtCementAllSystem.Text = TotalsHandler.getCement();
            txtRevenue.Text = TotalsHandler.getRevenue();
        }
    }
}
