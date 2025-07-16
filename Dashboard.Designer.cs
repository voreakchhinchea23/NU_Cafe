using System;

namespace NU_Cafe
{
    partial class DashboardView
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIsAvailable = new System.Windows.Forms.CheckBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnMenuDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnMenuCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnMenuSave = new System.Windows.Forms.Button();
            this.dtgMenu = new System.Windows.Forms.DataGridView();
            this.clProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tpOrder = new System.Windows.Forms.TabPage();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.dtgCart = new System.Windows.Forms.DataGridView();
            this.txtProductHiddenID = new System.Windows.Forms.TextBox();
            this.llbOrderDetail = new System.Windows.Forms.LinkLabel();
            this.btnOrderRefresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgOrders = new System.Windows.Forms.DataGridView();
            this.clOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrderedPrice = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboStaff = new System.Windows.Forms.ComboBox();
            this.btnOrderCancel = new System.Windows.Forms.Button();
            this.lblOrderFeedback = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.dtgOrderMenu = new System.Windows.Forms.DataGridView();
            this.clOrderProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrderProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderedProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpInventory = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInventoryID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInventorySupplier = new System.Windows.Forms.TextBox();
            this.btnInventoryDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInventoryReorder = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInventoryUnit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInventoryQty = new System.Windows.Forms.TextBox();
            this.btnInventoryCancel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInventoryName = new System.Windows.Forms.TextBox();
            this.btnInventorySave = new System.Windows.Forms.Button();
            this.dtgInventory = new System.Windows.Forms.DataGridView();
            this.clInventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInventoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInventoryQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInventoryUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbUserPw = new System.Windows.Forms.CheckBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSetPw = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSetusername = new System.Windows.Forms.TextBox();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label29 = new System.Windows.Forms.Label();
            this.tpReport = new System.Windows.Forms.TabPage();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtpSaleReport = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgOutstanding = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefreshReport = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dtgPopularItems = new System.Windows.Forms.DataGridView();
            this.colReportProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPopularProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgSalesReport = new System.Windows.Forms.DataGridView();
            this.colReportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReportTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.tpSupplier = new System.Windows.Forms.TabPage();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.dtgSupplier = new System.Windows.Forms.DataGridView();
            this.clSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupplierContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSupplierDelete = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSupplierContact = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnSupplierCancel = new System.Windows.Forms.Button();
            this.btnSupplierSave = new System.Windows.Forms.Button();
            this.nU_CafeDBDataSet = new NU_Cafe.NU_CafeDBDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new NU_Cafe.NU_CafeDBDataSetTableAdapters.ProductsTableAdapter();
            this.MainTab.SuspendLayout();
            this.tpMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).BeginInit();
            this.tpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderMenu)).BeginInit();
            this.tpInventory.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventory)).BeginInit();
            this.tpUser.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.tpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOutstanding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPopularItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalesReport)).BeginInit();
            this.tpSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSupplier)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nU_CafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tpMenu);
            this.MainTab.Controls.Add(this.tpOrder);
            this.MainTab.Controls.Add(this.tpInventory);
            this.MainTab.Controls.Add(this.tpUser);
            this.MainTab.Controls.Add(this.tpReport);
            this.MainTab.Controls.Add(this.tpSupplier);
            this.MainTab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTab.Location = new System.Drawing.Point(1, -1);
            this.MainTab.Margin = new System.Windows.Forms.Padding(4);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1260, 752);
            this.MainTab.TabIndex = 0;
            // 
            // tpMenu
            // 
            this.tpMenu.BackColor = System.Drawing.Color.Wheat;
            this.tpMenu.Controls.Add(this.groupBox1);
            this.tpMenu.Controls.Add(this.dtgMenu);
            this.tpMenu.Controls.Add(this.label1);
            this.tpMenu.Location = new System.Drawing.Point(4, 29);
            this.tpMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(4);
            this.tpMenu.Size = new System.Drawing.Size(1252, 719);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIsAvailable);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.btnMenuDelete);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.btnMenuCancel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.btnMenuSave);
            this.groupBox1.Location = new System.Drawing.Point(0, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1247, 255);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Menu";
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.AutoSize = true;
            this.cbIsAvailable.Location = new System.Drawing.Point(715, 86);
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.Size = new System.Drawing.Size(111, 24);
            this.cbIsAvailable.TabIndex = 5;
            this.cbIsAvailable.Text = "Is Available";
            this.cbIsAvailable.UseVisualStyleBackColor = true;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(1177, 26);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(63, 34);
            this.txtProductID.TabIndex = 16;
            this.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductID.Visible = false;
            // 
            // btnMenuDelete
            // 
            this.btnMenuDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDelete.Location = new System.Drawing.Point(715, 184);
            this.btnMenuDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuDelete.Name = "btnMenuDelete";
            this.btnMenuDelete.Size = new System.Drawing.Size(56, 48);
            this.btnMenuDelete.TabIndex = 6;
            this.btnMenuDelete.Text = "🗑";
            this.btnMenuDelete.UseVisualStyleBackColor = true;
            this.btnMenuDelete.Click += new System.EventHandler(this.btnMenuDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(417, 186);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(215, 34);
            this.txtDesc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Category";
            // 
            // txtCate
            // 
            this.txtCate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCate.Location = new System.Drawing.Point(420, 85);
            this.txtCate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCate.Name = "txtCate";
            this.txtCate.Size = new System.Drawing.Size(215, 34);
            this.txtCate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(83, 186);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(215, 34);
            this.txtPrice.TabIndex = 2;
            // 
            // btnMenuCancel
            // 
            this.btnMenuCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCancel.Location = new System.Drawing.Point(938, 184);
            this.btnMenuCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuCancel.Name = "btnMenuCancel";
            this.btnMenuCancel.Size = new System.Drawing.Size(145, 48);
            this.btnMenuCancel.TabIndex = 7;
            this.btnMenuCancel.Text = "Cancel";
            this.btnMenuCancel.UseVisualStyleBackColor = true;
            this.btnMenuCancel.Click += new System.EventHandler(this.btnMenuCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product name";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(83, 85);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(215, 34);
            this.txtProductName.TabIndex = 1;
            // 
            // btnMenuSave
            // 
            this.btnMenuSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSave.Location = new System.Drawing.Point(1088, 184);
            this.btnMenuSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuSave.Name = "btnMenuSave";
            this.btnMenuSave.Size = new System.Drawing.Size(145, 48);
            this.btnMenuSave.TabIndex = 8;
            this.btnMenuSave.Text = "Save";
            this.btnMenuSave.UseVisualStyleBackColor = true;
            this.btnMenuSave.Click += new System.EventHandler(this.btnMenuSave_Click);
            // 
            // dtgMenu
            // 
            this.dtgMenu.AllowUserToAddRows = false;
            this.dtgMenu.AllowUserToDeleteRows = false;
            this.dtgMenu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgMenu.ColumnHeadersHeight = 29;
            this.dtgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProductId,
            this.clName,
            this.clPrice,
            this.clCate,
            this.clDesc,
            this.clAvailable});
            this.dtgMenu.GridColor = System.Drawing.Color.White;
            this.dtgMenu.Location = new System.Drawing.Point(137, 412);
            this.dtgMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgMenu.Name = "dtgMenu";
            this.dtgMenu.ReadOnly = true;
            this.dtgMenu.RowHeadersWidth = 51;
            this.dtgMenu.RowTemplate.Height = 24;
            this.dtgMenu.Size = new System.Drawing.Size(926, 283);
            this.dtgMenu.TabIndex = 22;
            this.dtgMenu.SelectionChanged += new System.EventHandler(this.dtgMenu_SelectionChanged);
            // 
            // clProductId
            // 
            this.clProductId.HeaderText = "ID";
            this.clProductId.MinimumWidth = 6;
            this.clProductId.Name = "clProductId";
            this.clProductId.ReadOnly = true;
            this.clProductId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clProductId.Width = 50;
            // 
            // clName
            // 
            this.clName.HeaderText = "Product Name";
            this.clName.MinimumWidth = 10;
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clName.Width = 120;
            // 
            // clPrice
            // 
            this.clPrice.HeaderText = "Price";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clPrice.Width = 125;
            // 
            // clCate
            // 
            this.clCate.HeaderText = "Category";
            this.clCate.MinimumWidth = 6;
            this.clCate.Name = "clCate";
            this.clCate.ReadOnly = true;
            this.clCate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clCate.Width = 125;
            // 
            // clDesc
            // 
            this.clDesc.HeaderText = "Description";
            this.clDesc.MinimumWidth = 10;
            this.clDesc.Name = "clDesc";
            this.clDesc.ReadOnly = true;
            this.clDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clDesc.Width = 150;
            // 
            // clAvailable
            // 
            this.clAvailable.HeaderText = "IsAvailable";
            this.clAvailable.MinimumWidth = 6;
            this.clAvailable.Name = "clAvailable";
            this.clAvailable.ReadOnly = true;
            this.clAvailable.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 81);
            this.label1.TabIndex = 21;
            this.label1.Text = "Menu Management";
            // 
            // tpOrder
            // 
            this.tpOrder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpOrder.Controls.Add(this.btnRemoveFromCart);
            this.tpOrder.Controls.Add(this.btnConfirm);
            this.tpOrder.Controls.Add(this.label33);
            this.tpOrder.Controls.Add(this.dtgCart);
            this.tpOrder.Controls.Add(this.txtProductHiddenID);
            this.tpOrder.Controls.Add(this.llbOrderDetail);
            this.tpOrder.Controls.Add(this.btnOrderRefresh);
            this.tpOrder.Controls.Add(this.label8);
            this.tpOrder.Controls.Add(this.dtgOrders);
            this.tpOrder.Controls.Add(this.groupBox2);
            this.tpOrder.Controls.Add(this.label6);
            this.tpOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpOrder.Location = new System.Drawing.Point(4, 29);
            this.tpOrder.Margin = new System.Windows.Forms.Padding(4);
            this.tpOrder.Name = "tpOrder";
            this.tpOrder.Padding = new System.Windows.Forms.Padding(4);
            this.tpOrder.Size = new System.Drawing.Size(1252, 719);
            this.tpOrder.TabIndex = 1;
            this.tpOrder.Text = "Order";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.Location = new System.Drawing.Point(918, 431);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(153, 48);
            this.btnRemoveFromCart.TabIndex = 40;
            this.btnRemoveFromCart.Text = "Remove";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(1077, 431);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(168, 48);
            this.btnConfirm.TabIndex = 34;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(913, 122);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 28);
            this.label33.TabIndex = 34;
            this.label33.Text = "Cart:";
            // 
            // dtgCart
            // 
            this.dtgCart.AllowUserToAddRows = false;
            this.dtgCart.AllowUserToDeleteRows = false;
            this.dtgCart.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dtgCart.ColumnHeadersHeight = 29;
            this.dtgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgCart.Location = new System.Drawing.Point(918, 153);
            this.dtgCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCart.Name = "dtgCart";
            this.dtgCart.ReadOnly = true;
            this.dtgCart.RowHeadersWidth = 51;
            this.dtgCart.RowTemplate.Height = 24;
            this.dtgCart.Size = new System.Drawing.Size(327, 262);
            this.dtgCart.TabIndex = 34;
            // 
            // txtProductHiddenID
            // 
            this.txtProductHiddenID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductHiddenID.Location = new System.Drawing.Point(1189, 680);
            this.txtProductHiddenID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductHiddenID.MaxLength = 4;
            this.txtProductHiddenID.Name = "txtProductHiddenID";
            this.txtProductHiddenID.ReadOnly = true;
            this.txtProductHiddenID.Size = new System.Drawing.Size(56, 34);
            this.txtProductHiddenID.TabIndex = 33;
            this.txtProductHiddenID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductHiddenID.Visible = false;
            // 
            // llbOrderDetail
            // 
            this.llbOrderDetail.AutoSize = true;
            this.llbOrderDetail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbOrderDetail.Location = new System.Drawing.Point(791, 666);
            this.llbOrderDetail.Name = "llbOrderDetail";
            this.llbOrderDetail.Size = new System.Drawing.Size(216, 32);
            this.llbOrderDetail.TabIndex = 39;
            this.llbOrderDetail.TabStop = true;
            this.llbOrderDetail.Text = "View Order Detail";
            this.llbOrderDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOrderDetail_LinkClicked);
            // 
            // btnOrderRefresh
            // 
            this.btnOrderRefresh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderRefresh.Location = new System.Drawing.Point(10, 122);
            this.btnOrderRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderRefresh.Name = "btnOrderRefresh";
            this.btnOrderRefresh.Size = new System.Drawing.Size(59, 43);
            this.btnOrderRefresh.TabIndex = 38;
            this.btnOrderRefresh.Text = "↻";
            this.btnOrderRefresh.UseVisualStyleBackColor = true;
            this.btnOrderRefresh.Click += new System.EventHandler(this.btnOrderRefresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 28);
            this.label8.TabIndex = 35;
            this.label8.Text = "Order";
            // 
            // dtgOrders
            // 
            this.dtgOrders.AllowUserToAddRows = false;
            this.dtgOrders.AllowUserToDeleteRows = false;
            this.dtgOrders.BackgroundColor = System.Drawing.Color.White;
            this.dtgOrders.ColumnHeadersHeight = 29;
            this.dtgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOrderId,
            this.clOrderTotal,
            this.clStaff,
            this.clOrderDate});
            this.dtgOrders.Location = new System.Drawing.Point(76, 513);
            this.dtgOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgOrders.Name = "dtgOrders";
            this.dtgOrders.ReadOnly = true;
            this.dtgOrders.RowHeadersWidth = 51;
            this.dtgOrders.RowTemplate.Height = 24;
            this.dtgOrders.Size = new System.Drawing.Size(688, 185);
            this.dtgOrders.TabIndex = 36;
            this.dtgOrders.SelectionChanged += new System.EventHandler(this.dtgOrders_SelectionChanged);
            // 
            // clOrderId
            // 
            this.clOrderId.HeaderText = "Order ID";
            this.clOrderId.MinimumWidth = 10;
            this.clOrderId.Name = "clOrderId";
            this.clOrderId.ReadOnly = true;
            this.clOrderId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clOrderId.Width = 80;
            // 
            // clOrderTotal
            // 
            this.clOrderTotal.HeaderText = "Total Amount";
            this.clOrderTotal.MinimumWidth = 6;
            this.clOrderTotal.Name = "clOrderTotal";
            this.clOrderTotal.ReadOnly = true;
            this.clOrderTotal.Width = 125;
            // 
            // clStaff
            // 
            this.clStaff.HeaderText = "Seller ID";
            this.clStaff.MinimumWidth = 6;
            this.clStaff.Name = "clStaff";
            this.clStaff.ReadOnly = true;
            this.clStaff.Width = 125;
            // 
            // clOrderDate
            // 
            this.clOrderDate.HeaderText = "Order Date";
            this.clOrderDate.MinimumWidth = 6;
            this.clOrderDate.Name = "clOrderDate";
            this.clOrderDate.ReadOnly = true;
            this.clOrderDate.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrderedPrice);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.comboStaff);
            this.groupBox2.Controls.Add(this.btnOrderCancel);
            this.groupBox2.Controls.Add(this.lblOrderFeedback);
            this.groupBox2.Controls.Add(this.btnMinus);
            this.groupBox2.Controls.Add(this.btnPlus);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.dtgOrderMenu);
            this.groupBox2.Controls.Add(this.btnAddToCart);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtOrderedProduct);
            this.groupBox2.Location = new System.Drawing.Point(76, 122);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(830, 357);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Making Order";
            // 
            // txtOrderedPrice
            // 
            this.txtOrderedPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderedPrice.Location = new System.Drawing.Point(350, 120);
            this.txtOrderedPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderedPrice.Name = "txtOrderedPrice";
            this.txtOrderedPrice.ReadOnly = true;
            this.txtOrderedPrice.Size = new System.Drawing.Size(265, 34);
            this.txtOrderedPrice.TabIndex = 33;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(653, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(114, 28);
            this.label27.TabIndex = 32;
            this.label27.Text = "Select seller";
            // 
            // comboStaff
            // 
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(658, 59);
            this.comboStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(163, 28);
            this.comboStaff.TabIndex = 5;
            // 
            // btnOrderCancel
            // 
            this.btnOrderCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCancel.Location = new System.Drawing.Point(350, 245);
            this.btnOrderCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderCancel.Name = "btnOrderCancel";
            this.btnOrderCancel.Size = new System.Drawing.Size(108, 48);
            this.btnOrderCancel.TabIndex = 6;
            this.btnOrderCancel.Text = "Cancel";
            this.btnOrderCancel.UseVisualStyleBackColor = true;
            this.btnOrderCancel.Click += new System.EventHandler(this.btnOrderCancel_Click);
            // 
            // lblOrderFeedback
            // 
            this.lblOrderFeedback.AutoSize = true;
            this.lblOrderFeedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderFeedback.ForeColor = System.Drawing.Color.Red;
            this.lblOrderFeedback.Location = new System.Drawing.Point(345, 191);
            this.lblOrderFeedback.Name = "lblOrderFeedback";
            this.lblOrderFeedback.Size = new System.Drawing.Size(0, 28);
            this.lblOrderFeedback.TabIndex = 27;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(348, 171);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(56, 48);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(559, 171);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(56, 48);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(443, 171);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQty.MaxLength = 3;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(73, 34);
            this.txtQty.TabIndex = 2;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgOrderMenu
            // 
            this.dtgOrderMenu.AllowUserToAddRows = false;
            this.dtgOrderMenu.AllowUserToDeleteRows = false;
            this.dtgOrderMenu.BackgroundColor = System.Drawing.Color.White;
            this.dtgOrderMenu.ColumnHeadersHeight = 29;
            this.dtgOrderMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgOrderMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOrderProductID,
            this.clOrderProductName,
            this.clOrderPrice});
            this.dtgOrderMenu.Location = new System.Drawing.Point(8, 30);
            this.dtgOrderMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgOrderMenu.Name = "dtgOrderMenu";
            this.dtgOrderMenu.ReadOnly = true;
            this.dtgOrderMenu.RowHeadersWidth = 51;
            this.dtgOrderMenu.RowTemplate.Height = 24;
            this.dtgOrderMenu.Size = new System.Drawing.Size(310, 263);
            this.dtgOrderMenu.TabIndex = 23;
            this.dtgOrderMenu.SelectionChanged += new System.EventHandler(this.dtgOrderMenu_SelectionChanged);
            // 
            // clOrderProductID
            // 
            this.clOrderProductID.HeaderText = "ID";
            this.clOrderProductID.MinimumWidth = 6;
            this.clOrderProductID.Name = "clOrderProductID";
            this.clOrderProductID.ReadOnly = true;
            this.clOrderProductID.Width = 50;
            // 
            // clOrderProductName
            // 
            this.clOrderProductName.HeaderText = "Product Name";
            this.clOrderProductName.MinimumWidth = 10;
            this.clOrderProductName.Name = "clOrderProductName";
            this.clOrderProductName.ReadOnly = true;
            this.clOrderProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clOrderProductName.Width = 120;
            // 
            // clOrderPrice
            // 
            this.clOrderPrice.HeaderText = "Price";
            this.clOrderPrice.MinimumWidth = 6;
            this.clOrderPrice.Name = "clOrderPrice";
            this.clOrderPrice.ReadOnly = true;
            this.clOrderPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clOrderPrice.Visible = false;
            this.clOrderPrice.Width = 125;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(465, 245);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(153, 48);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Name and Price";
            // 
            // txtOrderedProduct
            // 
            this.txtOrderedProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderedProduct.Location = new System.Drawing.Point(350, 59);
            this.txtOrderedProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderedProduct.Name = "txtOrderedProduct";
            this.txtOrderedProduct.ReadOnly = true;
            this.txtOrderedProduct.Size = new System.Drawing.Size(265, 34);
            this.txtOrderedProduct.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(586, 81);
            this.label6.TabIndex = 34;
            this.label6.Text = "Order Management";
            // 
            // tpInventory
            // 
            this.tpInventory.BackColor = System.Drawing.Color.LightBlue;
            this.tpInventory.Controls.Add(this.groupBox3);
            this.tpInventory.Controls.Add(this.dtgInventory);
            this.tpInventory.Controls.Add(this.label13);
            this.tpInventory.Location = new System.Drawing.Point(4, 29);
            this.tpInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tpInventory.Name = "tpInventory";
            this.tpInventory.Padding = new System.Windows.Forms.Padding(4);
            this.tpInventory.Size = new System.Drawing.Size(1252, 719);
            this.tpInventory.TabIndex = 2;
            this.tpInventory.Text = "Inventory";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtInventoryID);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtInventorySupplier);
            this.groupBox3.Controls.Add(this.btnInventoryDelete);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtInventoryReorder);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtInventoryUnit);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtInventoryQty);
            this.groupBox3.Controls.Add(this.btnInventoryCancel);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtInventoryName);
            this.groupBox3.Controls.Add(this.btnInventorySave);
            this.groupBox3.Location = new System.Drawing.Point(8, 161);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1231, 295);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add/Edit Inventory";
            // 
            // txtInventoryID
            // 
            this.txtInventoryID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryID.Location = new System.Drawing.Point(1179, 14);
            this.txtInventoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventoryID.Name = "txtInventoryID";
            this.txtInventoryID.ReadOnly = true;
            this.txtInventoryID.Size = new System.Drawing.Size(45, 34);
            this.txtInventoryID.TabIndex = 17;
            this.txtInventoryID.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(196, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 28);
            this.label15.TabIndex = 16;
            this.label15.Text = "Supplier ID";
            // 
            // txtInventorySupplier
            // 
            this.txtInventorySupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventorySupplier.Location = new System.Drawing.Point(319, 153);
            this.txtInventorySupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventorySupplier.Name = "txtInventorySupplier";
            this.txtInventorySupplier.Size = new System.Drawing.Size(187, 34);
            this.txtInventorySupplier.TabIndex = 5;
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryDelete.Location = new System.Drawing.Point(319, 214);
            this.btnInventoryDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.Size = new System.Drawing.Size(66, 48);
            this.btnInventoryDelete.TabIndex = 6;
            this.btnInventoryDelete.Text = "🗑";
            this.btnInventoryDelete.UseVisualStyleBackColor = true;
            this.btnInventoryDelete.Click += new System.EventHandler(this.btnInventoryDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(659, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Recorder level";
            // 
            // txtInventoryReorder
            // 
            this.txtInventoryReorder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryReorder.Location = new System.Drawing.Point(809, 97);
            this.txtInventoryReorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventoryReorder.Name = "txtInventoryReorder";
            this.txtInventoryReorder.Size = new System.Drawing.Size(187, 34);
            this.txtInventoryReorder.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(752, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "Unit";
            // 
            // txtInventoryUnit
            // 
            this.txtInventoryUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryUnit.Location = new System.Drawing.Point(809, 39);
            this.txtInventoryUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventoryUnit.Name = "txtInventoryUnit";
            this.txtInventoryUnit.Size = new System.Drawing.Size(187, 34);
            this.txtInventoryUnit.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 28);
            this.label11.TabIndex = 10;
            this.label11.Text = "Quantity";
            // 
            // txtInventoryQty
            // 
            this.txtInventoryQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryQty.Location = new System.Drawing.Point(319, 94);
            this.txtInventoryQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventoryQty.Name = "txtInventoryQty";
            this.txtInventoryQty.Size = new System.Drawing.Size(187, 34);
            this.txtInventoryQty.TabIndex = 2;
            // 
            // btnInventoryCancel
            // 
            this.btnInventoryCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryCancel.Location = new System.Drawing.Point(772, 214);
            this.btnInventoryCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryCancel.Name = "btnInventoryCancel";
            this.btnInventoryCancel.Size = new System.Drawing.Size(104, 48);
            this.btnInventoryCancel.TabIndex = 7;
            this.btnInventoryCancel.Text = "Cancel";
            this.btnInventoryCancel.UseVisualStyleBackColor = true;
            this.btnInventoryCancel.Click += new System.EventHandler(this.btnInventoryCancel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(171, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 28);
            this.label12.TabIndex = 7;
            this.label12.Text = "Product name";
            // 
            // txtInventoryName
            // 
            this.txtInventoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryName.Location = new System.Drawing.Point(319, 36);
            this.txtInventoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventoryName.Name = "txtInventoryName";
            this.txtInventoryName.Size = new System.Drawing.Size(187, 34);
            this.txtInventoryName.TabIndex = 1;
            // 
            // btnInventorySave
            // 
            this.btnInventorySave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventorySave.Location = new System.Drawing.Point(881, 214);
            this.btnInventorySave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventorySave.Name = "btnInventorySave";
            this.btnInventorySave.Size = new System.Drawing.Size(145, 48);
            this.btnInventorySave.TabIndex = 8;
            this.btnInventorySave.Text = "Save";
            this.btnInventorySave.UseVisualStyleBackColor = true;
            this.btnInventorySave.Click += new System.EventHandler(this.btnInventorySave_Click);
            // 
            // dtgInventory
            // 
            this.dtgInventory.AllowUserToAddRows = false;
            this.dtgInventory.AllowUserToDeleteRows = false;
            this.dtgInventory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgInventory.ColumnHeadersHeight = 29;
            this.dtgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clInventoryID,
            this.clInventoryName,
            this.clInventoryQty,
            this.clInventoryUnit,
            this.clReorder,
            this.clSupplier});
            this.dtgInventory.Location = new System.Drawing.Point(188, 489);
            this.dtgInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgInventory.Name = "dtgInventory";
            this.dtgInventory.ReadOnly = true;
            this.dtgInventory.RowHeadersWidth = 51;
            this.dtgInventory.RowTemplate.Height = 24;
            this.dtgInventory.Size = new System.Drawing.Size(876, 214);
            this.dtgInventory.TabIndex = 25;
            this.dtgInventory.SelectionChanged += new System.EventHandler(this.dtgInventory_SelectionChanged);
            // 
            // clInventoryID
            // 
            this.clInventoryID.HeaderText = "ID";
            this.clInventoryID.MinimumWidth = 6;
            this.clInventoryID.Name = "clInventoryID";
            this.clInventoryID.ReadOnly = true;
            this.clInventoryID.Width = 50;
            // 
            // clInventoryName
            // 
            this.clInventoryName.HeaderText = "Item Name";
            this.clInventoryName.MinimumWidth = 10;
            this.clInventoryName.Name = "clInventoryName";
            this.clInventoryName.ReadOnly = true;
            this.clInventoryName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clInventoryName.Width = 110;
            // 
            // clInventoryQty
            // 
            this.clInventoryQty.HeaderText = "Quantity";
            this.clInventoryQty.MinimumWidth = 6;
            this.clInventoryQty.Name = "clInventoryQty";
            this.clInventoryQty.ReadOnly = true;
            this.clInventoryQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clInventoryQty.Width = 125;
            // 
            // clInventoryUnit
            // 
            this.clInventoryUnit.HeaderText = "Unit";
            this.clInventoryUnit.MinimumWidth = 6;
            this.clInventoryUnit.Name = "clInventoryUnit";
            this.clInventoryUnit.ReadOnly = true;
            this.clInventoryUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clInventoryUnit.Width = 125;
            // 
            // clReorder
            // 
            this.clReorder.HeaderText = "Reorder Level";
            this.clReorder.MinimumWidth = 10;
            this.clReorder.Name = "clReorder";
            this.clReorder.ReadOnly = true;
            this.clReorder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clReorder.Width = 125;
            // 
            // clSupplier
            // 
            this.clSupplier.HeaderText = "Supplier ID";
            this.clSupplier.MinimumWidth = 6;
            this.clSupplier.Name = "clSupplier";
            this.clSupplier.ReadOnly = true;
            this.clSupplier.Width = 125;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(253, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(697, 81);
            this.label13.TabIndex = 24;
            this.label13.Text = "Inventory Management";
            // 
            // tpUser
            // 
            this.tpUser.BackColor = System.Drawing.Color.Turquoise;
            this.tpUser.Controls.Add(this.txtUserID);
            this.tpUser.Controls.Add(this.groupBox4);
            this.tpUser.Controls.Add(this.dtgUsers);
            this.tpUser.Controls.Add(this.label29);
            this.tpUser.Location = new System.Drawing.Point(4, 29);
            this.tpUser.Margin = new System.Windows.Forms.Padding(4);
            this.tpUser.Name = "tpUser";
            this.tpUser.Padding = new System.Windows.Forms.Padding(4);
            this.tpUser.Size = new System.Drawing.Size(1252, 719);
            this.tpUser.TabIndex = 3;
            this.tpUser.Text = "User";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(1207, 683);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(42, 34);
            this.txtUserID.TabIndex = 27;
            this.txtUserID.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbUserPw);
            this.groupBox4.Controls.Add(this.txtRole);
            this.groupBox4.Controls.Add(this.rbtnOther);
            this.groupBox4.Controls.Add(this.rbtnFemale);
            this.groupBox4.Controls.Add(this.rbtnMale);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtSetPw);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtSetusername);
            this.groupBox4.Controls.Add(this.btnUserDelete);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtContact);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.btnUserCancel);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.txtFullname);
            this.groupBox4.Controls.Add(this.btnUserSave);
            this.groupBox4.Location = new System.Drawing.Point(59, 84);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1131, 357);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add/Edit User";
            // 
            // cbUserPw
            // 
            this.cbUserPw.AutoSize = true;
            this.cbUserPw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserPw.ForeColor = System.Drawing.Color.Black;
            this.cbUserPw.Location = new System.Drawing.Point(1051, 112);
            this.cbUserPw.Name = "cbUserPw";
            this.cbUserPw.Size = new System.Drawing.Size(61, 32);
            this.cbUserPw.TabIndex = 26;
            this.cbUserPw.Text = "👁️";
            this.cbUserPw.UseVisualStyleBackColor = true;
            this.cbUserPw.CheckedChanged += new System.EventHandler(this.cbUserPw_CheckedChanged);
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(781, 155);
            this.txtRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(265, 34);
            this.txtRole.TabIndex = 9;
            // 
            // rbtnOther
            // 
            this.rbtnOther.AutoSize = true;
            this.rbtnOther.Location = new System.Drawing.Point(393, 108);
            this.rbtnOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(70, 24);
            this.rbtnOther.TabIndex = 4;
            this.rbtnOther.TabStop = true;
            this.rbtnOther.Text = "Other";
            this.rbtnOther.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(285, 108);
            this.rbtnFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(80, 24);
            this.rbtnFemale.TabIndex = 3;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(191, 108);
            this.rbtnMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(64, 24);
            this.rbtnMale.TabIndex = 2;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(80, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 28);
            this.label17.TabIndex = 20;
            this.label17.Text = "Gender";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(669, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 28);
            this.label18.TabIndex = 18;
            this.label18.Text = "Password";
            // 
            // txtSetPw
            // 
            this.txtSetPw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetPw.Location = new System.Drawing.Point(780, 102);
            this.txtSetPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSetPw.MaxLength = 20;
            this.txtSetPw.Name = "txtSetPw";
            this.txtSetPw.Size = new System.Drawing.Size(265, 34);
            this.txtSetPw.TabIndex = 8;
            this.txtSetPw.UseSystemPasswordChar = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(665, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 28);
            this.label19.TabIndex = 16;
            this.label19.Text = "Username";
            // 
            // txtSetusername
            // 
            this.txtSetusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetusername.Location = new System.Drawing.Point(780, 43);
            this.txtSetusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSetusername.Name = "txtSetusername";
            this.txtSetusername.Size = new System.Drawing.Size(265, 34);
            this.txtSetusername.TabIndex = 7;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDelete.Location = new System.Drawing.Point(23, 287);
            this.btnUserDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(56, 48);
            this.btnUserDelete.TabIndex = 12;
            this.btnUserDelete.Text = "🗑";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 216);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 28);
            this.label20.TabIndex = 14;
            this.label20.Text = "Contact Number";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(191, 212);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContact.MaxLength = 10;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(265, 34);
            this.txtContact.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(80, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 28);
            this.label21.TabIndex = 12;
            this.label21.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(191, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 34);
            this.txtEmail.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(712, 155);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 28);
            this.label22.TabIndex = 10;
            this.label22.Text = "Role";
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCancel.Location = new System.Drawing.Point(780, 216);
            this.btnUserCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(116, 48);
            this.btnUserCancel.TabIndex = 10;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = true;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(80, 48);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(96, 28);
            this.label28.TabIndex = 20;
            this.label28.Text = "Full name";
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(191, 46);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(265, 34);
            this.txtFullname.TabIndex = 1;
            // 
            // btnUserSave
            // 
            this.btnUserSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSave.Location = new System.Drawing.Point(901, 216);
            this.btnUserSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(145, 48);
            this.btnUserSave.TabIndex = 11;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.AllowUserToDeleteRows = false;
            this.dtgUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgUsers.ColumnHeadersHeight = 29;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.clFullName,
            this.clGender,
            this.clRole,
            this.clEmail,
            this.clUserContact,
            this.clUsername,
            this.clPw});
            this.dtgUsers.Location = new System.Drawing.Point(117, 447);
            this.dtgUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            this.dtgUsers.RowHeadersWidth = 51;
            this.dtgUsers.RowTemplate.Height = 24;
            this.dtgUsers.Size = new System.Drawing.Size(1012, 241);
            this.dtgUsers.TabIndex = 31;
            this.dtgUsers.SelectionChanged += new System.EventHandler(this.dtgUsers_SelectionChanged);
            // 
            // UserID
            // 
            this.UserID.HeaderText = "ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 50;
            // 
            // clFullName
            // 
            this.clFullName.HeaderText = "Full Name";
            this.clFullName.MinimumWidth = 10;
            this.clFullName.Name = "clFullName";
            this.clFullName.ReadOnly = true;
            this.clFullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clFullName.Width = 110;
            // 
            // clGender
            // 
            this.clGender.HeaderText = "Gender";
            this.clGender.MinimumWidth = 6;
            this.clGender.Name = "clGender";
            this.clGender.ReadOnly = true;
            this.clGender.Width = 90;
            // 
            // clRole
            // 
            this.clRole.HeaderText = "Role";
            this.clRole.MinimumWidth = 6;
            this.clRole.Name = "clRole";
            this.clRole.ReadOnly = true;
            this.clRole.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clRole.Width = 125;
            // 
            // clEmail
            // 
            this.clEmail.HeaderText = "Email";
            this.clEmail.MinimumWidth = 6;
            this.clEmail.Name = "clEmail";
            this.clEmail.ReadOnly = true;
            this.clEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clEmail.Width = 150;
            // 
            // clUserContact
            // 
            this.clUserContact.HeaderText = "Contact";
            this.clUserContact.MinimumWidth = 10;
            this.clUserContact.Name = "clUserContact";
            this.clUserContact.ReadOnly = true;
            this.clUserContact.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clUserContact.Width = 110;
            // 
            // clUsername
            // 
            this.clUsername.HeaderText = "Username";
            this.clUsername.MinimumWidth = 6;
            this.clUsername.Name = "clUsername";
            this.clUsername.ReadOnly = true;
            this.clUsername.Width = 110;
            // 
            // clPw
            // 
            this.clPw.HeaderText = "Password";
            this.clPw.MinimumWidth = 6;
            this.clPw.Name = "clPw";
            this.clPw.ReadOnly = true;
            this.clPw.Width = 125;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(343, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(549, 81);
            this.label29.TabIndex = 30;
            this.label29.Text = "User Management";
            // 
            // tpReport
            // 
            this.tpReport.BackColor = System.Drawing.Color.Lavender;
            this.tpReport.Controls.Add(this.btnToday);
            this.tpReport.Controls.Add(this.dtpSaleReport);
            this.tpReport.Controls.Add(this.label14);
            this.tpReport.Controls.Add(this.dtgOutstanding);
            this.tpReport.Controls.Add(this.btnRefreshReport);
            this.tpReport.Controls.Add(this.label24);
            this.tpReport.Controls.Add(this.label25);
            this.tpReport.Controls.Add(this.dtgPopularItems);
            this.tpReport.Controls.Add(this.dtgSalesReport);
            this.tpReport.Controls.Add(this.label23);
            this.tpReport.Location = new System.Drawing.Point(4, 29);
            this.tpReport.Margin = new System.Windows.Forms.Padding(4);
            this.tpReport.Name = "tpReport";
            this.tpReport.Padding = new System.Windows.Forms.Padding(4);
            this.tpReport.Size = new System.Drawing.Size(1252, 719);
            this.tpReport.TabIndex = 4;
            this.tpReport.Text = "Report";
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(313, 195);
            this.btnToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(106, 28);
            this.btnToday.TabIndex = 43;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dtpSaleReport
            // 
            this.dtpSaleReport.CustomFormat = "dd/MMM/yyyy";
            this.dtpSaleReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaleReport.Location = new System.Drawing.Point(27, 194);
            this.dtpSaleReport.Name = "dtpSaleReport";
            this.dtpSaleReport.Size = new System.Drawing.Size(156, 27);
            this.dtpSaleReport.TabIndex = 42;
            this.dtpSaleReport.ValueChanged += new System.EventHandler(this.dtpSaleReport_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label14.Location = new System.Drawing.Point(883, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(339, 54);
            this.label14.TabIndex = 41;
            this.label14.Text = "OutStanding Staff";
            // 
            // dtgOutstanding
            // 
            this.dtgOutstanding.AllowUserToAddRows = false;
            this.dtgOutstanding.AllowUserToDeleteRows = false;
            this.dtgOutstanding.BackgroundColor = System.Drawing.Color.White;
            this.dtgOutstanding.ColumnHeadersHeight = 29;
            this.dtgOutstanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgOutstanding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colStaffName,
            this.colTotalSold});
            this.dtgOutstanding.Location = new System.Drawing.Point(885, 226);
            this.dtgOutstanding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgOutstanding.Name = "dtgOutstanding";
            this.dtgOutstanding.ReadOnly = true;
            this.dtgOutstanding.RowHeadersWidth = 51;
            this.dtgOutstanding.RowTemplate.Height = 24;
            this.dtgOutstanding.Size = new System.Drawing.Size(341, 478);
            this.dtgOutstanding.TabIndex = 40;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 50;
            // 
            // colStaffName
            // 
            this.colStaffName.HeaderText = "Name";
            this.colStaffName.MinimumWidth = 10;
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.ReadOnly = true;
            this.colStaffName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStaffName.Width = 125;
            // 
            // colTotalSold
            // 
            this.colTotalSold.HeaderText = "Total Sales";
            this.colTotalSold.MinimumWidth = 6;
            this.colTotalSold.Name = "colTotalSold";
            this.colTotalSold.ReadOnly = true;
            this.colTotalSold.Width = 125;
            // 
            // btnRefreshReport
            // 
            this.btnRefreshReport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshReport.Location = new System.Drawing.Point(7, 118);
            this.btnRefreshReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshReport.Name = "btnRefreshReport";
            this.btnRefreshReport.Size = new System.Drawing.Size(59, 43);
            this.btnRefreshReport.TabIndex = 39;
            this.btnRefreshReport.Text = "↻";
            this.btnRefreshReport.UseVisualStyleBackColor = true;
            this.btnRefreshReport.Click += new System.EventHandler(this.btnRefreshReport_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label24.Location = new System.Drawing.Point(490, 125);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(324, 54);
            this.label24.TabIndex = 35;
            this.label24.Text = "Popular Products";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label25.Location = new System.Drawing.Point(80, 123);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(242, 54);
            this.label25.TabIndex = 34;
            this.label25.Text = "Sale Reports";
            // 
            // dtgPopularItems
            // 
            this.dtgPopularItems.AllowUserToAddRows = false;
            this.dtgPopularItems.AllowUserToDeleteRows = false;
            this.dtgPopularItems.BackgroundColor = System.Drawing.Color.White;
            this.dtgPopularItems.ColumnHeadersHeight = 29;
            this.dtgPopularItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPopularItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReportProductID,
            this.colPopularProducts,
            this.colTotalQty});
            this.dtgPopularItems.Location = new System.Drawing.Point(467, 226);
            this.dtgPopularItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgPopularItems.Name = "dtgPopularItems";
            this.dtgPopularItems.ReadOnly = true;
            this.dtgPopularItems.RowHeadersWidth = 51;
            this.dtgPopularItems.RowTemplate.Height = 24;
            this.dtgPopularItems.Size = new System.Drawing.Size(372, 478);
            this.dtgPopularItems.TabIndex = 33;
            // 
            // colReportProductID
            // 
            this.colReportProductID.HeaderText = "Product ID";
            this.colReportProductID.MinimumWidth = 6;
            this.colReportProductID.Name = "colReportProductID";
            this.colReportProductID.ReadOnly = true;
            this.colReportProductID.Visible = false;
            this.colReportProductID.Width = 125;
            // 
            // colPopularProducts
            // 
            this.colPopularProducts.HeaderText = "Product Name";
            this.colPopularProducts.MinimumWidth = 10;
            this.colPopularProducts.Name = "colPopularProducts";
            this.colPopularProducts.ReadOnly = true;
            this.colPopularProducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPopularProducts.Width = 150;
            // 
            // colTotalQty
            // 
            this.colTotalQty.HeaderText = "Quantity";
            this.colTotalQty.MinimumWidth = 6;
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.ReadOnly = true;
            this.colTotalQty.Width = 125;
            // 
            // dtgSalesReport
            // 
            this.dtgSalesReport.AllowUserToAddRows = false;
            this.dtgSalesReport.AllowUserToDeleteRows = false;
            this.dtgSalesReport.BackgroundColor = System.Drawing.Color.White;
            this.dtgSalesReport.ColumnHeadersHeight = 29;
            this.dtgSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReportID,
            this.clReportDate,
            this.clReportTotalAmount});
            this.dtgSalesReport.Location = new System.Drawing.Point(27, 226);
            this.dtgSalesReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgSalesReport.Name = "dtgSalesReport";
            this.dtgSalesReport.ReadOnly = true;
            this.dtgSalesReport.RowHeadersWidth = 51;
            this.dtgSalesReport.RowTemplate.Height = 24;
            this.dtgSalesReport.Size = new System.Drawing.Size(392, 478);
            this.dtgSalesReport.TabIndex = 32;
            // 
            // colReportID
            // 
            this.colReportID.HeaderText = "ID";
            this.colReportID.MinimumWidth = 6;
            this.colReportID.Name = "colReportID";
            this.colReportID.ReadOnly = true;
            this.colReportID.Visible = false;
            this.colReportID.Width = 125;
            // 
            // clReportDate
            // 
            this.clReportDate.HeaderText = "Date";
            this.clReportDate.MinimumWidth = 10;
            this.clReportDate.Name = "clReportDate";
            this.clReportDate.ReadOnly = true;
            this.clReportDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clReportDate.Width = 150;
            // 
            // clReportTotalAmount
            // 
            this.clReportTotalAmount.HeaderText = "Total Amount";
            this.clReportTotalAmount.MinimumWidth = 6;
            this.clReportTotalAmount.Name = "clReportTotalAmount";
            this.clReportTotalAmount.ReadOnly = true;
            this.clReportTotalAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clReportTotalAmount.Width = 125;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(477, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(254, 81);
            this.label23.TabIndex = 31;
            this.label23.Text = "Reports";
            // 
            // tpSupplier
            // 
            this.tpSupplier.BackColor = System.Drawing.Color.LightGray;
            this.tpSupplier.Controls.Add(this.txtSupplierID);
            this.tpSupplier.Controls.Add(this.dtgSupplier);
            this.tpSupplier.Controls.Add(this.label32);
            this.tpSupplier.Controls.Add(this.groupBox5);
            this.tpSupplier.Location = new System.Drawing.Point(4, 29);
            this.tpSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.tpSupplier.Name = "tpSupplier";
            this.tpSupplier.Padding = new System.Windows.Forms.Padding(4);
            this.tpSupplier.Size = new System.Drawing.Size(1252, 719);
            this.tpSupplier.TabIndex = 6;
            this.tpSupplier.Text = "Supplier";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierID.Location = new System.Drawing.Point(1201, 680);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(44, 34);
            this.txtSupplierID.TabIndex = 27;
            this.txtSupplierID.Visible = false;
            // 
            // dtgSupplier
            // 
            this.dtgSupplier.AllowUserToAddRows = false;
            this.dtgSupplier.AllowUserToDeleteRows = false;
            this.dtgSupplier.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgSupplier.ColumnHeadersHeight = 29;
            this.dtgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSupplierID,
            this.clSupplierName,
            this.clSupplierContact,
            this.clSupplierEmail,
            this.clSupplierAddress});
            this.dtgSupplier.Location = new System.Drawing.Point(252, 447);
            this.dtgSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgSupplier.Name = "dtgSupplier";
            this.dtgSupplier.ReadOnly = true;
            this.dtgSupplier.RowHeadersWidth = 51;
            this.dtgSupplier.RowTemplate.Height = 24;
            this.dtgSupplier.Size = new System.Drawing.Size(726, 214);
            this.dtgSupplier.TabIndex = 32;
            this.dtgSupplier.SelectionChanged += new System.EventHandler(this.dtgSupplier_SelectionChanged);
            // 
            // clSupplierID
            // 
            this.clSupplierID.HeaderText = "ID";
            this.clSupplierID.MinimumWidth = 6;
            this.clSupplierID.Name = "clSupplierID";
            this.clSupplierID.ReadOnly = true;
            this.clSupplierID.Width = 50;
            // 
            // clSupplierName
            // 
            this.clSupplierName.HeaderText = "Name";
            this.clSupplierName.MinimumWidth = 10;
            this.clSupplierName.Name = "clSupplierName";
            this.clSupplierName.ReadOnly = true;
            this.clSupplierName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clSupplierName.Width = 110;
            // 
            // clSupplierContact
            // 
            this.clSupplierContact.HeaderText = "Contact";
            this.clSupplierContact.MinimumWidth = 6;
            this.clSupplierContact.Name = "clSupplierContact";
            this.clSupplierContact.ReadOnly = true;
            this.clSupplierContact.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clSupplierContact.Width = 125;
            // 
            // clSupplierEmail
            // 
            this.clSupplierEmail.HeaderText = "Email";
            this.clSupplierEmail.MinimumWidth = 6;
            this.clSupplierEmail.Name = "clSupplierEmail";
            this.clSupplierEmail.ReadOnly = true;
            this.clSupplierEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clSupplierEmail.Width = 125;
            // 
            // clSupplierAddress
            // 
            this.clSupplierAddress.HeaderText = "Address";
            this.clSupplierAddress.MinimumWidth = 10;
            this.clSupplierAddress.Name = "clSupplierAddress";
            this.clSupplierAddress.ReadOnly = true;
            this.clSupplierAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clSupplierAddress.Width = 125;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(298, 22);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(658, 81);
            this.label32.TabIndex = 31;
            this.label32.Text = "Supplier Management";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSupplierDelete);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.txtSupplierAddress);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.txtSupplierEmail);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtSupplierContact);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtSupplierName);
            this.groupBox5.Controls.Add(this.btnSupplierCancel);
            this.groupBox5.Controls.Add(this.btnSupplierSave);
            this.groupBox5.Location = new System.Drawing.Point(97, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1055, 263);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Supplier";
            // 
            // btnSupplierDelete
            // 
            this.btnSupplierDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierDelete.Location = new System.Drawing.Point(180, 173);
            this.btnSupplierDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupplierDelete.Name = "btnSupplierDelete";
            this.btnSupplierDelete.Size = new System.Drawing.Size(56, 48);
            this.btnSupplierDelete.TabIndex = 5;
            this.btnSupplierDelete.Text = "🗑";
            this.btnSupplierDelete.UseVisualStyleBackColor = true;
            this.btnSupplierDelete.Click += new System.EventHandler(this.btnSupplierDelete_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(581, 90);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(82, 28);
            this.label30.TabIndex = 26;
            this.label30.Text = "Address";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddress.Location = new System.Drawing.Point(692, 88);
            this.txtSupplierAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierAddress.MaxLength = 20;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(265, 34);
            this.txtSupplierAddress.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(577, 29);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 28);
            this.label31.TabIndex = 25;
            this.label31.Text = "Email";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierEmail.Location = new System.Drawing.Point(692, 29);
            this.txtSupplierEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(265, 34);
            this.txtSupplierEmail.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(69, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 28);
            this.label16.TabIndex = 22;
            this.label16.Text = "Contact";
            // 
            // txtSupplierContact
            // 
            this.txtSupplierContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierContact.Location = new System.Drawing.Point(180, 92);
            this.txtSupplierContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierContact.MaxLength = 10;
            this.txtSupplierContact.Name = "txtSupplierContact";
            this.txtSupplierContact.Size = new System.Drawing.Size(265, 34);
            this.txtSupplierContact.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(65, 33);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 28);
            this.label26.TabIndex = 21;
            this.label26.Text = "Name";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(180, 33);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(265, 34);
            this.txtSupplierName.TabIndex = 1;
            // 
            // btnSupplierCancel
            // 
            this.btnSupplierCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierCancel.Location = new System.Drawing.Point(692, 173);
            this.btnSupplierCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupplierCancel.Name = "btnSupplierCancel";
            this.btnSupplierCancel.Size = new System.Drawing.Size(114, 48);
            this.btnSupplierCancel.TabIndex = 6;
            this.btnSupplierCancel.Text = "Cancel";
            this.btnSupplierCancel.UseVisualStyleBackColor = true;
            this.btnSupplierCancel.Click += new System.EventHandler(this.btnSupplierCancel_Click);
            // 
            // btnSupplierSave
            // 
            this.btnSupplierSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierSave.Location = new System.Drawing.Point(812, 173);
            this.btnSupplierSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupplierSave.Name = "btnSupplierSave";
            this.btnSupplierSave.Size = new System.Drawing.Size(145, 48);
            this.btnSupplierSave.TabIndex = 7;
            this.btnSupplierSave.Text = "Save";
            this.btnSupplierSave.UseVisualStyleBackColor = true;
            this.btnSupplierSave.Click += new System.EventHandler(this.btnSupplierSave_Click);
            // 
            // nU_CafeDBDataSet
            // 
            this.nU_CafeDBDataSet.DataSetName = "NU_CafeDBDataSet";
            this.nU_CafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.nU_CafeDBDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.MainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.MainTab.ResumeLayout(false);
            this.tpMenu.ResumeLayout(false);
            this.tpMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).EndInit();
            this.tpOrder.ResumeLayout(false);
            this.tpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderMenu)).EndInit();
            this.tpInventory.ResumeLayout(false);
            this.tpInventory.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventory)).EndInit();
            this.tpUser.ResumeLayout(false);
            this.tpUser.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.tpReport.ResumeLayout(false);
            this.tpReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOutstanding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPopularItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalesReport)).EndInit();
            this.tpSupplier.ResumeLayout(false);
            this.tpSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSupplier)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nU_CafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void DtgMenu_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.TabPage tpOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnMenuCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnMenuSave;
        private System.Windows.Forms.DataGridView dtgMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrderRefresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgOrders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboStaff;
        private System.Windows.Forms.Button btnOrderCancel;
        private System.Windows.Forms.Label lblOrderFeedback;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridView dtgOrderMenu;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderedProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpInventory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInventoryDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInventoryReorder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInventoryUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInventoryQty;
        private System.Windows.Forms.Button btnInventoryCancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtInventoryName;
        private System.Windows.Forms.Button btnInventorySave;
        private System.Windows.Forms.DataGridView dtgInventory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tpUser;
        private System.Windows.Forms.TabPage tpReport;
        private System.Windows.Forms.TabPage tpSupplier;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnOther;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSetPw;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSetusername;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dtgPopularItems;
        private System.Windows.Forms.DataGridView dtgSalesReport;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.LinkLabel llbOrderDetail;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.CheckBox cbIsAvailable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtInventorySupplier;
        private System.Windows.Forms.TextBox txtInventoryID;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.CheckBox cbUserPw;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSupplierContact;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnSupplierCancel;
        private System.Windows.Forms.Button btnSupplierSave;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSupplierDelete;
        private System.Windows.Forms.DataGridView dtgSupplier;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPw;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupplierContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupplierEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInventoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInventoryQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInventoryUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderDate;
        private NU_CafeDBDataSet nU_CafeDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NU_CafeDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TextBox txtProductHiddenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReportTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPopularProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalQty;
        private System.Windows.Forms.Button btnRefreshReport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dtgOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalSold;
        private System.Windows.Forms.DateTimePicker dtpSaleReport;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dtgCart;
        private System.Windows.Forms.TextBox txtOrderedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderPrice;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnConfirm;
    }
}