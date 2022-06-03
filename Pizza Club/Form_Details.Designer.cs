
namespace Pizza_Club
{
    partial class Form_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_todayOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_todaySales = new System.Windows.Forms.Label();
            this.dataGridView_todaySales = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGivenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblsalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_todayPurchase = new System.Windows.Forms.Label();
            this.dataGridView_todayPurchase = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblpurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_todayExpense = new System.Windows.Forms.Label();
            this.dataGridView_todayExpense = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblexpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_todayPayments = new System.Windows.Forms.Label();
            this.dataGridView_todayPayments = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblonlinePaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label_admin_main = new System.Windows.Forms.Label();
            this.tbl_salesTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_salesTableAdapter();
            this.tbl_purchaseTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_purchaseTableAdapter();
            this.tbl_expenseTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_expenseTableAdapter();
            this.tbl_onlinePaymentTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_onlinePaymentTableAdapter();
            this.btn_generateReport = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_exportSale = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_exportPayment = new System.Windows.Forms.Button();
            this.btn_exportExpense = new System.Windows.Forms.Button();
            this.btn_exportPurchase = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todaySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todayPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpurchaseBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todayExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblexpenseBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todayPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblonlinePaymentBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_todayOrders);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_todaySales);
            this.groupBox1.Controls.Add(this.dataGridView_todaySales);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today\'s Sale";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(43, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Orders:-";
            // 
            // label_todayOrders
            // 
            this.label_todayOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_todayOrders.AutoSize = true;
            this.label_todayOrders.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_todayOrders.Location = new System.Drawing.Point(123, 171);
            this.label_todayOrders.Name = "label_todayOrders";
            this.label_todayOrders.Size = new System.Drawing.Size(18, 20);
            this.label_todayOrders.TabIndex = 1;
            this.label_todayOrders.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(248, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gross Total:-";
            // 
            // label_todaySales
            // 
            this.label_todaySales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_todaySales.AutoSize = true;
            this.label_todaySales.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_todaySales.Location = new System.Drawing.Point(369, 171);
            this.label_todaySales.Name = "label_todaySales";
            this.label_todaySales.Size = new System.Drawing.Size(40, 20);
            this.label_todaySales.TabIndex = 1;
            this.label_todaySales.Text = "0.00";
            // 
            // dataGridView_todaySales
            // 
            this.dataGridView_todaySales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_todaySales.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_todaySales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_todaySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_todaySales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.extraChargesDataGridViewTextBoxColumn,
            this.grossTotalDataGridViewTextBoxColumn,
            this.amountGivenDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_todaySales.DataSource = this.tblsalesBindingSource;
            this.dataGridView_todaySales.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_todaySales.Name = "dataGridView_todaySales";
            this.dataGridView_todaySales.ReadOnly = true;
            this.dataGridView_todaySales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_todaySales.Size = new System.Drawing.Size(507, 147);
            this.dataGridView_todaySales.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extraChargesDataGridViewTextBoxColumn
            // 
            this.extraChargesDataGridViewTextBoxColumn.DataPropertyName = "extraCharges";
            this.extraChargesDataGridViewTextBoxColumn.HeaderText = "Extra";
            this.extraChargesDataGridViewTextBoxColumn.Name = "extraChargesDataGridViewTextBoxColumn";
            this.extraChargesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossTotalDataGridViewTextBoxColumn
            // 
            this.grossTotalDataGridViewTextBoxColumn.DataPropertyName = "grossTotal";
            this.grossTotalDataGridViewTextBoxColumn.HeaderText = "Gross Total";
            this.grossTotalDataGridViewTextBoxColumn.Name = "grossTotalDataGridViewTextBoxColumn";
            this.grossTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountGivenDataGridViewTextBoxColumn
            // 
            this.amountGivenDataGridViewTextBoxColumn.DataPropertyName = "amountGiven";
            this.amountGivenDataGridViewTextBoxColumn.HeaderText = "Amount Given";
            this.amountGivenDataGridViewTextBoxColumn.Name = "amountGivenDataGridViewTextBoxColumn";
            this.amountGivenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            this.changeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "orderType";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "Order Type";
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            this.orderTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selectDataGridViewCheckBoxColumn
            // 
            this.selectDataGridViewCheckBoxColumn.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn.Name = "selectDataGridViewCheckBoxColumn";
            this.selectDataGridViewCheckBoxColumn.ReadOnly = true;
            this.selectDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tblsalesBindingSource
            // 
            this.tblsalesBindingSource.DataMember = "tbl_sales";
            this.tblsalesBindingSource.DataSource = this.databasePCDataSet;
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_todayPurchase);
            this.groupBox2.Controls.Add(this.dataGridView_todayPurchase);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(528, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 194);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Today\'s Purchase";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(248, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gross Total:-";
            // 
            // label_todayPurchase
            // 
            this.label_todayPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_todayPurchase.AutoSize = true;
            this.label_todayPurchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_todayPurchase.Location = new System.Drawing.Point(369, 171);
            this.label_todayPurchase.Name = "label_todayPurchase";
            this.label_todayPurchase.Size = new System.Drawing.Size(40, 20);
            this.label_todayPurchase.TabIndex = 1;
            this.label_todayPurchase.Text = "0.00";
            // 
            // dataGridView_todayPurchase
            // 
            this.dataGridView_todayPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_todayPurchase.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_todayPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_todayPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_todayPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.selectDataGridViewCheckBoxColumn1});
            this.dataGridView_todayPurchase.DataSource = this.tblpurchaseBindingSource;
            this.dataGridView_todayPurchase.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_todayPurchase.Name = "dataGridView_todayPurchase";
            this.dataGridView_todayPurchase.ReadOnly = true;
            this.dataGridView_todayPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_todayPurchase.Size = new System.Drawing.Size(507, 147);
            this.dataGridView_todayPurchase.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // selectDataGridViewCheckBoxColumn1
            // 
            this.selectDataGridViewCheckBoxColumn1.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn1.Name = "selectDataGridViewCheckBoxColumn1";
            this.selectDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.selectDataGridViewCheckBoxColumn1.Visible = false;
            this.selectDataGridViewCheckBoxColumn1.Width = 60;
            // 
            // tblpurchaseBindingSource
            // 
            this.tblpurchaseBindingSource.DataMember = "tbl_purchase";
            this.tblpurchaseBindingSource.DataSource = this.databasePCDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label_todayExpense);
            this.groupBox3.Controls.Add(this.dataGridView_todayExpense);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 194);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Today\'s Expense";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(248, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gross Total:-";
            // 
            // label_todayExpense
            // 
            this.label_todayExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_todayExpense.AutoSize = true;
            this.label_todayExpense.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_todayExpense.Location = new System.Drawing.Point(369, 171);
            this.label_todayExpense.Name = "label_todayExpense";
            this.label_todayExpense.Size = new System.Drawing.Size(40, 20);
            this.label_todayExpense.TabIndex = 1;
            this.label_todayExpense.Text = "0.00";
            // 
            // dataGridView_todayExpense
            // 
            this.dataGridView_todayExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_todayExpense.AutoGenerateColumns = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_todayExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_todayExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_todayExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn2,
            this.selectDataGridViewCheckBoxColumn2});
            this.dataGridView_todayExpense.DataSource = this.tblexpenseBindingSource;
            this.dataGridView_todayExpense.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_todayExpense.Name = "dataGridView_todayExpense";
            this.dataGridView_todayExpense.ReadOnly = true;
            this.dataGridView_todayExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_todayExpense.Size = new System.Drawing.Size(507, 147);
            this.dataGridView_todayExpense.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn2
            // 
            this.priceDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn2.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn2.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
            this.priceDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn2
            // 
            this.dateDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn2.Name = "dateDataGridViewTextBoxColumn2";
            this.dateDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // selectDataGridViewCheckBoxColumn2
            // 
            this.selectDataGridViewCheckBoxColumn2.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn2.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn2.Name = "selectDataGridViewCheckBoxColumn2";
            this.selectDataGridViewCheckBoxColumn2.ReadOnly = true;
            this.selectDataGridViewCheckBoxColumn2.Visible = false;
            this.selectDataGridViewCheckBoxColumn2.Width = 60;
            // 
            // tblexpenseBindingSource
            // 
            this.tblexpenseBindingSource.DataMember = "tbl_expense";
            this.tblexpenseBindingSource.DataSource = this.databasePCDataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label_todayPayments);
            this.groupBox4.Controls.Add(this.dataGridView_todayPayments);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(528, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(519, 194);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Today\'s Online Payments";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(248, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gross Total:-";
            // 
            // label_todayPayments
            // 
            this.label_todayPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_todayPayments.AutoSize = true;
            this.label_todayPayments.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_todayPayments.Location = new System.Drawing.Point(369, 171);
            this.label_todayPayments.Name = "label_todayPayments";
            this.label_todayPayments.Size = new System.Drawing.Size(40, 20);
            this.label_todayPayments.TabIndex = 1;
            this.label_todayPayments.Text = "0.00";
            // 
            // dataGridView_todayPayments
            // 
            this.dataGridView_todayPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_todayPayments.AutoGenerateColumns = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_todayPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_todayPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_todayPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn2,
            this.priceDataGridViewTextBoxColumn3,
            this.dateDataGridViewTextBoxColumn3,
            this.selectDataGridViewCheckBoxColumn3});
            this.dataGridView_todayPayments.DataSource = this.tblonlinePaymentBindingSource;
            this.dataGridView_todayPayments.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_todayPayments.Name = "dataGridView_todayPayments";
            this.dataGridView_todayPayments.ReadOnly = true;
            this.dataGridView_todayPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_todayPayments.Size = new System.Drawing.Size(507, 147);
            this.dataGridView_todayPayments.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn3
            // 
            this.priceDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn3.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn3.Name = "priceDataGridViewTextBoxColumn3";
            this.priceDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn3
            // 
            this.dateDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn3.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn3.Name = "dateDataGridViewTextBoxColumn3";
            this.dateDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // selectDataGridViewCheckBoxColumn3
            // 
            this.selectDataGridViewCheckBoxColumn3.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn3.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn3.Name = "selectDataGridViewCheckBoxColumn3";
            this.selectDataGridViewCheckBoxColumn3.ReadOnly = true;
            this.selectDataGridViewCheckBoxColumn3.Visible = false;
            this.selectDataGridViewCheckBoxColumn3.Width = 60;
            // 
            // tblonlinePaymentBindingSource
            // 
            this.tblonlinePaymentBindingSource.DataMember = "tbl_onlinePayment";
            this.tblonlinePaymentBindingSource.DataSource = this.databasePCDataSet;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1012, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_admin_main
            // 
            this.label_admin_main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_admin_main.AutoSize = true;
            this.label_admin_main.Font = new System.Drawing.Font("Hobo Std", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_admin_main.Location = new System.Drawing.Point(379, 1);
            this.label_admin_main.Name = "label_admin_main";
            this.label_admin_main.Size = new System.Drawing.Size(298, 52);
            this.label_admin_main.TabIndex = 5;
            this.label_admin_main.Text = "Today\'s History";
            // 
            // tbl_salesTableAdapter
            // 
            this.tbl_salesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_purchaseTableAdapter
            // 
            this.tbl_purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_expenseTableAdapter
            // 
            this.tbl_expenseTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_onlinePaymentTableAdapter
            // 
            this.tbl_onlinePaymentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_generateReport
            // 
            this.btn_generateReport.BackColor = System.Drawing.Color.Teal;
            this.btn_generateReport.FlatAppearance.BorderSize = 0;
            this.btn_generateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generateReport.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateReport.ForeColor = System.Drawing.Color.White;
            this.btn_generateReport.Location = new System.Drawing.Point(10, 12);
            this.btn_generateReport.Name = "btn_generateReport";
            this.btn_generateReport.Size = new System.Drawing.Size(70, 41);
            this.btn_generateReport.TabIndex = 6;
            this.btn_generateReport.Text = "Report";
            this.btn_generateReport.UseVisualStyleBackColor = false;
            this.btn_generateReport.Click += new System.EventHandler(this.btn_generateReport_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_exportSale
            // 
            this.btn_exportSale.BackColor = System.Drawing.Color.Teal;
            this.btn_exportSale.FlatAppearance.BorderSize = 0;
            this.btn_exportSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportSale.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportSale.ForeColor = System.Drawing.Color.White;
            this.btn_exportSale.Location = new System.Drawing.Point(6, 15);
            this.btn_exportSale.Name = "btn_exportSale";
            this.btn_exportSale.Size = new System.Drawing.Size(51, 25);
            this.btn_exportSale.TabIndex = 6;
            this.btn_exportSale.Text = "Sale";
            this.btn_exportSale.UseVisualStyleBackColor = false;
            this.btn_exportSale.Click += new System.EventHandler(this.btn_exportSale_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_exportPayment);
            this.groupBox5.Controls.Add(this.btn_exportExpense);
            this.groupBox5.Controls.Add(this.btn_exportPurchase);
            this.groupBox5.Controls.Add(this.btn_exportSale);
            this.groupBox5.Location = new System.Drawing.Point(85, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 47);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Export XLS";
            // 
            // btn_exportPayment
            // 
            this.btn_exportPayment.BackColor = System.Drawing.Color.Teal;
            this.btn_exportPayment.FlatAppearance.BorderSize = 0;
            this.btn_exportPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportPayment.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportPayment.ForeColor = System.Drawing.Color.White;
            this.btn_exportPayment.Location = new System.Drawing.Point(177, 14);
            this.btn_exportPayment.Name = "btn_exportPayment";
            this.btn_exportPayment.Size = new System.Drawing.Size(51, 25);
            this.btn_exportPayment.TabIndex = 6;
            this.btn_exportPayment.Text = "Payments";
            this.btn_exportPayment.UseVisualStyleBackColor = false;
            this.btn_exportPayment.Click += new System.EventHandler(this.btn_exportPayment_Click);
            // 
            // btn_exportExpense
            // 
            this.btn_exportExpense.BackColor = System.Drawing.Color.Teal;
            this.btn_exportExpense.FlatAppearance.BorderSize = 0;
            this.btn_exportExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportExpense.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportExpense.ForeColor = System.Drawing.Color.White;
            this.btn_exportExpense.Location = new System.Drawing.Point(120, 14);
            this.btn_exportExpense.Name = "btn_exportExpense";
            this.btn_exportExpense.Size = new System.Drawing.Size(51, 25);
            this.btn_exportExpense.TabIndex = 6;
            this.btn_exportExpense.Text = "Expense";
            this.btn_exportExpense.UseVisualStyleBackColor = false;
            this.btn_exportExpense.Click += new System.EventHandler(this.btn_exportExpense_Click);
            // 
            // btn_exportPurchase
            // 
            this.btn_exportPurchase.BackColor = System.Drawing.Color.Teal;
            this.btn_exportPurchase.FlatAppearance.BorderSize = 0;
            this.btn_exportPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportPurchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportPurchase.ForeColor = System.Drawing.Color.White;
            this.btn_exportPurchase.Location = new System.Drawing.Point(63, 15);
            this.btn_exportPurchase.Name = "btn_exportPurchase";
            this.btn_exportPurchase.Size = new System.Drawing.Size(51, 25);
            this.btn_exportPurchase.TabIndex = 6;
            this.btn_exportPurchase.Text = "Purchase";
            this.btn_exportPurchase.UseVisualStyleBackColor = false;
            this.btn_exportPurchase.Click += new System.EventHandler(this.btn_exportPurchase_Click);
            // 
            // Form_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_generateReport);
            this.Controls.Add(this.label_admin_main);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Details_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todaySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todayPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpurchaseBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todayExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblexpenseBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todayPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblonlinePaymentBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_admin_main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_todaySales;
        private System.Windows.Forms.DataGridView dataGridView_todaySales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_todayPurchase;
        private System.Windows.Forms.DataGridView dataGridView_todayPurchase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_todayExpense;
        private System.Windows.Forms.DataGridView dataGridView_todayExpense;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_todayPayments;
        private System.Windows.Forms.DataGridView dataGridView_todayPayments;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblsalesBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_salesTableAdapter tbl_salesTableAdapter;
        private System.Windows.Forms.BindingSource tblpurchaseBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_purchaseTableAdapter tbl_purchaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGivenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource tblexpenseBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_expenseTableAdapter tbl_expenseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.BindingSource tblonlinePaymentBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_onlinePaymentTableAdapter tbl_onlinePaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn3;
        private System.Windows.Forms.Button btn_generateReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_todayOrders;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_exportSale;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_exportPayment;
        private System.Windows.Forms.Button btn_exportExpense;
        private System.Windows.Forms.Button btn_exportPurchase;
    }
}