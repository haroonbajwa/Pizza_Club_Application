
namespace Pizza_Club
{
    partial class Form_SideOderItems
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clearSideOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SideOrderId = new System.Windows.Forms.TextBox();
            this.txt_SideOrderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SideOrderPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_viewSideOrder = new System.Windows.Forms.Button();
            this.btn_deleteSideOrder = new System.Windows.Forms.Button();
            this.btn_updateSideOrder = new System.Windows.Forms.Button();
            this.btn_addSideOrder = new System.Windows.Forms.Button();
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.tblsideOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sideOrderTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_sideOrderTableAdapter();
            this.dataGridView_SideOrder = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsideOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SideOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_clearSideOrder);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_SideOrderId);
            this.panel1.Controls.Add(this.txt_SideOrderName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_SideOrderPrice);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 146);
            this.panel1.TabIndex = 8;
            // 
            // btn_clearSideOrder
            // 
            this.btn_clearSideOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clearSideOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearSideOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clearSideOrder.Location = new System.Drawing.Point(525, 109);
            this.btn_clearSideOrder.Name = "btn_clearSideOrder";
            this.btn_clearSideOrder.Size = new System.Drawing.Size(79, 28);
            this.btn_clearSideOrder.TabIndex = 8;
            this.btn_clearSideOrder.Text = "Reset";
            this.btn_clearSideOrder.UseVisualStyleBackColor = false;
            this.btn_clearSideOrder.Click += new System.EventHandler(this.btn_clearSideOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_SideOrderId
            // 
            this.txt_SideOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SideOrderId.Location = new System.Drawing.Point(231, 10);
            this.txt_SideOrderId.Name = "txt_SideOrderId";
            this.txt_SideOrderId.ReadOnly = true;
            this.txt_SideOrderId.Size = new System.Drawing.Size(245, 21);
            this.txt_SideOrderId.TabIndex = 1;
            // 
            // txt_SideOrderName
            // 
            this.txt_SideOrderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SideOrderName.Location = new System.Drawing.Point(231, 49);
            this.txt_SideOrderName.Name = "txt_SideOrderName";
            this.txt_SideOrderName.Size = new System.Drawing.Size(245, 21);
            this.txt_SideOrderName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price ";
            // 
            // txt_SideOrderPrice
            // 
            this.txt_SideOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SideOrderPrice.Location = new System.Drawing.Point(231, 90);
            this.txt_SideOrderPrice.Name = "txt_SideOrderPrice";
            this.txt_SideOrderPrice.Size = new System.Drawing.Size(245, 21);
            this.txt_SideOrderPrice.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_viewSideOrder);
            this.panel2.Controls.Add(this.btn_deleteSideOrder);
            this.panel2.Controls.Add(this.btn_updateSideOrder);
            this.panel2.Controls.Add(this.btn_addSideOrder);
            this.panel2.Location = new System.Drawing.Point(672, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 146);
            this.panel2.TabIndex = 9;
            // 
            // btn_viewSideOrder
            // 
            this.btn_viewSideOrder.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewSideOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewSideOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewSideOrder.Location = new System.Drawing.Point(184, 74);
            this.btn_viewSideOrder.Name = "btn_viewSideOrder";
            this.btn_viewSideOrder.Size = new System.Drawing.Size(181, 65);
            this.btn_viewSideOrder.TabIndex = 7;
            this.btn_viewSideOrder.Text = "View";
            this.btn_viewSideOrder.UseVisualStyleBackColor = false;
            this.btn_viewSideOrder.Click += new System.EventHandler(this.btn_viewSideOrder_Click);
            // 
            // btn_deleteSideOrder
            // 
            this.btn_deleteSideOrder.BackColor = System.Drawing.Color.Red;
            this.btn_deleteSideOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteSideOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteSideOrder.Location = new System.Drawing.Point(3, 73);
            this.btn_deleteSideOrder.Name = "btn_deleteSideOrder";
            this.btn_deleteSideOrder.Size = new System.Drawing.Size(175, 65);
            this.btn_deleteSideOrder.TabIndex = 6;
            this.btn_deleteSideOrder.Text = "Delete";
            this.btn_deleteSideOrder.UseVisualStyleBackColor = false;
            this.btn_deleteSideOrder.Click += new System.EventHandler(this.btn_deleteSideOrder_Click);
            // 
            // btn_updateSideOrder
            // 
            this.btn_updateSideOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateSideOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateSideOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateSideOrder.Location = new System.Drawing.Point(184, 4);
            this.btn_updateSideOrder.Name = "btn_updateSideOrder";
            this.btn_updateSideOrder.Size = new System.Drawing.Size(181, 65);
            this.btn_updateSideOrder.TabIndex = 5;
            this.btn_updateSideOrder.Text = "Update";
            this.btn_updateSideOrder.UseVisualStyleBackColor = false;
            this.btn_updateSideOrder.Click += new System.EventHandler(this.btn_updateSideOrder_Click);
            // 
            // btn_addSideOrder
            // 
            this.btn_addSideOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addSideOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSideOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSideOrder.Location = new System.Drawing.Point(3, 4);
            this.btn_addSideOrder.Name = "btn_addSideOrder";
            this.btn_addSideOrder.Size = new System.Drawing.Size(175, 65);
            this.btn_addSideOrder.TabIndex = 4;
            this.btn_addSideOrder.Text = "ADD";
            this.btn_addSideOrder.UseVisualStyleBackColor = false;
            this.btn_addSideOrder.Click += new System.EventHandler(this.btn_addSideOder_Click);
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsideOrderBindingSource
            // 
            this.tblsideOrderBindingSource.DataMember = "tbl_sideOrder";
            this.tblsideOrderBindingSource.DataSource = this.databasePCDataSet;
            // 
            // tbl_sideOrderTableAdapter
            // 
            this.tbl_sideOrderTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_SideOrder
            // 
            this.dataGridView_SideOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SideOrder.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_SideOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_SideOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SideOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_SideOrder.DataSource = this.tblsideOrderBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_SideOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_SideOrder.Location = new System.Drawing.Point(1, 154);
            this.dataGridView_SideOrder.MultiSelect = false;
            this.dataGridView_SideOrder.Name = "dataGridView_SideOrder";
            this.dataGridView_SideOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_SideOrder.Size = new System.Drawing.Size(1050, 303);
            this.dataGridView_SideOrder.TabIndex = 9;
            this.dataGridView_SideOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_SideOrder_MouseClick);
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
            // Form_SideOderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.dataGridView_SideOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SideOderItems";
            this.Text = "Form_SideOderItems";
            this.Load += new System.EventHandler(this.Form_SideOderItems_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsideOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SideOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clearSideOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SideOrderId;
        private System.Windows.Forms.TextBox txt_SideOrderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SideOrderPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_viewSideOrder;
        private System.Windows.Forms.Button btn_deleteSideOrder;
        private System.Windows.Forms.Button btn_updateSideOrder;
        private System.Windows.Forms.Button btn_addSideOrder;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblsideOrderBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_sideOrderTableAdapter tbl_sideOrderTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_SideOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}