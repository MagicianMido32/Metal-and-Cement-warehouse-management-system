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
    public partial class frmHagz : Form
    {
        private string _clientId;
        private string _clientName;
        public frmHagz(string clinetid, string clientname)
        {
            _clientId = clinetid;
            _clientName = clientname;
            InitializeComponent();

        }

        private void FrmHagz_Load(object sender, EventArgs e)
        {
            txtMetal.Text = "0";
            // txtMetalTon.Text = "0";
            lblMetalTotal.Text = "0";
            txtCement.Text = "0";
            //txtCementTon.Text = "0";
            lblCementTotal.Text = "0";
            txtPayMoney.Text = "0";
            lblRemainMoney.Text = "0";
            lblPastMoney.Text = "0";
            lblRemainMoney.Text = "0";
            lblClientName.Text = _clientName;

            txtMetal.TextChanged += TxtMetalChanged;
            txtMetalTon.TextChanged += TxtMetalChanged;

            txtCement.TextChanged += TxtCementChanged;
            txtCementTon.TextChanged += TxtCementChanged;

            txtPayMoney.TextChanged += TxtTotalChanged;

            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "SELECT C_Money,Metal_Ton_Price,Cement_Ton_Price " +
                           "FROM Client where Client_ID = @client_id";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@client_id", _clientId);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            lblPastMoney.Text = reader["C_Money"].ToString();
            txtMetalTon.Text = reader["Metal_Ton_Price"].ToString();
            txtCementTon.Text = reader["Cement_Ton_Price"].ToString();
            command.Dispose();
            reader.Dispose();
            connection.Close();

            if (lblPastMoney.Text.Contains("-"))
            {
                lblPastMoney.ForeColor = Color.Red;
                lblDeptation.ForeColor = Color.Red;
                lblDeptation.Text = "+ عليه من العمليه +";
            }
            else
            {
                lblPastMoney.ForeColor = Color.Black;
                lblDeptation.ForeColor = Color.Black;
                lblDeptation.Text = "+ له من العملية +";
            }
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
                string metal = txtMetal.Text;
                string metalTon = txtMetalTon.Text;
                string cement = txtCement.Text;
                string cementTon = txtCement.Text;
              //  string c_money = lblRemainMoney.Text;
     
                string paidMoney = txtPayMoney.Text;
                string notes = txtNotes.Text;
                string totalOp = (double.Parse(lblMetalTotal.Text) + double.Parse(lblCementTotal.Text)).ToString();

                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "UPDATE Client SET " +
                               "Metal  = Metal  + @metal," +
                               "Cement = Cement + @cement," +
                               "[C_Money]  = [C_Money]+ @paidnow," +
                               //الفلوس الي معاه +الفلوس الي دفعها
                               //عند الحجز مش هخصم فلوس لأن السعر ممكن يتغير عند السحب
                               //احسب بس الفلوس الي دفعها واخصم منها لما ييجي يسحب
                               "All_Money = All_Money + @paidnow " +
                               "WHERE Client_ID = @client_id;";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@metal", metal);
                command.Parameters.AddWithValue("@cement", cement);
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
                commandOperation.Parameters.AddWithValue("@op_type", "حجز");
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
                //our metal cement and money increased
                TotalsHandler.Add(metal, cement, paidMoney);
                string report = " :: العميل :: " + _clientName + " :: قام بحجز :: "
                                + " :: حجز الحديد :: " + metal + " :: سعر الطن :: " + metalTon +
                                " :: حجز الإسمنت :: " + cement
                                + " :: سعر الطن :: " + cementTon + " :: دفع :: " + paidMoney + " :: ملاحظات :: " + notes;
                ReportsHandler.Write(report,
                    _clientId,
                    _clientName);
                MessageBox.Show("تم الحجز", "حجز", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
