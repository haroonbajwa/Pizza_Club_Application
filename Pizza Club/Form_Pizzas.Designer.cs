
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_clear_pizzas = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pizzaId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_viewPizzas = new System.Windows.Forms.Button();
            this.btn_deletePizza = new System.Windows.Forms.Button();
            this.btn_updatePizza = new System.Windows.Forms.Button();
            this.btn_addPizza = new System.Windows.Forms.Button();
            this.dataGridView_pizzas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblpizzasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.tbl_pizzasTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_pizzasTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pizzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpizzasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
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
            this.panel1.Controls.Add(this.btn_clear_pizzas);
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
            // btn_clear_pizzas
            // 
            this.btn_clear_pizzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clear_pizzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_pizzas.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear_pizzas.Location = new System.Drawing.Point(684, 111);
            this.btn_clear_pizzas.Name = "btn_clear_pizzas";
            this.btn_clear_pizzas.Size = new System.Drawing.Size(79, 28);
            this.btn_clear_pizzas.TabIndex = 7;
            this.btn_clear_pizzas.Text = "Clear";
            this.btn_clear_pizzas.UseVisualStyleBackColor = false;
            this.btn_clear_pizzas.Click += new System.EventHandler(this.btn_clear_pizzas_Click);
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
            this.txt_pizzaId.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_pizzas.DataSource = this.tblpizzasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_pizzas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_pizzas.Location = new System.Drawing.Point(1, 154);
            this.dataGridView_pizzas.MultiSelect = false;
            this.dataGridView_pizzas.Name = "dataGridView_pizzas";
            this.dataGridView_pizzas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pizzas.Size = new System.Drawing.Size(1050, 303);
            this.dataGridView_pizzas.TabIndex = 4;
            this.dataGridView_pizzas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_pizzas_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "priceS";
            this.dataGridViewTextBoxColumn3.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price (S)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "priceM";
            this.dataGridViewTextBoxColumn4.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price (M)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "priceL";
            this.dataGridViewTextBoxColumn5.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Price (L)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "priceXL";
            this.dataGridViewTextBoxColumn6.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Price (XL)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // selectDataGridViewCheckBoxColumn
            // 
            this.selectDataGridViewCheckBoxColumn.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn.FillWeight = 177.665F;
            this.selectDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn.Name = "selectDataGridViewCheckBoxColumn";
            this.selectDataGridViewCheckBoxColumn.Width = 50;
            // 
            // tblpizzasBindingSource
            // 
            this.tblpizzasBindingSource.DataMember = "tbl_pizzas";
            this.tblpizzasBindingSource.DataSource = this.databasePCDataSet;
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_pizzasTableAdapter
            // 
            this.tbl_pizzasTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceXLDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_clear_pizzas;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblpizzasBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_pizzasTableAdapter tbl_pizzasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}