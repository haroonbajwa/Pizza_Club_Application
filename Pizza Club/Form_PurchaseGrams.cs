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
    public partial class Form_PurchaseGrams : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;

        public Form_PurchaseGrams()
        {
            InitializeComponent();
        }

        //function of load ingredients in combo box
        void load_allIngredients()
        {
            //remove previous items
            combo_gramsName.Items.Clear();

            try
            {
                sqlcon.Open();

                string query = "select * from tbl_allIngredients WHERE type = @type";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@type", "Grams");
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_gramsName.Items.Add(reader["name"].ToString());
                }

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_PurchaseGrams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_purchaseGrams' table. You can move, or remove it, as needed.
            this.tbl_purchaseGramsTableAdapter.Fill(this.databasePCDataSet.tbl_purchaseGrams);

            dataGridView_purchaseGrams.Columns[0].ReadOnly = true;
            dataGridView_purchaseGrams.Columns[1].ReadOnly = true;
            dataGridView_purchaseGrams.Columns[2].ReadOnly = true;
            dataGridView_purchaseGrams.Columns[3].ReadOnly = true;
            dataGridView_purchaseGrams.Columns[4].ReadOnly = true;
            dataGridView_purchaseGrams.Columns[5].ReadOnly = false;

            auto_increment_id(sender, e);
            load_allIngredients();

        }

        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_purchaseGrams";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_gramsId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_gramsId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (combo_gramsName.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_gramsName.Focus();
                return false;
            }
            else if (txt_gramsQuantity.Text == String.Empty)
            {
                MessageBox.Show("Quantity is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_gramsQuantity.Focus();
                return false;
            }
            else if (txt_gramsPrice.Text == String.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_gramsPrice.Focus();
                return false;
            }
            return true;
        }

        private void btn_purchaseGrams_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_purchaseGrams Values (@id, @name, @quantity, @price, @date, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_gramsId.Text);
                    cmd.Parameters.AddWithValue("@name", combo_gramsName.Text);
                    cmd.Parameters.AddWithValue("@quantity", txt_gramsQuantity.Text);
                    cmd.Parameters.AddWithValue("@price", txt_gramsPrice.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();


                    //check if stock record exists then update or create new
                    sqlcon.Open();
                    cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_stockGrams WHERE name = @name", sqlcon);
                    cmd.Parameters.AddWithValue("@name", combo_gramsName.Text);
                    int productExist = (int)cmd.ExecuteScalar();
                    sqlcon.Close();
                    if (productExist > 0)
                    {
                        //update stock in stock table
                        cmd.Parameters.Clear();
                        cmd = new SqlCommand("UPDATE tbl_stockGrams SET quantity = quantity+@newQty WHERE name = @name", sqlcon);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@name", combo_gramsName.Text);
                        cmd.Parameters.AddWithValue("@newQty", txt_gramsQuantity.Text);

                        sqlcon.Open();
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                    }
                    else
                    {
                        //auto increment in stock Id
                        int a, incId = 1;
                        sqlcon.Open();
                        string query = "Select Max(Id) from tbl_stockGrams";
                        SqlCommand stockIncCmd = new SqlCommand(query, sqlcon);
                        SqlDataReader dr = stockIncCmd.ExecuteReader();
                        if (dr.Read())
                        {
                            string val = dr[0].ToString();
                            if (val == "")
                            {
                                incId = 1;
                            }
                            else
                            {
                                a = Convert.ToInt32(dr[0].ToString());
                                a = a + 1;
                                incId = a;
                            }
                        }
                        sqlcon.Close();

                        //add stock info in stock table
                        cmd.Parameters.Clear();
                        cmd = new SqlCommand("Insert into tbl_stockGrams Values (@Id, @name, @quantity, @select)", sqlcon);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", incId.ToString());
                        cmd.Parameters.AddWithValue("@name", combo_gramsName.Text);
                        cmd.Parameters.AddWithValue("@quantity", txt_gramsQuantity.Text);
                        cmd.Parameters.AddWithValue("@select", false);

                        sqlcon.Open();
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                    }


                    btn_viewGrams_Click(sender, e);
                    MessageBox.Show("Product purchased successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        private void btn_deleteGrams_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewGrams_Click(object sender, EventArgs e)
        {

        }

        private void btn_clearGrams_Click(object sender, EventArgs e)
        {

        }
    }
}
