using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Club
{
    public partial class Form_Sales : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");
        public Form_Sales()
        {
            InitializeComponent();
        }

        //variable for fetching price when pizza size selected
        public string cartProductprice;
        public string selectedSize;

        //function of load customers in combo box
        /*void load_customers()
        {
            //remove previous items
            combo_customerName.Items.Clear();

            try
            {
                sqlcon.Open();

                string query = "select * from tbl_customers";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_customerName.Items.Add(reader["name"].ToString());
                }

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        //function of load pizzas in combo box
        void load_pizzas()
        {
            //remove previous items
            combo_pizzas.Items.Clear();

            try
            {
                sqlcon.Open();

                string query = "select * from tbl_pizzas";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_pizzas.Items.Add(reader["name"].ToString());
                }

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function of load burgers in combo box
        void load_burgers()
        {
            //remove previous items
            combo_burgers.Items.Clear();

            try
            {
                sqlcon.Open();

                string query = "select * from tbl_burgers";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_burgers.Items.Add(reader["name"].ToString());
                }

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function of load drinks in combo box
        void load_drinks()
        {
            //remove previous items
            combo_drinks.Items.Clear();

            try
            {
                sqlcon.Open();

                string query = "select * from tbl_drinks";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_drinks.Items.Add(reader["name"].ToString());
                }

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function of load side orders in combo box
        void load_sideOrders()
        {
            //remove previous items
            combo_sideOrders.Items.Clear();

            try
            {
                sqlcon.Open();

                string query = "select * from tbl_sideOrder";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_sideOrders.Items.Add(reader["name"].ToString());
                }

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // close button for sale window
        private void btn_closeSales_Click(object sender, EventArgs e)
        {
            btn_resetCart_Click(sender, e);

            this.Hide();
            Program.fw.Show();
        }

        private void load_customerContacts()
        {
            try
            {
                sqlcon.Open();

                string query = "select contact from tbl_customers";
                SqlCommand cmd = new SqlCommand(query, sqlcon)
                {
                    CommandText = query
                };
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                txt_customerContact.AutoCompleteCustomSource = MyCollection;

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //on form load
        private void Form_Sales_Load(object sender, EventArgs e)
        {
            //load_customers();
            load_customerContacts();
            txt_customerContact.Text = "Contact";
            txt_customerAddress.Text = "Address";
            
            load_pizzas();
            load_burgers();
            load_drinks();
            load_sideOrders();
            btn_resetCart_Click(sender, e);

            //auto check pizza size to small when form loads
            radio_small.Checked = true;
            radio_dineIn.Checked = true;
        }

        //fetch customer data from database when anyone is selected from combobox
        private void combo_customerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                sqlcon.Open();

                string query = "select contact, address from tbl_customers WHERE name = '"+combo_customerName.Text.ToString()+"'";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt_customerContact.Text = Convert.ToString(reader["contact"]);
                    txt_customerAddress.Text = Convert.ToString(reader["address"]);
                }

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        //IsValid Pizza
        private bool IsValid_Pizza()
        {
            if (combo_pizzas.Text == String.Empty)
            {
                MessageBox.Show("First select a Pizza", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_pizzas.Focus();
                return false;
            }
            else if (txt_qtyPizza.Text == String.Empty)
            {
                MessageBox.Show("Pizza quantity is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_qtyBurger.Focus();
                return false;
            }
            else if (radio_small.Checked == false && radio_medium.Checked == false && radio_large.Checked == false && radio_xLarge.Checked == false)
            {
                MessageBox.Show("First select Pizza size", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //method to add pizza to cart
        private void addPizzaData(string product, string selecSize, string quantity, string price, string total_amount)
        {
            String[] row = { product+","+selecSize, quantity, price, total_amount };
            //Add the row to datagridview
            dataGridView_cart.Rows.Add(row);
        }

        public void GetPriceColumn(string size)
        {
            
            string columnName = "";
            
            if(size == "small")
            { 
                columnName = "priceS";
                selectedSize = "S";
            }
            else if(size == "medium")
            { 
                columnName = "priceM";
                selectedSize = "M";
            }
            else if (size == "large")
            { 
                columnName = "priceL";
                selectedSize = "L";
            }
            else if (size == "xlarge")
            { 
                columnName = "priceXL";
                selectedSize = "XL";
            }

            //read product price according to selected size
            try
            {
                SqlCommand com = new SqlCommand();
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select [" + columnName + "] from tbl_pizzas Where name = @name", sqlcon); ;
                cmd.Parameters.AddWithValue("@name", combo_pizzas.GetItemText(combo_pizzas.SelectedItem));
                //cmdSale.Parameters.AddWithValue("@columnName", columnName);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    cartProductprice = da.GetValue(0).ToString();
                }
                sqlcon.Close();
            }
            catch
            {
                sqlcon.Close();
            }
        }

        private void btn_ATCPizza_Click(object sender, EventArgs e)
        {
            if (IsValid_Pizza())
            {
                //if entered quantity is invalid ( <= 0)
                if (Convert.ToInt32(txt_qtyPizza.Text) <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(radio_small.Checked == true)
                    {
                        GetPriceColumn("small");
                    }
                    else if(radio_medium.Checked == true)
                    {
                        GetPriceColumn("medium");
                    }
                    else if (radio_large.Checked == true)
                    {
                        GetPriceColumn("large");
                    }
                    else if (radio_xLarge.Checked == true)
                    {
                        GetPriceColumn("xlarge");
                    }

                    //Boolean value to check if the DataGridView has the same value.  
                    bool Found = false;
                    if (dataGridView_cart.Rows.Count > 0)
                    {
                        //Check if the product Name exists
                        foreach (DataGridViewRow row in dataGridView_cart.Rows)
                        {
                            if (Convert.ToString(row.Cells[0].Value) == combo_pizzas.Text+","+selectedSize)
                            {
                                //Update the Quantity and totalAmount of the found row  
                                row.Cells[1].Value = Convert.ToString(Convert.ToInt32(txt_qtyPizza.Text) + Convert.ToInt32(row.Cells[1].Value));
                                row.Cells[3].Value = Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
                                Found = true;
                            }
                        }
                    }
                    if (!Found)
                    {
                        string total_amount = "";
                        total_amount = (Convert.ToInt32(cartProductprice) * Convert.ToInt32(txt_qtyPizza.Text.ToString())).ToString();
                        addPizzaData(combo_pizzas.Text, selectedSize, txt_qtyPizza.Text, cartProductprice, total_amount);
                    }
                    calculate_grossTotal();
                }
            }
        }

        //IsValid Pizza
        private bool IsValid_Burger()
        {
            if (combo_burgers.Text == String.Empty)
            {
                MessageBox.Show("First select a Burger", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_burgers.Focus();
                return false;
            }
            else if (txt_qtyBurger.Text == String.Empty)
            {
                MessageBox.Show("Burger quantity is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_qtyBurger.Focus();
                return false;
            }
            return true;
        }

        //method to add burger to cart
        private void addBurgerData(string product, string quantity, string price, string total_amount)
        {
            String[] row = { product, quantity, price, total_amount };
            //Add the row to datagridview
            dataGridView_cart.Rows.Add(row);
        }

        private void btn_ATCBurger_Click(object sender, EventArgs e)
        {
            if (IsValid_Burger())
            {
                try
                {
                    //if entered quantity is invalid ( <= 0)
                    if (Convert.ToInt32(txt_qtyBurger.Text) <= 0)
                    {
                        MessageBox.Show("Please enter a valid quantity", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string readPrice = "";

                        //read product price from database against selected product
                        try
                        {
                            SqlCommand com = new SqlCommand();
                            sqlcon.Open();
                            SqlCommand cmd = new SqlCommand("Select price from tbl_burgers Where name = @name", sqlcon);
                            cmd.Parameters.AddWithValue("@name", combo_burgers.Text);
                            SqlDataReader da = cmd.ExecuteReader();
                            while (da.Read())
                            {
                                readPrice = da.GetValue(0).ToString();
                            }
                            sqlcon.Close();
                        }
                        catch
                        {
                            sqlcon.Close();
                        }

                        //Boolean value to check if the DataGridView has the same value.  
                        bool Found = false;
                        if (dataGridView_cart.Rows.Count > 0)
                        {
                            //Check if the product Name exists
                            foreach (DataGridViewRow row in dataGridView_cart.Rows)
                            {
                                if (Convert.ToString(row.Cells[0].Value) == combo_burgers.Text)
                                {
                                    //Update the Quantity and totalAmount of the found row  
                                    row.Cells[1].Value = Convert.ToString(Convert.ToInt32(txt_qtyBurger.Text) + Convert.ToInt32(row.Cells[1].Value));
                                    row.Cells[3].Value = Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
                                    Found = true;
                                }
                            }
                        }
                        if (!Found)
                        {
                            string total_amount = "";
                            total_amount = (Convert.ToInt32(readPrice) * Convert.ToInt32(txt_qtyBurger.Text.ToString())).ToString();
                            addBurgerData(combo_burgers.Text, txt_qtyBurger.Text, readPrice, total_amount);
                        }
                        calculate_grossTotal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        //IsValid Drink
        private bool IsValid_Drink()
        {
            if (combo_drinks.Text == String.Empty)
            {
                MessageBox.Show("First select a Drink", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_drinks.Focus();
                return false;
            }
            else if (txt_qtyDrink.Text == String.Empty)
            {
                MessageBox.Show("Drink quantity is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_qtyDrink.Focus();
                return false;
            }
            return true;
        }

        //method to add drink to cart
        private void addDrinkData(string product, string quantity, string price, string total_amount)
        {
            String[] row = { product, quantity, price, total_amount };
            //Add the row to datagridview
            dataGridView_cart.Rows.Add(row);
        }

        private void btn_ATCDrink_Click(object sender, EventArgs e)
        {
            if (IsValid_Drink())
            {
                try
                {
                    //if entered quantity is invalid ( <= 0)
                    if (Convert.ToInt32(txt_qtyDrink.Text) <= 0)
                    {
                        MessageBox.Show("Please enter a valid quantity", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string readPrice = "";

                        //read product price from database against selected product
                        try
                        {
                            SqlCommand com = new SqlCommand();
                            sqlcon.Open();
                            SqlCommand cmd = new SqlCommand("Select price from tbl_drinks Where name = @name", sqlcon);
                            cmd.Parameters.AddWithValue("@name", combo_drinks.Text);
                            SqlDataReader da = cmd.ExecuteReader();
                            while (da.Read())
                            {
                                readPrice = da.GetValue(0).ToString();
                            }
                            sqlcon.Close();
                        }
                        catch
                        {
                            sqlcon.Close();
                        }

                        //Boolean value to check if the DataGridView has the same value.  
                        bool Found = false;
                        if (dataGridView_cart.Rows.Count > 0)
                        {
                            //Check if the product Name exists
                            foreach (DataGridViewRow row in dataGridView_cart.Rows)
                            {
                                if (Convert.ToString(row.Cells[0].Value) == combo_drinks.Text)
                                {
                                    //Update the Quantity and totalAmount of the found row  
                                    row.Cells[1].Value = Convert.ToString(Convert.ToInt32(txt_qtyDrink.Text) + Convert.ToInt32(row.Cells[1].Value));
                                    row.Cells[3].Value = Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
                                    Found = true;
                                }
                            }
                        }
                        if (!Found)
                        {
                            string total_amount = "";
                            total_amount = (Convert.ToInt32(readPrice) * Convert.ToInt32(txt_qtyDrink.Text.ToString())).ToString();
                            addDrinkData(combo_drinks.Text, txt_qtyDrink.Text, readPrice, total_amount);
                        }
                        calculate_grossTotal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //IsValid SideOrder
        private bool IsValid_SideOrder()
        {
            if (combo_sideOrders.Text == String.Empty)
            {
                MessageBox.Show("First select a Side Order", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_sideOrders.Focus();
                return false;
            }
            else if (txt_qtySideOrder.Text == String.Empty)
            {
                MessageBox.Show("Side Order quantity is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_qtySideOrder.Focus();
                return false;
            }
            return true;
        }

        //method to add drink to cart
        private void addSideOrderData(string product, string quantity, string price, string total_amount)
        {
            String[] row = { product, quantity, price, total_amount };
            //Add the row to datagridview
            dataGridView_cart.Rows.Add(row);
        }

        private void btn_ATCSideOrder_Click(object sender, EventArgs e)
        {
            if (IsValid_SideOrder())
            {
                try
                {
                    //if entered quantity is invalid ( <= 0)
                    if (Convert.ToInt32(txt_qtySideOrder.Text) <= 0)
                    {
                        MessageBox.Show("Please enter a valid quantity", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string readPrice = "";

                        //read product price from database against selected product
                        try
                        {
                            SqlCommand com = new SqlCommand();
                            sqlcon.Open();
                            SqlCommand cmd = new SqlCommand("Select price from tbl_sideOrder Where name = @name", sqlcon);
                            cmd.Parameters.AddWithValue("@name", combo_sideOrders.Text);
                            SqlDataReader da = cmd.ExecuteReader();
                            while (da.Read())
                            {
                                readPrice = da.GetValue(0).ToString();
                            }
                            sqlcon.Close();
                        }
                        catch
                        {
                            sqlcon.Close();
                        }

                        //Boolean value to check if the DataGridView has the same value.  
                        bool Found = false;
                        if (dataGridView_cart.Rows.Count > 0)
                        {
                            //Check if the product Name exists
                            foreach (DataGridViewRow row in dataGridView_cart.Rows)
                            {
                                if (Convert.ToString(row.Cells[0].Value) == combo_sideOrders.Text)
                                {
                                    //Update the Quantity and totalAmount of the found row  
                                    row.Cells[1].Value = Convert.ToString(Convert.ToInt32(txt_qtySideOrder.Text) + Convert.ToInt32(row.Cells[1].Value));
                                    row.Cells[3].Value = Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
                                    Found = true;
                                }
                            }
                        }
                        if (!Found)
                        {
                            string total_amount = "";
                            total_amount = (Convert.ToInt32(readPrice) * Convert.ToInt32(txt_qtySideOrder.Text.ToString())).ToString();
                            addBurgerData(combo_sideOrders.Text, txt_qtySideOrder.Text, readPrice, total_amount);
                        }
                        calculate_grossTotal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //reset cart datagridview and all fields
        private void btn_resetCart_Click(object sender, EventArgs e)
        {
            combo_customerName.Text = "";
            txt_customerContact.Text = "Contact";
            txt_customerAddress.Text = "Address";

            combo_pizzas.SelectedIndex = 0;
            radio_small.Checked = true;

            combo_burgers.SelectedIndex = 0;

            combo_drinks.SelectedIndex = 0;

            combo_sideOrders.SelectedIndex = 0;

            dataGridView_cart.Rows.Clear();

            radio_dineIn.Checked = true;

            txt_extraCharges.Clear();
            txt_amountGiven.Clear();
            txt_change.Clear();

            label_cartGrossTotal.Text = "0.00";

            //load_customers();
            load_customerContacts();
        }

        //calculate gross total
        void calculate_grossTotal()
        {
            decimal sum = 0;
            //calculate gross total from cart datagridview
            for (int i = 0; i < dataGridView_cart.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView_cart.Rows[i].Cells[3].Value);
            }
            if(txt_extraCharges.Text != "")
            {
                sum += Convert.ToInt32(txt_extraCharges.Text);
            }
            label_cartGrossTotal.Text = sum.ToString();
            if (sum == 0)
            {
                label_cartGrossTotal.Text = "0.00";
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            int totalItems = dataGridView_cart.Rows.Count;
            if(totalItems > 0 && totalItems <= 6)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 400);
            }
            if (totalItems > 6 && totalItems <= 10)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 500);
            }
            if (totalItems > 10 && totalItems <= 14)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            }
            if (totalItems > 14 && totalItems <= 20)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 700);
            }
            if (totalItems > 20 && totalItems <= 25)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 800);
            }
            if (totalItems > 25 && totalItems <= 30)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 900);
            }
            if (totalItems > 30 && totalItems <= 35)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1000);
            }
            //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printPreviewDialog1.ShowDialog();
        }

        //Auto Increment
        int sale_id = 1;
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(Id) from tbl_sales";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    sale_id = 1;
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    sale_id = a;
                }
            }
            sqlcon.Close();
        }

        //decrease ingredients on sideOrder sale
        public void Dec_sideOrder_ingredients(string productName, int decQty, int DGVqty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-("+decQty+" * " + DGVqty + ") WHERE name='"+productName+"';", sqlcon)
                {
                    CommandType = CommandType.Text
                };
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+ex.Source);
            }
        }

        //will write drink decrease here
        public void Dec_drink_stock(string productName, int decQty, int DGVqty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(" + decQty + " * " + DGVqty + ") WHERE name='" + productName + "';", sqlcon)
                {
                    CommandType = CommandType.Text
                };
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source);
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (dataGridView_cart.Rows.Count <= 1)
            {
                MessageBox.Show("Please First add product(s) to cart");
            }
            else if (txt_amountGiven.Text == "")
            {
                MessageBox.Show("Please Enter the Amount given by Customer");
            }
            else if(Convert.ToInt32(txt_amountGiven.Text) < Convert.ToDecimal(label_cartGrossTotal.Text))
            {
                MessageBox.Show("Your Entered Amount is less then Total Bill");
            }
            else if (Convert.ToDecimal(label_cartGrossTotal.Text) <= 0)
            {
                MessageBox.Show("Please First add product(s) to cart");
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("\tTotal Amount: " + label_cartGrossTotal.Text + "\n\tAmount Given: " + txt_amountGiven.Text + "\n\tAmount Returned: " + txt_change.Text + "\nAre you sure, Submit current order?", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //if yes
                if (dialogResult == DialogResult.Yes)
                {
                    //insert sales into sales table
                    try
                    {
                        auto_increment_id(sender, e);

                        string orderType = "";
                        //check order type
                        if(radio_dineIn.Checked == true)
                        {
                            orderType = "Dine In";
                        }
                        else if(radio_takeAway.Checked == true)
                        {
                            orderType = "Take Away";
                        }
                        //get extra charges
                        int extraCharges;
                        if(txt_extraCharges.Text == "")
                        {
                            extraCharges = 0;
                        }
                        else
                        {
                            extraCharges = Convert.ToInt32(txt_extraCharges.Text);
                        }

                        sqlcon.Open();
                        SqlCommand cmdSale;
                        for (int i = 0; i < (dataGridView_cart.Rows.Count) - 1; i++)
                        {
                            cmdSale = new SqlCommand(@"INSERT INTO tbl_sales VALUES (@saleId, @customer, @product, @quantity, @price, @totalPrice, @extraCharges, @grossTotal, @amountGiven, @change, @orderType, @date, @select)", sqlcon)
                            {
                                CommandType = CommandType.Text
                            };

                            cmdSale.Parameters.AddWithValue("@saleId", sale_id);
                            cmdSale.Parameters.AddWithValue("@customer", combo_customerName.Text);
                            cmdSale.Parameters.AddWithValue("@product", dataGridView_cart.Rows[i].Cells["DGVname"].Value);
                            cmdSale.Parameters.AddWithValue("@quantity", dataGridView_cart.Rows[i].Cells["DGVquantity"].Value);
                            cmdSale.Parameters.AddWithValue("@price", dataGridView_cart.Rows[i].Cells["DGVprice"].Value);
                            cmdSale.Parameters.AddWithValue("@totalPrice", dataGridView_cart.Rows[i].Cells["DGVtotal"].Value);
                            cmdSale.Parameters.AddWithValue("@extraCharges", extraCharges);
                            cmdSale.Parameters.AddWithValue("@grossTotal", label_cartGrossTotal.Text);
                            cmdSale.Parameters.AddWithValue("@amountGiven", txt_amountGiven.Text);
                            cmdSale.Parameters.AddWithValue("@change", txt_change.Text);
                            cmdSale.Parameters.AddWithValue("@orderType", orderType);
                            cmdSale.Parameters.AddWithValue("@date", DateTime.Now);
                            cmdSale.Parameters.AddWithValue("@select", false);

                            cmdSale.ExecuteNonQuery();

                            //check product name and decrease ingrediennts from database accordingly
                            if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Zinger Burger")
                            {
                                //bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Chicken Burger")
                            {
                                //bread, chicken petty
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Chicken Petty'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Beef Burger")
                            {
                                //bread, beef petty
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Beef Petty'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Sizler Burger")
                            {
                                //bread, 1.5 zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(2*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Tower Burger")
                            {
                                //bread, 2 zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(2*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Mighty Burger")
                            {
                                //bread, zinger piece, cheese slice, chicken petty
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Cheese Slice';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Chicken Petty';", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Club Burger")
                            {
                                //bread, zinger piece, cheese slice, beef petty
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Cheese Slice';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Beef Petty';", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Twister")
                            {
                                //twister bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Twister Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Zinger Shwarma")
                            {
                                //shwarma bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Shwarma Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Cheese Burger")
                            {
                                //bread, zinger piece, cheeze slice
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Cheese Slice';", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Cheese Twister")
                            {
                                //twister bread, zinger piece, cheeze slice
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Twister Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Cheese Slice';", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            } //decrease ingredients for side orders
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "1 Pcs Chicken")
                            {
                                Dec_sideOrder_ingredients("Chicken Pcs", 1, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "5 Hot Wings")
                            {
                                Dec_sideOrder_ingredients("Hot Wings", 5, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "5 Nuggets")
                            {
                                Dec_sideOrder_ingredients("Nuggets", 5, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "6 Hot Shots")
                            {
                                Dec_sideOrder_ingredients("Hot Shots", 6, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "5 Pcs Chicken")
                            {
                                Dec_sideOrder_ingredients("Chicken Pcs", 5, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "10 Hot Wings")
                            {
                                Dec_sideOrder_ingredients("Hot Wings", 10, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "10 Nuggets")
                            {
                                Dec_sideOrder_ingredients("Nuggets", 10, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "12 Hot Shots")
                            {
                                Dec_sideOrder_ingredients("Hot Shots", 12, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }//decrease ingredients for deals
                            else if(dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 1")
                            {
                                //bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(1*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if(dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 2")
                            {
                                //bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(2*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(2*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 3")
                            {
                                //bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(3*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(3*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 4")
                            {
                                //bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(4*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(4*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 5")
                            {
                                //shwarma bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(3*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Shwarma Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(3*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 6")
                            {
                                //bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(5*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(5*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();

                                    Dec_sideOrder_ingredients("Hot Wings", 10, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if(dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 8")
                            {
                                Dec_sideOrder_ingredients("Hot Wings", 5, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 9")
                            {
                                //bread, zinger piece
                                try
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity=quantity-(2*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Bread';" +
                                        "UPDATE tbl_stockPCS SET quantity=quantity-(2*'" + Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value) + "') WHERE name='Zinger Piece'", sqlcon)
                                    {
                                        CommandType = CommandType.Text
                                    };
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                                Dec_sideOrder_ingredients("Hot Wings", 10, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 10")
                            {
                                Dec_sideOrder_ingredients("Chicken Pcs", 3, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 11")
                            {
                                Dec_sideOrder_ingredients("Nuggets", 10, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Deal 12")
                            {
                                Dec_sideOrder_ingredients("Nuggets", 10, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                                Dec_sideOrder_ingredients("Hot Wings", 10, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }//decrease stock for drinks
                            else if(dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "Tin Pack")
                            {
                                Dec_drink_stock("Tin Pack", 1, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "1 Liter")
                            {
                                Dec_drink_stock("1 Liter", 1, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "1.5 Liter")
                            {
                                Dec_drink_stock("1.5 Liter", 1, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "S-Water")
                            {
                                Dec_drink_stock("S-Water", 1, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }
                            else if (dataGridView_cart.Rows[i].Cells[0].Value.ToString() == "L-Water")
                            {
                                Dec_drink_stock("L-Water", 1, Convert.ToInt32(dataGridView_cart.Rows[i].Cells["DGVquantity"].Value));
                            }

                        }
                        sqlcon.Close();

                        

                        if(combo_customerName.Text != "")
                        {
                            //generate customer id
                            int customer_id = 1;

                            int a;
                            sqlcon.Open();
                            string query = "Select Max(Id) from tbl_customers";
                            SqlCommand cmdId = new SqlCommand(query, sqlcon);
                            SqlDataReader dr = cmdId.ExecuteReader();
                            if (dr.Read())
                            {
                                string val = dr[0].ToString();
                                if (val == "")
                                {
                                    customer_id = 1;
                                }
                                else
                                {
                                    a = Convert.ToInt32(dr[0].ToString());
                                    a = a + 1;
                                    customer_id = a;
                                }
                            }
                            sqlcon.Close();

                            //store customer in database if already not exist
                            string s = @"SELECT COUNT(*) FROM tbl_customers WHERE name = @name AND contact = @contact";
                            SqlCommand cmdCust = new SqlCommand(s, sqlcon);
                            cmdCust.Parameters.AddWithValue("@name", combo_customerName.Text);
                            cmdCust.Parameters.AddWithValue("@contact", txt_customerContact.Text);
                            sqlcon.Open();
                            int records = (int)cmdCust.ExecuteScalar();
                            sqlcon.Close();

                            if (records == 0)
                            {
                                cmdCust.Parameters.Clear();
                                s = @"INSERT into tbl_customers VALUES (@id , @name, @contact, @address, @select)";
                                cmdCust = new SqlCommand(s, sqlcon);

                                cmdCust.Parameters.AddWithValue("@id", customer_id);
                                cmdCust.Parameters.AddWithValue("@name", combo_customerName.Text);
                                cmdCust.Parameters.AddWithValue("@contact", txt_customerContact.Text);
                                cmdCust.Parameters.AddWithValue("@address", txt_customerAddress.Text);
                                cmdCust.Parameters.AddWithValue("@select", false);
                                sqlcon.Open();
                                cmdCust.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                            else
                            {
                            }
                        }


                        MessageBox.Show("Sales Successfull!");
                        //to print receipt
                        ReceiptPrints();
                        sqlcon.Close();

                        btn_resetCart_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.Source);
                        sqlcon.Close();
                    }
                }

                //if no
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Sales Not Successfull!");
                }
            }
        }

        //calculate change when given amount entered
        private void txt_amountGiven_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_amountGiven.Text, "[^0-9]"))
            {
                txt_amountGiven.Clear();
            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_amountGiven.Text))
                    {
                        txt_change.Text = "";
                    }
                    txt_change.Text = (float.Parse(txt_amountGiven.Text) - float.Parse(label_cartGrossTotal.Text)).ToString();

                }
                catch
                {
                }
            }
            
        }

        //for placeholder in customer details text boxes
        private void txt_customerContact_Enter(object sender, EventArgs e)
        {
            if (txt_customerContact.Text == "Contact")
            {
                txt_customerContact.Text = "";
            }
        }

        private void txt_customerContact_Leave(object sender, EventArgs e)
        {
            if (txt_customerContact.Text == "")
            {
                txt_customerContact.Text = "Contact";
            }
        }

        private void txt_customerAddress_Enter(object sender, EventArgs e)
        {
            if (txt_customerAddress.Text == "Address")
            {
                txt_customerAddress.Text = "";
            }
        }

        private void txt_customerAddress_Leave(object sender, EventArgs e)
        {
            if (txt_customerAddress.Text == "")
            {
                txt_customerAddress.Text = "Address";
            }
        }

        //press enter key to add to cart
        private void txt_qtyPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_ATCPizza_Click(sender, e);
            }
        }

        private void txt_qtyBurger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_ATCBurger_Click(sender, e);
            }
        }

        private void txt_qtyDrink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_ATCDrink_Click(sender, e);
            }
        }

        private void txt_qtySideOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_ATCSideOrder_Click(sender, e);
            }
        }

        //show menu strip on right click and get row index
        private int rowIndex = 0;
        private void dataGridView_cart_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView_cart.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView_cart.CurrentCell = this.dataGridView_cart.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridView_cart, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView_cart.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridView_cart.Rows.RemoveAt(this.rowIndex);
            }
            calculate_grossTotal();
        }

        //press enter in txtbox Given Amount to launch pay order
        private void txt_amountGiven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_pay_Click(sender, e);
            }
        }

        //handle deals add to cart
        public void HandleDealATC(string selectedDeal, string dealPrice)
        {
            //Boolean value to check if the DataGridView has the same value.  
            bool Found = false;
            if (dataGridView_cart.Rows.Count > 0)
            {
                //Check if the product Name exists
                foreach (DataGridViewRow row in dataGridView_cart.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == selectedDeal)
                    {
                        //Update the Quantity and totalAmount of the found row  
                        row.Cells[1].Value = Convert.ToString(Convert.ToInt32(row.Cells[1].Value) + 1);
                        row.Cells[3].Value = Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
                        Found = true;
                    }
                }
            }
            if (!Found)
            {
                string total_amount = dealPrice;
                addBurgerData(selectedDeal, "1", total_amount, total_amount);
            }
            calculate_grossTotal();
        }

        //deals buttons
        private void btn_deal1_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 1";
            string dealPrice = "299";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal2_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 2";
            string dealPrice = "499";
            HandleDealATC(selectedDeal, dealPrice);

        }

        private void btn_deal3_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 3";
            string dealPrice = "670";
            HandleDealATC(selectedDeal, dealPrice);

        }

        private void btn_deal4_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 4";
            string dealPrice = "799";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal5_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 5";
            string dealPrice = "650";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal6_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 6";
            string dealPrice = "1199";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal7_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 7";
            string dealPrice = "799";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal8_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 8";
            string dealPrice = "850";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal9_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 9";
            string dealPrice = "1499";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal10_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 10";
            string dealPrice = "1599";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal11_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 11";
            string dealPrice = "1799";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal12_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 12";
            string dealPrice = "2499";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal13_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 13";
            string dealPrice = "699";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal14_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 14";
            string dealPrice = "1350";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal15_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 15";
            string dealPrice = "1799";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void btn_deal16_Click(object sender, EventArgs e)
        {
            string selectedDeal = "Deal 16";
            string dealPrice = "2399";
            HandleDealATC(selectedDeal, dealPrice);
        }

        private void ReceiptPrints()
        {
            int totalItems = dataGridView_cart.Rows.Count;
            if (totalItems > 0 && totalItems <= 6)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 400);
                printDocument1.Print();
            }
            if (totalItems > 6 && totalItems <= 10)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 500);
                printDocument1.Print();
            }
            if (totalItems > 10 && totalItems <= 14)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                printDocument1.Print();
            }
            if (totalItems > 14 && totalItems <= 20)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 700);
                printDocument1.Print();
            }
            if (totalItems > 20 && totalItems <= 25)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 800);
                printDocument1.Print();
            }
            if (totalItems > 25 && totalItems <= 30)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 900);
                printDocument1.Print();
            }
            if (totalItems > 30 && totalItems <= 35)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1000);
                printDocument1.Print();
            }
        }

        //design of receipt
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.pizzalogo;
            //Bitmap bmp2 = Properties.Resources.fotolarge;
            Image img = bmp;
            //Image logo = bmp2;
            e.Graphics.DrawImage(img, 5, 5, 75, 70);
            //e.Graphics.DrawImage(logo, 700, 20, 150, 80);
            //e.Graphics.DrawString("Customer Name: " + txtBoxCustomer.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(220, 220));
            e.Graphics.DrawString("PIZZA CLUB", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(100, 20));
            e.Graphics.DrawString("Model Town Phase: 2", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, new Point(102, 40));
            e.Graphics.DrawString("Near Islam Medical College", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, new Point(92, 50));
            e.Graphics.DrawString("Pasrur Road Sialkot", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, new Point(104, 60));
            e.Graphics.DrawString("Order Receipt", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(110, 80));
            auto_increment_id(sender, e);
            e.Graphics.DrawString("Order ID: " + sale_id, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(10, 90));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(215, 90));
            //if (string.IsNullOrEmpty(txtBoxCustomer.Text) != true)

            //e.Graphics.DrawString("Time: " + DateTime.Now.ToLongTimeString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(220, 310));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(0, 100));
            e.Graphics.DrawString("ITEM", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(10, 110));
            e.Graphics.DrawString("PRICE", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(110, 110));
            e.Graphics.DrawString("QTY", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(170, 110));
            e.Graphics.DrawString("Total", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(220, 110));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(0, 120));
            int gap = 130;
            //int subTotal1 = 0;
            for (int i = 0; i < dataGridView_cart.Rows.Count-1; i++)
            {
                try
                {   //item name
                    e.Graphics.DrawString(dataGridView_cart.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, gap));
                    //item price
                    e.Graphics.DrawString(dataGridView_cart.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(110, gap));
                    //quantity
                    e.Graphics.DrawString(dataGridView_cart.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(170, gap));
                    //total
                    e.Graphics.DrawString(dataGridView_cart.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(220, gap));
                    gap = gap + 20;
                    //subTotal1 = subTotal1 + (Convert.ToInt32(sales_dataGridView.Rows[i].Cells[5].Value.ToString()));
                }
                catch
                {

                }
            }
            if(txt_extraCharges.Text != "")
            {
                e.Graphics.DrawString("Extra Charges", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(10, gap));
                e.Graphics.DrawString(txt_extraCharges.Text, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(220, gap));
                gap += 10;
            }

            //if (gap < 750)
            //gap = 750;
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(0, gap));
            gap = gap + 10;
            //e.Graphics.DrawString("Sub Total: " + subTotal1 + ".00 Rs/-", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(220, gap));
            //gap = gap + 30;
            //if (txtBoxFinalCost.Text != null)
            //e.Graphics.DrawString("Taxes: " + printTax + ".00 Rs/-", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(220, gap));
            //gap = gap + 20;
            e.Graphics.DrawString("Final Amount: " + label_cartGrossTotal.Text + ".00 Rs/-", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(160, gap));
            gap = gap + 10;
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(0, gap));
            gap = gap + 10;
            e.Graphics.DrawString("Amount Paid: " + txt_amountGiven.Text + ".00 Rs/-", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(162, gap));
            gap = gap + 10;
            e.Graphics.DrawString("Change: " + txt_change.Text + ".00 Rs/-", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(183, gap));
            gap = gap + 30;
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(0, gap));
            gap = gap + 10;

            e.Graphics.DrawString("Thanks for your order!", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(90, gap));
            gap = gap + 10;
            e.Graphics.DrawString("For Home Delivery, Call us at: 0314 7863120", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(48, gap));
            //gap = gap + 10;
            //e.Graphics.DrawString("Previously known as BAJWA SUPER STORE", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(48, gap));
            gap = gap + 20;
            e.Graphics.DrawString("Developer Contact: 0304-2998055", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(70, gap));
            gap = gap + 10;
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(0, gap));
            gap = gap + 10;
        }

        //allow only numbers to quantity textboxes
        private void txt_qtyPizza_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_qtyPizza.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_qtyPizza.Clear();
            }
        }

        private void txt_qtyBurger_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_qtyBurger.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_qtyBurger.Clear();
            }
        }

        private void txt_qtyDrink_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_qtyDrink.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_qtyDrink.Clear();
            }
        }

        private void txt_qtySideOrder_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_qtySideOrder.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_qtySideOrder.Clear();
            }
        }

        //type customer number, name and address will automatically loaded
        private void txt_customerContact_TextChanged(object sender, EventArgs e)
        {
            if(txt_customerContact.Text == "")
            {
                combo_customerName.Text = "";
                txt_customerAddress.Text = "";
            }
            try
            {
                SqlCommand com = new SqlCommand();
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select name, address from tbl_customers Where contact = @contact", sqlcon);
                cmd.Parameters.AddWithValue("@contact", txt_customerContact.Text);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    combo_customerName.Text = da.GetValue(0).ToString();
                    txt_customerAddress.Text = da.GetValue(1).ToString();
                }
                sqlcon.Close();
            }
            catch
            {
                sqlcon.Close();
            }
        }

        //calculate gross total when extra charges are added
        private void txt_extraCharges_TextChanged(object sender, EventArgs e)
        {
            calculate_grossTotal();
        }
    }
}
