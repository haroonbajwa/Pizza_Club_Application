
namespace Pizza_Club
{
    partial class Form_Burgers
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
            this.dataGridView_burgers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblburgersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clearBurger = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BurgerId = new System.Windows.Forms.TextBox();
            this.txt_BurgerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BurgerPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_viewBurger = new System.Windows.Forms.Button();
            this.btn_deleteBurger = new System.Windows.Forms.Button();
            this.btn_updateBurger = new System.Windows.Forms.Button();
            this.btn_addBurger = new System.Windows.Forms.Button();
            this.tbl_burgersTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_burgersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_burgers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblburgersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_burgers
            // 
            this.dataGridView_burgers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_burgers.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_burgers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_burgers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_burgers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_burgers.DataSource = this.tblburgersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_burgers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_burgers.Location = new System.Drawing.Point(2, 154);
            this.dataGridView_burgers.MultiSelect = false;
            this.dataGridView_burgers.Name = "dataGridView_burgers";
            this.dataGridView_burgers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_burgers.Size = new System.Drawing.Size(1050, 303);
            this.dataGridView_burgers.TabIndex = 9;
            this.dataGridView_burgers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_burgers_MouseClick);
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
            // selectDataGridViewCheckBoxColumn
            // 
            this.selectDataGridViewCheckBoxColumn.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn.Name = "selectDataGridViewCheckBoxColumn";
            this.selectDataGridViewCheckBoxColumn.Width = 60;
            // 
            // tblburgersBindingSource
            // 
            this.tblburgersBindingSource.DataMember = "tbl_burgers";
            this.tblburgersBindingSource.DataSource = this.databasePCDataSet;
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_clearBurger);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_BurgerId);
            this.panel1.Controls.Add(this.txt_BurgerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_BurgerPrice);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 146);
            this.panel1.TabIndex = 7;
            // 
            // btn_clearBurger
            // 
            this.btn_clearBurger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clearBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clearBurger.Location = new System.Drawing.Point(510, 110);
            this.btn_clearBurger.Name = "btn_clearBurger";
            this.btn_clearBurger.Size = new System.Drawing.Size(79, 28);
            this.btn_clearBurger.TabIndex = 8;
            this.btn_clearBurger.Text = "Reset";
            this.btn_clearBurger.UseVisualStyleBackColor = false;
            this.btn_clearBurger.Click += new System.EventHandler(this.btn_clearBurger_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_BurgerId
            // 
            this.txt_BurgerId.Enabled = false;
            this.txt_BurgerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BurgerId.Location = new System.Drawing.Point(220, 10);
            this.txt_BurgerId.Name = "txt_BurgerId";
            this.txt_BurgerId.ReadOnly = true;
            this.txt_BurgerId.Size = new System.Drawing.Size(245, 21);
            this.txt_BurgerId.TabIndex = 1;
            // 
            // txt_BurgerName
            // 
            this.txt_BurgerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BurgerName.Location = new System.Drawing.Point(220, 48);
            this.txt_BurgerName.Name = "txt_BurgerName";
            this.txt_BurgerName.Size = new System.Drawing.Size(245, 21);
            this.txt_BurgerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price ";
            // 
            // txt_BurgerPrice
            // 
            this.txt_BurgerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BurgerPrice.Location = new System.Drawing.Point(220, 85);
            this.txt_BurgerPrice.Name = "txt_BurgerPrice";
            this.txt_BurgerPrice.Size = new System.Drawing.Size(245, 21);
            this.txt_BurgerPrice.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_viewBurger);
            this.panel2.Controls.Add(this.btn_deleteBurger);
            this.panel2.Controls.Add(this.btn_updateBurger);
            this.panel2.Controls.Add(this.btn_addBurger);
            this.panel2.Location = new System.Drawing.Point(672, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 146);
            this.panel2.TabIndex = 8;
            // 
            // btn_viewBurger
            // 
            this.btn_viewBurger.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewBurger.Location = new System.Drawing.Point(184, 74);
            this.btn_viewBurger.Name = "btn_viewBurger";
            this.btn_viewBurger.Size = new System.Drawing.Size(181, 65);
            this.btn_viewBurger.TabIndex = 7;
            this.btn_viewBurger.Text = "View";
            this.btn_viewBurger.UseVisualStyleBackColor = false;
            this.btn_viewBurger.Click += new System.EventHandler(this.btn_viewBurger_Click);
            // 
            // btn_deleteBurger
            // 
            this.btn_deleteBurger.BackColor = System.Drawing.Color.Red;
            this.btn_deleteBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteBurger.Location = new System.Drawing.Point(3, 73);
            this.btn_deleteBurger.Name = "btn_deleteBurger";
            this.btn_deleteBurger.Size = new System.Drawing.Size(175, 65);
            this.btn_deleteBurger.TabIndex = 6;
            this.btn_deleteBurger.Text = "Delete";
            this.btn_deleteBurger.UseVisualStyleBackColor = false;
            this.btn_deleteBurger.Click += new System.EventHandler(this.btn_deleteBurger_Click);
            // 
            // btn_updateBurger
            // 
            this.btn_updateBurger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateBurger.Location = new System.Drawing.Point(184, 4);
            this.btn_updateBurger.Name = "btn_updateBurger";
            this.btn_updateBurger.Size = new System.Drawing.Size(181, 65);
            this.btn_updateBurger.TabIndex = 5;
            this.btn_updateBurger.Text = "Update";
            this.btn_updateBurger.UseVisualStyleBackColor = false;
            this.btn_updateBurger.Click += new System.EventHandler(this.btn_updateBurger_Click);
            // 
            // btn_addBurger
            // 
            this.btn_addBurger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBurger.Location = new System.Drawing.Point(3, 4);
            this.btn_addBurger.Name = "btn_addBurger";
            this.btn_addBurger.Size = new System.Drawing.Size(175, 65);
            this.btn_addBurger.TabIndex = 4;
            this.btn_addBurger.Text = "ADD";
            this.btn_addBurger.UseVisualStyleBackColor = false;
            this.btn_addBurger.Click += new System.EventHandler(this.btn_addBurger_Click);
            // 
            // tbl_burgersTableAdapter
            // 
            this.tbl_burgersTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Burgers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_burgers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Burgers";
            this.Text = "Form_Burgers";
            this.Load += new System.EventHandler(this.Form_Burgers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_burgers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblburgersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_burgers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clearBurger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BurgerId;
        private System.Windows.Forms.TextBox txt_BurgerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BurgerPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_viewBurger;
        private System.Windows.Forms.Button btn_deleteBurger;
        private System.Windows.Forms.Button btn_updateBurger;
        private System.Windows.Forms.Button btn_addBurger;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblburgersBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_burgersTableAdapter tbl_burgersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}