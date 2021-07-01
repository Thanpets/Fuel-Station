
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.txtSqlPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.crtlConnectToDB = new DevExpress.XtraBars.BarButtonItem();
            this.crtlLoadFromDB = new DevExpress.XtraBars.BarButtonItem();
            this.crtlExitApplication = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.crtlAddNewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.crtlAddNewEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.crtlAddNewItem = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.label1 = new System.Windows.Forms.Label();
            this.crtlNewTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.crtlCustomerCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.xtraTabPane = new DevExpress.XtraTab.XtraTabControl();
            this.tabCustomers = new DevExpress.XtraTab.XtraTabPage();
            this.tabEmployees = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlEmployees = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabItems = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlItems = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabTransactions = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabLedger = new DevExpress.XtraTab.XtraTabPage();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btnSaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSqlPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlCustomerCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabPane)).BeginInit();
            this.xtraTabPane.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.tabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSqlPath
            // 
            this.txtSqlPath.EditValue = "Data Source=DESKTOP-JQOORR3;Initial Catalog=FuelStation;Integrated Security=True;" +
    "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=" +
    "ReadWrite;MultiSubnetFailover=False";
            this.txtSqlPath.Location = new System.Drawing.Point(652, 528);
            this.txtSqlPath.Name = "txtSqlPath";
            this.txtSqlPath.Size = new System.Drawing.Size(390, 20);
            this.txtSqlPath.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(602, 531);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "SQL Path";
            // 
            // gridControlCustomers
            // 
            this.gridControlCustomers.Location = new System.Drawing.Point(0, 0);
            this.gridControlCustomers.MainView = this.gridView1;
            this.gridControlCustomers.Name = "gridControlCustomers";
            this.gridControlCustomers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlCustomers.Size = new System.Drawing.Size(749, 329);
            this.gridControlCustomers.TabIndex = 5;
            this.gridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlCustomers;
            this.gridView1.Name = "gridView1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
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
            this.crtlAddNewEmployee,
            this.barButtonItem1,
            this.barSubItem3,
            this.barSubItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 14;
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
            // barSubItem1
            // 
            this.barSubItem1.Caption = "File";
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
            this.barSubItem2.Caption = "Add";
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
            // crtlAddNewEmployee
            // 
            this.crtlAddNewEmployee.Caption = "New Employee";
            this.crtlAddNewEmployee.Id = 7;
            this.crtlAddNewEmployee.Name = "crtlAddNewEmployee";
            this.crtlAddNewEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.crtlAddNewEmployee_ItemClick);
            // 
            // crtlAddNewItem
            // 
            this.crtlAddNewItem.Caption = "New item";
            this.crtlAddNewItem.Id = 6;
            this.crtlAddNewItem.Name = "crtlAddNewItem";
            this.crtlAddNewItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.crtlAddNewItem_ItemClick);
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Edit";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "barSubItem3";
            this.barSubItem3.Id = 9;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Edit";
            this.barSubItem4.Id = 10;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Transaction";
            // 
            // crtlNewTransaction
            // 
            this.tablePanel1.SetColumn(this.crtlNewTransaction, 1);
            this.crtlNewTransaction.Location = new System.Drawing.Point(83, 82);
            this.crtlNewTransaction.Name = "crtlNewTransaction";
            this.tablePanel1.SetRow(this.crtlNewTransaction, 1);
            this.crtlNewTransaction.Size = new System.Drawing.Size(364, 45);
            this.crtlNewTransaction.TabIndex = 16;
            this.crtlNewTransaction.Text = "New Transaction...";
            this.crtlNewTransaction.Click += new System.EventHandler(this.crtlNewTransaction_Click);
            // 
            // crtlCustomerCardNumber
            // 
            this.tablePanel1.SetColumn(this.crtlCustomerCardNumber, 1);
            this.crtlCustomerCardNumber.Location = new System.Drawing.Point(83, 15);
            this.crtlCustomerCardNumber.MenuManager = this.barManager1;
            this.crtlCustomerCardNumber.Name = "crtlCustomerCardNumber";
            this.tablePanel1.SetRow(this.crtlCustomerCardNumber, 0);
            this.crtlCustomerCardNumber.Size = new System.Drawing.Size(364, 20);
            this.crtlCustomerCardNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 0);
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer Card Number:";
            // 
            // xtraTabPane
            // 
            this.xtraTabPane.Location = new System.Drawing.Point(0, 46);
            this.xtraTabPane.Name = "xtraTabPane";
            this.xtraTabPane.SelectedTabPage = this.tabCustomers;
            this.xtraTabPane.Size = new System.Drawing.Size(751, 352);
            this.xtraTabPane.TabIndex = 29;
            this.xtraTabPane.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabCustomers,
            this.tabEmployees,
            this.tabItems,
            this.tabTransactions,
            this.tabLedger});
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.gridControlCustomers);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(749, 327);
            this.tabCustomers.Text = "Customers";
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.gridControlEmployees);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Size = new System.Drawing.Size(749, 327);
            this.tabEmployees.Text = "Employees";
            // 
            // gridControlEmployees
            // 
            this.gridControlEmployees.Location = new System.Drawing.Point(0, 0);
            this.gridControlEmployees.MainView = this.gridView2;
            this.gridControlEmployees.Name = "gridControlEmployees";
            this.gridControlEmployees.Size = new System.Drawing.Size(749, 329);
            this.gridControlEmployees.TabIndex = 30;
            this.gridControlEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlEmployees;
            this.gridView2.Name = "gridView2";
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.gridControlItems);
            this.tabItems.Name = "tabItems";
            this.tabItems.Size = new System.Drawing.Size(749, 327);
            this.tabItems.Text = "Items";
            // 
            // gridControlItems
            // 
            this.gridControlItems.Location = new System.Drawing.Point(0, 0);
            this.gridControlItems.MainView = this.gridView3;
            this.gridControlItems.MenuManager = this.barManager1;
            this.gridControlItems.Name = "gridControlItems";
            this.gridControlItems.Size = new System.Drawing.Size(749, 329);
            this.gridControlItems.TabIndex = 0;
            this.gridControlItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlItems;
            this.gridView3.Name = "gridView3";
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.gridControlTransactions);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Size = new System.Drawing.Size(749, 327);
            this.tabTransactions.Text = "Transactions";
            // 
            // gridControlTransactions
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControlTransactions.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlTransactions.Location = new System.Drawing.Point(0, 0);
            this.gridControlTransactions.MainView = this.gridView4;
            this.gridControlTransactions.MenuManager = this.barManager1;
            this.gridControlTransactions.Name = "gridControlTransactions";
            this.gridControlTransactions.Size = new System.Drawing.Size(749, 329);
            this.gridControlTransactions.TabIndex = 1;
            this.gridControlTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControlTransactions;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            // 
            // tabLedger
            // 
            this.tabLedger.Name = "tabLedger";
            this.tabLedger.Size = new System.Drawing.Size(749, 327);
            this.tabLedger.Text = "Ledger";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10.69F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.31F)});
            this.tablePanel1.Controls.Add(this.crtlNewTransaction);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.crtlCustomerCardNumber);
            this.tablePanel1.Location = new System.Drawing.Point(12, 403);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(450, 159);
            this.tablePanel1.TabIndex = 34;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveChanges.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSaveChanges.Appearance.Options.UseBackColor = true;
            this.btnSaveChanges.Appearance.Options.UseFont = true;
            this.btnSaveChanges.Location = new System.Drawing.Point(800, 360);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 39);
            this.btnSaveChanges.TabIndex = 42;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(800, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 39);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 593);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.xtraTabPane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSqlPath);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ViewForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSqlPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlCustomerCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabPane)).EndInit();
            this.xtraTabPane.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.tabTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSqlPath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlCustomers;
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
        private DevExpress.XtraTab.XtraTabControl xtraTabPane;
        private DevExpress.XtraTab.XtraTabPage tabItems;
        private DevExpress.XtraGrid.GridControl gridControlItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabPage tabCustomers;
        private DevExpress.XtraGrid.GridControl gridControlEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage tabEmployees;
        private DevExpress.XtraTab.XtraTabPage tabTransactions;
        private DevExpress.XtraGrid.GridControl gridControlTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraTab.XtraTabPage tabLedger;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnSaveChanges;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem4;

        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}

