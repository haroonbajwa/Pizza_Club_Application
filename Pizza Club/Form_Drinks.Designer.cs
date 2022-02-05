
namespace Pizza_Club
{
    partial class Form_Drinks
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
            this.dataGridView_drinks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbldrinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear_drinks = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_drinkId = new System.Windows.Forms.TextBox();
            this.txt_drinkName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_drinkPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_viewDrinks = new System.Windows.Forms.Button();
            this.btn_deleteDrink = new System.Windows.Forms.Button();
            this.btn_updateDrink = new System.Windows.Forms.Button();
            this.btn_addDrink = new System.Windows.Forms.Button();
            this.tbl_drinksTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_drinksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_drinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldrinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_drinks
            // 
            this.dataGridView_drinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_drinks.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_drinks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_drinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_drinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_drinks.DataSource = this.tbldrinksBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_drinks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_drinks.Location = new System.Drawing.Point(2, 154);
            this.dataGridView_drinks.MultiSelect = false;
            this.dataGridView_drinks.Name = "dataGridView_drinks";
            this.dataGridView_drinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_drinks.Size = new System.Drawing.Size(1050, 302);
            this.dataGridView_drinks.TabIndex = 9;
            this.dataGridView_drinks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_drinks_MouseClick);
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
            // tbldrinksBindingSource
            // 
            this.tbldrinksBindingSource.DataMember = "tbl_drinks";
            this.tbldrinksBindingSource.DataSource = this.databasePCDataSet;
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
            this.panel1.Controls.Add(this.btn_clear_drinks);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_drinkId);
            this.panel1.Controls.Add(this.txt_drinkName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_drinkPrice);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 146);
            this.panel1.TabIndex = 9;
            // 
            // btn_clear_drinks
            // 
            this.btn_clear_drinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clear_drinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear_drinks.Location = new System.Drawing.Point(529, 110);
            this.btn_clear_drinks.Name = "btn_clear_drinks";
            this.btn_clear_drinks.Size = new System.Drawing.Size(79, 28);
            this.btn_clear_drinks.TabIndex = 4;
            this.btn_clear_drinks.Text = "Reset";
            this.btn_clear_drinks.UseVisualStyleBackColor = false;
            this.btn_clear_drinks.Click += new System.EventHandler(this.btn_clear_drinks_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_drinkId
            // 
            this.txt_drinkId.Enabled = false;
            this.txt_drinkId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_drinkId.Location = new System.Drawing.Point(231, 10);
            this.txt_drinkId.Name = "txt_drinkId";
            this.txt_drinkId.ReadOnly = true;
            this.txt_drinkId.Size = new System.Drawing.Size(245, 21);
            this.txt_drinkId.TabIndex = 1;
            // 
            // txt_drinkName
            // 
            this.txt_drinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_drinkName.Location = new System.Drawing.Point(231, 49);
            this.txt_drinkName.Name = "txt_drinkName";
            this.txt_drinkName.Size = new System.Drawing.Size(245, 21);
            this.txt_drinkName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price ";
            // 
            // txt_drinkPrice
            // 
            this.txt_drinkPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_drinkPrice.Location = new System.Drawing.Point(231, 89);
            this.txt_drinkPrice.Name = "txt_drinkPrice";
            this.txt_drinkPrice.Size = new System.Drawing.Size(245, 21);
            this.txt_drinkPrice.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_viewDrinks);
            this.panel2.Controls.Add(this.btn_deleteDrink);
            this.panel2.Controls.Add(this.btn_updateDrink);
            this.panel2.Controls.Add(this.btn_addDrink);
            this.panel2.Location = new System.Drawing.Point(672, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 146);
            this.panel2.TabIndex = 10;
            // 
            // btn_viewDrinks
            // 
            this.btn_viewDrinks.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewDrinks.Location = new System.Drawing.Point(184, 74);
            this.btn_viewDrinks.Name = "btn_viewDrinks";
            this.btn_viewDrinks.Size = new System.Drawing.Size(181, 65);
            this.btn_viewDrinks.TabIndex = 8;
            this.btn_viewDrinks.Text = "View";
            this.btn_viewDrinks.UseVisualStyleBackColor = false;
            this.btn_viewDrinks.Click += new System.EventHandler(this.btn_viewDrinks_Click);
            // 
            // btn_deleteDrink
            // 
            this.btn_deleteDrink.BackColor = System.Drawing.Color.Red;
            this.btn_deleteDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteDrink.Location = new System.Drawing.Point(3, 73);
            this.btn_deleteDrink.Name = "btn_deleteDrink";
            this.btn_deleteDrink.Size = new System.Drawing.Size(175, 65);
            this.btn_deleteDrink.TabIndex = 7;
            this.btn_deleteDrink.Text = "Delete";
            this.btn_deleteDrink.UseVisualStyleBackColor = false;
            this.btn_deleteDrink.Click += new System.EventHandler(this.btn_deleteDrink_Click);
            // 
            // btn_updateDrink
            // 
            this.btn_updateDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateDrink.Location = new System.Drawing.Point(184, 4);
            this.btn_updateDrink.Name = "btn_updateDrink";
            this.btn_updateDrink.Size = new System.Drawing.Size(181, 65);
            this.btn_updateDrink.TabIndex = 6;
            this.btn_updateDrink.Text = "Update";
            this.btn_updateDrink.UseVisualStyleBackColor = false;
            this.btn_updateDrink.Click += new System.EventHandler(this.btn_updateDrink_Click);
            // 
            // btn_addDrink
            // 
            this.btn_addDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDrink.Location = new System.Drawing.Point(3, 4);
            this.btn_addDrink.Name = "btn_addDrink";
            this.btn_addDrink.Size = new System.Drawing.Size(175, 65);
            this.btn_addDrink.TabIndex = 5;
            this.btn_addDrink.Text = "ADD";
            this.btn_addDrink.UseVisualStyleBackColor = false;
            this.btn_addDrink.Click += new System.EventHandler(this.btn_addDrink_Click);
            // 
            // tbl_drinksTableAdapter
            // 
            this.tbl_drinksTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_drinks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Drinks";
            this.Text = "Form_Drinks";
            this.Load += new System.EventHandler(this.Form_Drinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_drinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldrinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_drinks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear_drinks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_drinkId;
        private System.Windows.Forms.TextBox txt_drinkName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_drinkPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_viewDrinks;
        private System.Windows.Forms.Button btn_deleteDrink;
        private System.Windows.Forms.Button btn_updateDrink;
        private System.Windows.Forms.Button btn_addDrink;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tbldrinksBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_drinksTableAdapter tbl_drinksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}