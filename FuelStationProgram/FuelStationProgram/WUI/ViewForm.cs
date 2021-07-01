using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using FuelStationProgram.Impl;
using FuelStationProgram.Properties;
using FuelStationProgram.WUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationProgram
{
    public partial class ViewForm : Form
    {
        public string ConnString { get; set; }
        public SqlConnection Conn { get; set; }
        public DataSet MasterData = new DataSet();
        public DataSet OldMasterData = new DataSet();
        public ViewForm()
        {
            InitializeComponent();
        }

        #region Events

        private void ViewForm_Load(object sender, EventArgs e) {

            gridControlCustomers.Visible = false;
            gridControlEmployees.Visible = false;
            gridControlItems.Visible = false;
            gridControlTransactions.Visible = false;
            btnDelete.Visible = false;
            btnSaveChanges.Visible = false;
        }
        private void crtlExitApplication_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void crtlConnectToDB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlConnect();
        }
        private void crtlLoadFromDB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlLoadTables();
        }
        private void crtlAddNewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (Conn == null) {
                return;
            }
            AddCustomer();
        }
        private void crtlAddNewEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (Conn == null) {
                return;
            }
            AddEmployee();
        }
        private void crtlAddNewItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (Conn == null) {
                return;
            }
            AddItem();
        }
        private void crtlNewTransaction_Click(object sender, EventArgs e)
        {
            if (Conn == null)
            {
                MessageBox.Show("Please start a connection before attemping a new transaction");
                return;
            }
            var testCustomerExistance = CustomerExists(out var customerID);
            if (testCustomerExistance)
            {

                try
                {
                    Transaction transaction = new Transaction();
                    transaction.Date = DateTime.Now;
                    transaction.CustomerID = customerID;
                    
                    TransactionForm form = new TransactionForm();


                    form.Conn = Conn;
                    form.Transaction = transaction;
                    form.ShowDialog();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectTransactions, Conn);
                MasterData.Tables["Transactions"].Clear();
                OldMasterData.Tables["Transactions"].Clear();
                adapter.Fill(MasterData, "Transactions");
                adapter.Fill(OldMasterData, "Transactions");
                MasterData.AcceptChanges();
                gridControl1.Refresh();
            }
            else
            {
                MessageBox.Show("Customer does not exist,or card registration number field is empty");
            }


        }
        private void btnSaveChanges_Click(object sender, EventArgs e) {
            if (!MasterData.HasChanges()) {
                MessageBox.Show("No changes were made.");
                return;
            }
            SaveAdds("Customers");
            SaveAdds("Employees");
            SaveAdds("Items");
            SaveDeletes("Customers");
            SaveDeletes("Employees");
            SaveDeletes("Items");
            SaveDeletes("Transactions");
            SaveChanges("Customers");
            SaveChanges("Employees");
            SaveChanges("Items");
            MasterData.AcceptChanges();
            RefreshTables();

        }
        private void btnDelete_Click(object sender, EventArgs e) {
            DeleteEntity();
        }
        private void gridView4_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) {
            LoadTransactionLinesToGrid();

        }

        



        #endregion

        #region Methods


        private void SqlConnect()
        {
            ConnString = txtSqlPath.EditValue.ToString();
            try
            {
                Conn = new SqlConnection(ConnString);
                Conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SqlLoadTables()
        {
            btnDelete.Visible = true;
            btnSaveChanges.Visible = true;
            BindingSource bindingSourceCustomers = new BindingSource();
            BindingSource bindingSourceEmployees = new BindingSource();
            BindingSource bindingSourceItems = new BindingSource();

            BindingSource bindingSourceTransactions = new BindingSource();

            try {
                SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectCustomers, Conn);
                MasterData.Clear();
                adapter.Fill(MasterData, "Customers");
                adapter.Fill(OldMasterData, "Customers");
                bindingSourceCustomers.DataSource = MasterData.Tables["Customers"];
                gridControlCustomers.DataSource = bindingSourceCustomers;

                adapter = new SqlDataAdapter(Resources.SelectEmployees, Conn);
                adapter.Fill(MasterData, "Employees");
                adapter.Fill(OldMasterData, "Employees");
                bindingSourceEmployees.DataSource = MasterData.Tables["Employees"];
                gridControlEmployees.DataSource = bindingSourceEmployees;

                adapter = new SqlDataAdapter(Resources.SelectItems, Conn);
                adapter.Fill(MasterData, "Items");
                adapter.Fill(OldMasterData, "Items");
                bindingSourceItems.DataSource = MasterData.Tables["Items"];
                gridControlItems.DataSource = bindingSourceItems;

                adapter = new SqlDataAdapter(Resources.SelectTransactions, Conn);
                adapter.Fill(MasterData, "Transactions");
                adapter.Fill(OldMasterData, "Transactions");


                DataColumn newCol = new DataColumn();
                newCol.DataType = typeof(string);

                newCol.AllowDBNull = true;
                newCol.ColumnName = "CustomerName";
                newCol.Caption = "Customer Name";
                MasterData.Tables["Transactions"].Columns.Add(newCol);

                foreach (DataRow row in MasterData.Tables["Transactions"].Rows) {
                    try {
                        string expression = string.Format("ID = '{0}'", row["CustomerID"].ToString());
                        DataRow customerRow = MasterData.Tables["Customers"].Select(expression)[0];
                        row["CustomerName"] = string.Format("{0} {1}", customerRow["Name"], customerRow["Surname"]);
                    }
                    catch (Exception e) {
                        //customer was deleted
                    }
                }


                bindingSourceTransactions.DataSource = MasterData.Tables["Transactions"];
                gridControlTransactions.DataSource = bindingSourceTransactions;



                gridControlCustomers.Refresh();
                gridControlCustomers.Visible = true;
                gridView1.Columns["ID"].Visible = false;
                gridView1.BeginDataUpdate();
                gridView1.ClearSorting();
                gridView1.Columns[2].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView1.EndDataUpdate();

                gridControlEmployees.Refresh();
                gridControlEmployees.Visible = true;
                gridView2.Columns["ID"].Visible = false;
                gridView2.BeginDataUpdate();
                gridView2.ClearSorting();
                gridView2.Columns[2].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView2.EndDataUpdate();

                gridControlItems.Refresh();
                gridControlItems.Visible = true;
                gridView3.Columns["ID"].Visible = false;
                gridView3.BeginDataUpdate();
                gridView3.ClearSorting();
                gridView3.Columns["Description"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView3.EndDataUpdate();

                gridControlTransactions.Refresh();
                gridControlTransactions.Visible = true;
                gridView4.Columns["ID"].Visible = false;
                gridView4.Columns["CustomerID"].Visible = false;
                //gridView4.BeginDataUpdate();
                //gridView4.ClearSorting();
                //gridView4.Columns["Date"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                //gridView4.EndDataUpdate();

                gridControl1.Visible = true;
                gridView6.OptionsView.ShowGroupPanel = false;

                dateEdit1.Visible = true;
                dateEdit2.Visible = true;
                lblEndDate.Visible = true;
                lblStartDate.Visible = true;
                btnCalculate.Visible = true;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
        private void RefreshTables() {
            gridControlCustomers.Refresh();
            gridControlEmployees.Refresh();
            gridControlItems.Refresh();
            gridControlTransactions.Refresh();

            LoadTransactionLinesToGrid();
            gridControl1.Refresh();
        }
        private void AddCustomer() {
            DataEditForm form = new DataEditForm();
            Customer newCustomer = new Customer();
            form.EditObject = newCustomer;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) {
                try {
                    DataRow newRow = MasterData.Tables["Customers"].NewRow();
                    newRow["ID"] = newCustomer.ID;
                    newRow["Name"] = newCustomer.Name;
                    newRow["Surname"] = newCustomer.Surname;
                    newRow["CardNumber"] = newCustomer.CardNumber;

                    MasterData.Tables["Customers"].Rows.Add(newRow);
                    RefreshTables();
                }
                catch (Exception e) {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void AddEmployee() {
            DataEditForm form = new DataEditForm();
            Employee newEmployee = new Employee();
            form.EditObject = newEmployee;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) {
                try {
                    DataRow newRow = MasterData.Tables["Employees"].NewRow();
                    newRow["ID"] = newEmployee.ID;
                    newRow["Name"] = newEmployee.Name;
                    newRow["Surname"] = newEmployee.Surname;
                    newRow["DateStart"] = newEmployee.DateStart.Date;
                    newRow["DateEnd"] = newEmployee.DateEnd.Date;
                    newRow["Salary"] = newEmployee.Salary;

                    MasterData.Tables["Employees"].Rows.Add(newRow);
                    RefreshTables();
                }
                catch (Exception e) {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void AddItem() {
            DataEditForm form = new DataEditForm();
            Items newItem = new Items();
            form.EditObject = newItem;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) {
                try {
                    DataRow newRow = MasterData.Tables["Items"].NewRow();
                    newRow["ID"] = newItem.ID;
                    newRow["Code"] = newItem.Code;
                    newRow["Description"] = newItem.Description;
                    newRow["ItemType"] = newItem.ItemType.ToString();
                    newRow["Price"] = newItem.Price;
                    newRow["Cost"] = newItem.Cost;

                    MasterData.Tables["Items"].Rows.Add(newRow);
                    RefreshTables();
                }
                catch (Exception e) {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private bool CustomerExists(out Guid customerId)
        {
            customerId = Guid.Empty;
            if (crtlCustomerCardNumber.EditValue == null || string.IsNullOrEmpty(crtlCustomerCardNumber.EditValue.ToString()))
            {
                return false;
            }
            string customerCardNumber = crtlCustomerCardNumber.EditValue.ToString();
            
            string querytest = $"SELECT * FROM[dbo].[Customers] WHERE[Customers].CardNumber = {customerCardNumber}";
            SqlDataAdapter adapter = new SqlDataAdapter(querytest, Conn);            
            var customerDataTable = new DataSet();
            
            adapter.Fill(customerDataTable);
            if (customerDataTable.Tables[0].Rows.Count > 0)
            {
                customerId = (Guid)customerDataTable.Tables[0].Rows[0]["ID"];
                return true;
            }
            else
            {
                return false;
            }
                
        }
        private void SaveChanges(string tableName) {
            if (!MasterData.HasChanges()) {
                return;
            }

            List<string> sqlCommands = new List<string>();
            var MasterDataChanges = MasterData.GetChanges();

            string primaryKey = "ID";
            foreach (DataRow row in MasterDataChanges.Tables[tableName].Rows) {
                
                string sql = string.Empty;
                string sqlSet = string.Empty;

                List<string> sqlSetLines = new List<string>();
                List<string> sqlWhereLines = new List<string>();
                try {
                    string selectExpression = string.Format("ID = '{0}'", row[primaryKey].ToString());
                    DataRow rowOld = OldMasterData.Tables[tableName].Select(selectExpression)[0];
                
                foreach (DataColumn column in MasterData.Tables[tableName].Columns) {

                    if (column.ColumnName == primaryKey) {
                        ComposeQueryField(sqlWhereLines, column.ColumnName, row[column.ColumnName]);
                    }
                    else {

                        if (row[column.ColumnName].ToString() != rowOld[column.ColumnName].ToString()) {

                            ComposeQueryField(sqlSetLines, column.ColumnName, row[column.ColumnName]);
                        }
                    }

                }
                }
                catch (Exception e) {
                }

                sqlSet = string.Join(",", sqlSetLines);

                if (sqlSetLines.Count > 0) {
                    sql = "UPDATE " + MasterData.Tables[tableName].TableName + " SET " + sqlSet + " WHERE " + string.Join(",", sqlWhereLines);
                    sqlCommands.Add(sql);
                }

                SqlCommand sqlCmd;
                foreach (string cmdText in sqlCommands) {
                    sqlCmd = new SqlCommand(cmdText, Conn);
                    sqlCmd.ExecuteNonQuery();
                }

                string selectCmd = string.Format("SELECT * From {0}",tableName);
                SqlDataAdapter adapter = new SqlDataAdapter(selectCmd, Conn);
                OldMasterData.Tables[tableName].Clear();
                adapter.Fill(OldMasterData, tableName);
            }
        }
        private void ComposeQueryField(List<string> sqlLine, string columnName, object value) {

            switch (value.GetType().Name) {
                case "Guid":
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, value));
                    break;
                case "String":
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, value));
                    break;

                case "Int32":
                case "Int64":
                    sqlLine.Add(string.Format("{0}={1}", columnName, value));
                    break;

                case "DateTime":
                    string datePart = Convert.ToDateTime(value).ToString("yyyyMMdd");
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, datePart));
                    break;

                case "Decimal":

                    // decimal provider , .

                    string decimalPart = Convert.ToDecimal(value).ToString().Replace(',', '.');

                    sqlLine.Add(string.Format("{0}={1}", columnName, decimalPart));
                    break;
            }



        }
        private void DeleteEntity() {
            string selectedTab = xtraTabPane.SelectedTabPage.Text;
            switch (selectedTab) {
                case "Customers":
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);    
                    break;
                case "Employees":
                    gridView2.DeleteRow(gridView2.FocusedRowHandle);
                    break;
                case "Items":
                    gridView3.DeleteRow(gridView3.FocusedRowHandle);
                    break;
                case "Transactions":
                    gridView4.DeleteRow(gridView4.FocusedRowHandle);
                    break;
                default:
                    break;
            }
            RefreshTables();
        }
        private void SaveDeletes(string tableName) {
                    
            foreach (DataRow row in OldMasterData.Tables[tableName].Rows) {
                
                try {
                    string expression = string.Format("ID = '{0}'", row["ID"]);
                    DataRow deletedRow = MasterData.Tables[tableName].Select(expression)[0];
                }
                catch (Exception ex) {
                    SqlCommand sqlCmd;
                    string cmdText = string.Format("DELETE FROM {0} WHERE ID = '{1}'",tableName,row["ID"]);
                    sqlCmd = new SqlCommand(cmdText, Conn);
                    sqlCmd.ExecuteNonQuery();

                }
            }

            string selectCmd = string.Format("SELECT * From {0}", tableName);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCmd, Conn);
            OldMasterData.Tables[tableName].Clear();
            adapter.Fill(OldMasterData, tableName);

        }
        private void SaveAdds(string tableName) {

            foreach (DataRow row in MasterData.Tables[tableName].Rows) {

                try {
                    string expression = string.Format("ID = '{0}'", row["ID"]);
                    DataRow addedRow = OldMasterData.Tables[tableName].Select(expression)[0];
                }
                catch (Exception ex) {
                    if (ex is DeletedRowInaccessibleException) {
                        continue;
                    }
                    else {
                        SqlCommand cmd;
                        switch (tableName) {
                            case "Customers":
                                cmd = new SqlCommand(Resources.InsertCustomer, Conn);
                                cmd.Parameters.AddWithValue("@ID", row["ID"]);
                                cmd.Parameters.AddWithValue("@Name", row["Name"]);
                                cmd.Parameters.AddWithValue("@Surname", row["Surname"]);
                                cmd.Parameters.AddWithValue("@CardNumber", row["CardNumber"]);
                                cmd.ExecuteNonQuery();
                                break;
                            case "Employees":
                                cmd = new SqlCommand(Resources.InsertEmployee, Conn);
                                cmd.Parameters.AddWithValue("@ID", row["ID"]);
                                cmd.Parameters.AddWithValue("@Name", row["Name"]);
                                cmd.Parameters.AddWithValue("@Surname", row["Surname"]);
                                cmd.Parameters.AddWithValue("@DateStart", row["DateStart"]);
                                cmd.Parameters.AddWithValue("@DateEnd", row["DateEnd"]);
                                cmd.Parameters.AddWithValue("@Salary", row["Salary"]);
                                cmd.ExecuteNonQuery();
                                break;
                            case "Items":
                                cmd = new SqlCommand(Resources.InsertItem, Conn);
                                cmd.Parameters.AddWithValue("@ID", row["ID"]);
                                cmd.Parameters.AddWithValue("@Code", row["Code"]);
                                cmd.Parameters.AddWithValue("@Description", row["Description"]);
                                cmd.Parameters.AddWithValue("@ItemType", row["ItemType"]);
                                cmd.Parameters.AddWithValue("@Price", row["Price"]);
                                cmd.Parameters.AddWithValue("@Cost", row["Cost"]);
                                cmd.ExecuteNonQuery();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            string selectCmd = string.Format("SELECT * From {0}", tableName);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCmd, Conn);
            OldMasterData.Tables[tableName].Clear();
            adapter.Fill(OldMasterData, tableName);


        }
        private void gridTransactionLineLayout() {
            gridView6.Columns["ID"].Visible = false;
            gridView6.Columns["TransactionID"].Visible = false;
            gridView6.Columns["ItemID"].Visible = false;
            gridView6.Columns["Quantity"].Visible = true;
            gridView6.Columns["Value"].Visible = true;
            gridView6.Columns["ItemDescription"].VisibleIndex = 0;
        }
        private void LoadTransactionLinesToGrid() {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from transactionlines", Conn);

            MasterData.Tables["TransactionLines"]?.Clear();
            
            DataColumn newCol = new DataColumn();
            newCol.DataType = typeof(string);
            newCol.AllowDBNull = true;
            newCol.ColumnName = "ItemDescription";
            newCol.Caption = "Items Description";
            try {
                adapter.Fill(MasterData, "TransactionLines");
            }
            catch { }

            if (!MasterData.Tables["TransactionLines"].Columns.Contains("ItemDescription")) {
                MasterData.Tables["TransactionLines"].Columns.Add(newCol);
            }
            
            DataRow transactionRow = gridView4.GetFocusedDataRow();
            try {
                string expression = string.Format("TransactionID = '{0}'", transactionRow["ID"]);
                DataRow[] transactionLines = MasterData.Tables["TransactionLines"].Select(expression);
                DataTable dt = transactionLines.CopyToDataTable();

                foreach (DataRow row in dt.Rows) {
                    expression = string.Format("ID = '{0}'", row["ItemID"].ToString());
                    DataRow itemRow = MasterData.Tables["Items"].Select(expression)[0];
                    row["ItemDescription"] = string.Format("{0}", itemRow["Description"]);
                }

                gridControl1.DataSource = dt;

                gridTransactionLineLayout();
            }
            catch (Exception ex) {

            }

        }
        private void btnCalculate_Click(object sender, EventArgs e) {
            DateTime dateStart = Convert.ToDateTime(dateEdit1.EditValue);
            DateTime dateEnd = Convert.ToDateTime(dateEdit2.EditValue);
            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null || dateStart>dateEnd) {
                MessageBox.Show("Please enter valid dates.");
                return;
            }

            List<Employee> employees = new List<Employee>();
            List<Transaction> transactions = new List<Transaction>();
            List<Items> items = new List<Items>();
            List<TransactionLine> transactionLines = new List<TransactionLine>();

            foreach (DataRow dr in OldMasterData.Tables["Employees"].Rows) {
                employees.Add(DatarowToObject.ToObject<Employee>(dr));
            }
            foreach (DataRow dr in OldMasterData.Tables["Transactions"].Rows) {
                transactions.Add(DatarowToObject.ToObject<Transaction>(dr));
            }
            foreach (DataRow dr in OldMasterData.Tables["Items"].Rows) {
                items.Add(DatarowToObject.ToObject<Items>(dr));
            }

            SqlDataAdapter adapter = new SqlDataAdapter("Select * From TransactionLines", Conn);
            OldMasterData.Tables["TransactionLines"]?.Clear();
            adapter.Fill(OldMasterData, "TransactionLines");
            foreach (DataRow dr in OldMasterData.Tables["TransactionLines"].Rows) {
                transactionLines.Add(DatarowToObject.ToObject<TransactionLine>(dr));
            }

            Ledger ledger = new Ledger();
            ledger.DateFrom = dateStart;
            ledger.DateTo = dateEnd;
            ledger.Calculate(transactions, employees, items, transactionLines);

            lblIncome.Visible = true;
            lblIncomeValue.Visible = true;
            lblIncomeValue.Text = ledger.Income.ToString("#.##");
            lblExpenses.Visible = true;
            lblExpensesValue.Visible = true;
            lblExpensesValue.Text = ledger.Expenses.ToString("#.##");
            lblTotal.Visible = true;
            lblTotalValue.Visible = true;
            lblTotalValue.Text = ledger.Total.ToString("#.##");
        }

    }


    #endregion
}
