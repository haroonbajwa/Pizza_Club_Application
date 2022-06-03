
namespace Pizza_Club
{
    partial class Form_AddRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddRecord));
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_expenseId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_expenseAdd = new System.Windows.Forms.Button();
            this.txt_expensePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_expenseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_purchaseAdd = new System.Windows.Forms.Button();
            this.txt_purchasePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_purchaseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_purchaseId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_paymentAdd = new System.Windows.Forms.Button();
            this.txt_paymentPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_paymentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_paymentId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(760, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID";
            // 
            // txt_expenseId
            // 
            this.txt_expenseId.Enabled = false;
            this.txt_expenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expenseId.Location = new System.Drawing.Point(120, 22);
            this.txt_expenseId.Name = "txt_expenseId";
            this.txt_expenseId.ReadOnly = true;
            this.txt_expenseId.Size = new System.Drawing.Size(245, 21);
            this.txt_expenseId.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_expenseAdd);
            this.groupBox1.Controls.Add(this.txt_expensePrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_expenseName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_expenseId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(176, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD EXPENSE";
            // 
            // btn_expenseAdd
            // 
            this.btn_expenseAdd.BackColor = System.Drawing.Color.White;
            this.btn_expenseAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expenseAdd.Image = ((System.Drawing.Image)(resources.GetObject("btn_expenseAdd.Image")));
            this.btn_expenseAdd.Location = new System.Drawing.Point(384, 23);
            this.btn_expenseAdd.Name = "btn_expenseAdd";
            this.btn_expenseAdd.Size = new System.Drawing.Size(90, 74);
            this.btn_expenseAdd.TabIndex = 4;
            this.btn_expenseAdd.UseVisualStyleBackColor = false;
            this.btn_expenseAdd.Click += new System.EventHandler(this.btn_expenseAdd_Click);
            // 
            // txt_expensePrice
            // 
            this.txt_expensePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expensePrice.Location = new System.Drawing.Point(120, 76);
            this.txt_expensePrice.Name = "txt_expensePrice";
            this.txt_expensePrice.Size = new System.Drawing.Size(245, 21);
            this.txt_expensePrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // txt_expenseName
            // 
            this.txt_expenseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expenseName.Location = new System.Drawing.Point(120, 49);
            this.txt_expenseName.Name = "txt_expenseName";
            this.txt_expenseName.Size = new System.Drawing.Size(245, 21);
            this.txt_expenseName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_purchaseAdd);
            this.groupBox2.Controls.Add(this.txt_purchasePrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_purchaseName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_purchaseId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(176, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 115);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADD PURCHASE";
            // 
            // btn_purchaseAdd
            // 
            this.btn_purchaseAdd.BackColor = System.Drawing.Color.White;
            this.btn_purchaseAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchaseAdd.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchaseAdd.Image")));
            this.btn_purchaseAdd.Location = new System.Drawing.Point(384, 23);
            this.btn_purchaseAdd.Name = "btn_purchaseAdd";
            this.btn_purchaseAdd.Size = new System.Drawing.Size(90, 74);
            this.btn_purchaseAdd.TabIndex = 8;
            this.btn_purchaseAdd.UseVisualStyleBackColor = false;
            this.btn_purchaseAdd.Click += new System.EventHandler(this.btn_purchaseAdd_Click);
            // 
            // txt_purchasePrice
            // 
            this.txt_purchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchasePrice.Location = new System.Drawing.Point(120, 76);
            this.txt_purchasePrice.Name = "txt_purchasePrice";
            this.txt_purchasePrice.Size = new System.Drawing.Size(245, 21);
            this.txt_purchasePrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // txt_purchaseName
            // 
            this.txt_purchaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchaseName.Location = new System.Drawing.Point(120, 49);
            this.txt_purchaseName.Name = "txt_purchaseName";
            this.txt_purchaseName.Size = new System.Drawing.Size(245, 21);
            this.txt_purchaseName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // txt_purchaseId
            // 
            this.txt_purchaseId.Enabled = false;
            this.txt_purchaseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchaseId.Location = new System.Drawing.Point(120, 22);
            this.txt_purchaseId.Name = "txt_purchaseId";
            this.txt_purchaseId.ReadOnly = true;
            this.txt_purchaseId.Size = new System.Drawing.Size(245, 21);
            this.txt_purchaseId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_paymentAdd);
            this.groupBox3.Controls.Add(this.txt_paymentPrice);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_paymentName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_paymentId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(176, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 115);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ADD ONLINE PAYMENT";
            // 
            // btn_paymentAdd
            // 
            this.btn_paymentAdd.BackColor = System.Drawing.Color.White;
            this.btn_paymentAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paymentAdd.Image = ((System.Drawing.Image)(resources.GetObject("btn_paymentAdd.Image")));
            this.btn_paymentAdd.Location = new System.Drawing.Point(384, 23);
            this.btn_paymentAdd.Name = "btn_paymentAdd";
            this.btn_paymentAdd.Size = new System.Drawing.Size(90, 74);
            this.btn_paymentAdd.TabIndex = 12;
            this.btn_paymentAdd.UseVisualStyleBackColor = false;
            this.btn_paymentAdd.Click += new System.EventHandler(this.btn_paymentAdd_Click);
            // 
            // txt_paymentPrice
            // 
            this.txt_paymentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentPrice.Location = new System.Drawing.Point(120, 76);
            this.txt_paymentPrice.Name = "txt_paymentPrice";
            this.txt_paymentPrice.Size = new System.Drawing.Size(245, 21);
            this.txt_paymentPrice.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Price";
            // 
            // txt_paymentName
            // 
            this.txt_paymentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentName.Location = new System.Drawing.Point(120, 49);
            this.txt_paymentName.Name = "txt_paymentName";
            this.txt_paymentName.Size = new System.Drawing.Size(245, 21);
            this.txt_paymentName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name";
            // 
            // txt_paymentId
            // 
            this.txt_paymentId.Enabled = false;
            this.txt_paymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentId.Location = new System.Drawing.Point(120, 22);
            this.txt_paymentId.Name = "txt_paymentId";
            this.txt_paymentId.ReadOnly = true;
            this.txt_paymentId.Size = new System.Drawing.Size(245, 21);
            this.txt_paymentId.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 103);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 103);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(60, 323);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 103);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Form_AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Details";
            this.Load += new System.EventHandler(this.Form_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_expenseId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_expenseAdd;
        private System.Windows.Forms.TextBox txt_expensePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_expenseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_purchaseAdd;
        private System.Windows.Forms.TextBox txt_purchasePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_purchaseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_purchaseId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_paymentAdd;
        private System.Windows.Forms.TextBox txt_paymentPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_paymentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_paymentId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}