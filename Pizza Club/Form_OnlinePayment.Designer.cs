
namespace Pizza_Club
{
    partial class Form_OnlinePayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_filterPayment = new System.Windows.Forms.Button();
            this.radio_selectDatePayment = new System.Windows.Forms.RadioButton();
            this.radio_30DaysPayment = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_addPayment = new System.Windows.Forms.Button();
            this.btn_deletePayment = new System.Windows.Forms.Button();
            this.dataGridView_payment = new System.Windows.Forms.DataGridView();
            this.btn_viewPayment = new System.Windows.Forms.Button();
            this.label_grossTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_searchPayment = new System.Windows.Forms.TextBox();
            this.btn_clearPayment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_paymentPrice = new System.Windows.Forms.TextBox();
            this.txt_paymentName = new System.Windows.Forms.TextBox();
            this.txt_paymentId = new System.Windows.Forms.TextBox();
            this.databasePCDataSet = new Pizza_Club.DatabasePCDataSet();
            this.tblonlinePaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_onlinePaymentTableAdapter = new Pizza_Club.DatabasePCDataSetTableAdapters.tbl_onlinePaymentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblonlinePaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(572, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 30;
            this.label4.Text = "Gross Total:-";
            // 
            // btn_filterPayment
            // 
            this.btn_filterPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filterPayment.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_filterPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filterPayment.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filterPayment.Location = new System.Drawing.Point(372, 110);
            this.btn_filterPayment.Name = "btn_filterPayment";
            this.btn_filterPayment.Size = new System.Drawing.Size(93, 33);
            this.btn_filterPayment.TabIndex = 10;
            this.btn_filterPayment.Text = "Filter";
            this.btn_filterPayment.UseVisualStyleBackColor = false;
            this.btn_filterPayment.Click += new System.EventHandler(this.btn_filterPayment_Click);
            // 
            // radio_selectDatePayment
            // 
            this.radio_selectDatePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radio_selectDatePayment.AutoSize = true;
            this.radio_selectDatePayment.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_selectDatePayment.Location = new System.Drawing.Point(119, 119);
            this.radio_selectDatePayment.Name = "radio_selectDatePayment";
            this.radio_selectDatePayment.Size = new System.Drawing.Size(110, 24);
            this.radio_selectDatePayment.TabIndex = 8;
            this.radio_selectDatePayment.TabStop = true;
            this.radio_selectDatePayment.Text = "Select Date";
            this.radio_selectDatePayment.UseVisualStyleBackColor = true;
            // 
            // radio_30DaysPayment
            // 
            this.radio_30DaysPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radio_30DaysPayment.AutoSize = true;
            this.radio_30DaysPayment.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_30DaysPayment.Location = new System.Drawing.Point(29, 119);
            this.radio_30DaysPayment.Name = "radio_30DaysPayment";
            this.radio_30DaysPayment.Size = new System.Drawing.Size(84, 24);
            this.radio_30DaysPayment.TabIndex = 7;
            this.radio_30DaysPayment.TabStop = true;
            this.radio_30DaysPayment.Text = "30 Days";
            this.radio_30DaysPayment.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btn_addPayment
            // 
            this.btn_addPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPayment.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPayment.Location = new System.Drawing.Point(3, 7);
            this.btn_addPayment.Name = "btn_addPayment";
            this.btn_addPayment.Size = new System.Drawing.Size(140, 65);
            this.btn_addPayment.TabIndex = 4;
            this.btn_addPayment.Text = "ADD";
            this.btn_addPayment.UseVisualStyleBackColor = false;
            this.btn_addPayment.Click += new System.EventHandler(this.btn_addPayment_Click);
            // 
            // btn_deletePayment
            // 
            this.btn_deletePayment.BackColor = System.Drawing.Color.Red;
            this.btn_deletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePayment.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletePayment.Location = new System.Drawing.Point(148, 7);
            this.btn_deletePayment.Name = "btn_deletePayment";
            this.btn_deletePayment.Size = new System.Drawing.Size(140, 65);
            this.btn_deletePayment.TabIndex = 5;
            this.btn_deletePayment.Text = "Delete ";
            this.btn_deletePayment.UseVisualStyleBackColor = false;
            this.btn_deletePayment.Click += new System.EventHandler(this.btn_deletePayment_Click);
            // 
            // dataGridView_payment
            // 
            this.dataGridView_payment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_payment.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_payment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_payment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.selectDataGridViewCheckBoxColumn});
            this.dataGridView_payment.DataSource = this.tblonlinePaymentBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_payment.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_payment.Location = new System.Drawing.Point(1, 164);
            this.dataGridView_payment.MultiSelect = false;
            this.dataGridView_payment.Name = "dataGridView_payment";
            this.dataGridView_payment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_payment.Size = new System.Drawing.Size(1051, 239);
            this.dataGridView_payment.TabIndex = 28;
            this.dataGridView_payment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_payment_MouseClick);
            // 
            // btn_viewPayment
            // 
            this.btn_viewPayment.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_viewPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewPayment.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewPayment.Location = new System.Drawing.Point(293, 7);
            this.btn_viewPayment.Name = "btn_viewPayment";
            this.btn_viewPayment.Size = new System.Drawing.Size(140, 65);
            this.btn_viewPayment.TabIndex = 6;
            this.btn_viewPayment.Text = "View";
            this.btn_viewPayment.UseVisualStyleBackColor = false;
            this.btn_viewPayment.Click += new System.EventHandler(this.btn_viewPayment_Click);
            // 
            // label_grossTotal
            // 
            this.label_grossTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_grossTotal.AutoSize = true;
            this.label_grossTotal.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_grossTotal.Location = new System.Drawing.Point(750, 420);
            this.label_grossTotal.Name = "label_grossTotal";
            this.label_grossTotal.Size = new System.Drawing.Size(54, 26);
            this.label_grossTotal.TabIndex = 31;
            this.label_grossTotal.Text = "0.00";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Search";
            // 
            // txt_searchPayment
            // 
            this.txt_searchPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_searchPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchPayment.Location = new System.Drawing.Point(84, 136);
            this.txt_searchPayment.Name = "txt_searchPayment";
            this.txt_searchPayment.Size = new System.Drawing.Size(188, 22);
            this.txt_searchPayment.TabIndex = 26;
            this.txt_searchPayment.TextChanged += new System.EventHandler(this.txt_searchPayment_TextChanged);
            // 
            // btn_clearPayment
            // 
            this.btn_clearPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clearPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearPayment.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clearPayment.Location = new System.Drawing.Point(461, 130);
            this.btn_clearPayment.Name = "btn_clearPayment";
            this.btn_clearPayment.Size = new System.Drawing.Size(79, 28);
            this.btn_clearPayment.TabIndex = 25;
            this.btn_clearPayment.Text = "Reset";
            this.btn_clearPayment.UseVisualStyleBackColor = false;
            this.btn_clearPayment.Click += new System.EventHandler(this.btn_clearPayment_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_filterPayment);
            this.panel2.Controls.Add(this.radio_selectDatePayment);
            this.panel2.Controls.Add(this.radio_30DaysPayment);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btn_addPayment);
            this.panel2.Controls.Add(this.btn_deletePayment);
            this.panel2.Controls.Add(this.btn_viewPayment);
            this.panel2.Location = new System.Drawing.Point(561, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 148);
            this.panel2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID";
            // 
            // txt_paymentPrice
            // 
            this.txt_paymentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentPrice.Location = new System.Drawing.Point(362, 65);
            this.txt_paymentPrice.Name = "txt_paymentPrice";
            this.txt_paymentPrice.Size = new System.Drawing.Size(178, 21);
            this.txt_paymentPrice.TabIndex = 24;
            // 
            // txt_paymentName
            // 
            this.txt_paymentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentName.Location = new System.Drawing.Point(362, 28);
            this.txt_paymentName.Name = "txt_paymentName";
            this.txt_paymentName.Size = new System.Drawing.Size(178, 21);
            this.txt_paymentName.TabIndex = 23;
            // 
            // txt_paymentId
            // 
            this.txt_paymentId.Enabled = false;
            this.txt_paymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentId.Location = new System.Drawing.Point(108, 27);
            this.txt_paymentId.Name = "txt_paymentId";
            this.txt_paymentId.ReadOnly = true;
            this.txt_paymentId.Size = new System.Drawing.Size(178, 21);
            this.txt_paymentId.TabIndex = 19;
            // 
            // databasePCDataSet
            // 
            this.databasePCDataSet.DataSetName = "DatabasePCDataSet";
            this.databasePCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblonlinePaymentBindingSource
            // 
            this.tblonlinePaymentBindingSource.DataMember = "tbl_onlinePayment";
            this.tblonlinePaymentBindingSource.DataSource = this.databasePCDataSet;
            // 
            // tbl_onlinePaymentTableAdapter
            // 
            this.tbl_onlinePaymentTableAdapter.ClearBeforeFill = true;
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
            this.selectDataGridViewCheckBoxColumn.Visible = false;
            this.selectDataGridViewCheckBoxColumn.Width = 60;
            // 
            // Form_OnlinePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1052, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_payment);
            this.Controls.Add(this.label_grossTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_searchPayment);
            this.Controls.Add(this.btn_clearPayment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_paymentPrice);
            this.Controls.Add(this.txt_paymentName);
            this.Controls.Add(this.txt_paymentId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_OnlinePayment";
            this.Text = "Form_OnlinePayment";
            this.Load += new System.EventHandler(this.Form_OnlinePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasePCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblonlinePaymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_filterPayment;
        private System.Windows.Forms.RadioButton radio_selectDatePayment;
        private System.Windows.Forms.RadioButton radio_30DaysPayment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_addPayment;
        private System.Windows.Forms.Button btn_deletePayment;
        private System.Windows.Forms.DataGridView dataGridView_payment;
        private System.Windows.Forms.Button btn_viewPayment;
        private System.Windows.Forms.Label label_grossTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_searchPayment;
        private System.Windows.Forms.Button btn_clearPayment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_paymentPrice;
        private System.Windows.Forms.TextBox txt_paymentName;
        private System.Windows.Forms.TextBox txt_paymentId;
        private DatabasePCDataSet databasePCDataSet;
        private System.Windows.Forms.BindingSource tblonlinePaymentBindingSource;
        private DatabasePCDataSetTableAdapters.tbl_onlinePaymentTableAdapter tbl_onlinePaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDataGridViewCheckBoxColumn;
    }
}