using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace MetalAndSementSystem
{
    public partial class frmMain : Form
    {
        private DataTable _tableAll;
        private DataTable _tableReports;
        private bool _quickSearch;
        private bool _autoUpdate;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
            InitializeTable();
            if (File.Exists("\\vetdb.laccdb")) File.Delete("\\vetdb.laccdb");
            _autoUpdate = true;
            _quickSearch = true;
        }

        private void InitializeTable()
        {
            try
            {
                _tableAll = new DataTable();
                txtClientSearch.Text = "";
                string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBsm.accdb";
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                string query = "SELECT Client_ID,Client_Name,Client_Country,Date_Added,Metal,Cement,C_Money,Notes FROM Client ;";
                OleDbDataAdapter adapterFillGridView = new OleDbDataAdapter(query, connection);
                adapterFillGridView.Fill(_tableAll);
                adapterFillGridView.Dispose();
                connection.Close();
                _tableReports = ReportsHandler.LoadData();
                dataGridViewReports.AutoGenerateColumns = false;
                dataGridViewReports.DataSource = _tableReports;
                dataGridViewReports.Update();
                dataGridViewReports.Refresh();
                DisplayAll();
            }
            catch (Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message.ToString(), "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message.ToString());
            }
        }
        private void DisplayAll()
        {

            TotalsHandler.loadData();
            lblMetalAllSystem.Text = TotalsHandler.getMetal() + " طن ";
            lblCementAllSystem.Text = TotalsHandler.getCement() + " طن ";
            lblRevenue.Text = TotalsHandler.getRevenue() + " جنيه ";

            txtClientSearch.Text = "";
            DataGridClients.AutoGenerateColumns = false;
            DataGridClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DataGridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridClients.DataSource = _tableAll;
            DataGridClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridClients.Update();
            DataGridClients.Refresh();
        }

        private void Search()
        {
            try
            {
                string name = txtClientSearch.Text;
                if (name == "")
                {
                    DisplayAll();
                    return;
                }
                DataGridClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                DataGridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                DataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                DataTable table = new DataTable();
                if (_tableAll.Select("Client_Name LIKE '%" + name + "%' OR Client_Country LIKE '%" + name + "%'").Any())
                {
                    table = _tableAll.Select("Client_Name LIKE '%" + name + "%' OR Client_Country LIKE '%" + name + "%'")
                        .CopyToDataTable();
                }
                DataGridClients.AutoGenerateColumns = false;
                DataGridClients.DataSource = table;
                DataGridClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DataGridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                DataGridClients.Update();
                DataGridClients.Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show("حدث خطا من نوع :" + exception.Message.ToString(), "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                File.AppendAllText("ErrorReport.txt", exception.Message.ToString());
            }
        }
        private void TxtClientSearch_TextChanged(object sender, EventArgs e)
        {
            if (_quickSearch) Search();
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            new frmAddClient().ShowDialog();
            if (_autoUpdate) InitializeTable();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            InitializeTable();
            btnRefresh.Enabled = true;
        }

        private void BtnOpenClient_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCellClientId = "";
                try
                {
                    selectedCellClientId =
                        DataGridClients.SelectedCells[0].OwningRow.Cells["clmClientID"].Value.ToString();

                }
                catch
                {
                    selectedCellClientId = DataGridClients.SelectedRows[0].Cells["clmClientID"].Value.ToString();

                }

                frmClientPage frmClientPage = new frmClientPage(selectedCellClientId);
                frmClientPage.ShowDialog();
                if (_autoUpdate) InitializeTable();
            }
            catch { MessageBox.Show("خطأ"); }
        }

        private void ButtonSahbQuick_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCellClientId = "";
                string selectedCellClientName = "";
                try
                {
                    selectedCellClientId =
                        DataGridClients.SelectedCells[0].OwningRow.Cells["clmClientID"].Value.ToString();
                    selectedCellClientName =
                        DataGridClients.SelectedCells[0].OwningRow.Cells["clmName"].Value.ToString();

                }
                catch
                {
                    selectedCellClientId = DataGridClients.SelectedRows[0].Cells["clmClientID"].Value.ToString();
                    selectedCellClientName = DataGridClients.SelectedRows[0].Cells["clmName"].Value.ToString();

                }

                frmSahb formSahb = new frmSahb(selectedCellClientId, selectedCellClientName);
                formSahb.ShowDialog();
                if (_autoUpdate) InitializeTable();
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
        }

        private void ButtonHagzQuick_Click(object sender, EventArgs e)
        {
            try
            {//Coded By Mohammed AlSayed, MagicianMiDo32
                string selectedCellClientId = "";
                string selectedCellClientName = "";
                try
                {
                    selectedCellClientId = DataGridClients.SelectedCells[0].OwningRow.Cells["clmClientID"].Value.ToString();
                    selectedCellClientName = DataGridClients.SelectedCells[0].OwningRow.Cells["clmName"].Value.ToString();

                }
                catch
                {
                    selectedCellClientId = DataGridClients.SelectedRows[0].Cells["clmClientID"].Value.ToString();
                    selectedCellClientName = DataGridClients.SelectedRows[0].Cells["clmName"].Value.ToString();

                }
                frmHagz formHagz = new frmHagz(selectedCellClientId, selectedCellClientName);
                formHagz.ShowDialog();

                if (_autoUpdate) InitializeTable();
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
        }
        private void BtnDelClient_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCellClientId = "";
                try
                {
                    selectedCellClientId = DataGridClients.SelectedCells[0].OwningRow.Cells["clmClientID"].Value.ToString();
                }
                catch
                {
                    selectedCellClientId = DataGridClients.SelectedRows[0].Cells["clmClientID"].Value.ToString();

                }

                RemoveHandler.removeClient(selectedCellClientId, null, false);
                if (_autoUpdate) InitializeTable();
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            frmPrevClients prevClients = new frmPrevClients();
            prevClients.ShowDialog();
            if (_autoUpdate) InitializeTable();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void ChkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            _autoUpdate = chkAutoUpdate.Checked;
        }

        private void ChkQuickSearch_CheckedChanged(object sender, EventArgs e)
        {
            _quickSearch = chkQuickSearch.Checked;
        }

        private void BtnOpenReport_Click(object sender, EventArgs e)
        {
            try
            {
                string client_Id = "";
                try
                {
                    client_Id = dataGridViewReports.SelectedCells[0].OwningRow.Cells["clmClientIDreports"].Value.ToString();

                }
                catch
                {
                    client_Id = dataGridViewReports.SelectedRows[0].Cells["clmClientIDreports"].Value.ToString();

                }

                frmClientPage frmClientPage = new frmClientPage(client_Id);
                frmClientPage.ShowDialog();
                if (_autoUpdate) InitializeTable();
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
        }

        private void BtnRemoveReport_Click(object sender, EventArgs e)
        {
            try
            {
                string reportId = "";
                try
                {
                    reportId = dataGridViewReports.SelectedCells[0].OwningRow.Cells["Report_ID"].Value.ToString();

                }
                catch
                {
                    reportId = dataGridViewReports.SelectedRows[0].Cells["Report_ID"].Value.ToString();

                }
                ReportsHandler.RemoveReport(reportId);
                
                if (_autoUpdate) InitializeTable();
                MessageBox.Show("تم حذف التقرير", "حذف التقرير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
        }

        private void BtnDeleteAllReports_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل حقا تود حذف كل التقارير",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No) return;

                ReportsHandler.RemoveAllReports();
                
                if (_autoUpdate) InitializeTable();
                MessageBox.Show("تم حذف كافة التقارير", "حذف التقارير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
        }

        private void BtnRefreshReports_Click(object sender, EventArgs e)
        {
            BtnRefresh_Click(sender, e);
        }

        private void LnklblChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmTotals().ShowDialog();
            if (_autoUpdate) InitializeTable();
        }
    }
}
