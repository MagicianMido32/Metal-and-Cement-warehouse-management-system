using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetalAndSementSystem
{
    public partial class inputDelWhy : Form
    {
        private string reason = "";
        public inputDelWhy()
        {
            InitializeComponent();
        }

        private void InputDelWhy_Load(object sender, EventArgs e)
        {
        

        }

        public  void  showInput(ref string val)
        {
            
            this.ShowDialog();
            val =  reason;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            reason = txtDelReson.Text;
            this.Close();
        }
    }
}
