using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using FuelStationProgram.Impl;
using FuelStationProgram.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
            if (true) {
                AddCustomer();
            }
            else {
                MessageBox.Show("No database connection has been established");
            }
        }



        private void crtlAddNewEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (true) {
                AddEmployee();
            }
            else {
                MessageBox.Show("No database connection has been established");
            }
        }

        private void crtlAddNewItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (true) {
                AddItem();
            }
            else {
                MessageBox.Show("No database connection has been established");
            }
        }
        private void editCustomer(object sender, EventArgs e)
        {
            DataRow dr = ((GridView)gridControlCustomers.MainView).GetFocusedDataRow();
            Customer customer = new Customer
            {
                ID = new Guid(),
                Name = dr.ItemArray[1].ToString(),
                Surname = dr.ItemArray[2].ToString(),
                CardNumber = 0
            };
            DataEditForm form = new DataEditForm();
            form.EditObject = customer;
            form.Show();
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
            try {
                return;
                SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectCustomers, Conn);
                MasterData.Clear();
                adapter.Fill(MasterData, "Customers");
                gridControlCustomers.DataSource = MasterData.Tables["Customers"];

                adapter = new SqlDataAdapter(Resources.SelectEmployees, Conn);
                adapter.Fill(MasterData, "Employees");
                gridControlEmployees.DataSource = MasterData.Tables["Employees"];

                adapter = new SqlDataAdapter(Resources.SelectItems, Conn);
                adapter.Fill(MasterData, "Items");
                gridControlItems.DataSource = MasterData.Tables["Items"];


                //adapter.SelectCommand = new SqlCommand(Resources.SelectTransactions, Conn);
                //adapter.Fill(MasterData, "Transactions");
                //gridControlItems.DataSource = MasterData.Tables["Transactions"];


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

                //gridControlTransactions.Refresh();
                //gridControlTransactions.Visible = true;
                //gridView4.Columns["ID"].Visible = false;
                //gridView4.BeginDataUpdate();
                //gridView4.ClearSorting();
                //gridView4.Columns["Date"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                //gridView4.EndDataUpdate();


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void RefreshTables() {
            gridControlCustomers.Refresh();
        }

        private void AddCustomer() {
            DataEditForm form = new DataEditForm();
            Customer newCustomer = new Customer();
            form.EditObject = newCustomer;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) {
                try {
                    SqlCommand cmd = new SqlCommand(Resources.InsertCustomer, Conn);
                    cmd.Parameters.AddWithValue("@ID", newCustomer.ID);
                    cmd.Parameters.AddWithValue("@Name", newCustomer.Name);
                    cmd.Parameters.AddWithValue("@Surname", newCustomer.Surname);
                    cmd.Parameters.AddWithValue("@CardNumber", newCustomer.CardNumber);
                    cmd.ExecuteNonQuery();
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
                    SqlCommand cmd = new SqlCommand(Resources.InsertEmployee, Conn);
                    cmd.Parameters.AddWithValue("@ID", newEmployee.ID);
                    cmd.Parameters.AddWithValue("@Name", newEmployee.Name);
                    cmd.Parameters.AddWithValue("@Surname", newEmployee.Surname);
                    cmd.Parameters.AddWithValue("@DateStart", newEmployee.DateStart.Date);
                    cmd.Parameters.AddWithValue("@DateEnd", newEmployee.DateEnd.Date);
                    cmd.Parameters.AddWithValue("@Salary", newEmployee.Salary);
                    cmd.ExecuteNonQuery();
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
                    SqlCommand cmd = new SqlCommand(Resources.InsertItem, Conn);
                    cmd.Parameters.AddWithValue("@ID", newItem.ID);
                    cmd.Parameters.AddWithValue("@Code", newItem.Code);
                    cmd.Parameters.AddWithValue("@Description", newItem.Description);
                    cmd.Parameters.AddWithValue("@ItemType", newItem.ItemType.ToString());
                    cmd.Parameters.AddWithValue("@Price", newItem.Price);
                    cmd.Parameters.AddWithValue("@Cost", newItem.Cost);
                    cmd.ExecuteNonQuery();
                    RefreshTables();
                }
                catch (Exception e) {
                    MessageBox.Show(e.Message);
                }
            }
        }

    }
    #endregion
}
