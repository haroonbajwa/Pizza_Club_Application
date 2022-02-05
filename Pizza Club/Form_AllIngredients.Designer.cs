
namespace Pizza_Club
{
    partial class Form_AllIngredients
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_viewIng = new System.Windows.Forms.Button();
            this.btn_deleteIng = new System.Windows.Forms.Button();
            this.btn_updateIng = new System.Windows.Forms.Button();
            this.btn_addIng = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_ingType = new System.Windows.Forms.ComboBox();
            this.btn_clear_ing = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ingId = new System.Windows.Forms.TextBox();
            this.txt_ingName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Ingredients = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblallIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.tbl_allIngredientsTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_allIngredientsTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ingredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblallIngredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_viewIng);
            this.panel2.Controls.Add(this.btn_deleteIng);
            this.panel2.Controls.Add(this.btn_updateIng);
            this.panel2.Controls.Add(this.btn_addIng);
            this.panel2.Location = new System.Drawing.Point(670, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 146);
            this.panel2.TabIndex = 12;
            // 
            // btn_viewIng
            // 
            this.btn_viewIng.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewIng.Location = new System.Drawing.Point(184, 74);
            this.btn_viewIng.Name = "btn_viewIng";
            this.btn_viewIng.Size = new System.Drawing.Size(181, 65);
            this.btn_viewIng.TabIndex = 8;
            this.btn_viewIng.Text = "View";
            this.btn_viewIng.UseVisualStyleBackColor = false;
            this.btn_viewIng.Click += new System.EventHandler(this.btn_viewIng_Click);
            // 
            // btn_deleteIng
            // 
            this.btn_deleteIng.BackColor = System.Drawing.Color.Red;
            this.btn_deleteIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteIng.Location = new System.Drawing.Point(3, 73);
            this.btn_deleteIng.Name = "btn_deleteIng";
            this.btn_deleteIng.Size = new System.Drawing.Size(175, 65);
            this.btn_deleteIng.TabIndex = 7;
            this.btn_deleteIng.Text = "Delete";
            this.btn_deleteIng.UseVisualStyleBackColor = false;
            this.btn_deleteIng.Click += new System.EventHandler(this.btn_deleteIng_Click);
            // 
            // btn_updateIng
            // 
            this.btn_updateIng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateIng.Location = new System.Drawing.Point(184, 4);
            this.btn_updateIng.Name = "btn_updateIng";
            this.btn_updateIng.Size = new System.Drawing.Size(181, 65);
            this.btn_updateIng.TabIndex = 6;
            this.btn_updateIng.Text = "Update";
            this.btn_updateIng.UseVisualStyleBackColor = false;
            this.btn_updateIng.Click += new System.EventHandler(this.btn_updateIng_Click);
            // 
            // btn_addIng
            // 
            this.btn_addIng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addIng.Location = new System.Drawing.Point(3, 4);
            this.btn_addIng.Name = "btn_addIng";
            this.btn_addIng.Size = new System.Drawing.Size(175, 65);
            this.btn_addIng.TabIndex = 5;
            this.btn_addIng.Text = "ADD";
            this.btn_addIng.UseVisualStyleBackColor = false;
            this.btn_addIng.Click += new System.EventHandler(this.btn_addIng_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.combo_ingType);
            this.panel1.Controls.Add(this.btn_clear_ing);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_ingId);
            this.panel1.Controls.Add(this.txt_ingName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 146);
            this.panel1.TabIndex = 11;
            // 
            // combo_ingType
            // 
            this.combo_ingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_ingType.FormattingEnabled = true;
            this.combo_ingType.Items.AddRange(new object[] {
            "Pieces",
            "Grams"});
            this.combo_ingType.Location = new System.Drawing.Point(231, 89);
            this.combo_ingType.Name = "combo_ingType";
            this.combo_ingType.Size = new System.Drawing.Size(245, 23);
            this.combo_ingType.TabIndex = 5;
            // 
            // btn_clear_ing
            // 
            this.btn_clear_ing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clear_ing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_ing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear_ing.Location = new System.Drawing.Point(529, 110);
            this.btn_clear_ing.Name = "btn_clear_ing";
            this.btn_clear_ing.Size = new System.Drawing.Size(79, 28);
            this.btn_clear_ing.TabIndex = 4;
            this.btn_clear_ing.Text = "Reset";
            this.btn_clear_ing.UseVisualStyleBackColor = false;
            this.btn_clear_ing.Click += new System.EventHandler(this.btn_clear_ing_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_ingId
            // 
            this.txt_ingId.Enabled = false;
            this.txt_ingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ingId.Location = new System.Drawing.Point(231, 10);
            this.txt_ingId.Name = "txt_ingId";
            this.txt_ingId.ReadOnly = true;
            this.txt_ingId.Size = new System.Drawing.Size(245, 21);
            this.txt_ingId.TabIndex = 1;
            // 
            // txt_ingName
            // 
            this.txt_ingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ingName.Location = new System.Drawing.Point(231, 48);
            this.txt_ingName.Name = "txt_ingName";
            this.txt_ingName.Size = new System.Drawing.Size(245, 21);
            this.txt_ingName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            // 
            // dataGridView_Ingredients
            // 
            this.dataGridView_Ingredients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Ingredients.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Ingredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Ingredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ingredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_Ingredients.DataSource = this.tblallIngredientsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Ingredients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Ingredients.Location = new System.Drawing.Point(3, 159);
            this.dataGridView_Ingredients.MultiSelect = false;
            this.dataGridView_Ingredients.Name = "dataGridView_Ingredients";
            this.dataGridView_Ingredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Ingredients.Size = new System.Drawing.Size(1040, 290);
            this.dataGridView_Ingredients.TabIndex = 13;
            this.dataGridView_Ingredients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Ingredients_MouseClick);
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
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // selectDataGridViewCheckBoxColumn
            // 
            this.selectDataGridViewCheckBoxColumn.DataPropertyName = "select";
            this.selectDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.selectDataGridViewCheckBoxColumn.Name = "selectDataGridViewCheckBoxColumn";
            this.selectDataGridViewCheckBoxColumn.Width = 60;
            // 
            // tblallIngredientsBindingSource
            // 
            this.tblallIngredientsBindingSource.DataMember = "tbl_allIngredients";
            this.tblallIngredientsBindingSource.DataSource = this.databasePCDataSet;
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_allIngredientsTableAdapter
            // 
            this.tbl_allIngredientsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_AllIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.dataGridView_Ingredients);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AllIngredients";
            this.Text = "Form_AllIngredients";
            this.Load += new System.EventHandler(this.Form_AllIngredients_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ingredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblallIngredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_viewIng;
        private System.Windows.Forms.Button btn_deleteIng;
        private System.Windows.Forms.Button btn_updateIng;
        private System.Windows.Forms.Button btn_addIng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear_ing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ingId;
        private System.Windows.Forms.TextBox txt_ingName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_ingType;
        private System.Windows.Forms.DataGridView dataGridView_Ingredients;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblallIngredientsBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_allIngredientsTableAdapter tbl_allIngredientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}