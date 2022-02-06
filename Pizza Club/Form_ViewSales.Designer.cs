
namespace Pizza_Club
{
    partial class Form_ViewSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewSales));
            this.dataGridView_viewSales = new System.Windows.Forms.DataGridView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_searchSales = new System.Windows.Forms.TextBox();
            this.btn_deleteSales = new System.Windows.Forms.Button();
            this.btn_refreshSales = new System.Windows.Forms.Button();
            this.btn_filterSales = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radio_selectDate = new System.Windows.Forms.RadioButton();
            this.radio_30daysSales = new System.Windows.Forms.RadioButton();
            this.radio_7daysSales = new System.Windows.Forms.RadioButton();
            this.radio_todaySales = new System.Windows.Forms.RadioButton();
            this.radio_allSales = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label_totalViewSales = new System.Windows.Forms.Label();
            this.tbl_salesTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_salesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_viewSales
            // 
            this.dataGridView_viewSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_viewSales.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_viewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_viewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_viewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView_viewSales.DataSource = this.tblsalesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_viewSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_viewSales.Location = new System.Drawing.Point(1, 120);
            this.dataGridView_viewSales.Name = "dataGridView_viewSales";
            this.dataGridView_viewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_viewSales.Size = new System.Drawing.Size(1050, 276);
            this.dataGridView_viewSales.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // extraChargesDataGridViewTextBoxColumn
            // 
            this.extraChargesDataGridViewTextBoxColumn.DataPropertyName = "extraCharges";
            this.extraChargesDataGridViewTextBoxColumn.HeaderText = "Extra";
            this.extraChargesDataGridViewTextBoxColumn.Name = "extraChargesDataGridViewTextBoxColumn";
            // 
            // grossTotalDataGridViewTextBoxColumn
            // 
            this.grossTotalDataGridViewTextBoxColumn.DataPropertyName = "grossTotal";
            this.grossTotalDataGridViewTextBoxColumn.HeaderText = "Gross Total";
            this.grossTotalDataGridViewTextBoxColumn.Name = "grossTotalDataGridViewTextBoxColumn";
            // 
            // amountGivenDataGridViewTextBoxColumn
            // 
            this.amountGivenDataGridViewTextBoxColumn.DataPropertyName = "amountGiven";
            this.amountGivenDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.amountGivenDataGridViewTextBoxColumn.Name = "amountGivenDataGridViewTextBoxColumn";
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "orderType";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "Order Type";
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // selectDataGridViewCheckBoxColumn
            // 
            this.selectDataGridViewCheckBoxColumn.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn.Name = "selectDataGridViewCheckBoxColumn";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_searchSales);
            this.panel1.Controls.Add(this.btn_deleteSales);
            this.panel1.Controls.Add(this.btn_refreshSales);
            this.panel1.Controls.Add(this.btn_filterSales);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.radio_selectDate);
            this.panel1.Controls.Add(this.radio_30daysSales);
            this.panel1.Controls.Add(this.radio_7daysSales);
            this.panel1.Controls.Add(this.radio_todaySales);
            this.panel1.Controls.Add(this.radio_allSales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 114);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search";
            // 
            // txt_searchSales
            // 
            this.txt_searchSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_searchSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchSales.Location = new System.Drawing.Point(93, 86);
            this.txt_searchSales.Name = "txt_searchSales";
            this.txt_searchSales.Size = new System.Drawing.Size(188, 22);
            this.txt_searchSales.TabIndex = 8;
            this.txt_searchSales.TextChanged += new System.EventHandler(this.txt_searchSales_TextChanged);
            // 
            // btn_deleteSales
            // 
            this.btn_deleteSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteSales.BackColor = System.Drawing.Color.Coral;
            this.btn_deleteSales.FlatAppearance.BorderSize = 0;
            this.btn_deleteSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteSales.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteSales.Image")));
            this.btn_deleteSales.Location = new System.Drawing.Point(996, 24);
            this.btn_deleteSales.Name = "btn_deleteSales";
            this.btn_deleteSales.Size = new System.Drawing.Size(45, 37);
            this.btn_deleteSales.TabIndex = 10;
            this.btn_deleteSales.UseVisualStyleBackColor = false;
            this.btn_deleteSales.Click += new System.EventHandler(this.btn_deleteSales_Click);
            // 
            // btn_refreshSales
            // 
            this.btn_refreshSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refreshSales.FlatAppearance.BorderSize = 0;
            this.btn_refreshSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshSales.Image = ((System.Drawing.Image)(resources.GetObject("btn_refreshSales.Image")));
            this.btn_refreshSales.Location = new System.Drawing.Point(996, 73);
            this.btn_refreshSales.Name = "btn_refreshSales";
            this.btn_refreshSales.Size = new System.Drawing.Size(45, 37);
            this.btn_refreshSales.TabIndex = 9;
            this.btn_refreshSales.UseVisualStyleBackColor = true;
            this.btn_refreshSales.Click += new System.EventHandler(this.btn_refreshSales_Click);
            // 
            // btn_filterSales
            // 
            this.btn_filterSales.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_filterSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filterSales.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filterSales.Location = new System.Drawing.Point(702, 27);
            this.btn_filterSales.Name = "btn_filterSales";
            this.btn_filterSales.Size = new System.Drawing.Size(143, 50);
            this.btn_filterSales.TabIndex = 7;
            this.btn_filterSales.Text = "Filter";
            this.btn_filterSales.UseVisualStyleBackColor = false;
            this.btn_filterSales.Click += new System.EventHandler(this.btn_filterSales_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(559, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // radio_selectDate
            // 
            this.radio_selectDate.AutoSize = true;
            this.radio_selectDate.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_selectDate.Location = new System.Drawing.Point(559, 27);
            this.radio_selectDate.Name = "radio_selectDate";
            this.radio_selectDate.Size = new System.Drawing.Size(110, 24);
            this.radio_selectDate.TabIndex = 5;
            this.radio_selectDate.TabStop = true;
            this.radio_selectDate.Text = "Select Date";
            this.radio_selectDate.UseVisualStyleBackColor = true;
            // 
            // radio_30daysSales
            // 
            this.radio_30daysSales.AutoSize = true;
            this.radio_30daysSales.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_30daysSales.Location = new System.Drawing.Point(428, 27);
            this.radio_30daysSales.Name = "radio_30daysSales";
            this.radio_30daysSales.Size = new System.Drawing.Size(125, 24);
            this.radio_30daysSales.TabIndex = 4;
            this.radio_30daysSales.TabStop = true;
            this.radio_30daysSales.Text = "30 Days Sales";
            this.radio_30daysSales.UseVisualStyleBackColor = true;
            // 
            // radio_7daysSales
            // 
            this.radio_7daysSales.AutoSize = true;
            this.radio_7daysSales.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_7daysSales.Location = new System.Drawing.Point(306, 27);
            this.radio_7daysSales.Name = "radio_7daysSales";
            this.radio_7daysSales.Size = new System.Drawing.Size(116, 24);
            this.radio_7daysSales.TabIndex = 3;
            this.radio_7daysSales.TabStop = true;
            this.radio_7daysSales.Text = "7 Days Sales";
            this.radio_7daysSales.UseVisualStyleBackColor = true;
            // 
            // radio_todaySales
            // 
            this.radio_todaySales.AutoSize = true;
            this.radio_todaySales.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_todaySales.Location = new System.Drawing.Point(186, 27);
            this.radio_todaySales.Name = "radio_todaySales";
            this.radio_todaySales.Size = new System.Drawing.Size(114, 24);
            this.radio_todaySales.TabIndex = 2;
            this.radio_todaySales.TabStop = true;
            this.radio_todaySales.Text = "Today Sales";
            this.radio_todaySales.UseVisualStyleBackColor = true;
            // 
            // radio_allSales
            // 
            this.radio_allSales.AutoSize = true;
            this.radio_allSales.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_allSales.Location = new System.Drawing.Point(93, 27);
            this.radio_allSales.Name = "radio_allSales";
            this.radio_allSales.Size = new System.Drawing.Size(87, 24);
            this.radio_allSales.TabIndex = 1;
            this.radio_allSales.TabStop = true;
            this.radio_allSales.Text = "All Sales";
            this.radio_allSales.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(559, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gross Total:-";
            // 
            // label_totalViewSales
            // 
            this.label_totalViewSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalViewSales.AutoSize = true;
            this.label_totalViewSales.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_totalViewSales.Location = new System.Drawing.Point(737, 413);
            this.label_totalViewSales.Name = "label_totalViewSales";
            this.label_totalViewSales.Size = new System.Drawing.Size(54, 26);
            this.label_totalViewSales.TabIndex = 2;
            this.label_totalViewSales.Text = "0.00";
            // 
            // tbl_salesTableAdapter
            // 
            this.tbl_salesTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.label_totalViewSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_viewSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ViewSales";
            this.Text = "Form_ViewSales";
            this.Load += new System.EventHandler(this.Form_ViewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_viewSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_selectDate;
        private System.Windows.Forms.RadioButton radio_30daysSales;
        private System.Windows.Forms.RadioButton radio_7daysSales;
        private System.Windows.Forms.RadioButton radio_todaySales;
        private System.Windows.Forms.RadioButton radio_allSales;
        private System.Windows.Forms.Button btn_filterSales;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_totalViewSales;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblsalesBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_salesTableAdapter tbl_salesTableAdapter;
        private System.Windows.Forms.Button btn_refreshSales;
        private System.Windows.Forms.Button btn_deleteSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_searchSales;
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
    }
}