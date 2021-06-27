using DevExpress.Data.Mask;
using DevExpress.XtraEditors.Mask;
using FuelStationProgram.Base;
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
                    EmployeeLayout(employee);
                    break;
                case Items item:
                    ItemLayout(item);
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            switch (EditObject) {
                case Customer customer:
                    CustomerEdit(customer);
                    break;
                case Employee employee:
                    EmployeeEdit(employee);
                    break;
                case Items item:
                    ItemEdit(item);
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
            labelControl3.Text = "Card Number:";

            labelControl1.Visible = true;
            labelControl2.Visible = true;
            labelControl3.Visible = true;
            textEdit1.Visible = true;
            textEdit2.Visible = true;
            calcEdit1.Visible = true;
            textEdit1.TabIndex = 1;
            textEdit2.TabIndex = 2;
            calcEdit1.TabIndex = 3;

            calcEdit1.Location = new Point(126, 122);
            
            calcEdit1.Properties.MaskSettings.Configure<MaskSettings.Numeric>(settings => {
                settings.MaskExpression = "####";
            });
            calcEdit1.Properties.Buttons.Clear();

            if (customer.Name != null) {
                textEdit1.Text = customer.Name;
                textEdit2.Text = customer.Surname;
                calcEdit1.Text = customer.CardNumber.ToString();
            }
        }

        private void CustomerEdit(Customer customer) {
            try {
                customer.Name = textEdit1.EditValue.ToString();
                customer.Surname = textEdit2.EditValue.ToString();
                customer.CardNumber = Convert.ToInt32(textEdit3.EditValue);
            }
            catch (System.NullReferenceException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Item
        private void ItemLayout(Items item) {
            grpFields.Text = "Item Details";
            labelControl1.Text = "Code:";
            labelControl2.Text = "Description:";
            labelControl3.Text = "Item type:";
            labelControl4.Text = "Price:";
            labelControl5.Text = "Cost:";

            labelControl1.Visible = true;
            labelControl2.Visible = true;
            labelControl3.Visible = true;
            labelControl4.Visible = true;
            labelControl5.Visible = true;

            textEdit1.Visible = true;
            textEdit2.Visible = true;
            comboBoxEdit1.Visible = true;
            calcEdit1.Visible = true;
            calcEdit2.Visible = true;
            textEdit1.TabIndex = 1;
            textEdit2.TabIndex = 2;
            comboBoxEdit1.TabIndex = 3;
            calcEdit1.TabIndex = 4;
            calcEdit2.TabIndex = 5;

            comboBoxEdit1.Location = new Point(126,122);
            calcEdit1.Location = new Point(126, 162);
            calcEdit2.Location = new Point(126, 202);

            foreach (ItemType i in Enum.GetValues(typeof(ItemType))) {
                comboBoxEdit1.Properties.Items.Add(i.ToString());
            }
            calcEdit1.Properties.MaskSettings.Configure<MaskSettings.Numeric>(settings => {
                settings.MaskExpression = "C";
            });
            calcEdit2.Properties.MaskSettings.Configure<MaskSettings.Numeric>(settings => {
                settings.MaskExpression = "C";
            });
            calcEdit1.Properties.Buttons.Clear();
            calcEdit2.Properties.Buttons.Clear();

            if (item.Description != null) {
                textEdit1.Text = item.Code.ToString();
                textEdit2.Text = item.Description;
                textEdit3.Text = item.ItemType.ToString();
                comboBoxEdit1.Text = item.ItemType.ToString();
                calcEdit1.Text = item.Price.ToString();
                calcEdit2.Text = item.Cost.ToString();
            }
        }

        private void ItemEdit(Items item) {
            try {
                item.Code = Convert.ToInt32(textEdit1.EditValue);
                item.Description = textEdit2.EditValue.ToString();
                item.ItemType = (ItemType)Enum.Parse(typeof(ItemType), comboBoxEdit1.EditValue.ToString());
                item.Price = Convert.ToDecimal(calcEdit1.EditValue);
                item.Cost = Convert.ToDecimal(calcEdit2.EditValue);
            }
            catch (System.NullReferenceException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Employee
        private void EmployeeLayout(Employee employee) {
            grpFields.Text = "Employee Details";
            labelControl1.Text = "Name:";
            labelControl2.Text = "Surname:";
            labelControl3.Text = "Start Date:";
            labelControl4.Text = "End Date:";
            labelControl5.Text = "Salary:";

            labelControl1.Visible = true;
            labelControl2.Visible = true;
            labelControl3.Visible = true;
            labelControl4.Visible = true;
            labelControl5.Visible = true;
            textEdit1.Visible = true;
            textEdit2.Visible = true;
            dateEdit1.Visible = true;
            dateEdit2.Visible = true;
            calcEdit1.Visible = true;
            textEdit1.TabIndex = 1;
            textEdit2.TabIndex = 2;
            dateEdit1.TabIndex = 3;
            dateEdit2.TabIndex = 4;
            calcEdit1.TabIndex = 5;


            dateEdit1.Location = new Point(126, 122);
            dateEdit2.Location = new Point(126, 162);
            calcEdit1.Location = new Point(126, 202);

            calcEdit1.Properties.MaskSettings.Configure<MaskSettings.Numeric>(settings => {
                settings.MaskExpression = "C";
            });
            calcEdit1.Properties.Buttons.Clear();

            if (employee.Name != null) {
                textEdit1.Text = employee.Name;
                textEdit2.Text = employee.Surname;
                dateEdit1.Text = employee.DateStart.ToString();
                dateEdit2.Text = employee.DateEnd.ToString();
                calcEdit1.Text = employee.Salary.ToString();
            }
        }

        private void EmployeeEdit(Employee employee) {
            try {
                employee.Name = textEdit1.EditValue.ToString();
                employee.Surname = textEdit2.EditValue.ToString();
                employee.DateStart = Convert.ToDateTime(dateEdit1.EditValue);
                employee.DateEnd = Convert.ToDateTime(dateEdit2.EditValue);
                employee.Salary = Convert.ToDecimal(calcEdit1.EditValue);
            }
            catch (System.NullReferenceException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
