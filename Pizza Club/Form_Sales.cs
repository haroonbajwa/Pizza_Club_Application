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
        void load_customers()
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
        }

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
            this.Hide();
            Program.fw.Show();
        }

        //on form load
        private void Form_Sales_Load(object sender, EventArgs e)
        {
            load_customers();
            load_pizzas();
            load_burgers();
            load_drinks();
            load_sideOrders();

            //auto check pizza size to small when form loads
            //radio_small.Checked = true;
        }

        //fetch customer data from database when anyone is selected from combobox
        private void combo_customerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            }
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
                //cmd.Parameters.AddWithValue("@columnName", columnName);
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
                }
            }
        }

        //IsValid Pizza
        private bool IsValid_Burger()
        {
            if (combo_burgers.Text == String.Empty)
            {
                MessageBox.Show("First select a Burger", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_pizzas.Focus();
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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btn_ATCDrink_Click(object sender, EventArgs e)
        {

        }

        private void btn_ATCSideOrder_Click(object sender, EventArgs e)
        {

        }

        //reset cart datagridview and all fields
        private void btn_resetCart_Click(object sender, EventArgs e)
        {
            combo_pizzas.SelectedIndex = -1;
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {

        }
    }
}
