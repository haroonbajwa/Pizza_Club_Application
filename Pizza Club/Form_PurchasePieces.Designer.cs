﻿
namespace Pizza_Club
{
    partial class purchase_pieces
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_purchasePCS = new System.Windows.Forms.DataGridView();
            this.tblpurchasePCSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pcsName = new System.Windows.Forms.TextBox();
            this.txt_pcsId = new System.Windows.Forms.TextBox();
            this.txt_pcsPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clearPCS = new System.Windows.Forms.Button();
            this.btn_deletePCS = new System.Windows.Forms.Button();
            this.btn_viewPCS = new System.Windows.Forms.Button();
            this.btn_purchasePCS = new System.Windows.Forms.Button();
            this.txt_pcsQuantity = new System.Windows.Forms.TextBox();
            this.tbl_purchasePCSTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_purchasePCSTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchasePCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpurchasePCSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_purchasePCS
            // 
            this.dataGridView_purchasePCS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_purchasePCS.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_purchasePCS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_purchasePCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_purchasePCS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_purchasePCS.DataSource = this.tblpurchasePCSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_purchasePCS.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_purchasePCS.Location = new System.Drawing.Point(0, 152);
            this.dataGridView_purchasePCS.MultiSelect = false;
            this.dataGridView_purchasePCS.Name = "dataGridView_purchasePCS";
            this.dataGridView_purchasePCS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_purchasePCS.Size = new System.Drawing.Size(1052, 305);
            this.dataGridView_purchasePCS.TabIndex = 5;
            // 
            // tblpurchasePCSBindingSource
            // 
            this.tblpurchasePCSBindingSource.DataMember = "tbl_purchasePCS";
            this.tblpurchasePCSBindingSource.DataSource = this.databasePCDataSet;
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_pcsName
            // 
            this.txt_pcsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pcsName.Location = new System.Drawing.Point(381, 17);
            this.txt_pcsName.Name = "txt_pcsName";
            this.txt_pcsName.Size = new System.Drawing.Size(178, 21);
            this.txt_pcsName.TabIndex = 2;
            // 
            // txt_pcsId
            // 
            this.txt_pcsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pcsId.Location = new System.Drawing.Point(107, 17);
            this.txt_pcsId.Name = "txt_pcsId";
            this.txt_pcsId.ReadOnly = true;
            this.txt_pcsId.Size = new System.Drawing.Size(178, 21);
            this.txt_pcsId.TabIndex = 1;
            // 
            // txt_pcsPrice
            // 
            this.txt_pcsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pcsPrice.Location = new System.Drawing.Point(381, 58);
            this.txt_pcsPrice.Name = "txt_pcsPrice";
            this.txt_pcsPrice.Size = new System.Drawing.Size(178, 21);
            this.txt_pcsPrice.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_clearPCS);
            this.panel1.Controls.Add(this.btn_deletePCS);
            this.panel1.Controls.Add(this.btn_viewPCS);
            this.panel1.Controls.Add(this.btn_purchasePCS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_pcsPrice);
            this.panel1.Controls.Add(this.txt_pcsId);
            this.panel1.Controls.Add(this.txt_pcsName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_pcsQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 146);
            this.panel1.TabIndex = 11;
            // 
            // btn_clearPCS
            // 
            this.btn_clearPCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clearPCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearPCS.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clearPCS.Location = new System.Drawing.Point(480, 114);
            this.btn_clearPCS.Name = "btn_clearPCS";
            this.btn_clearPCS.Size = new System.Drawing.Size(79, 28);
            this.btn_clearPCS.TabIndex = 10;
            this.btn_clearPCS.Text = "Clear";
            this.btn_clearPCS.UseVisualStyleBackColor = false;
            this.btn_clearPCS.Click += new System.EventHandler(this.btn_clearPCS_Click);
            // 
            // btn_deletePCS
            // 
            this.btn_deletePCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_deletePCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_deletePCS.Location = new System.Drawing.Point(814, 7);
            this.btn_deletePCS.Name = "btn_deletePCS";
            this.btn_deletePCS.Size = new System.Drawing.Size(140, 65);
            this.btn_deletePCS.TabIndex = 9;
            this.btn_deletePCS.Text = "Delete ";
            this.btn_deletePCS.UseVisualStyleBackColor = false;
            this.btn_deletePCS.Click += new System.EventHandler(this.btn_deletePCS_Click);
            // 
            // btn_viewPCS
            // 
            this.btn_viewPCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_viewPCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewPCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_viewPCS.Location = new System.Drawing.Point(668, 77);
            this.btn_viewPCS.Name = "btn_viewPCS";
            this.btn_viewPCS.Size = new System.Drawing.Size(140, 65);
            this.btn_viewPCS.TabIndex = 8;
            this.btn_viewPCS.Text = "View";
            this.btn_viewPCS.UseVisualStyleBackColor = false;
            this.btn_viewPCS.Click += new System.EventHandler(this.btn_viewPCS_Click);
            // 
            // btn_purchasePCS
            // 
            this.btn_purchasePCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_purchasePCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchasePCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_purchasePCS.Location = new System.Drawing.Point(668, 7);
            this.btn_purchasePCS.Name = "btn_purchasePCS";
            this.btn_purchasePCS.Size = new System.Drawing.Size(140, 65);
            this.btn_purchasePCS.TabIndex = 7;
            this.btn_purchasePCS.Text = "Purchase";
            this.btn_purchasePCS.UseVisualStyleBackColor = false;
            this.btn_purchasePCS.Click += new System.EventHandler(this.btn_purchasePCS_Click);
            // 
            // txt_pcsQuantity
            // 
            this.txt_pcsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pcsQuantity.Location = new System.Drawing.Point(107, 57);
            this.txt_pcsQuantity.Name = "txt_pcsQuantity";
            this.txt_pcsQuantity.Size = new System.Drawing.Size(178, 21);
            this.txt_pcsQuantity.TabIndex = 3;
            // 
            // tbl_purchasePCSTableAdapter
            // 
            this.tbl_purchasePCSTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            // selectDataGridViewCheckBoxColumn
            // 
            this.selectDataGridViewCheckBoxColumn.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn.Name = "selectDataGridViewCheckBoxColumn";
            this.selectDataGridViewCheckBoxColumn.Width = 60;
            // 
            // purchase_pieces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_purchasePCS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "purchase_pieces";
            this.Text = "purchase_pieces";
            this.Load += new System.EventHandler(this.purchase_pieces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchasePCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpurchasePCSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_purchasePCS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pcsName;
        private System.Windows.Forms.TextBox txt_pcsId;
        private System.Windows.Forms.TextBox txt_pcsPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pcsQuantity;
        private System.Windows.Forms.Button btn_purchasePCS;
        private System.Windows.Forms.Button btn_deletePCS;
        private System.Windows.Forms.Button btn_viewPCS;
        private System.Windows.Forms.Button btn_clearPCS;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblpurchasePCSBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_purchasePCSTableAdapter tbl_purchasePCSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}