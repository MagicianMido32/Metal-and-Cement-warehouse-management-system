using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetalAndSementSystem
{
    static class TotalsHandler
    {
        private static string _metal;
        private static string _cement;
        private static string _revenue;

        public static void Add(string metal, string cememnt, string money)
        {
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "UPDATE Total SET " +
                           "Total_Metal=Total_Metal+@metal," +
                           "Total_Cement=Total_Cement+@cement," +
                           "Revenue=Revenue+@money;";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@metal", metal);
            command.Parameters.AddWithValue("@cement", cememnt);
            command.Parameters.AddWithValue("@money", money);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            string report = ":: دخل للنظام ::" + _revenue + " جنيه :: " + ":: حجز حديد ::" + metal + " طن :: " +
                            ":: حجز اسمنت ::" + cememnt + " طن :: ";
            ReportsHandler.Write(report);
        }

        public static void change(string metal, string cememnt, string money)
        {
            DialogResult dialogResult = MessageBox.Show("أنت على وشك ان تقوم بالتعديل يدويا في حسابات النظام , سوف يؤدي ذلك الى تخريب الحسابات , قم بذلك على ضمانتك",
                "التعديل يدويا في حسابات النظام", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)

            {
                return;
            }

            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "UPDATE Total SET " +
                           "Total_Metal=@metal," +
                           "Total_Cement=@cement," +
                           "Revenue=@money;";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@metal", metal);
            command.Parameters.AddWithValue("@cement", cememnt);
            command.Parameters.AddWithValue("@money", money);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            string report = ":: تم التغيير يدويا في النظام ::" + _revenue + " جنيه :: " + "::  حديد ::" + metal + " طن :: " +
                            "::  اسمنت ::" + cememnt + " طن :: ";
            ReportsHandler.Write(report);
        }
        public static void Remove(string metal, string cememnt, string money)
        {
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "UPDATE Total SET " +
                           "Total_Metal=Total_Metal - @metal," +
                           "Total_Cement=Total_Cement - @cement," +
                           "Revenue=Revenue - @money;";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@metal", metal);
            command.Parameters.AddWithValue("@cement", cememnt);
            command.Parameters.AddWithValue("@money", money);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            string report = ":: تم سحب من النظام ::" + _revenue + " جنيه :: " + ":: سحب حديد ::" + metal + " طن :: " +
                            ":: سحب اسمنت ::" + cememnt + " طن :: ";
            ReportsHandler.Write(report);
        }

        public static void loadData()
        {
            try
            {
                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "Select * from Total;";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                _metal = reader["Total_Metal"].ToString();
                _cement = reader["Total_Cement"].ToString();
                _revenue = reader["Revenue"].ToString();
                command.Dispose();
                connection.Close();
            }
            catch
            {
                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "INSERT INTO Total VALUES(0,0,0);";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                loadData();
            }
           
        }
        public static string getMetal()
        {
            return _metal;
        }
        public static string getCement()
        {
            return _cement;
        }
        public static string getRevenue()
        {
            return _revenue;
        }
    }
}
