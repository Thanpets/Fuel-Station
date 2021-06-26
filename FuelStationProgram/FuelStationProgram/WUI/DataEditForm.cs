using FuelStationProgram.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationProgram {
    public partial class DataEditForm : Form {
        public object EditObject {get; set;}
        public DataEditForm() {
            InitializeComponent();
        }
        private void DataEditForm_Load(object sender, EventArgs e) {
            switch (EditObject) {
                case Customer customer:
                    CustomerLayout(customer);
                    break;
                case Employee employee:
                    break;
                case Items item:
                    break;
                case Transaction transaction:
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            switch (EditObject) {
                case Customer customer:
                    CustomerEdit(customer);
                    break;
                case Employee employee:
                    break;
                case Items item:
                    break;
                case Transaction transaction:
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #region Customer
        private void CustomerLayout(Customer customer) {
            grpFields.Text = "Customer Details";
            labelControl1.Text = "Name:";
            labelControl2.Text = "Surname:";
            labelControl3.Text = "Card Number";
            labelControl1.Visible = true;
            labelControl2.Visible = true;
            labelControl3.Visible = true;
            textEdit1.Visible = true;
            textEdit2.Visible = true;
            textEdit3.Visible = true;
            textEdit1.Text = customer.Name;
            textEdit2.Text = customer.Surname;
            textEdit3.Text = customer.CardNumber.ToString();
        }

        private void CustomerEdit(Customer customer) {
            try {
                customer.Name = textEdit1.EditValue.ToString();
                customer.Surname = textEdit2.EditValue.ToString();
                customer.CardNumber = (Int32)textEdit3.EditValue;
            }
            catch (System.NullReferenceException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


    }
}
