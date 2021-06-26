﻿
namespace FuelStationProgram
{
    partial class ViewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.txtSqlPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.crtlConnectToDB = new DevExpress.XtraBars.BarButtonItem();
            this.crtlLoadFromDB = new DevExpress.XtraBars.BarButtonItem();
            this.crtlExitApplication = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.crtlAddNewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.crtlAddNewItem = new DevExpress.XtraBars.BarButtonItem();
            this.crtlAddNewEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.label1 = new System.Windows.Forms.Label();
            this.crtlNewTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.crtlCustomerCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtSqlPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlCustomerCardNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSqlPath
            // 
            this.txtSqlPath.EditValue = resources.GetString("txtSqlPath.EditValue");
            this.txtSqlPath.Location = new System.Drawing.Point(60, 529);
            this.txtSqlPath.Name = "txtSqlPath";
            this.txtSqlPath.Size = new System.Drawing.Size(390, 20);
            this.txtSqlPath.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 532);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "SQL Path";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 275);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.crtlConnectToDB,
            this.crtlLoadFromDB,
            this.crtlExitApplication,
            this.barSubItem2,
            this.crtlAddNewCustomer,
            this.crtlAddNewItem,
            this.crtlAddNewEmployee});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1054, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 573);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1054, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 553);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1054, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 553);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "File...";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.crtlConnectToDB),
            new DevExpress.XtraBars.LinkPersistInfo(this.crtlLoadFromDB),
            new DevExpress.XtraBars.LinkPersistInfo(this.crtlExitApplication)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // crtlConnectToDB
            // 
            this.crtlConnectToDB.Caption = "Connect";
            this.crtlConnectToDB.Id = 1;
            this.crtlConnectToDB.Name = "crtlConnectToDB";
            this.crtlConnectToDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.crtlConnectToDB_ItemClick);
            // 
            // crtlLoadFromDB
            // 
            this.crtlLoadFromDB.Caption = "Load Data";
            this.crtlLoadFromDB.Id = 2;
            this.crtlLoadFromDB.Name = "crtlLoadFromDB";
            this.crtlLoadFromDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.crtlLoadFromDB_ItemClick);
            // 
            // crtlExitApplication
            // 
            this.crtlExitApplication.Caption = "Exit";
            this.crtlExitApplication.Id = 3;
            this.crtlExitApplication.Name = "crtlExitApplication";
            this.crtlExitApplication.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.crtlExitApplication_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Add...";
            this.barSubItem2.Id = 4;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.crtlAddNewCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.crtlAddNewEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.crtlAddNewItem)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // crtlAddNewCustomer
            // 
            this.crtlAddNewCustomer.Caption = "New Customer";
            this.crtlAddNewCustomer.Id = 5;
            this.crtlAddNewCustomer.Name = "crtlAddNewCustomer";
            this.crtlAddNewCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.crtlAddNewCustomer_ItemClick);
            // 
            // crtlAddNewItem
            // 
            this.crtlAddNewItem.Caption = "New item";
            this.crtlAddNewItem.Id = 6;
            this.crtlAddNewItem.Name = "crtlAddNewItem";
            this.crtlAddNewItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.crtlAddNewItem_ItemClick);
            // 
            // crtlAddNewEmployee
            // 
            this.crtlAddNewEmployee.Caption = "New Employee";
            this.crtlAddNewEmployee.Id = 7;
            this.crtlAddNewEmployee.Name = "crtlAddNewEmployee";
            this.crtlAddNewEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.crtlAddNewEmployee_ItemClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Transaction";
            // 
            // crtlNewTransaction
            // 
            this.crtlNewTransaction.Location = new System.Drawing.Point(58, 469);
            this.crtlNewTransaction.Name = "crtlNewTransaction";
            this.crtlNewTransaction.Size = new System.Drawing.Size(261, 41);
            this.crtlNewTransaction.TabIndex = 16;
            this.crtlNewTransaction.Text = "New Transaction...";
            // 
            // crtlCustomerCardNumber
            // 
            this.crtlCustomerCardNumber.Location = new System.Drawing.Point(180, 431);
            this.crtlCustomerCardNumber.MenuManager = this.barManager1;
            this.crtlCustomerCardNumber.Name = "crtlCustomerCardNumber";
            this.crtlCustomerCardNumber.Size = new System.Drawing.Size(141, 20);
            this.crtlCustomerCardNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer Card Number:";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crtlCustomerCardNumber);
            this.Controls.Add(this.crtlNewTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSqlPath);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ViewForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSqlPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlCustomerCardNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSqlPath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem crtlConnectToDB;
        private DevExpress.XtraBars.BarButtonItem crtlLoadFromDB;
        private DevExpress.XtraBars.BarButtonItem crtlExitApplication;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem crtlAddNewCustomer;
        private DevExpress.XtraBars.BarButtonItem crtlAddNewItem;
        private DevExpress.XtraBars.BarButtonItem crtlAddNewEmployee;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit crtlCustomerCardNumber;
        private DevExpress.XtraEditors.SimpleButton crtlNewTransaction;
        private System.Windows.Forms.Label label1;
    }
}

