namespace BdProject.UI
{
    partial class frmPurchaseAndSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlDeaCust = new System.Windows.Forms.Panel();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblBilldate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDeaCustTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblProductSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
            this.lblDGVTitle = new System.Windows.Forms.Label();
            this.pnlCalculation = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtGrandtotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblcalculationTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.pnlDeaCust.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
            this.pnlCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 58);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1423, 9);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 43);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.White;
            this.lblTop.Location = new System.Drawing.Point(712, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(274, 32);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "PURCHASE AND SALES";
            // 
            // pnlDeaCust
            // 
            this.pnlDeaCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.pnlDeaCust.Controls.Add(this.dtpBillDate);
            this.pnlDeaCust.Controls.Add(this.txtName);
            this.pnlDeaCust.Controls.Add(this.txtEmail);
            this.pnlDeaCust.Controls.Add(this.txtContact);
            this.pnlDeaCust.Controls.Add(this.txtAddress);
            this.pnlDeaCust.Controls.Add(this.txtSearch);
            this.pnlDeaCust.Controls.Add(this.lblContact);
            this.pnlDeaCust.Controls.Add(this.lblBilldate);
            this.pnlDeaCust.Controls.Add(this.lblEmail);
            this.pnlDeaCust.Controls.Add(this.lblName);
            this.pnlDeaCust.Controls.Add(this.lblAddress);
            this.pnlDeaCust.Controls.Add(this.lblSearch);
            this.pnlDeaCust.Controls.Add(this.lblDeaCustTitle);
            this.pnlDeaCust.Location = new System.Drawing.Point(11, 65);
            this.pnlDeaCust.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDeaCust.Name = "pnlDeaCust";
            this.pnlDeaCust.Size = new System.Drawing.Size(1451, 196);
            this.pnlDeaCust.TabIndex = 4;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Location = new System.Drawing.Point(998, 77);
            this.dtpBillDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(235, 34);
            this.dtpBillDate.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(88, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 34);
            this.txtName.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(408, 50);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 34);
            this.txtEmail.TabIndex = 11;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(408, 95);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(235, 34);
            this.txtContact.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(741, 45);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(235, 127);
            this.txtAddress.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(88, 50);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 34);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContact.Location = new System.Drawing.Point(331, 95);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(80, 28);
            this.lblContact.TabIndex = 8;
            this.lblContact.Text = "Contact";
            // 
            // lblBilldate
            // 
            this.lblBilldate.AutoSize = true;
            this.lblBilldate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilldate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBilldate.Location = new System.Drawing.Point(993, 45);
            this.lblBilldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBilldate.Name = "lblBilldate";
            this.lblBilldate.Size = new System.Drawing.Size(84, 28);
            this.lblBilldate.TabIndex = 5;
            this.lblBilldate.Text = "Bill Date";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(341, 53);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 28);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Location = new System.Drawing.Point(17, 95);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddress.Location = new System.Drawing.Point(651, 53);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 28);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSearch.Location = new System.Drawing.Point(23, 50);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 28);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // lblDeaCustTitle
            // 
            this.lblDeaCustTitle.AutoSize = true;
            this.lblDeaCustTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaCustTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeaCustTitle.Location = new System.Drawing.Point(17, 17);
            this.lblDeaCustTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeaCustTitle.Name = "lblDeaCustTitle";
            this.lblDeaCustTitle.Size = new System.Drawing.Size(283, 28);
            this.lblDeaCustTitle.TabIndex = 0;
            this.lblDeaCustTitle.Text = "Dealer and Customer Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1306, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtRate);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.txtInventory);
            this.panel2.Controls.Add(this.txtSearchProduct);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.lblInventory);
            this.panel2.Controls.Add(this.lblRate);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.lblProductSearch);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(11, 269);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1451, 86);
            this.panel2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(1555, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 63);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(845, 31);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(173, 26);
            this.txtRate.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(346, 31);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(173, 26);
            this.txtProductName.TabIndex = 9;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(1073, 28);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(173, 26);
            this.txtQty.TabIndex = 8;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(616, 31);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(173, 26);
            this.txtInventory.TabIndex = 7;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(95, 37);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(173, 26);
            this.txtSearchProduct.TabIndex = 6;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductName.Location = new System.Drawing.Point(286, 31);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(64, 28);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInventory.Location = new System.Drawing.Point(526, 31);
            this.lblInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(95, 28);
            this.lblInventory.TabIndex = 4;
            this.lblInventory.Text = "Inventory";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRate.Location = new System.Drawing.Point(796, 31);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(51, 28);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Rate";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQty.Location = new System.Drawing.Point(1029, 31);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(48, 28);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Qty.";
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductSearch.Location = new System.Drawing.Point(18, 34);
            this.lblProductSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(70, 28);
            this.lblProductSearch.TabIndex = 1;
            this.lblProductSearch.Text = "Search";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(18, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Details";
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.pnlDataGridView.Controls.Add(this.dgvAddedProducts);
            this.pnlDataGridView.Controls.Add(this.lblDGVTitle);
            this.pnlDataGridView.Location = new System.Drawing.Point(11, 362);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(728, 354);
            this.pnlDataGridView.TabIndex = 6;
            // 
            // dgvAddedProducts
            // 
            this.dgvAddedProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedProducts.Location = new System.Drawing.Point(13, 39);
            this.dgvAddedProducts.Name = "dgvAddedProducts";
            this.dgvAddedProducts.RowHeadersWidth = 62;
            this.dgvAddedProducts.RowTemplate.Height = 28;
            this.dgvAddedProducts.Size = new System.Drawing.Size(700, 300);
            this.dgvAddedProducts.TabIndex = 1;
            this.dgvAddedProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddedProducts_CellContentClick);
            // 
            // lblDGVTitle
            // 
            this.lblDGVTitle.AutoSize = true;
            this.lblDGVTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGVTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDGVTitle.Location = new System.Drawing.Point(14, 8);
            this.lblDGVTitle.Name = "lblDGVTitle";
            this.lblDGVTitle.Size = new System.Drawing.Size(162, 28);
            this.lblDGVTitle.TabIndex = 0;
            this.lblDGVTitle.Text = "Added Products";
            // 
            // pnlCalculation
            // 
            this.pnlCalculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.pnlCalculation.Controls.Add(this.btnSave);
            this.pnlCalculation.Controls.Add(this.txtSubTotal);
            this.pnlCalculation.Controls.Add(this.txtVat);
            this.pnlCalculation.Controls.Add(this.txtReturnAmount);
            this.pnlCalculation.Controls.Add(this.txtPaidAmount);
            this.pnlCalculation.Controls.Add(this.txtGrandtotal);
            this.pnlCalculation.Controls.Add(this.txtDiscount);
            this.pnlCalculation.Controls.Add(this.lblReturnAmount);
            this.pnlCalculation.Controls.Add(this.lblVat);
            this.pnlCalculation.Controls.Add(this.lblDiscount);
            this.pnlCalculation.Controls.Add(this.lblGrandTotal);
            this.pnlCalculation.Controls.Add(this.lblPaidAmount);
            this.pnlCalculation.Controls.Add(this.lblSubTotal);
            this.pnlCalculation.Controls.Add(this.lblcalculationTitle);
            this.pnlCalculation.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlCalculation.Location = new System.Drawing.Point(745, 362);
            this.pnlCalculation.Name = "pnlCalculation";
            this.pnlCalculation.Size = new System.Drawing.Size(718, 354);
            this.pnlCalculation.TabIndex = 7;
            this.pnlCalculation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCalculation_Paint);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(446, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 50);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(145, 36);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(285, 26);
            this.txtSubTotal.TabIndex = 13;
            this.txtSubTotal.Text = "0";
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(145, 116);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(285, 26);
            this.txtVat.TabIndex = 12;
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.txtReturnAmount.Location = new System.Drawing.Point(145, 236);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.ReadOnly = true;
            this.txtReturnAmount.Size = new System.Drawing.Size(285, 55);
            this.txtReturnAmount.TabIndex = 11;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(145, 196);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(285, 26);
            this.txtPaidAmount.TabIndex = 10;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // txtGrandtotal
            // 
            this.txtGrandtotal.Location = new System.Drawing.Point(145, 156);
            this.txtGrandtotal.Name = "txtGrandtotal";
            this.txtGrandtotal.ReadOnly = true;
            this.txtGrandtotal.Size = new System.Drawing.Size(285, 26);
            this.txtGrandtotal.TabIndex = 9;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(145, 76);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(285, 26);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReturnAmount.Location = new System.Drawing.Point(3, 242);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(114, 20);
            this.lblReturnAmount.TabIndex = 7;
            this.lblReturnAmount.Text = "ReturnAmount";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVat.Location = new System.Drawing.Point(7, 122);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(62, 20);
            this.lblVat.TabIndex = 6;
            this.lblVat.Text = "Vat (%)";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiscount.Location = new System.Drawing.Point(3, 82);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(100, 20);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGrandTotal.Location = new System.Drawing.Point(12, 162);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(93, 20);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaidAmount.Location = new System.Drawing.Point(12, 205);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(100, 20);
            this.lblPaidAmount.TabIndex = 3;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubTotal.Location = new System.Drawing.Point(3, 42);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(77, 20);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblcalculationTitle
            // 
            this.lblcalculationTitle.AutoSize = true;
            this.lblcalculationTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculationTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcalculationTitle.Location = new System.Drawing.Point(3, 11);
            this.lblcalculationTitle.Name = "lblcalculationTitle";
            this.lblcalculationTitle.Size = new System.Drawing.Size(190, 28);
            this.lblcalculationTitle.TabIndex = 0;
            this.lblcalculationTitle.Text = "Calculation Details";
            this.lblcalculationTitle.Click += new System.EventHandler(this.lblcalculationTitle_Click);
            // 
            // frmPurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1475, 728);
            this.Controls.Add(this.pnlCalculation);
            this.Controls.Add(this.pnlDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDeaCust);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDea";
            this.Load += new System.EventHandler(this.frmPurAndSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.pnlDeaCust.ResumeLayout(false);
            this.pnlDeaCust.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDataGridView.ResumeLayout(false);
            this.pnlDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
            this.pnlCalculation.ResumeLayout(false);
            this.pnlCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlDeaCust;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblBilldate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDeaCustTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblProductSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.DataGridView dgvAddedProducts;
        private System.Windows.Forms.Label lblDGVTitle;
        private System.Windows.Forms.Panel pnlCalculation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtGrandtotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblcalculationTitle;
        private System.Windows.Forms.Button button1;
    }
}