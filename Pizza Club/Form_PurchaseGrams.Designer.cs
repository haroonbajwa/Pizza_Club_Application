﻿namespace Pizza_Club
{
    partial class Form_PurchaseGrams
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
            this.txt_gramsId = new System.Windows.Forms.TextBox();
            this.btn_purchaseGrams = new System.Windows.Forms.Button();
            this.btn_deleteGrams = new System.Windows.Forms.Button();
            this.btn_viewGrams = new System.Windows.Forms.Button();
            this.combo_gramsName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clearGrams = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gramsPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gramsQuantity = new System.Windows.Forms.TextBox();
            this.dataGridView_purchaseGrams = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.tblpurchaseGramsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_purchaseGramsTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_purchaseGramsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchaseGrams)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpurchaseGramsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_gramsId
            // 
            this.txt_gramsId.Enabled = false;
            this.txt_gramsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gramsId.Location = new System.Drawing.Point(107, 17);
            this.txt_gramsId.Name = "txt_gramsId";
            this.txt_gramsId.ReadOnly = true;
            this.txt_gramsId.Size = new System.Drawing.Size(178, 21);
            this.txt_gramsId.TabIndex = 1;
            // 
            // btn_purchaseGrams
            // 
            this.btn_purchaseGrams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_purchaseGrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchaseGrams.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_purchaseGrams.Location = new System.Drawing.Point(3, 7);
            this.btn_purchaseGrams.Name = "btn_purchaseGrams";
            this.btn_purchaseGrams.Size = new System.Drawing.Size(140, 65);
            this.btn_purchaseGrams.TabIndex = 7;
            this.btn_purchaseGrams.Text = "Purchase";
            this.btn_purchaseGrams.UseVisualStyleBackColor = false;
            this.btn_purchaseGrams.Click += new System.EventHandler(this.btn_purchaseGrams_Click);
            // 
            // btn_deleteGrams
            // 
            this.btn_deleteGrams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_deleteGrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteGrams.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_deleteGrams.Location = new System.Drawing.Point(148, 7);
            this.btn_deleteGrams.Name = "btn_deleteGrams";
            this.btn_deleteGrams.Size = new System.Drawing.Size(140, 65);
            this.btn_deleteGrams.TabIndex = 9;
            this.btn_deleteGrams.Text = "Delete ";
            this.btn_deleteGrams.UseVisualStyleBackColor = false;
            this.btn_deleteGrams.Click += new System.EventHandler(this.btn_deleteGrams_Click);
            // 
            // btn_viewGrams
            // 
            this.btn_viewGrams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_viewGrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewGrams.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_viewGrams.Location = new System.Drawing.Point(3, 77);
            this.btn_viewGrams.Name = "btn_viewGrams";
            this.btn_viewGrams.Size = new System.Drawing.Size(140, 65);
            this.btn_viewGrams.TabIndex = 8;
            this.btn_viewGrams.Text = "View";
            this.btn_viewGrams.UseVisualStyleBackColor = false;
            this.btn_viewGrams.Click += new System.EventHandler(this.btn_viewGrams_Click);
            // 
            // combo_gramsName
            // 
            this.combo_gramsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_gramsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_gramsName.FormattingEnabled = true;
            this.combo_gramsName.Location = new System.Drawing.Point(381, 15);
            this.combo_gramsName.Name = "combo_gramsName";
            this.combo_gramsName.Size = new System.Drawing.Size(178, 23);
            this.combo_gramsName.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_purchaseGrams);
            this.panel2.Controls.Add(this.btn_deleteGrams);
            this.panel2.Controls.Add(this.btn_viewGrams);
            this.panel2.Location = new System.Drawing.Point(757, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 146);
            this.panel2.TabIndex = 11;
            // 
            // btn_clearGrams
            // 
            this.btn_clearGrams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clearGrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearGrams.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clearGrams.Location = new System.Drawing.Point(480, 114);
            this.btn_clearGrams.Name = "btn_clearGrams";
            this.btn_clearGrams.Size = new System.Drawing.Size(79, 28);
            this.btn_clearGrams.TabIndex = 10;
            this.btn_clearGrams.Text = "Clear";
            this.btn_clearGrams.UseVisualStyleBackColor = false;
            this.btn_clearGrams.Click += new System.EventHandler(this.btn_clearGrams_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_gramsPrice
            // 
            this.txt_gramsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gramsPrice.Location = new System.Drawing.Point(381, 58);
            this.txt_gramsPrice.Name = "txt_gramsPrice";
            this.txt_gramsPrice.Size = new System.Drawing.Size(178, 21);
            this.txt_gramsPrice.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // txt_gramsQuantity
            // 
            this.txt_gramsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gramsQuantity.Location = new System.Drawing.Point(107, 57);
            this.txt_gramsQuantity.Name = "txt_gramsQuantity";
            this.txt_gramsQuantity.Size = new System.Drawing.Size(178, 21);
            this.txt_gramsQuantity.TabIndex = 3;
            // 
            // dataGridView_purchaseGrams
            // 
            this.dataGridView_purchaseGrams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_purchaseGrams.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_purchaseGrams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_purchaseGrams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_purchaseGrams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_purchaseGrams.DataSource = this.tblpurchaseGramsBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_purchaseGrams.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_purchaseGrams.Location = new System.Drawing.Point(0, 152);
            this.dataGridView_purchaseGrams.MultiSelect = false;
            this.dataGridView_purchaseGrams.Name = "dataGridView_purchaseGrams";
            this.dataGridView_purchaseGrams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_purchaseGrams.Size = new System.Drawing.Size(1052, 305);
            this.dataGridView_purchaseGrams.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combo_gramsName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_clearGrams);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_gramsPrice);
            this.panel1.Controls.Add(this.txt_gramsId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_gramsQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 146);
            this.panel1.TabIndex = 13;
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpurchaseGramsBindingSource
            // 
            this.tblpurchaseGramsBindingSource.DataMember = "tbl_purchaseGrams";
            this.tblpurchaseGramsBindingSource.DataSource = this.databasePCDataSet;
            // 
            // tbl_purchaseGramsTableAdapter
            // 
            this.tbl_purchaseGramsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
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
            this.selectDataGridViewCheckBoxColumn.Width = 60;
            // 
            // Form_PurchaseGrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.dataGridView_purchaseGrams);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_PurchaseGrams";
            this.Text = "Form_PurchaseGrams";
            this.Load += new System.EventHandler(this.Form_PurchaseGrams_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchaseGrams)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpurchaseGramsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_gramsId;
        private System.Windows.Forms.Button btn_purchaseGrams;
        private System.Windows.Forms.Button btn_deleteGrams;
        private System.Windows.Forms.Button btn_viewGrams;
        private System.Windows.Forms.ComboBox combo_gramsName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clearGrams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gramsPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gramsQuantity;
        private System.Windows.Forms.DataGridView dataGridView_purchaseGrams;
        private System.Windows.Forms.Panel panel1;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblpurchaseGramsBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_purchaseGramsTableAdapter tbl_purchaseGramsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}