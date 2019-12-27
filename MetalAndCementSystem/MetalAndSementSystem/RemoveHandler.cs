using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetalAndSementSystem
{
    static class RemoveHandler
    {
        public static void removeClient(string _clientId, Form sender, bool closeSender = true)
        {

            DialogResult dialogResult = MessageBox.Show("هل حقا تود حذف هذا العميل",
                "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            string _notedeleted = "";
            new inputDelWhy().showInput(ref _notedeleted);
            try
            {

                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();

                string queryRead = "Select * from Client where Client_ID = @client_id;";
                OleDbCommand commandRead = new OleDbCommand(queryRead, connection);
                commandRead.Parameters.AddWithValue("@client_id", _clientId);
                OleDbDataReader reader = commandRead.ExecuteReader();
                reader.Read();

                string clientname = reader["Client_Name"].ToString();
                string clientcountry = reader["Client_Country"].ToString();
                string dateadded = reader["Date_Added"].ToString();
                string dateremoved = DateTime.Today.ToString("d");
                string metal = reader["Metal"].ToString();
                string metalton = reader["Metal_Ton_Price"].ToString();
                string takenmetal = reader["Taken_Metal"].ToString();
                string cement = reader["Cement"].ToString();
                string cementton = reader["Cement_Ton_Price"].ToString();
                string takencement = reader["Taken_Cement"].ToString();
                string money = reader["C_Money"].ToString();
                string allmoney = reader["All_Money"].ToString();
                string notedeleted = _notedeleted;
                string notes = reader["Notes"].ToString();

                if(!CanDeleteClient(money,metal,cement))return;


                string movingQuery = "INSERT INTO Prev_Client VALUES" +
                                     "(@clientname,@clientcountry,@dateadded,@dateremoved," +
                                     "@metal,@metalton,@takenmetal," +
                                     "@cement,@cementton,@takencement," +
                                     "@money,@allmoney,@notedeleted,@notes);";
                OleDbCommand moveToArchive = new OleDbCommand(movingQuery, connection);
                moveToArchive.Parameters.AddWithValue("@clientname", clientname);
                moveToArchive.Parameters.AddWithValue("@clientcountry", clientcountry);
                moveToArchive.Parameters.AddWithValue("@dateadded", dateadded);
                moveToArchive.Parameters.AddWithValue("@dateremoved", dateremoved);
                moveToArchive.Parameters.AddWithValue("@metal", metal);
                moveToArchive.Parameters.AddWithValue("@metalton", metalton);
                moveToArchive.Parameters.AddWithValue("@takenmetal", takenmetal);
                moveToArchive.Parameters.AddWithValue("@cement", cement);
                moveToArchive.Parameters.AddWithValue("@cementton", cementton);
                moveToArchive.Parameters.AddWithValue("@takencement", takencement);
                moveToArchive.Parameters.AddWithValue("@money", money);
                moveToArchive.Parameters.AddWithValue("@allmoney", allmoney);
                moveToArchive.Parameters.AddWithValue("@notedeleted", notedeleted);
                moveToArchive.Parameters.AddWithValue("@notes", notes);
                moveToArchive.ExecuteNonQuery();
                moveToArchive.Dispose();
                //===========================
                string query = "DELETE FROM Client WHERE Client_ID = @client_id; ";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@client_id", _clientId);
                command.ExecuteNonQuery();
                command.Dispose();
                //=====================
                
                //all his hagz are removed
                TotalsHandler.Remove(metal,cement,money);//حذف حجوزاته

                string report = $"تم حذف العميل {clientname} ملاحظات {notes} ";
                //noClientID
                ReportsHandler.Write(report,"",clientname);
                connection.Close();
                MessageBox.Show("تم حذف العميل", "حذف العميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (closeSender) sender.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message.ToString(), "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message.ToString());
            }
        }

        private static bool CanDeleteClient(string money, string metal, string cement)
        {
            bool pass = false;
            if (double.Parse(money) > 0)
            {
                DialogResult dialogResult1 = MessageBox.Show(
                    "هذا العميل لازال لديه فلوس في النظام , هل لازلت تود حذفه",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult1 == DialogResult.No)
                {
                    return false;
                }
                pass = true;
            }
            else if (double.Parse(money) < 0)
            {
                DialogResult dialogResult1 = MessageBox.Show(
                    "هذا العميل لازال عليه فلوس في النظام , هل لازلت تود حذفه",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult1 == DialogResult.No)
                {
                    return false;
                }
                pass = true;
            }

            if (double.Parse(metal) > 0 && !pass)
            {
                DialogResult dialogResult1 = MessageBox.Show(
                    "هذا العميل لازال لديه حجز حديد في النظام , هل لازلت تود حذفه",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult1 == DialogResult.No)
                {
                    return false;
                }
                pass = true;
            }
            if (double.Parse(cement) > 0 && !pass)
            {
                DialogResult dialogResult1 = MessageBox.Show(
                    "هذا العميل لازال لديه حجز إسمنت  في النظام , هل لازلت تود حذفه",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult1 == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
