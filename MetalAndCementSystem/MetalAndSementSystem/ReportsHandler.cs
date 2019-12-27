using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MetalAndSementSystem
{
    static class ReportsHandler
    {
        public static DataTable LoadData()
        {
            DataTable bufferDataTable = new DataTable();
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "SELECT * FROM Reports ;";
            OleDbDataAdapter adapterFillGridView = new OleDbDataAdapter(query, connection);
            adapterFillGridView.Fill(bufferDataTable);
            adapterFillGridView.Dispose();
            connection.Close();
            return bufferDataTable;
        }

        public static void RemoveAllReports()
        {
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "DELETE FROM Reports;";

            OleDbCommand cmd = new OleDbCommand(query, connection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close(); 
        }
        public static void RemoveReport(string reportID)
        {
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "DELETE FROM Reports WHERE [Report_ID] = @reportID;";

            OleDbCommand cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@report", reportID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
        }
        public static void Write(string report, string clientId ="",string clientName="")
        {
            string date = DateTime.Today.ToString("d");
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            string query = "INSERT INTO Reports([Client_ID],[Client_Name],[Date_Added],[Report]) VALUES(" +
                           "@clientid,"+
                           "@clientname,"+
                           "@date," +
                           "@report);";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@clientid", clientId);
            cmd.Parameters.AddWithValue("@clienname", clientName);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@report", report);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
        }
    }
}
