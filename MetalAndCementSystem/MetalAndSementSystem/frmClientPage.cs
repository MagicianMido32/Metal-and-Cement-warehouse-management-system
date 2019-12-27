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
    public partial class frmClientPage : Form
    {
        private string _clientId;

        public frmClientPage(string clientId)
        {
            InitializeComponent();
            _clientId = clientId;
        }
        private void FrmClientPage_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            try
            {
                dataGridOprerations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dataGridOprerations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridOprerations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "Select * from Client where Client_ID = @client_id;";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@client_id", _clientId);
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                _clientId = reader["Client_ID"].ToString();
                txtName.Text = reader["Client_Name"].ToString();
                txtCountry.Text = reader["Client_Country"].ToString();
                txtDateAdded.Text = reader["Date_Added"].ToString();
                txtMetal.Text = reader["Metal"].ToString();
                txtMetalTon.Text = reader["Metal_Ton_Price"].ToString();
                txtTakenMetal.Text = reader["Taken_Metal"].ToString();
                txtCement.Text = reader["Cement"].ToString();
                txtCementTon.Text = reader["Cement_Ton_Price"].ToString();
                txtTakenCement.Text = reader["Taken_Cement"].ToString();

                txtMoney.Text = reader["C_Money"].ToString();

                txtAllMoney.Text = reader["All_Money"].ToString();
                txtNotes.Text = reader["Notes"].ToString();
                command.Dispose();
                if (txtMoney.Text.Contains("-"))
                {
                    txtMoney.ForeColor = Color.Red;
                    lblMoney.Text = "فلوس العميل الحالية - مديون";
                }
                else
                {
                    txtMoney.ForeColor = Color.Black;
                    lblMoney.Text = "فلوس العميل الحالية";
                }
                string queryFillGridView = "SELECT * FROM Operation Where Client_ID = @client_id";
                OleDbDataAdapter adapterFillGridView = new OleDbDataAdapter(queryFillGridView, connection);
                adapterFillGridView.SelectCommand.Parameters.AddWithValue("@client_id", _clientId);
                DataTable table = new DataTable();
                adapterFillGridView.Fill(table);
                dataGridOprerations.AutoGenerateColumns = false;
                dataGridOprerations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridOprerations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridOprerations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                dataGridOprerations.DataSource = table;
                dataGridOprerations.Update();
                dataGridOprerations.Refresh();
                adapterFillGridView.Dispose();

                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message.ToString(), "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message.ToString());

            }
        }
        private void ButtonHagz_Click(object sender, EventArgs e)
        {
            frmHagz formHagz = new frmHagz(_clientId, txtName.Text);
            formHagz.ShowDialog();
            FillData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void ButtonSahb_Click(object sender, EventArgs e)
        {
            frmSahb formSahb = new frmSahb(_clientId, txtName.Text);
            formSahb.ShowDialog();
            FillData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string country = txtCountry.Text;
                string dateAdded = txtDateAdded.Text;
                string metal = txtMetal.Text;
                string metalton = txtMetalTon.Text;
                string takenmetal = txtTakenMetal.Text;
                string cement = txtCement.Text;
                string cementton = txtCementTon.Text;
                string takencement = txtTakenCement.Text;
                string money = txtMoney.Text;
                string allmoney = txtAllMoney.Text;
                string notes = txtNotes.Text;
                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "UPDATE Client SET " +
                               "Client_Name     = @name," +
                               "Client_Country  = @country," +
                               "Date_Added      = @dateAdded," +
                               "Metal           = @metal," +
                               "Metal_Ton_Price = @metalton," +
                               "Taken_Metal     = @takenmetal," +
                               "Cement          = @cement," +
                               "Cement_Ton_Price= @cementton," +
                               "Taken_Cement    = @takencement," +
                               "C_Money         = @money," +
                               "All_Money       = @allmoney," +
                               "Notes           = @notes " +
                               "WHERE Client_ID = @client_id;";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@dateAdded", dateAdded);
                command.Parameters.AddWithValue("@metal", metal);
                command.Parameters.AddWithValue("@metalton", metalton);
                command.Parameters.AddWithValue("@takenmetal", takenmetal);
                command.Parameters.AddWithValue("@cement", cement);
                command.Parameters.AddWithValue("@cementton", cementton);
                command.Parameters.AddWithValue("@takencement", takencement);
                command.Parameters.AddWithValue("@money", money);
                command.Parameters.AddWithValue("@allmoney", allmoney);
                command.Parameters.AddWithValue("@notes", notes);
                command.Parameters.AddWithValue("@client_id", _clientId);


                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                ReportsHandler.Write(":: تم التعديل على العميل ::" + txtName.Text);
                MessageBox.Show("تم حفظ التعديلات", "التعديل على العميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message.ToString(), "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message.ToString());
            }
        }

        private void BtnDelClient_Click(object sender, EventArgs e)
        {

            RemoveHandler.removeClient(_clientId, this, true);
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                string opid = "";
                string opdate = "";
                string optype = "";
                string metal = "";
                string cement = "";
                string opPaidMoney = "";
                string opTotalMoney = "";
                try
                {
                    opid = dataGridOprerations.SelectedCells[0].OwningRow.Cells["clmOpId"].Value.ToString();
                    optype = dataGridOprerations.SelectedCells[0].OwningRow.Cells["clmOpType"].Value.ToString();
                    metal = dataGridOprerations.SelectedCells[0].OwningRow.Cells["clmMetal"].Value.ToString();
                    cement = dataGridOprerations.SelectedCells[0].OwningRow.Cells["clmCement"].Value.ToString();
                    opPaidMoney = dataGridOprerations.SelectedCells[0].OwningRow.Cells["clmMoney"].Value.ToString();
                    opTotalMoney = dataGridOprerations.SelectedCells[0].OwningRow.Cells["clmTotal"].Value.ToString();
                }
                catch
                {
                    opid = dataGridOprerations.SelectedRows[0].Cells["clmOpId"].Value.ToString();
                    optype = dataGridOprerations.SelectedRows[0].Cells["clmOpType"].Value.ToString();
                    metal = dataGridOprerations.SelectedRows[0].Cells["clmMetal"].Value.ToString();
                    cement = dataGridOprerations.SelectedRows[0].Cells["clmCement"].Value.ToString();
                    opPaidMoney = dataGridOprerations.SelectedRows[0].Cells["clmMoney"].Value.ToString();
                    opTotalMoney = dataGridOprerations.SelectedRows[0].Cells["clmTotal"].Value.ToString();
                }
                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                if (optype == "حجز")
                {

                    ///لو العملية حجز اسحب
                    string query = "UPDATE Client SET " +
                                   "Metal  = Metal  - @metal," +
                                   "Cement = Cement - @cement," +
                                   "C_Money   = C_Money   - @opmoney," +
                                   //هحذف الفلوس الي دفعها في العملية
                                   //علشان الحجز = الفلوس الي معاه + الفلوس الي دفعها
                                   "All_Money = All_Money - @opmoney " +
                                   "WHERE Client_ID = @client_id;";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@metal", metal);
                    command.Parameters.AddWithValue("@cement", cement);
                    command.Parameters.AddWithValue("@opmoney", opPaidMoney);
                    command.Parameters.AddWithValue("@client_id", _clientId);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    TotalsHandler.Remove(metal, cement, opPaidMoney);
                }
                else
                {//لو سحب احجز
                    string finalMoney = (double.Parse(opTotalMoney) - double.Parse(opPaidMoney)).ToString();
                    string query = "UPDATE Client SET " +
                                   "Metal  =  Metal + @metal," +
                                   "Taken_Metal = Taken_Metal- @metal," +
                                   "Cement = Cement + @cement," +
                                   "Taken_Cement= Taken_Cement-@cement," +
                                   //وانا بسحب , ضفت الفلوس الي هو دفعها + الفلوس الي قبل كدا - التوتال 
                                   //عشان ارجعه هشيل الفلوس الي هو دفعها واحطله التوتال تاني علشان كنت خصمته
                                   "C_Money   = C_Money   + @finalMoney," +
                                   "All_Money = All_Money - @paidMoney " +
                                   "WHERE Client_ID = @client_id;";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@metal", metal);
                    command.Parameters.AddWithValue("@cement", cement);
                    command.Parameters.AddWithValue("@finalMoney", finalMoney);
                    command.Parameters.AddWithValue("@paidMoney", opPaidMoney);
                    command.Parameters.AddWithValue("@client_id", _clientId);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    TotalsHandler.Add(metal, cement, "0");
                    TotalsHandler.Remove("0", "0", opPaidMoney);
                }

                string deleteQuery = "DELETE FROM Operation WHERE OP_ID=@opid;";
                OleDbCommand deleteOpCommand = new OleDbCommand(deleteQuery, connection);
                deleteOpCommand.Parameters.AddWithValue("@opid", opid);
                deleteOpCommand.ExecuteNonQuery();
                deleteOpCommand.Dispose();
                connection.Close();
                FillData();
                string report = " :: قام العميل :: " + txtName.Text +
                                " :: بالتراجع عن العملية من نوع :: " + optype +
                                " :: حجز الحديد المستعاد :: " + metal +
                                " :: حجز الإسمنت المستعاد :: " + cement +
                                " :: النقود المستعادة :: " + opPaidMoney;
                ReportsHandler.Write(report, _clientId, txtName.Text);
                MessageBox.Show("تم التراجع عن العملية", "التراجع عن العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
