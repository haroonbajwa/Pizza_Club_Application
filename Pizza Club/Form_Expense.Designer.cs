
namespace Pizza_Club
{
    partial class Form_Expense
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
            this.dataGridView_expense = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblexpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clearExpnse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ExpenseId = new System.Windows.Forms.TextBox();
            this.txt_ExpenseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ExpensePrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_viewExpense = new System.Windows.Forms.Button();
            this.btn_deleteExpense = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_updateExpense = new System.Windows.Forms.Button();
            this.btn_addExpense = new System.Windows.Forms.Button();
            this.tbl_expenseTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_expenseTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label_grossTotalExp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblexpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_expense
            // 
            this.dataGridView_expense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_expense.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_expense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_expense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_expense.DataSource = this.tblexpenseBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_expense.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_expense.Location = new System.Drawing.Point(2, 182);
            this.dataGridView_expense.Name = "dataGridView_expense";
            this.dataGridView_expense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_expense.Size = new System.Drawing.Size(1050, 215);
            this.dataGridView_expense.TabIndex = 11;
            this.dataGridView_expense.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_expense_MouseClick);
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
            this.selectDataGridViewCheckBoxColumn.Width = 60;
            // 
            // tblexpenseBindingSource
            // 
            this.tblexpenseBindingSource.DataMember = "tbl_expense";
            this.tblexpenseBindingSource.DataSource = this.databasePCDataSet;
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
            this.panel1.Controls.Add(this.btn_clearExpnse);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_ExpenseId);
            this.panel1.Controls.Add(this.txt_ExpenseName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ExpensePrice);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 176);
            this.panel1.TabIndex = 12;
            // 
            // btn_clearExpnse
            // 
            this.btn_clearExpnse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clearExpnse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearExpnse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clearExpnse.Location = new System.Drawing.Point(519, 110);
            this.btn_clearExpnse.Name = "btn_clearExpnse";
            this.btn_clearExpnse.Size = new System.Drawing.Size(79, 28);
            this.btn_clearExpnse.TabIndex = 7;
            this.btn_clearExpnse.Text = "Clear";
            this.btn_clearExpnse.UseVisualStyleBackColor = false;
            this.btn_clearExpnse.Click += new System.EventHandler(this.btn_clearExpnse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_ExpenseId
            // 
            this.txt_ExpenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExpenseId.Location = new System.Drawing.Point(221, 10);
            this.txt_ExpenseId.Name = "txt_ExpenseId";
            this.txt_ExpenseId.ReadOnly = true;
            this.txt_ExpenseId.Size = new System.Drawing.Size(245, 21);
            this.txt_ExpenseId.TabIndex = 1;
            // 
            // txt_ExpenseName
            // 
            this.txt_ExpenseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExpenseName.Location = new System.Drawing.Point(221, 49);
            this.txt_ExpenseName.Name = "txt_ExpenseName";
            this.txt_ExpenseName.Size = new System.Drawing.Size(245, 21);
            this.txt_ExpenseName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price ";
            // 
            // txt_ExpensePrice
            // 
            this.txt_ExpensePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExpensePrice.Location = new System.Drawing.Point(221, 95);
            this.txt_ExpensePrice.Name = "txt_ExpensePrice";
            this.txt_ExpensePrice.Size = new System.Drawing.Size(245, 21);
            this.txt_ExpensePrice.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_viewExpense);
            this.panel2.Controls.Add(this.btn_deleteExpense);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_updateExpense);
            this.panel2.Controls.Add(this.btn_addExpense);
            this.panel2.Location = new System.Drawing.Point(672, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 176);
            this.panel2.TabIndex = 13;
            // 
            // btn_viewExpense
            // 
            this.btn_viewExpense.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewExpense.Location = new System.Drawing.Point(184, 74);
            this.btn_viewExpense.Name = "btn_viewExpense";
            this.btn_viewExpense.Size = new System.Drawing.Size(181, 65);
            this.btn_viewExpense.TabIndex = 10;
            this.btn_viewExpense.Text = "View";
            this.btn_viewExpense.UseVisualStyleBackColor = false;
            this.btn_viewExpense.Click += new System.EventHandler(this.btn_viewExpense_Click);
            // 
            // btn_deleteExpense
            // 
            this.btn_deleteExpense.BackColor = System.Drawing.Color.Red;
            this.btn_deleteExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteExpense.Location = new System.Drawing.Point(3, 73);
            this.btn_deleteExpense.Name = "btn_deleteExpense";
            this.btn_deleteExpense.Size = new System.Drawing.Size(175, 65);
            this.btn_deleteExpense.TabIndex = 9;
            this.btn_deleteExpense.Text = "Delete";
            this.btn_deleteExpense.UseVisualStyleBackColor = false;
            this.btn_deleteExpense.Click += new System.EventHandler(this.btn_deleteExpense_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filter";
            // 
            // btn_updateExpense
            // 
            this.btn_updateExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateExpense.Location = new System.Drawing.Point(184, 4);
            this.btn_updateExpense.Name = "btn_updateExpense";
            this.btn_updateExpense.Size = new System.Drawing.Size(181, 65);
            this.btn_updateExpense.TabIndex = 8;
            this.btn_updateExpense.Text = "Update";
            this.btn_updateExpense.UseVisualStyleBackColor = false;
            this.btn_updateExpense.Click += new System.EventHandler(this.btn_updateExpense_Click);
            // 
            // btn_addExpense
            // 
            this.btn_addExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addExpense.Location = new System.Drawing.Point(3, 4);
            this.btn_addExpense.Name = "btn_addExpense";
            this.btn_addExpense.Size = new System.Drawing.Size(175, 65);
            this.btn_addExpense.TabIndex = 7;
            this.btn_addExpense.Text = "ADD";
            this.btn_addExpense.UseVisualStyleBackColor = false;
            this.btn_addExpense.Click += new System.EventHandler(this.btn_addExpense_Click);
            // 
            // tbl_expenseTableAdapter
            // 
            this.tbl_expenseTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(559, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gross Total:-";
            // 
            // label_grossTotalExp
            // 
            this.label_grossTotalExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_grossTotalExp.AutoSize = true;
            this.label_grossTotalExp.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_grossTotalExp.Location = new System.Drawing.Point(737, 412);
            this.label_grossTotalExp.Name = "label_grossTotalExp";
            this.label_grossTotalExp.Size = new System.Drawing.Size(54, 26);
            this.label_grossTotalExp.TabIndex = 17;
            this.label_grossTotalExp.Text = "0.00";
            // 
            // Form_Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_grossTotalExp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_expense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Expense";
            this.Text = "Form_Expense";
            this.Load += new System.EventHandler(this.Form_Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblexpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_expense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clearExpnse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ExpenseId;
        private System.Windows.Forms.TextBox txt_ExpenseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ExpensePrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_viewExpense;
        private System.Windows.Forms.Button btn_deleteExpense;
        private System.Windows.Forms.Button btn_updateExpense;
        private System.Windows.Forms.Button btn_addExpense;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblexpenseBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_expenseTableAdapter tbl_expenseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_grossTotalExp;
    }
}