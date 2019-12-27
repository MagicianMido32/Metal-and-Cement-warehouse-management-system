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
    public partial class frmPrevClients : Form
    {
        public frmPrevClients()
        {
            InitializeComponent();
        }

        private void FrmPrevClients_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            dataGridPrevClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridPrevClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridPrevClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "Select * from Prev_Client ;";
            OleDbDataAdapter adapterFillGridView = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            dataGridPrevClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridPrevClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridPrevClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            adapterFillGridView.Fill(table);
            dataGridPrevClients.AutoGenerateColumns = false;
            dataGridPrevClients.DataSource = table;
            dataGridPrevClients.Update();
            dataGridPrevClients.Refresh();
            adapterFillGridView.Dispose();
            connection.Close();
        }

        private void BtnDelAll_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل حقا تود حذف كافة العملاءالسابقين تماما",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No) return;

                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "DELETE from Prev_Client ;";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                displayData();
                ReportsHandler.Write(" :: تم حذف كافة العملاء السابقين :: ");
                MessageBox.Show("تم حذف العملاء", "حذف العملاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message.ToString(), "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message.ToString());
                throw exception;
            }
        }

        private void BtnFullDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل حقا تود حذف هذا العميل تماما",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No) return;
                string selectedCellClientName = "";
                try
                {
                    selectedCellClientName = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmName"].Value.ToString();
                }
                catch
                {
                    selectedCellClientName = dataGridPrevClients.SelectedRows[0].Cells["clmName"].Value.ToString();
                }
                deleteClient(selectedCellClientName);
                ReportsHandler.Write(
                    " :: تم حذف العميل :: " +
                    selectedCellClientName +
                    " :: للأبد :: "
                    , "", selectedCellClientName);
                MessageBox.Show("تم حذف العميل", "حذف العميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
        }

        private void deleteClient(string selectedCellClientName)
        {

            try
            {


                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "DELETE from Prev_Client WHERE Client_Name = @clientname;";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@clientname", selectedCellClientName);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                displayData();


            }
            catch (Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message.ToString(), "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message.ToString());
            }
        }
        private void BtnRecover_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل حقا تود استعادة هذا العميل ",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No) return;
                string clientName = "";
                string clientCountry = "";
                string dateAdded = "";
                string metal = "";
                string metalton = "";
                string takenMetal = "";
                string cement = "";
                string cementton = "";
                string takenCement = "";
                string money = "";
                string allmoney = "";
                string notes = "";
                try
                {
                    clientName = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmName"].Value.ToString();
                    clientCountry = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmCountry"].Value.ToString();
                    dateAdded = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmDateAdded"].Value.ToString();
                    metal = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmMetal"].Value.ToString();
                    metalton = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmMetalTon"].Value.ToString();
                    takenMetal = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmTakenMetal"].Value.ToString();
                    cement = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmCement"].Value.ToString();
                    cementton = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmCementTon"].Value.ToString();
                    takenCement = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmTakenCement"].Value.ToString();
                    money = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmMoney"].Value.ToString();
                    allmoney = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["clmAllMoney"].Value.ToString();
                    notes = dataGridPrevClients.SelectedCells[0].OwningRow.Cells["Notes"].Value.ToString();
                }
                catch
                {
                    clientName = dataGridPrevClients.SelectedRows[0].Cells["clmName"].Value.ToString();
                    clientCountry = dataGridPrevClients.SelectedRows[0].Cells["clmCountry"].Value.ToString();
                    dateAdded = dataGridPrevClients.SelectedRows[0].Cells["clmDateAdded"].Value.ToString();
                    metal = dataGridPrevClients.SelectedRows[0].Cells["clmMetal"].Value.ToString();
                    metalton = dataGridPrevClients.SelectedRows[0].Cells["clmMetalTon"].Value.ToString();
                    takenMetal = dataGridPrevClients.SelectedRows[0].Cells["clmTakenMetal"].Value.ToString();
                    cement = dataGridPrevClients.SelectedRows[0].Cells["clmCement"].Value.ToString();
                    cementton = dataGridPrevClients.SelectedRows[0].Cells["clmCementTon"].Value.ToString();
                    takenCement = dataGridPrevClients.SelectedRows[0].Cells["clmTakenCement"].Value.ToString();
                    money = dataGridPrevClients.SelectedRows[0].Cells["clmMoney"].Value.ToString();
                    allmoney = dataGridPrevClients.SelectedRows[0].Cells["clmAllMoney"].Value.ToString();
                    notes = dataGridPrevClients.SelectedRows[0].Cells["Notes"].Value.ToString();
                }

                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "INSERT INTO Client(Client_Name,Client_Country,Date_Added,Metal," +
                               "Metal_Ton_Price,Taken_Metal,Cement,Cement_Ton_Price,Taken_Cement,C_Money,All_Money,Notes)" +
                               "VALUES(@clientName,@clientCountrey,@DateAdded,@metal,@metalTon,@takenMetal,@Cement,@cementTon,@takenCement,@money,@allmoney,@Notes);";

                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@clientName", clientName);
                cmd.Parameters.AddWithValue("@clientCountrey", clientCountry);
                cmd.Parameters.AddWithValue("@DateAdded", dateAdded);
                cmd.Parameters.AddWithValue("@metal", metal);
                cmd.Parameters.AddWithValue("@metalTon", metalton);
                cmd.Parameters.AddWithValue("@takenMetal", takenMetal);
                cmd.Parameters.AddWithValue("@Cement", cement);
                cmd.Parameters.AddWithValue("@cementTon", cementton);
                cmd.Parameters.AddWithValue("@takenCement", takenCement);
                cmd.Parameters.AddWithValue("@money", money);
                cmd.Parameters.AddWithValue("@allmoney", allmoney);
                cmd.Parameters.AddWithValue("@Notes", notes);
                cmd.ExecuteNonQuery();
                connection.Close();
                //all his haz back
                TotalsHandler.Add(metal, cement, money);
                deleteClient(clientName);
                string report = " :: تمت استعادة العميل :: " + clientName +
                                " :: من بلد :: " + clientCountry +
                                " :: تاريخ إضافته :: " + dateAdded;
                ReportsHandler.Write(report, "", clientName);
                MessageBox.Show("تمت استعادة العميل, قم بتحديث البيانات في واجهة" +
                "البرنامج الرئيسية", "إستعادة عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message.ToString(), "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message.ToString());

            }
        }
    }
}
