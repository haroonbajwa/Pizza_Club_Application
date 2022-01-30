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
    public partial class purchase_pieces : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public purchase_pieces()
        {
            InitializeComponent();
        }

        //function of load ingredients in combo box
        void load_allIngredients()
        {
            //remove previous items
            combo_pcsName.Items.Clear();

            try
            {
                sqlcon.Open();

                string query = "select * from tbl_allIngredients WHERE type = @type";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@type", "Pieces");
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_pcsName.Items.Add(reader["name"].ToString());
                }

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void purchase_pieces_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_purchasePCS' table. You can move, or remove it, as needed.
            this.tbl_purchasePCSTableAdapter.Fill(this.databasePCDataSet.tbl_purchasePCS);

            dataGridView_purchasePCS.Columns[0].ReadOnly = true;
            dataGridView_purchasePCS.Columns[1].ReadOnly = true;
            dataGridView_purchasePCS.Columns[2].ReadOnly = true;
            dataGridView_purchasePCS.Columns[3].ReadOnly = true;
            dataGridView_purchasePCS.Columns[4].ReadOnly = true;
            dataGridView_purchasePCS.Columns[5].ReadOnly = false;

            auto_increment_id(sender, e);
            load_allIngredients();

        }

        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_purchasePCS";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_pcsId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_pcsId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (combo_pcsName.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_pcsName.Focus();
                return false;
            }
            else if (txt_pcsQuantity.Text == String.Empty)
            {
                MessageBox.Show("Quantity is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pcsQuantity.Focus();
                return false;
            }
            else if (txt_pcsPrice.Text == String.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pcsPrice.Focus();
                return false;
            }
            return true;
        }

        private void btn_purchasePCS_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_purchasePCS Values (@id, @name, @quantity, @price, @date, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_pcsId.Text);
                    cmd.Parameters.AddWithValue("@name", combo_pcsName.Text);
                    cmd.Parameters.AddWithValue("@quantity", txt_pcsQuantity.Text);
                    cmd.Parameters.AddWithValue("@price", txt_pcsPrice.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();


                    //check if stock record exists then update or create new
                    sqlcon.Open();
                    cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_stockPCS WHERE name = @name", sqlcon);
                    cmd.Parameters.AddWithValue("@name", combo_pcsName.Text);
                    int productExist = (int)cmd.ExecuteScalar();
                    sqlcon.Close();
                    if (productExist > 0)
                    {
                        //update stock in stock table
                        cmd.Parameters.Clear();
                        cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity = quantity+@newQty WHERE name = @name", sqlcon);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@name", combo_pcsName.Text);
                        cmd.Parameters.AddWithValue("@newQty", txt_pcsQuantity.Text);

                        sqlcon.Open();
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                    }
                    else
                    {
                        //auto increment in stock Id
                        int a, incId = 1;
                        sqlcon.Open();
                        string query = "Select Max(Id) from tbl_stockPCS";
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
                        cmd = new SqlCommand("Insert into tbl_stockPCS Values (@Id, @name, @quantity, @select)", sqlcon);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", incId.ToString());
                        cmd.Parameters.AddWithValue("@name", combo_pcsName.Text);
                        cmd.Parameters.AddWithValue("@quantity", txt_pcsQuantity.Text);
                        cmd.Parameters.AddWithValue("@select", false);

                        sqlcon.Open();
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                    }


                    btn_viewPCS_Click(sender, e);
                    MessageBox.Show("Product purchased successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        private void btn_deletePCS_Click(object sender, EventArgs e)
        {
            //read stock value of purchase record to be deleted
            int del_purchase_stock = 0;
            try
            {
                //read stock from purchase table of invoice which is going to delete
                SqlCommand cmd1;
                sqlcon.Open();
                string query = "Select quantity FROM tbl_purchasePCS where Id = @purchaseId";
                cmd1 = new SqlCommand(query, sqlcon);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@purchaseId", txt_pcsId.Text);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    string val = dr[0].ToString();
                    del_purchase_stock = Convert.ToInt32(dr[0].ToString());
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }

            //read stock total stock value from stock table against product name
            int total_stock = 0;
            try
            {
                SqlCommand cmd2;
                sqlcon.Open();
                string query = "Select quantity FROM tbl_stockPCS where name = @productName";
                cmd2 = new SqlCommand(query, sqlcon);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@productName", txt_pcsName.Text);
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    string val = dr[0].ToString();
                    total_stock = Convert.ToInt32(dr[0].ToString());
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }

            //calculation to calculate new total stock
            int new_total_stock = 0;
            new_total_stock = total_stock - del_purchase_stock;

            //store new stock value to stock table
            try
            {
                SqlCommand cmd1;
                cmd1 = new SqlCommand("UPDATE tbl_stockPCS SET quantity = @quantity WHERE name = @product", sqlcon);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@product", txt_pcsName.Text);
                cmd1.Parameters.AddWithValue("@quantity", new_total_stock.ToString());

                sqlcon.Open();
                cmd1.ExecuteNonQuery();
                sqlcon.Close();
                cmd1.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }

            //delete purchase Invoice
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from tbl_purchasePCS WHERE Id = '" + txt_pcsId.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }

            

            /*List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_purchasePCS.Rows.Count - 1; i++)
            {
                drow = dataGridView_purchasePCS.Rows[i];
                if (Convert.ToBoolean(drow.Cells[5].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_purchasePCS where id='" + s + "'", sqlcon);
                cmd.ExecuteNonQuery();
            }

            //if there is no record selected
            if (selectedItem.Count == 0)
            {
                MessageBox.Show("First select record(s) to delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
                return;
            }

            sqlcon.Close();

            btn_viewPCS_Click(sender, e);
            MessageBox.Show("Record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);*/
            btn_viewPCS_Click(sender, e);
            MessageBox.Show("Purchase record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        private void btn_viewPCS_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_purchasePCS";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_purchasePCS.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        //Clear textboxes
        private void ClearTextBoxes()
        {
            combo_pcsName.Text = "";
            txt_pcsQuantity.Text = "";
            txt_pcsPrice.Text = "";
            combo_pcsName.Focus();
        }

        //Uncheck checkboxes
        void Uncheck_checkboxes()
        {
            /*foreach (DataGridViewRow drv in dataGridView_purchasePCS.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[5].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[5].Value = false;
                }
            }*/
        }

        private void btn_clearPCS_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
            auto_increment_id(sender, e);
        }

        //selct record to show in text boxes
        private void dataGridView_purchasePCS_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_purchasePCS.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_pcsId.Text = row.Cells[0].Value.ToString();
                    txt_pcsName.Text = row.Cells[1].Value.ToString();
                    txt_pcsQuantity.Text = row.Cells[2].Value.ToString();
                    txt_pcsPrice.Text = row.Cells[3].Value.ToString();
                }
            }
            catch
            {
            }
        }
    }
}
