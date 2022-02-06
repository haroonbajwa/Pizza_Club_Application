
namespace Pizza_Club
{
    partial class Form_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_viewStockPcs = new System.Windows.Forms.Button();
            this.btn_deleteStockPcs = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_updateStockPcs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_StockPcsId = new System.Windows.Forms.TextBox();
            this.txt_StockPcsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StockPcsQty = new System.Windows.Forms.TextBox();
            this.btn_clearStock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_viewStockGrams = new System.Windows.Forms.Button();
            this.btn_deleteStockGrams = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_updateStockGrams = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_StockGramsId = new System.Windows.Forms.TextBox();
            this.txt_StockGramsName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_StockGramsQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_stockPCS = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblstockPCSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.dataGridView_stockGrams = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblstockGramsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_stockPCSTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_stockPCSTableAdapter();
            this.tbl_stockGramsTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_stockGramsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockPCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockPCSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockGrams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockGramsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_viewStockPcs);
            this.panel1.Controls.Add(this.btn_deleteStockPcs);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_updateStockPcs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_StockPcsId);
            this.panel1.Controls.Add(this.txt_StockPcsName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_StockPcsQty);
            this.panel1.Location = new System.Drawing.Point(2, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 146);
            this.panel1.TabIndex = 10;
            // 
            // btn_viewStockPcs
            // 
            this.btn_viewStockPcs.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewStockPcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewStockPcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewStockPcs.Location = new System.Drawing.Point(283, 103);
            this.btn_viewStockPcs.Name = "btn_viewStockPcs";
            this.btn_viewStockPcs.Size = new System.Drawing.Size(128, 35);
            this.btn_viewStockPcs.TabIndex = 10;
            this.btn_viewStockPcs.Text = "View";
            this.btn_viewStockPcs.UseVisualStyleBackColor = false;
            this.btn_viewStockPcs.Click += new System.EventHandler(this.btn_viewStockPcs_Click);
            // 
            // btn_deleteStockPcs
            // 
            this.btn_deleteStockPcs.BackColor = System.Drawing.Color.Red;
            this.btn_deleteStockPcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteStockPcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteStockPcs.Location = new System.Drawing.Point(155, 103);
            this.btn_deleteStockPcs.Name = "btn_deleteStockPcs";
            this.btn_deleteStockPcs.Size = new System.Drawing.Size(122, 35);
            this.btn_deleteStockPcs.TabIndex = 9;
            this.btn_deleteStockPcs.Text = "Delete";
            this.btn_deleteStockPcs.UseVisualStyleBackColor = false;
            this.btn_deleteStockPcs.Click += new System.EventHandler(this.btn_deleteStockPcs_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // btn_updateStockPcs
            // 
            this.btn_updateStockPcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateStockPcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateStockPcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateStockPcs.Location = new System.Drawing.Point(21, 103);
            this.btn_updateStockPcs.Name = "btn_updateStockPcs";
            this.btn_updateStockPcs.Size = new System.Drawing.Size(128, 35);
            this.btn_updateStockPcs.TabIndex = 8;
            this.btn_updateStockPcs.Text = "Update";
            this.btn_updateStockPcs.UseVisualStyleBackColor = false;
            this.btn_updateStockPcs.Click += new System.EventHandler(this.btn_updateStockPcs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_StockPcsId
            // 
            this.txt_StockPcsId.Enabled = false;
            this.txt_StockPcsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StockPcsId.Location = new System.Drawing.Point(47, 10);
            this.txt_StockPcsId.Name = "txt_StockPcsId";
            this.txt_StockPcsId.ReadOnly = true;
            this.txt_StockPcsId.Size = new System.Drawing.Size(109, 21);
            this.txt_StockPcsId.TabIndex = 1;
            // 
            // txt_StockPcsName
            // 
            this.txt_StockPcsName.Enabled = false;
            this.txt_StockPcsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StockPcsName.Location = new System.Drawing.Point(233, 9);
            this.txt_StockPcsName.Name = "txt_StockPcsName";
            this.txt_StockPcsName.Size = new System.Drawing.Size(178, 21);
            this.txt_StockPcsName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity(pcs)";
            // 
            // txt_StockPcsQty
            // 
            this.txt_StockPcsQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StockPcsQty.Location = new System.Drawing.Point(233, 48);
            this.txt_StockPcsQty.Name = "txt_StockPcsQty";
            this.txt_StockPcsQty.Size = new System.Drawing.Size(178, 21);
            this.txt_StockPcsQty.TabIndex = 3;
            // 
            // btn_clearStock
            // 
            this.btn_clearStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_clearStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clearStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clearStock.Location = new System.Drawing.Point(459, 94);
            this.btn_clearStock.Name = "btn_clearStock";
            this.btn_clearStock.Size = new System.Drawing.Size(134, 45);
            this.btn_clearStock.TabIndex = 7;
            this.btn_clearStock.Text = "Reset";
            this.btn_clearStock.UseVisualStyleBackColor = false;
            this.btn_clearStock.Click += new System.EventHandler(this.btn_clearStock_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_viewStockGrams);
            this.panel2.Controls.Add(this.btn_deleteStockGrams);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_updateStockGrams);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_StockGramsId);
            this.panel2.Controls.Add(this.txt_StockGramsName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_StockGramsQty);
            this.panel2.Location = new System.Drawing.Point(599, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 146);
            this.panel2.TabIndex = 11;
            // 
            // btn_viewStockGrams
            // 
            this.btn_viewStockGrams.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewStockGrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewStockGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewStockGrams.Location = new System.Drawing.Point(283, 103);
            this.btn_viewStockGrams.Name = "btn_viewStockGrams";
            this.btn_viewStockGrams.Size = new System.Drawing.Size(128, 35);
            this.btn_viewStockGrams.TabIndex = 10;
            this.btn_viewStockGrams.Text = "View";
            this.btn_viewStockGrams.UseVisualStyleBackColor = false;
            this.btn_viewStockGrams.Click += new System.EventHandler(this.btn_viewStockGrams_Click);
            // 
            // btn_deleteStockGrams
            // 
            this.btn_deleteStockGrams.BackColor = System.Drawing.Color.Red;
            this.btn_deleteStockGrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteStockGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteStockGrams.Location = new System.Drawing.Point(155, 103);
            this.btn_deleteStockGrams.Name = "btn_deleteStockGrams";
            this.btn_deleteStockGrams.Size = new System.Drawing.Size(122, 35);
            this.btn_deleteStockGrams.TabIndex = 9;
            this.btn_deleteStockGrams.Text = "Delete";
            this.btn_deleteStockGrams.UseVisualStyleBackColor = false;
            this.btn_deleteStockGrams.Click += new System.EventHandler(this.btn_deleteStockGrams_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // btn_updateStockGrams
            // 
            this.btn_updateStockGrams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateStockGrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateStockGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateStockGrams.Location = new System.Drawing.Point(21, 103);
            this.btn_updateStockGrams.Name = "btn_updateStockGrams";
            this.btn_updateStockGrams.Size = new System.Drawing.Size(128, 35);
            this.btn_updateStockGrams.TabIndex = 8;
            this.btn_updateStockGrams.Text = "Update";
            this.btn_updateStockGrams.UseVisualStyleBackColor = false;
            this.btn_updateStockGrams.Click += new System.EventHandler(this.btn_updateStockGrams_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // txt_StockGramsId
            // 
            this.txt_StockGramsId.Enabled = false;
            this.txt_StockGramsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StockGramsId.Location = new System.Drawing.Point(47, 10);
            this.txt_StockGramsId.Name = "txt_StockGramsId";
            this.txt_StockGramsId.ReadOnly = true;
            this.txt_StockGramsId.Size = new System.Drawing.Size(109, 21);
            this.txt_StockGramsId.TabIndex = 1;
            // 
            // txt_StockGramsName
            // 
            this.txt_StockGramsName.Enabled = false;
            this.txt_StockGramsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StockGramsName.Location = new System.Drawing.Point(233, 9);
            this.txt_StockGramsName.Name = "txt_StockGramsName";
            this.txt_StockGramsName.Size = new System.Drawing.Size(178, 21);
            this.txt_StockGramsName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity(grams)";
            // 
            // txt_StockGramsQty
            // 
            this.txt_StockGramsQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StockGramsQty.Location = new System.Drawing.Point(233, 48);
            this.txt_StockGramsQty.Name = "txt_StockGramsQty";
            this.txt_StockGramsQty.Size = new System.Drawing.Size(178, 21);
            this.txt_StockGramsQty.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hobo Std", 27.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(100, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 52);
            this.label7.TabIndex = 12;
            this.label7.Text = "STOCK (PCS)";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Hobo Std", 27.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(662, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(333, 52);
            this.label8.TabIndex = 12;
            this.label8.Text = "STOCK (GRAMS)";
            // 
            // dataGridView_stockPCS
            // 
            this.dataGridView_stockPCS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_stockPCS.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_stockPCS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_stockPCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockPCS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_stockPCS.DataSource = this.tblstockPCSBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_stockPCS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_stockPCS.Location = new System.Drawing.Point(2, 217);
            this.dataGridView_stockPCS.MultiSelect = false;
            this.dataGridView_stockPCS.Name = "dataGridView_stockPCS";
            this.dataGridView_stockPCS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_stockPCS.Size = new System.Drawing.Size(525, 240);
            this.dataGridView_stockPCS.TabIndex = 13;
            this.dataGridView_stockPCS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_stockPCS_MouseClick);
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // selectDataGridViewCheckBoxColumn
            // 
            this.selectDataGridViewCheckBoxColumn.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn.Name = "selectDataGridViewCheckBoxColumn";
            this.selectDataGridViewCheckBoxColumn.Width = 60;
            // 
            // tblstockPCSBindingSource
            // 
            this.tblstockPCSBindingSource.DataMember = "tbl_stockPCS";
            this.tblstockPCSBindingSource.DataSource = this.databasePCDataSet;
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_stockGrams
            // 
            this.dataGridView_stockGrams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_stockGrams.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_stockGrams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_stockGrams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockGrams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.selectDataGridViewCheckBoxColumn1});
            this.dataGridView_stockGrams.DataSource = this.tblstockGramsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_stockGrams.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_stockGrams.Location = new System.Drawing.Point(533, 217);
            this.dataGridView_stockGrams.MultiSelect = false;
            this.dataGridView_stockGrams.Name = "dataGridView_stockGrams";
            this.dataGridView_stockGrams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_stockGrams.Size = new System.Drawing.Size(517, 240);
            this.dataGridView_stockGrams.TabIndex = 13;
            this.dataGridView_stockGrams.SelectionChanged += new System.EventHandler(this.dataGridView_stockGrams_SelectionChanged);
            this.dataGridView_stockGrams.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_stockGrams_MouseClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // selectDataGridViewCheckBoxColumn1
            // 
            this.selectDataGridViewCheckBoxColumn1.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn1.Name = "selectDataGridViewCheckBoxColumn1";
            this.selectDataGridViewCheckBoxColumn1.Width = 60;
            // 
            // tblstockGramsBindingSource
            // 
            this.tblstockGramsBindingSource.DataMember = "tbl_stockGrams";
            this.tblstockGramsBindingSource.DataSource = this.databasePCDataSet;
            // 
            // tbl_stockPCSTableAdapter
            // 
            this.tbl_stockPCSTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_stockGramsTableAdapter
            // 
            this.tbl_stockGramsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.dataGridView_stockGrams);
            this.Controls.Add(this.dataGridView_stockPCS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_clearStock);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Stock";
            this.Text = "Form_StockPrice";
            this.Load += new System.EventHandler(this.Form_Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockPCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockPCSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockGrams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockGramsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clearStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_StockPcsId;
        private System.Windows.Forms.TextBox txt_StockPcsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StockPcsQty;
        private System.Windows.Forms.Button btn_viewStockPcs;
        private System.Windows.Forms.Button btn_deleteStockPcs;
        private System.Windows.Forms.Button btn_updateStockPcs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_viewStockGrams;
        private System.Windows.Forms.Button btn_deleteStockGrams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_updateStockGrams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_StockGramsId;
        private System.Windows.Forms.TextBox txt_StockGramsName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_StockGramsQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_stockPCS;
        private System.Windows.Forms.DataGridView dataGridView_stockGrams;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblstockPCSBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_stockPCSTableAdapter tbl_stockPCSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource tblstockGramsBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_stockGramsTableAdapter tbl_stockGramsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn1;
    }
}