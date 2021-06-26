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
    public partial class Form1 : Form {
        public string ConnString { get; set; }
        public SqlConnection Conn { get; set; }
        public DataSet MasterData = new DataSet();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnConnect_Click(object sender, EventArgs e) {
            
            SqlConnect();
        }

        private void SqlConnect() {
            ConnString = txtSqlPath.EditValue.ToString();
            try {
                Conn = new SqlConnection(ConnString);
                Conn.Open();
                //Console.WriteLine(conn.State);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e) {
            SqlLoadTables();
        }

        private void SqlLoadTables() {
            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [dbo].[Customers]", Conn);
                adapter.Fill(MasterData);
                gridControl1.DataSource = MasterData.Tables[0];

                gridControl1.Refresh();


                gridView1.OptionsView.ShowGroupPanel = false;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
