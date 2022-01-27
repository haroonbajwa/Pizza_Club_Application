
namespace Pizza_Club
{
    partial class Form_Pizzas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pizzaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_priceS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_priceM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_priceL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_priceXL = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pizzaId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_viewPizzas = new System.Windows.Forms.Button();
            this.btn_deletePizza = new System.Windows.Forms.Button();
            this.btn_updatePizza = new System.Windows.Forms.Button();
            this.btn_addPizza = new System.Windows.Forms.Button();
            this.dataGridView_pizzas = new System.Windows.Forms.DataGridView();
            this.tblpizzasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Pizza_Club.DatabaseDataSet();
            this.tbl_pizzasTableAdapter = new Pizza_Club.DatabaseDataSetTableAdapters.tbl_pizzasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceXLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pizzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpizzasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_pizzaName
            // 
            this.txt_pizzaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pizzaName.Location = new System.Drawing.Point(332, 3);
            this.txt_pizzaName.Name = "txt_pizzaName";
            this.txt_pizzaName.Size = new System.Drawing.Size(178, 21);
            this.txt_pizzaName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price (S)";
            // 
            // txt_priceS
            // 
            this.txt_priceS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priceS.Location = new System.Drawing.Point(591, 3);
            this.txt_priceS.Name = "txt_priceS";
            this.txt_priceS.Size = new System.Drawing.Size(178, 21);
            this.txt_priceS.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price (M)";
            // 
            // txt_priceM
            // 
            this.txt_priceM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priceM.Location = new System.Drawing.Point(73, 47);
            this.txt_priceM.Name = "txt_priceM";
            this.txt_priceM.Size = new System.Drawing.Size(178, 21);
            this.txt_priceM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price (L)";
            // 
            // txt_priceL
            // 
            this.txt_priceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priceL.Location = new System.Drawing.Point(332, 47);
            this.txt_priceL.Name = "txt_priceL";
            this.txt_priceL.Size = new System.Drawing.Size(178, 21);
            this.txt_priceL.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price (XL)";
            // 
            // txt_priceXL
            // 
            this.txt_priceXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priceXL.Location = new System.Drawing.Point(591, 46);
            this.txt_priceXL.Name = "txt_priceXL";
            this.txt_priceXL.Size = new System.Drawing.Size(178, 21);
            this.txt_priceXL.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_priceXL);
            this.panel1.Controls.Add(this.txt_pizzaId);
            this.panel1.Controls.Add(this.txt_pizzaName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_priceL);
            this.panel1.Controls.Add(this.txt_priceS);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_priceM);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 146);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // txt_pizzaId
            // 
            this.txt_pizzaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pizzaId.Location = new System.Drawing.Point(73, 4);
            this.txt_pizzaId.Name = "txt_pizzaId";
            this.txt_pizzaId.Size = new System.Drawing.Size(178, 21);
            this.txt_pizzaId.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_viewPizzas);
            this.panel2.Controls.Add(this.btn_deletePizza);
            this.panel2.Controls.Add(this.btn_updatePizza);
            this.panel2.Controls.Add(this.btn_addPizza);
            this.panel2.Location = new System.Drawing.Point(771, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 146);
            this.panel2.TabIndex = 3;
            // 
            // btn_viewPizzas
            // 
            this.btn_viewPizzas.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewPizzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewPizzas.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewPizzas.Location = new System.Drawing.Point(143, 74);
            this.btn_viewPizzas.Name = "btn_viewPizzas";
            this.btn_viewPizzas.Size = new System.Drawing.Size(135, 65);
            this.btn_viewPizzas.TabIndex = 10;
            this.btn_viewPizzas.Text = "View";
            this.btn_viewPizzas.UseVisualStyleBackColor = false;
            this.btn_viewPizzas.Click += new System.EventHandler(this.btn_viewPizzas_Click);
            // 
            // btn_deletePizza
            // 
            this.btn_deletePizza.BackColor = System.Drawing.Color.Red;
            this.btn_deletePizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePizza.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletePizza.Location = new System.Drawing.Point(3, 74);
            this.btn_deletePizza.Name = "btn_deletePizza";
            this.btn_deletePizza.Size = new System.Drawing.Size(135, 65);
            this.btn_deletePizza.TabIndex = 9;
            this.btn_deletePizza.Text = "Delete";
            this.btn_deletePizza.UseVisualStyleBackColor = false;
            this.btn_deletePizza.Click += new System.EventHandler(this.btn_deletePizza_Click);
            // 
            // btn_updatePizza
            // 
            this.btn_updatePizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updatePizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatePizza.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePizza.Location = new System.Drawing.Point(143, 3);
            this.btn_updatePizza.Name = "btn_updatePizza";
            this.btn_updatePizza.Size = new System.Drawing.Size(135, 65);
            this.btn_updatePizza.TabIndex = 8;
            this.btn_updatePizza.Text = "Update";
            this.btn_updatePizza.UseVisualStyleBackColor = false;
            this.btn_updatePizza.Click += new System.EventHandler(this.btn_updatePizza_Click);
            // 
            // btn_addPizza
            // 
            this.btn_addPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPizza.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPizza.Location = new System.Drawing.Point(3, 3);
            this.btn_addPizza.Name = "btn_addPizza";
            this.btn_addPizza.Size = new System.Drawing.Size(135, 65);
            this.btn_addPizza.TabIndex = 7;
            this.btn_addPizza.Text = "ADD";
            this.btn_addPizza.UseVisualStyleBackColor = false;
            this.btn_addPizza.Click += new System.EventHandler(this.btn_addPizza_Click);
            // 
            // dataGridView_pizzas
            // 
            this.dataGridView_pizzas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_pizzas.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_pizzas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_pizzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pizzas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceSDataGridViewTextBoxColumn,
            this.priceMDataGridViewTextBoxColumn,
            this.priceLDataGridViewTextBoxColumn,
            this.priceXLDataGridViewTextBoxColumn});
            this.dataGridView_pizzas.DataSource = this.tblpizzasBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_pizzas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_pizzas.Location = new System.Drawing.Point(1, 154);
            this.dataGridView_pizzas.Name = "dataGridView_pizzas";
            this.dataGridView_pizzas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pizzas.Size = new System.Drawing.Size(1050, 303);
            this.dataGridView_pizzas.TabIndex = 4;
            // 
            // tblpizzasBindingSource
            // 
            this.tblpizzasBindingSource.DataMember = "tbl_pizzas";
            this.tblpizzasBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_pizzasTableAdapter
            // 
            this.tbl_pizzasTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F);
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F);
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceSDataGridViewTextBoxColumn
            // 
            this.priceSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceSDataGridViewTextBoxColumn.DataPropertyName = "priceS";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F);
            this.priceSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.priceSDataGridViewTextBoxColumn.HeaderText = "Price (S)";
            this.priceSDataGridViewTextBoxColumn.Name = "priceSDataGridViewTextBoxColumn";
            // 
            // priceMDataGridViewTextBoxColumn
            // 
            this.priceMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceMDataGridViewTextBoxColumn.DataPropertyName = "priceM";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F);
            this.priceMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.priceMDataGridViewTextBoxColumn.HeaderText = "Price (M)";
            this.priceMDataGridViewTextBoxColumn.Name = "priceMDataGridViewTextBoxColumn";
            // 
            // priceLDataGridViewTextBoxColumn
            // 
            this.priceLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceLDataGridViewTextBoxColumn.DataPropertyName = "priceL";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F);
            this.priceLDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.priceLDataGridViewTextBoxColumn.HeaderText = "Price (L)";
            this.priceLDataGridViewTextBoxColumn.Name = "priceLDataGridViewTextBoxColumn";
            // 
            // priceXLDataGridViewTextBoxColumn
            // 
            this.priceXLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceXLDataGridViewTextBoxColumn.DataPropertyName = "priceXL";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F);
            this.priceXLDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.priceXLDataGridViewTextBoxColumn.HeaderText = "Price (XL)";
            this.priceXLDataGridViewTextBoxColumn.Name = "priceXLDataGridViewTextBoxColumn";
            // 
            // Form_Pizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.dataGridView_pizzas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Pizzas";
            this.Text = "Form_Pizzas";
            this.Load += new System.EventHandler(this.Form_Pizzas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pizzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpizzasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pizzaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_priceS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_priceM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_priceL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_priceXL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pizzaId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_viewPizzas;
        private System.Windows.Forms.Button btn_deletePizza;
        private System.Windows.Forms.Button btn_updatePizza;
        private System.Windows.Forms.Button btn_addPizza;
        private System.Windows.Forms.DataGridView dataGridView_pizzas;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tblpizzasBindingSource;
        private DatabaseDataSetTableAdapters.tbl_pizzasTableAdapter tbl_pizzasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceXLDataGridViewTextBoxColumn;
    }
}