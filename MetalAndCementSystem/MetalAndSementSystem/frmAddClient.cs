using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace MetalAndSementSystem
{
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            //initialize 
            txtMetal.Text = "0";
            txtMetalTon.Text = "0";
            txtCement.Text = "0";
            txtCementTon.Text = "0";
            txtPaidMoney.Text = "0";
            lblMetalTotal.Text = "0";
            lblCementTotal.Text = "0";
            lblMoney.Text = "0";

            txtMetal.TextChanged += TxtMetalChanged;
            txtMetalTon.TextChanged += TxtMetalChanged;

            txtCement.TextChanged += TxtCementChanged;
            txtCementTon.TextChanged += TxtCementChanged;

            txtPaidMoney.TextChanged += TxtTotalChanged;

        }

        private void TxtMetalChanged(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtMetal.Text) || string.IsNullOrWhiteSpace(txtMetalTon.Text))
                {
                    lblMetalTotal.Text = "0";
                    return;
                }
                double metal = double.Parse(txtMetal.Text);
                double metalTonPrice = double.Parse(txtMetalTon.Text);
                double result = metal * metalTonPrice;
                lblMetalTotal.Text = result.ToString();
                TxtTotalChanged(sender, e);
            }
            catch { }
        }

        private void TxtCementChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCement.Text) || string.IsNullOrWhiteSpace(txtCementTon.Text))
                {
                    lblCementTotal.Text = "0";
                    return;
                }
                double cement = double.Parse(txtCement.Text);
                double cementTonPrice = double.Parse(txtCementTon.Text);
                double result = cement * cementTonPrice;
                lblCementTotal.Text = result.ToString();
                TxtTotalChanged(sender, e);
            }
            catch { }
        }
        private void TxtTotalChanged(object sender, EventArgs e)
        {
            try
            {
                double metalPrice = double.Parse(lblMetalTotal.Text);
                double cementPrice = double.Parse(lblCementTotal.Text);
                double total = metalPrice + cementPrice;
                double paid = double.Parse(txtPaidMoney.Text);
                double money = paid - total;
                if (money < 0)
                {
                    lblOpType.Text = "باقي عليه من العملية";
                    lblOpType.ForeColor = Color.Red;
                }
                else
                {
                    lblOpType.Text = "باقي له من العملية";
                    lblOpType.ForeColor = Color.Black;
                }
                lblMoney.Text = money.ToString();
            }
            catch { }
        }

        private bool isClientArchived()
        {
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "Select Client_Name from Prev_Client WHERE Client_Name = @clientname;";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@clientname", txtClientName.Text);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Dispose();
                cmd.Dispose();
                connection.Close();
                return true;
            }
            reader.Dispose();
            cmd.Dispose();
            connection.Close();
            return false;
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {

                string clientName = txtClientName.Text;
                string clientCountry = txtClientCountry.Text;
                if (string.IsNullOrWhiteSpace(clientName) || string.IsNullOrWhiteSpace(clientCountry))
                {
                    MessageBox.Show("الرجاء إدخال الإسم والبلد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isClientArchived())
                {
                    DialogResult dialogResult = MessageBox.Show("يوجد عميل محذوف بهذا الإسم هل تود استعادته ",
                        "عميل محذوف بهذا الإسم", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)

                    {
                        Hide();
                        frmPrevClients frmPrevClients = new frmPrevClients();
                        frmPrevClients.ShowDialog();
                        Close();
                        return;
                    }
                }
                string dateAdded = DateTime.Today.ToString("d");
                string metal = txtMetal.Text;
                string metalTon = txtMetalTon.Text;
                string cement = txtCement.Text;
                string cementTon = txtCementTon.Text;
                //  string money = lblMoney.Text; here we use paid money
                string paidMoney = txtPaidMoney.Text;//الفلوس الي دفعها بس
                if (string.IsNullOrWhiteSpace(paidMoney)) paidMoney = "0";
                string allmoney = txtPaidMoney.Text;
                string notes = txtNotes.Text;//check connectionString
                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "insert into Client(Client_Name,Client_Country,Date_Added,Metal,Metal_Ton_Price,Cement,Cement_Ton_Price,C_Money,All_Money,Notes) " +
                               " values(@clientName,@clientCountry,@dateAdded,@metal,@metalTon," +
                               "@cement,@cementTon," +
                               "@money,@allmoney,@notes);";


                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@clientName", clientName);
                cmd.Parameters.AddWithValue("@clientCountry", clientCountry);
                cmd.Parameters.AddWithValue("@dateAdded", dateAdded);
                cmd.Parameters.AddWithValue("@metal", metal);
                cmd.Parameters.AddWithValue("@metalTon", metalTon);
                cmd.Parameters.AddWithValue("@cement", cement);
                cmd.Parameters.AddWithValue("@cementTon", cementTon);
                cmd.Parameters.AddWithValue("@money", paidMoney);
                cmd.Parameters.AddWithValue("@allmoney", allmoney);
                cmd.Parameters.AddWithValue("@notes", notes);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                TotalsHandler.Add(metal, cement, paidMoney);
                string report = " تمت إضافة عميل جديد بإسم " + clientName + " من بلد " + clientCountry
                    + " حجز حديد " + metal + " سعر الطن " + metalTon + " حجز الإسمنت " + cement
                    + " سعر الطن " + cementTon + " دفع " + paidMoney + " ملاحظات " + notes;
                ReportsHandler.Write(report, "", clientName);

                MessageBox.Show(" تم إضافة عميل جديد ", " تم أضافة عميل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message);

            }
        }
    }
}
