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
    public partial class Form_Customers : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public Form_Customers()
        {
            InitializeComponent();
        }

        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_customers";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_customerId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_customerId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_customerName.Text == String.Empty)
            {
                MessageBox.Show("Customer Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_customerName.Focus();
                return false;
            }
            else if (txt_customerContact.Text == String.Empty)
            {
                MessageBox.Show("Contact is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_customerContact.Focus();
                return false;
            }
            return true;
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_customers Values (@id, @name, @contact, @address, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_customerId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_customerName.Text);
                    cmd.Parameters.AddWithValue("@contact", txt_customerContact.Text);
                    cmd.Parameters.AddWithValue("@address", txt_customerAddress.Text);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    btn_viewCustomer_Click(sender, e);
                    MessageBox.Show("New Customer added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_customers SET name = @Name, contact = @Contact, address = @Address WHERE Id = @id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txt_customerId.Text);
                cmd.Parameters.AddWithValue("@Name", txt_customerName.Text);
                cmd.Parameters.AddWithValue("@Contact", txt_customerContact.Text);
                cmd.Parameters.AddWithValue("@Address", txt_customerAddress.Text);


                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                btn_viewCustomer_Click(sender, e);
                MessageBox.Show("Customer information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                auto_increment_id(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_customer.Rows.Count - 1; i++)
            {
                drow = dataGridView_customer.Rows[i];
                if (Convert.ToBoolean(drow.Cells[4].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_customers where Id='" + s + "'", sqlcon);
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

            btn_viewCustomer_Click(sender, e);
            MessageBox.Show("Record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        private void btn_viewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_customers";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_customer.DataSource = dt;
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
            txt_customerName.Clear();
            txt_customerContact.Clear();
            txt_customerAddress.Clear();
            txt_customerName.Focus();
        }

        void Uncheck_checkboxes()
        {
            foreach (DataGridViewRow drv in dataGridView_customer.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[4].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[4].Value = false;
                }
            }
        }

        private void btn_clearCustomer_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
            auto_increment_id(sender, e);
        }

        private void dataGridView_customer_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_customer.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_customerId.Text = row.Cells[0].Value.ToString();
                    txt_customerName.Text = row.Cells[1].Value.ToString();
                    txt_customerContact.Text = row.Cells[2].Value.ToString();
                    txt_customerAddress.Text = row.Cells[3].Value.ToString();

                }
            }
            catch
            {
            }
        }

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_customers' table. You can move, or remove it, as needed.
            this.tbl_customersTableAdapter.Fill(this.databasePCDataSet.tbl_customers);

            dataGridView_customer.Columns[0].ReadOnly = true;
            dataGridView_customer.Columns[1].ReadOnly = true;
            dataGridView_customer.Columns[2].ReadOnly = true;
            dataGridView_customer.Columns[3].ReadOnly = true;
            dataGridView_customer.Columns[4].ReadOnly = false;

            auto_increment_id(sender, e);
        }
    }
}
