using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetalAndSementSystem
{
    public partial class frmSahb : Form
    {
        private string _clientId;
        private string _clientName;
        public frmSahb(string clientId, string clientname)
        {
            _clientId = clientId;
            _clientName = clientname;
            InitializeComponent();
        }

        private void FrmSahb_Load(object sender, EventArgs e)
        {
            txtMetal.Text = "0";
            // txtMetalTon.Text = "0";
            lblMetalTotal.Text = "0";
            txtCement.Text = "0";
            //  txtCementTon.Text = "0";
            lblCementTotal.Text = "0";
            txtPayMoney.Text = "0";
            lblPastMoney.Text = "0";
            lblRemainMoney.Text = "0";
            lblClientName.Text = _clientName;

            txtMetal.TextChanged += TxtMetalChanged;
            txtMetalTon.TextChanged += TxtMetalChanged;

            txtCement.TextChanged += TxtCementChanged;
            txtCementTon.TextChanged += TxtCementChanged;

            txtPayMoney.TextChanged += TxtTotalChanged;

            lblFormerMetal.ForeColor = Color.Black;
            lblFormerCement.ForeColor = Color.Black;


            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "SELECT Metal,Cement,Metal_Ton_Price,Cement_Ton_Price,C_Money " +
                           "FROM Client WHERE Client_ID = @client_id";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@client_id", _clientId);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            lblFormerMetal.Text = reader["Metal"].ToString();
            lblFormerCement.Text = reader["Cement"].ToString();
            lblDispMoney.Text = reader["C_Money"].ToString();
            lblPastMoney.Text = lblDispMoney.Text;
            txtMetalTon.Text = reader["Metal_Ton_Price"].ToString();
            txtCementTon.Text = reader["Cement_Ton_Price"].ToString();
            if (string.IsNullOrEmpty(lblFormerMetal.Text)) lblFormerMetal.Text = "0";
            if (string.IsNullOrEmpty(lblFormerCement.Text)) lblFormerCement.Text = "0";
            if (double.Parse(lblFormerMetal.Text) <= 0) lblFormerMetal.ForeColor = Color.Red;
            if (double.Parse(lblFormerCement.Text) <= 0) lblFormerCement.ForeColor = Color.Red;
            command.Dispose();
            reader.Dispose();
            connection.Close();
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
                double paid = 0; if (!string.IsNullOrWhiteSpace(txtPayMoney.Text)) paid = double.Parse(txtPayMoney.Text);
                double pays = paid + double.Parse(lblPastMoney.Text);
                double money = pays - total;
                if (money < 0)
                {
                    lblisDepted.Text = "عليه";
                    lblisDepted.ForeColor = Color.Red;
                    lblRemainMoney.ForeColor = Color.Red;
                }
                else
                {
                    lblisDepted.Text = "باقي له";
                    lblisDepted.ForeColor = Color.Black;
                    lblRemainMoney.ForeColor = Color.Black;
                }
                lblRemainMoney.Text = money.ToString();
            }
            catch { }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(lblFormerMetal.Text) < double.Parse(txtMetal.Text)) ||
                     double.Parse(lblFormerCement.Text) < double.Parse(txtCement.Text))
                {
                    DialogResult newHagz =
                        MessageBox.Show("لايكفي حجز هذا العميل هل تود عمل حجز جديد ؟ ", "خطأ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (newHagz == DialogResult.Yes)
                    {
                        frmHagz formHagz = new frmHagz(_clientId, _clientName);
                        formHagz.ShowDialog();
                        FrmSahb_Load(sender, e);
                    }

                    return;
                }
                string metal = txtMetal.Text;
                string metalTon = txtMetalTon.Text;
                string cement = txtCement.Text;
                string cementTon = txtCement.Text;
                //هنا بسحب يبقى اخصم من الفلوس
                //الفلوس الي دفعها + الي معاه - السعر 
                //ولو عليه ديون الي معاه هيبقى سالب
                string c_money = lblRemainMoney.Text;
                string paidMoney = txtPayMoney.Text;
                string notes = txtNotes.Text;
                string totalOp = (double.Parse(lblMetalTotal.Text) + double.Parse(lblCementTotal.Text)).ToString();

                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "UPDATE Client SET " +
                               "Metal  =  Metal - @metal," +
                               "Taken_Metal = Taken_Metal+@metal," +
                               "Cement = Cement - @cement," +
                               "Taken_Cement= Taken_Cement+@cement," +
                               "C_Money  =  @c_money," +//pastmoney+pay - total , lblremain
                               "All_Money = All_Money + @paidnow " +
                               "WHERE Client_ID = @client_id;";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@metal", metal);
                command.Parameters.AddWithValue("@cement", cement);
                command.Parameters.AddWithValue("@c_money", c_money);
                command.Parameters.AddWithValue("@paidnow", paidMoney);
                command.Parameters.AddWithValue("@client_id", _clientId);
                command.ExecuteNonQuery();
                command.Dispose();
                string queryOperation = "INSERT INTO Operation([Client_ID],[Client_Name],[OP_Type],[OP_Date],[Metal]," +
                                        "[Metal_Ton_Price],[Cement],[Cement_Ton_Price],[Total],[PMoney],[Notes]) VALUES (" +
                                        "@client_id,@client_name,@op_type,@op_date,@metal,@metal_ton," +
                                        "@cement,@cement_ton,@total,@paidnow,@notes);";
                OleDbCommand commandOperation = new OleDbCommand(queryOperation, connection);
                commandOperation.Parameters.AddWithValue("@client_id", _clientId);
                commandOperation.Parameters.AddWithValue("@client_name", _clientName);
                commandOperation.Parameters.AddWithValue("@op_type", "سحب");
                commandOperation.Parameters.AddWithValue("@op_date", DateTime.Today.ToString("d"));
                commandOperation.Parameters.AddWithValue("@metal", metal);
                commandOperation.Parameters.AddWithValue("@metal_ton", metalTon);
                commandOperation.Parameters.AddWithValue("@cement", cement);
                commandOperation.Parameters.AddWithValue("@cement_ton", cementTon);
                commandOperation.Parameters.AddWithValue("@total", totalOp);
                commandOperation.Parameters.AddWithValue("@paidnow", paidMoney);
                commandOperation.Parameters.AddWithValue("@notes", notes);

                commandOperation.ExecuteNonQuery();
                connection.Close();
                //our revenue is increased
                TotalsHandler.Add("0","0",paidMoney);
                //our hagz in decreased
                TotalsHandler.Remove(metal,cement,"0");

                string report = " :: العميل :: " + _clientName + " :: قام بسحب :: "
                                + " :: سحب الحديد :: " + metal + " :: سعر الطن :: " + metalTon + " :: سعر الإسمنت :: " + cement
                                + " :: سعر الطن :: " + cementTon + " :: دفع :: " + c_money + " :: ملاحظات :: " + notes;
                ReportsHandler.Write(
                    report,
                    _clientId,
                    _clientName);

                MessageBox.Show("تم السحب", "سحب", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message.ToString(), "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message.ToString());
            }
        }
    }
}
