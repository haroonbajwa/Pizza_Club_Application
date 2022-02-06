
namespace Pizza_Club
{
    partial class Form_usageGrams
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
            this.txt_usageName = new System.Windows.Forms.TextBox();
            this.btn_clearUsage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usageQty = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_updateUsage = new System.Windows.Forms.Button();
            this.btn_deleteUsage = new System.Windows.Forms.Button();
            this.btn_viewUsage = new System.Windows.Forms.Button();
            this.txt_usageId = new System.Windows.Forms.TextBox();
            this.dataGridView_usageGrams = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usageQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblusageGramsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbl_usageGramsTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_usageGramsTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usageGrams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusageGramsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_usageName
            // 
            this.txt_usageName.Enabled = false;
            this.txt_usageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usageName.Location = new System.Drawing.Point(381, 17);
            this.txt_usageName.Name = "txt_usageName";
            this.txt_usageName.Size = new System.Drawing.Size(178, 21);
            this.txt_usageName.TabIndex = 16;
            // 
            // btn_clearUsage
            // 
            this.btn_clearUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clearUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearUsage.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clearUsage.Location = new System.Drawing.Point(480, 110);
            this.btn_clearUsage.Name = "btn_clearUsage";
            this.btn_clearUsage.Size = new System.Drawing.Size(79, 28);
            this.btn_clearUsage.TabIndex = 10;
            this.btn_clearUsage.Text = "Reset";
            this.btn_clearUsage.UseVisualStyleBackColor = false;
            this.btn_clearUsage.Click += new System.EventHandler(this.btn_clearUsage_Click);
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
            // txt_usageQty
            // 
            this.txt_usageQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usageQty.Location = new System.Drawing.Point(107, 57);
            this.txt_usageQty.Name = "txt_usageQty";
            this.txt_usageQty.Size = new System.Drawing.Size(178, 21);
            this.txt_usageQty.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filter";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_updateUsage);
            this.panel2.Controls.Add(this.btn_deleteUsage);
            this.panel2.Controls.Add(this.btn_viewUsage);
            this.panel2.Location = new System.Drawing.Point(565, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 146);
            this.panel2.TabIndex = 11;
            // 
            // btn_updateUsage
            // 
            this.btn_updateUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_updateUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateUsage.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_updateUsage.Location = new System.Drawing.Point(3, 7);
            this.btn_updateUsage.Name = "btn_updateUsage";
            this.btn_updateUsage.Size = new System.Drawing.Size(140, 65);
            this.btn_updateUsage.TabIndex = 7;
            this.btn_updateUsage.Text = "Update";
            this.btn_updateUsage.UseVisualStyleBackColor = false;
            this.btn_updateUsage.Click += new System.EventHandler(this.btn_updateUsage_Click);
            // 
            // btn_deleteUsage
            // 
            this.btn_deleteUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_deleteUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUsage.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_deleteUsage.Location = new System.Drawing.Point(148, 7);
            this.btn_deleteUsage.Name = "btn_deleteUsage";
            this.btn_deleteUsage.Size = new System.Drawing.Size(140, 65);
            this.btn_deleteUsage.TabIndex = 9;
            this.btn_deleteUsage.Text = "Delete ";
            this.btn_deleteUsage.UseVisualStyleBackColor = false;
            this.btn_deleteUsage.Click += new System.EventHandler(this.btn_deleteUsage_Click);
            // 
            // btn_viewUsage
            // 
            this.btn_viewUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_viewUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewUsage.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_viewUsage.Location = new System.Drawing.Point(293, 7);
            this.btn_viewUsage.Name = "btn_viewUsage";
            this.btn_viewUsage.Size = new System.Drawing.Size(140, 65);
            this.btn_viewUsage.TabIndex = 8;
            this.btn_viewUsage.Text = "View";
            this.btn_viewUsage.UseVisualStyleBackColor = false;
            this.btn_viewUsage.Click += new System.EventHandler(this.btn_viewUsage_Click);
            // 
            // txt_usageId
            // 
            this.txt_usageId.Enabled = false;
            this.txt_usageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usageId.Location = new System.Drawing.Point(107, 17);
            this.txt_usageId.Name = "txt_usageId";
            this.txt_usageId.ReadOnly = true;
            this.txt_usageId.Size = new System.Drawing.Size(178, 21);
            this.txt_usageId.TabIndex = 1;
            // 
            // dataGridView_usageGrams
            // 
            this.dataGridView_usageGrams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_usageGrams.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_usageGrams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_usageGrams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_usageGrams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.usageQtyDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_usageGrams.DataSource = this.tblusageGramsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_usageGrams.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_usageGrams.Location = new System.Drawing.Point(0, 161);
            this.dataGridView_usageGrams.MultiSelect = false;
            this.dataGridView_usageGrams.Name = "dataGridView_usageGrams";
            this.dataGridView_usageGrams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_usageGrams.Size = new System.Drawing.Size(1052, 296);
            this.dataGridView_usageGrams.TabIndex = 17;
            this.dataGridView_usageGrams.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_usageGrams_MouseClick);
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
            // usageQtyDataGridViewTextBoxColumn
            // 
            this.usageQtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usageQtyDataGridViewTextBoxColumn.DataPropertyName = "usageQty";
            this.usageQtyDataGridViewTextBoxColumn.HeaderText = "Usage Qty";
            this.usageQtyDataGridViewTextBoxColumn.Name = "usageQtyDataGridViewTextBoxColumn";
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
            // tblusageGramsBindingSource
            // 
            this.tblusageGramsBindingSource.DataMember = "tbl_usageGrams";
            this.tblusageGramsBindingSource.DataSource = this.databasePCDataSet;
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_usageName);
            this.panel1.Controls.Add(this.btn_clearUsage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_usageId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_usageQty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 146);
            this.panel1.TabIndex = 18;
            // 
            // tbl_usageGramsTableAdapter
            // 
            this.tbl_usageGramsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_usageGrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.dataGridView_usageGrams);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_usageGrams";
            this.Text = "Form_usageGrams";
            this.Load += new System.EventHandler(this.Form_usageGrams_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usageGrams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusageGramsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_usageName;
        private System.Windows.Forms.Button btn_clearUsage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usageQty;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_updateUsage;
        private System.Windows.Forms.Button btn_deleteUsage;
        private System.Windows.Forms.Button btn_viewUsage;
        private System.Windows.Forms.TextBox txt_usageId;
        private System.Windows.Forms.DataGridView dataGridView_usageGrams;
        private System.Windows.Forms.Panel panel1;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblusageGramsBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_usageGramsTableAdapter tbl_usageGramsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usageQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}