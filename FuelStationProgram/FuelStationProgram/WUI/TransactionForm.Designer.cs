
namespace FuelStationProgram.WUI
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crtlItemList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.crtlTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.crtlAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.crtlFinishTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.crtlCancelTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.crtlItemAmount = new DevExpress.XtraEditors.SpinEdit();
            this.crtlDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.crtlItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlItemAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // crtlItemList
            // 
            this.crtlItemList.DataSource = typeof(FuelStationProgram.Impl.Items);
            this.crtlItemList.Location = new System.Drawing.Point(12, 64);
            this.crtlItemList.MainView = this.gridView1;
            this.crtlItemList.Name = "crtlItemList";
            this.crtlItemList.Size = new System.Drawing.Size(484, 320);
            this.crtlItemList.TabIndex = 2;
            this.crtlItemList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.crtlItemList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "Code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Description";
            this.gridColumn2.FieldName = "Description";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Item Type";
            this.gridColumn3.FieldName = "ItemType";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Price";
            this.gridColumn4.FieldName = "Price";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // crtlTransactionLines
            // 
            this.crtlTransactionLines.DataSource = typeof(FuelStationProgram.Impl.TransactionLine);
            this.crtlTransactionLines.Location = new System.Drawing.Point(526, 64);
            this.crtlTransactionLines.MainView = this.gridView2;
            this.crtlTransactionLines.Name = "crtlTransactionLines";
            this.crtlTransactionLines.Size = new System.Drawing.Size(484, 320);
            this.crtlTransactionLines.TabIndex = 3;
            this.crtlTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn7});
            this.gridView2.GridControl = this.crtlTransactionLines;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Description";
            this.gridColumn8.FieldName = "ItemDescription";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Quantity";
            this.gridColumn6.FieldName = "Quantity";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Price";
            this.gridColumn5.FieldName = "ItemPrice";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Value";
            this.gridColumn7.FieldName = "Value";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // crtlAddItem
            // 
            this.crtlAddItem.Location = new System.Drawing.Point(12, 390);
            this.crtlAddItem.Name = "crtlAddItem";
            this.crtlAddItem.Size = new System.Drawing.Size(178, 49);
            this.crtlAddItem.TabIndex = 4;
            this.crtlAddItem.Text = "Add Item...";
            this.crtlAddItem.Click += new System.EventHandler(this.crtlAddItem_Click);
            // 
            // crtlFinishTransaction
            // 
            this.crtlFinishTransaction.Location = new System.Drawing.Point(650, 390);
            this.crtlFinishTransaction.Name = "crtlFinishTransaction";
            this.crtlFinishTransaction.Size = new System.Drawing.Size(178, 49);
            this.crtlFinishTransaction.TabIndex = 5;
            this.crtlFinishTransaction.Text = "Finish Transcation";
            // 
            // crtlCancelTransaction
            // 
            this.crtlCancelTransaction.Location = new System.Drawing.Point(834, 390);
            this.crtlCancelTransaction.Name = "crtlCancelTransaction";
            this.crtlCancelTransaction.Size = new System.Drawing.Size(178, 49);
            this.crtlCancelTransaction.TabIndex = 6;
            this.crtlCancelTransaction.Text = "Cancel Transaction";
            this.crtlCancelTransaction.Click += new System.EventHandler(this.crtlCancelTransaction_Click);
            // 
            // crtlItemAmount
            // 
            this.crtlItemAmount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crtlItemAmount.Location = new System.Drawing.Point(218, 405);
            this.crtlItemAmount.Name = "crtlItemAmount";
            this.crtlItemAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.crtlItemAmount.Properties.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.crtlItemAmount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.crtlItemAmount.Size = new System.Drawing.Size(100, 20);
            this.crtlItemAmount.TabIndex = 7;
            this.crtlItemAmount.EditValueChanged += new System.EventHandler(this.crtlItemAmount_EditValueChanged);
            // 
            // crtlDeleteItem
            // 
            this.crtlDeleteItem.Location = new System.Drawing.Point(876, 26);
            this.crtlDeleteItem.Name = "crtlDeleteItem";
            this.crtlDeleteItem.Size = new System.Drawing.Size(134, 32);
            this.crtlDeleteItem.TabIndex = 8;
            this.crtlDeleteItem.Text = "Remove item";
            this.crtlDeleteItem.Click += new System.EventHandler(this.crtlDeleteItem_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 571);
            this.Controls.Add(this.crtlDeleteItem);
            this.Controls.Add(this.crtlItemAmount);
            this.Controls.Add(this.crtlCancelTransaction);
            this.Controls.Add(this.crtlFinishTransaction);
            this.Controls.Add(this.crtlAddItem);
            this.Controls.Add(this.crtlTransactionLines);
            this.Controls.Add(this.crtlItemList);
            this.Name = "TransactionForm";
            this.Text = "New Transaction...";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtlItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlItemAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl crtlItemList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl crtlTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton crtlAddItem;
        private DevExpress.XtraEditors.SimpleButton crtlFinishTransaction;
        private DevExpress.XtraEditors.SimpleButton crtlCancelTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SpinEdit crtlItemAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton crtlDeleteItem;
    }
}