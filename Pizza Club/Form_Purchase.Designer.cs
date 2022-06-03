
namespace Pizza_Club
{
    partial class Form_Purchase
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_purchaseId = new System.Windows.Forms.TextBox();
            this.txt_purchaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_purchasePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_filterPurchase = new System.Windows.Forms.Button();
            this.radio_selectDatePurchase = new System.Windows.Forms.RadioButton();
            this.radio_30DaysPurchase = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.btn_deletePurchase = new System.Windows.Forms.Button();
            this.btn_viewPurchase = new System.Windows.Forms.Button();
            this.btn_clearPurchase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_searchPurchase = new System.Windows.Forms.TextBox();
            this.dataGridView_purchase = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label_grossTotal = new System.Windows.Forms.Label();
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.tblpurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_purchaseTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_purchaseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpurchaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID";
            // 
            // txt_purchaseId
            // 
            this.txt_purchaseId.Enabled = false;
            this.txt_purchaseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchaseId.Location = new System.Drawing.Point(107, 18);
            this.txt_purchaseId.Name = "txt_purchaseId";
            this.txt_purchaseId.ReadOnly = true;
            this.txt_purchaseId.Size = new System.Drawing.Size(178, 21);
            this.txt_purchaseId.TabIndex = 1;
            // 
            // txt_purchaseName
            // 
            this.txt_purchaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchaseName.Location = new System.Drawing.Point(361, 19);
            this.txt_purchaseName.Name = "txt_purchaseName";
            this.txt_purchaseName.Size = new System.Drawing.Size(178, 21);
            this.txt_purchaseName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txt_purchasePrice
            // 
            this.txt_purchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchasePrice.Location = new System.Drawing.Point(361, 56);
            this.txt_purchasePrice.Name = "txt_purchasePrice";
            this.txt_purchasePrice.Size = new System.Drawing.Size(178, 21);
            this.txt_purchasePrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_filterPurchase);
            this.panel2.Controls.Add(this.radio_selectDatePurchase);
            this.panel2.Controls.Add(this.radio_30DaysPurchase);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btn_purchase);
            this.panel2.Controls.Add(this.btn_deletePurchase);
            this.panel2.Controls.Add(this.btn_viewPurchase);
            this.panel2.Location = new System.Drawing.Point(560, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 148);
            this.panel2.TabIndex = 12;
            // 
            // btn_filterPurchase
            // 
            this.btn_filterPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filterPurchase.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_filterPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filterPurchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filterPurchase.Location = new System.Drawing.Point(372, 110);
            this.btn_filterPurchase.Name = "btn_filterPurchase";
            this.btn_filterPurchase.Size = new System.Drawing.Size(93, 33);
            this.btn_filterPurchase.TabIndex = 10;
            this.btn_filterPurchase.Text = "Filter";
            this.btn_filterPurchase.UseVisualStyleBackColor = false;
            this.btn_filterPurchase.Click += new System.EventHandler(this.btn_filterPurchase_Click);
            // 
            // radio_selectDatePurchase
            // 
            this.radio_selectDatePurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radio_selectDatePurchase.AutoSize = true;
            this.radio_selectDatePurchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_selectDatePurchase.Location = new System.Drawing.Point(119, 119);
            this.radio_selectDatePurchase.Name = "radio_selectDatePurchase";
            this.radio_selectDatePurchase.Size = new System.Drawing.Size(110, 24);
            this.radio_selectDatePurchase.TabIndex = 8;
            this.radio_selectDatePurchase.TabStop = true;
            this.radio_selectDatePurchase.Text = "Select Date";
            this.radio_selectDatePurchase.UseVisualStyleBackColor = true;
            // 
            // radio_30DaysPurchase
            // 
            this.radio_30DaysPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radio_30DaysPurchase.AutoSize = true;
            this.radio_30DaysPurchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_30DaysPurchase.Location = new System.Drawing.Point(29, 119);
            this.radio_30DaysPurchase.Name = "radio_30DaysPurchase";
            this.radio_30DaysPurchase.Size = new System.Drawing.Size(84, 24);
            this.radio_30DaysPurchase.TabIndex = 7;
            this.radio_30DaysPurchase.TabStop = true;
            this.radio_30DaysPurchase.Text = "30 Days";
            this.radio_30DaysPurchase.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.Location = new System.Drawing.Point(3, 7);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(140, 65);
            this.btn_purchase.TabIndex = 4;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // btn_deletePurchase
            // 
            this.btn_deletePurchase.BackColor = System.Drawing.Color.Red;
            this.btn_deletePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePurchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletePurchase.Location = new System.Drawing.Point(148, 7);
            this.btn_deletePurchase.Name = "btn_deletePurchase";
            this.btn_deletePurchase.Size = new System.Drawing.Size(140, 65);
            this.btn_deletePurchase.TabIndex = 5;
            this.btn_deletePurchase.Text = "Delete ";
            this.btn_deletePurchase.UseVisualStyleBackColor = false;
            this.btn_deletePurchase.Click += new System.EventHandler(this.btn_deletePurchase_Click);
            // 
            // btn_viewPurchase
            // 
            this.btn_viewPurchase.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewPurchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewPurchase.Location = new System.Drawing.Point(293, 7);
            this.btn_viewPurchase.Name = "btn_viewPurchase";
            this.btn_viewPurchase.Size = new System.Drawing.Size(140, 65);
            this.btn_viewPurchase.TabIndex = 6;
            this.btn_viewPurchase.Text = "View";
            this.btn_viewPurchase.UseVisualStyleBackColor = false;
            this.btn_viewPurchase.Click += new System.EventHandler(this.btn_viewPurchase_Click);
            // 
            // btn_clearPurchase
            // 
            this.btn_clearPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clearPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearPurchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clearPurchase.Location = new System.Drawing.Point(460, 121);
            this.btn_clearPurchase.Name = "btn_clearPurchase";
            this.btn_clearPurchase.Size = new System.Drawing.Size(79, 28);
            this.btn_clearPurchase.TabIndex = 11;
            this.btn_clearPurchase.Text = "Reset";
            this.btn_clearPurchase.UseVisualStyleBackColor = false;
            this.btn_clearPurchase.Click += new System.EventHandler(this.btn_clearPurchase_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search";
            // 
            // txt_searchPurchase
            // 
            this.txt_searchPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_searchPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchPurchase.Location = new System.Drawing.Point(83, 127);
            this.txt_searchPurchase.Name = "txt_searchPurchase";
            this.txt_searchPurchase.Size = new System.Drawing.Size(188, 22);
            this.txt_searchPurchase.TabIndex = 12;
            this.txt_searchPurchase.TextChanged += new System.EventHandler(this.txt_searchPurchase_TextChanged);
            // 
            // dataGridView_purchase
            // 
            this.dataGridView_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_purchase.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_purchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_purchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_purchase.DataSource = this.tblpurchaseBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_purchase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_purchase.Location = new System.Drawing.Point(0, 155);
            this.dataGridView_purchase.MultiSelect = false;
            this.dataGridView_purchase.Name = "dataGridView_purchase";
            this.dataGridView_purchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_purchase.Size = new System.Drawing.Size(1051, 239);
            this.dataGridView_purchase.TabIndex = 13;
            this.dataGridView_purchase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_purchase_MouseClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(571, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gross Total:-";
            // 
            // label_grossTotal
            // 
            this.label_grossTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_grossTotal.AutoSize = true;
            this.label_grossTotal.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_grossTotal.Location = new System.Drawing.Point(749, 411);
            this.label_grossTotal.Name = "label_grossTotal";
            this.label_grossTotal.Size = new System.Drawing.Size(54, 26);
            this.label_grossTotal.TabIndex = 18;
            this.label_grossTotal.Text = "0.00";
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpurchaseBindingSource
            // 
            this.tblpurchaseBindingSource.DataMember = "tbl_purchase";
            this.tblpurchaseBindingSource.DataSource = this.databasePCDataSet;
            // 
            // tbl_purchaseTableAdapter
            // 
            this.tbl_purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // selectDataGridViewCheckBoxColumn
            // 
            this.selectDataGridViewCheckBoxColumn.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn.Name = "selectDataGridViewCheckBoxColumn";
            this.selectDataGridViewCheckBoxColumn.Visible = false;
            this.selectDataGridViewCheckBoxColumn.Width = 60;
            // 
            // Form_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_grossTotal);
            this.Controls.Add(this.dataGridView_purchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_searchPurchase);
            this.Controls.Add(this.btn_clearPurchase);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_purchasePrice);
            this.Controls.Add(this.txt_purchaseName);
            this.Controls.Add(this.txt_purchaseId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Purchase";
            this.Text = "Form_Purchase";
            this.Load += new System.EventHandler(this.Form_Purchase_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpurchaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_purchaseId;
        private System.Windows.Forms.TextBox txt_purchaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_purchasePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_filterPurchase;
        private System.Windows.Forms.RadioButton radio_selectDatePurchase;
        private System.Windows.Forms.RadioButton radio_30DaysPurchase;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button btn_deletePurchase;
        private System.Windows.Forms.Button btn_viewPurchase;
        private System.Windows.Forms.Button btn_clearPurchase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_searchPurchase;
        private System.Windows.Forms.DataGridView dataGridView_purchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_grossTotal;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblpurchaseBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_purchaseTableAdapter tbl_purchaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}