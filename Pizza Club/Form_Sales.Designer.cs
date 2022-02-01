
namespace Pizza_Club
{
    partial class Form_Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sales));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_customerName = new System.Windows.Forms.ComboBox();
            this.txt_customerAddress = new System.Windows.Forms.TextBox();
            this.txt_customerContact = new System.Windows.Forms.TextBox();
            this.btn_closeSales = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_qtySideOrder = new System.Windows.Forms.TextBox();
            this.txt_qtyBurger = new System.Windows.Forms.TextBox();
            this.txt_qtyDrink = new System.Windows.Forms.TextBox();
            this.txt_qtyPizza = new System.Windows.Forms.TextBox();
            this.btn_ATCSideOrder = new System.Windows.Forms.Button();
            this.btn_ATCBurger = new System.Windows.Forms.Button();
            this.btn_ATCDrink = new System.Windows.Forms.Button();
            this.btn_ATCPizza = new System.Windows.Forms.Button();
            this.radio_xLarge = new System.Windows.Forms.RadioButton();
            this.radio_large = new System.Windows.Forms.RadioButton();
            this.radio_medium = new System.Windows.Forms.RadioButton();
            this.combo_sideOrders = new System.Windows.Forms.ComboBox();
            this.radio_small = new System.Windows.Forms.RadioButton();
            this.combo_drinks = new System.Windows.Forms.ComboBox();
            this.combo_burgers = new System.Windows.Forms.ComboBox();
            this.combo_pizzas = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_resetCart = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_cartGrossTotal = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.txt_amountGiven = new System.Windows.Forms.TextBox();
            this.dataGridView_cart = new System.Windows.Forms.DataGridView();
            this.DGVname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label_admin_main = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_customerName);
            this.groupBox1.Controls.Add(this.txt_customerAddress);
            this.groupBox1.Controls.Add(this.txt_customerContact);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // combo_customerName
            // 
            this.combo_customerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_customerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_customerName.FormattingEnabled = true;
            this.combo_customerName.Location = new System.Drawing.Point(7, 21);
            this.combo_customerName.Name = "combo_customerName";
            this.combo_customerName.Size = new System.Drawing.Size(187, 24);
            this.combo_customerName.TabIndex = 4;
            this.combo_customerName.SelectedIndexChanged += new System.EventHandler(this.combo_customerName_SelectedIndexChanged);
            // 
            // txt_customerAddress
            // 
            this.txt_customerAddress.Location = new System.Drawing.Point(200, 48);
            this.txt_customerAddress.Name = "txt_customerAddress";
            this.txt_customerAddress.Size = new System.Drawing.Size(187, 22);
            this.txt_customerAddress.TabIndex = 3;
            this.txt_customerAddress.Text = "Address";
            // 
            // txt_customerContact
            // 
            this.txt_customerContact.Location = new System.Drawing.Point(200, 20);
            this.txt_customerContact.Name = "txt_customerContact";
            this.txt_customerContact.Size = new System.Drawing.Size(187, 22);
            this.txt_customerContact.TabIndex = 2;
            this.txt_customerContact.Text = "Contact";
            // 
            // btn_closeSales
            // 
            this.btn_closeSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closeSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_closeSales.FlatAppearance.BorderSize = 0;
            this.btn_closeSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeSales.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeSales.ForeColor = System.Drawing.Color.White;
            this.btn_closeSales.Location = new System.Drawing.Point(1019, 1);
            this.btn_closeSales.Name = "btn_closeSales";
            this.btn_closeSales.Size = new System.Drawing.Size(39, 33);
            this.btn_closeSales.TabIndex = 41;
            this.btn_closeSales.Text = "X";
            this.btn_closeSales.UseVisualStyleBackColor = false;
            this.btn_closeSales.Click += new System.EventHandler(this.btn_closeSales_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_qtySideOrder);
            this.groupBox2.Controls.Add(this.txt_qtyBurger);
            this.groupBox2.Controls.Add(this.txt_qtyDrink);
            this.groupBox2.Controls.Add(this.txt_qtyPizza);
            this.groupBox2.Controls.Add(this.btn_ATCSideOrder);
            this.groupBox2.Controls.Add(this.btn_ATCBurger);
            this.groupBox2.Controls.Add(this.btn_ATCDrink);
            this.groupBox2.Controls.Add(this.btn_ATCPizza);
            this.groupBox2.Controls.Add(this.radio_xLarge);
            this.groupBox2.Controls.Add(this.radio_large);
            this.groupBox2.Controls.Add(this.radio_medium);
            this.groupBox2.Controls.Add(this.combo_sideOrders);
            this.groupBox2.Controls.Add(this.radio_small);
            this.groupBox2.Controls.Add(this.combo_drinks);
            this.groupBox2.Controls.Add(this.combo_burgers);
            this.groupBox2.Controls.Add(this.combo_pizzas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 212);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Item";
            // 
            // txt_qtySideOrder
            // 
            this.txt_qtySideOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtySideOrder.Location = new System.Drawing.Point(200, 173);
            this.txt_qtySideOrder.Name = "txt_qtySideOrder";
            this.txt_qtySideOrder.Size = new System.Drawing.Size(92, 29);
            this.txt_qtySideOrder.TabIndex = 18;
            this.txt_qtySideOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_qtyBurger
            // 
            this.txt_qtyBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtyBurger.Location = new System.Drawing.Point(200, 79);
            this.txt_qtyBurger.Name = "txt_qtyBurger";
            this.txt_qtyBurger.Size = new System.Drawing.Size(92, 29);
            this.txt_qtyBurger.TabIndex = 12;
            this.txt_qtyBurger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_qtyDrink
            // 
            this.txt_qtyDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtyDrink.Location = new System.Drawing.Point(7, 173);
            this.txt_qtyDrink.Name = "txt_qtyDrink";
            this.txt_qtyDrink.Size = new System.Drawing.Size(92, 29);
            this.txt_qtyDrink.TabIndex = 16;
            this.txt_qtyDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_qtyPizza
            // 
            this.txt_qtyPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtyPizza.Location = new System.Drawing.Point(7, 79);
            this.txt_qtyPizza.Name = "txt_qtyPizza";
            this.txt_qtyPizza.Size = new System.Drawing.Size(92, 29);
            this.txt_qtyPizza.TabIndex = 10;
            this.txt_qtyPizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ATCSideOrder
            // 
            this.btn_ATCSideOrder.BackColor = System.Drawing.Color.Teal;
            this.btn_ATCSideOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ATCSideOrder.ForeColor = System.Drawing.Color.White;
            this.btn_ATCSideOrder.Location = new System.Drawing.Point(295, 173);
            this.btn_ATCSideOrder.Name = "btn_ATCSideOrder";
            this.btn_ATCSideOrder.Size = new System.Drawing.Size(92, 29);
            this.btn_ATCSideOrder.TabIndex = 19;
            this.btn_ATCSideOrder.Text = "ADD";
            this.btn_ATCSideOrder.UseVisualStyleBackColor = false;
            this.btn_ATCSideOrder.Click += new System.EventHandler(this.btn_ATCSideOrder_Click);
            // 
            // btn_ATCBurger
            // 
            this.btn_ATCBurger.BackColor = System.Drawing.Color.Teal;
            this.btn_ATCBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ATCBurger.ForeColor = System.Drawing.Color.White;
            this.btn_ATCBurger.Location = new System.Drawing.Point(295, 79);
            this.btn_ATCBurger.Name = "btn_ATCBurger";
            this.btn_ATCBurger.Size = new System.Drawing.Size(92, 29);
            this.btn_ATCBurger.TabIndex = 13;
            this.btn_ATCBurger.Text = "ADD";
            this.btn_ATCBurger.UseVisualStyleBackColor = false;
            this.btn_ATCBurger.Click += new System.EventHandler(this.btn_ATCBurger_Click);
            // 
            // btn_ATCDrink
            // 
            this.btn_ATCDrink.BackColor = System.Drawing.Color.Teal;
            this.btn_ATCDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ATCDrink.ForeColor = System.Drawing.Color.White;
            this.btn_ATCDrink.Location = new System.Drawing.Point(102, 173);
            this.btn_ATCDrink.Name = "btn_ATCDrink";
            this.btn_ATCDrink.Size = new System.Drawing.Size(92, 29);
            this.btn_ATCDrink.TabIndex = 17;
            this.btn_ATCDrink.Text = "ADD";
            this.btn_ATCDrink.UseVisualStyleBackColor = false;
            this.btn_ATCDrink.Click += new System.EventHandler(this.btn_ATCDrink_Click);
            // 
            // btn_ATCPizza
            // 
            this.btn_ATCPizza.BackColor = System.Drawing.Color.Teal;
            this.btn_ATCPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ATCPizza.ForeColor = System.Drawing.Color.White;
            this.btn_ATCPizza.Location = new System.Drawing.Point(102, 79);
            this.btn_ATCPizza.Name = "btn_ATCPizza";
            this.btn_ATCPizza.Size = new System.Drawing.Size(92, 29);
            this.btn_ATCPizza.TabIndex = 11;
            this.btn_ATCPizza.Text = "ADD";
            this.btn_ATCPizza.UseVisualStyleBackColor = false;
            this.btn_ATCPizza.Click += new System.EventHandler(this.btn_ATCPizza_Click);
            // 
            // radio_xLarge
            // 
            this.radio_xLarge.AutoSize = true;
            this.radio_xLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_xLarge.Location = new System.Drawing.Point(145, 52);
            this.radio_xLarge.Name = "radio_xLarge";
            this.radio_xLarge.Size = new System.Drawing.Size(43, 20);
            this.radio_xLarge.TabIndex = 9;
            this.radio_xLarge.TabStop = true;
            this.radio_xLarge.Text = "XL";
            this.radio_xLarge.UseVisualStyleBackColor = true;
            // 
            // radio_large
            // 
            this.radio_large.AutoSize = true;
            this.radio_large.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_large.Location = new System.Drawing.Point(105, 52);
            this.radio_large.Name = "radio_large";
            this.radio_large.Size = new System.Drawing.Size(34, 20);
            this.radio_large.TabIndex = 8;
            this.radio_large.TabStop = true;
            this.radio_large.Text = "L";
            this.radio_large.UseVisualStyleBackColor = true;
            // 
            // radio_medium
            // 
            this.radio_medium.AutoSize = true;
            this.radio_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_medium.Location = new System.Drawing.Point(61, 52);
            this.radio_medium.Name = "radio_medium";
            this.radio_medium.Size = new System.Drawing.Size(38, 20);
            this.radio_medium.TabIndex = 7;
            this.radio_medium.TabStop = true;
            this.radio_medium.Text = "M";
            this.radio_medium.UseVisualStyleBackColor = true;
            // 
            // combo_sideOrders
            // 
            this.combo_sideOrders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_sideOrders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_sideOrders.FormattingEnabled = true;
            this.combo_sideOrders.Location = new System.Drawing.Point(200, 137);
            this.combo_sideOrders.Name = "combo_sideOrders";
            this.combo_sideOrders.Size = new System.Drawing.Size(187, 24);
            this.combo_sideOrders.TabIndex = 15;
            // 
            // radio_small
            // 
            this.radio_small.AutoSize = true;
            this.radio_small.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_small.Location = new System.Drawing.Point(19, 52);
            this.radio_small.Name = "radio_small";
            this.radio_small.Size = new System.Drawing.Size(36, 20);
            this.radio_small.TabIndex = 6;
            this.radio_small.TabStop = true;
            this.radio_small.Text = "S";
            this.radio_small.UseVisualStyleBackColor = true;
            // 
            // combo_drinks
            // 
            this.combo_drinks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_drinks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_drinks.FormattingEnabled = true;
            this.combo_drinks.Location = new System.Drawing.Point(7, 137);
            this.combo_drinks.Name = "combo_drinks";
            this.combo_drinks.Size = new System.Drawing.Size(187, 24);
            this.combo_drinks.TabIndex = 14;
            // 
            // combo_burgers
            // 
            this.combo_burgers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_burgers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_burgers.FormattingEnabled = true;
            this.combo_burgers.Location = new System.Drawing.Point(200, 21);
            this.combo_burgers.Name = "combo_burgers";
            this.combo_burgers.Size = new System.Drawing.Size(187, 24);
            this.combo_burgers.TabIndex = 5;
            // 
            // combo_pizzas
            // 
            this.combo_pizzas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_pizzas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_pizzas.FormattingEnabled = true;
            this.combo_pizzas.Location = new System.Drawing.Point(7, 21);
            this.combo_pizzas.Name = "combo_pizzas";
            this.combo_pizzas.Size = new System.Drawing.Size(187, 24);
            this.combo_pizzas.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_pay);
            this.groupBox3.Controls.Add(this.btn_resetCart);
            this.groupBox3.Controls.Add(this.btn_preview);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label_cartGrossTotal);
            this.groupBox3.Controls.Add(this.labelChange);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_change);
            this.groupBox3.Controls.Add(this.txt_amountGiven);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 146);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payments";
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(267, 97);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(125, 40);
            this.btn_pay.TabIndex = 23;
            this.btn_pay.Text = "PAY";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_resetCart
            // 
            this.btn_resetCart.Location = new System.Drawing.Point(5, 97);
            this.btn_resetCart.Name = "btn_resetCart";
            this.btn_resetCart.Size = new System.Drawing.Size(125, 40);
            this.btn_resetCart.TabIndex = 22;
            this.btn_resetCart.Text = "RESET";
            this.btn_resetCart.UseVisualStyleBackColor = true;
            this.btn_resetCart.Click += new System.EventHandler(this.btn_resetCart_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(136, 97);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(125, 40);
            this.btn_preview.TabIndex = 22;
            this.btn_preview.Text = "PREVIEW";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gross Total";
            // 
            // label_cartGrossTotal
            // 
            this.label_cartGrossTotal.AutoSize = true;
            this.label_cartGrossTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cartGrossTotal.Location = new System.Drawing.Point(298, 51);
            this.label_cartGrossTotal.Name = "label_cartGrossTotal";
            this.label_cartGrossTotal.Size = new System.Drawing.Size(45, 24);
            this.label_cartGrossTotal.TabIndex = 1;
            this.label_cartGrossTotal.Text = "0.00";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(47, 63);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(55, 16);
            this.labelChange.TabIndex = 1;
            this.labelChange.Text = "Change";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount Given";
            // 
            // txt_change
            // 
            this.txt_change.Location = new System.Drawing.Point(105, 60);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(126, 22);
            this.txt_change.TabIndex = 21;
            this.txt_change.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_amountGiven
            // 
            this.txt_amountGiven.Location = new System.Drawing.Point(105, 27);
            this.txt_amountGiven.Name = "txt_amountGiven";
            this.txt_amountGiven.Size = new System.Drawing.Size(126, 22);
            this.txt_amountGiven.TabIndex = 20;
            this.txt_amountGiven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView_cart
            // 
            this.dataGridView_cart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVname,
            this.DGVquantity,
            this.DGVprice,
            this.DGVtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_cart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_cart.Location = new System.Drawing.Point(408, 90);
            this.dataGridView_cart.MultiSelect = false;
            this.dataGridView_cart.Name = "dataGridView_cart";
            this.dataGridView_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cart.Size = new System.Drawing.Size(404, 449);
            this.dataGridView_cart.TabIndex = 24;
            // 
            // DGVname
            // 
            this.DGVname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVname.HeaderText = "Name";
            this.DGVname.Name = "DGVname";
            // 
            // DGVquantity
            // 
            this.DGVquantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVquantity.HeaderText = "Quantity";
            this.DGVquantity.Name = "DGVquantity";
            // 
            // DGVprice
            // 
            this.DGVprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVprice.HeaderText = "Price";
            this.DGVprice.Name = "DGVprice";
            // 
            // DGVtotal
            // 
            this.DGVtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVtotal.HeaderText = "Total";
            this.DGVtotal.Name = "DGVtotal";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(126, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 26;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(3, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 45);
            this.button3.TabIndex = 27;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(126, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 45);
            this.button4.TabIndex = 28;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(3, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 45);
            this.button5.TabIndex = 29;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(126, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 45);
            this.button6.TabIndex = 30;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(3, 174);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 45);
            this.button7.TabIndex = 31;
            this.button7.Text = "button1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(126, 174);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 45);
            this.button8.TabIndex = 32;
            this.button8.Text = "button1";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(3, 225);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 45);
            this.button9.TabIndex = 33;
            this.button9.Text = "button1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(126, 225);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 45);
            this.button10.TabIndex = 34;
            this.button10.Text = "button1";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(3, 276);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 45);
            this.button11.TabIndex = 35;
            this.button11.Text = "button1";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(126, 276);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(117, 45);
            this.button12.TabIndex = 36;
            this.button12.Text = "button1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Location = new System.Drawing.Point(3, 327);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(117, 45);
            this.button13.TabIndex = 37;
            this.button13.Text = "button1";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Location = new System.Drawing.Point(126, 327);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(117, 45);
            this.button14.TabIndex = 38;
            this.button14.Text = "button1";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Location = new System.Drawing.Point(3, 378);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(117, 45);
            this.button15.TabIndex = 39;
            this.button15.Text = "button1";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Location = new System.Drawing.Point(126, 378);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(117, 45);
            this.button16.TabIndex = 40;
            this.button16.Text = "button1";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // label_admin_main
            // 
            this.label_admin_main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_admin_main.AutoSize = true;
            this.label_admin_main.Font = new System.Drawing.Font("Hobo Std", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_admin_main.Location = new System.Drawing.Point(353, 3);
            this.label_admin_main.Name = "label_admin_main";
            this.label_admin_main.Size = new System.Drawing.Size(244, 52);
            this.label_admin_main.TabIndex = 9;
            this.label_admin_main.Text = "PIZZA CLUB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(601, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label_admin_main);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 73);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Location = new System.Drawing.Point(810, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 449);
            this.panel2.TabIndex = 42;
            // 
            // Form_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1059, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_cart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_closeSales);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Sales";
            this.Text = "Form_Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_customerAddress;
        private System.Windows.Forms.TextBox txt_customerContact;
        private System.Windows.Forms.Button btn_closeSales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combo_pizzas;
        private System.Windows.Forms.RadioButton radio_xLarge;
        private System.Windows.Forms.RadioButton radio_large;
        private System.Windows.Forms.RadioButton radio_medium;
        private System.Windows.Forms.RadioButton radio_small;
        private System.Windows.Forms.ComboBox combo_burgers;
        private System.Windows.Forms.TextBox txt_qtyPizza;
        private System.Windows.Forms.Button btn_ATCPizza;
        private System.Windows.Forms.TextBox txt_qtySideOrder;
        private System.Windows.Forms.TextBox txt_qtyBurger;
        private System.Windows.Forms.TextBox txt_qtyDrink;
        private System.Windows.Forms.Button btn_ATCSideOrder;
        private System.Windows.Forms.Button btn_ATCBurger;
        private System.Windows.Forms.Button btn_ATCDrink;
        private System.Windows.Forms.ComboBox combo_sideOrders;
        private System.Windows.Forms.ComboBox combo_drinks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amountGiven;
        private System.Windows.Forms.Label label_cartGrossTotal;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox txt_change;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.DataGridView dataGridView_cart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label_admin_main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combo_customerName;
        private System.Windows.Forms.Button btn_resetCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtotal;
    }
}