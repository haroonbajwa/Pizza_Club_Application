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

        private void purchase_pieces_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_purchasePCS' table. You can move, or remove it, as needed.
            this.tbl_purchasePCSTableAdapter.Fill(this.databasePCDataSet.tbl_purchasePCS);

            dataGridView_purchasePCS.Columns[0].ReadOnly = true;
            dataGridView_purchasePCS.Columns[1].ReadOnly = true;
            dataGridView_purchasePCS.Columns[2].ReadOnly = true;
            dataGridView_purchasePCS.Columns[3].ReadOnly = true;
            dataGridView_purchasePCS.Columns[4].ReadOnly = false;

            auto_increment_id(sender, e);

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
            if (txt_pcsName.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pcsName.Focus();
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
                    SqlCommand cmd = new SqlCommand("Insert into tbl_purchasePCS Values (@id, @name, @quantity, @price, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_pcsId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_pcsName.Text);
                    cmd.Parameters.AddWithValue("@quantity", txt_pcsQuantity.Text);
                    cmd.Parameters.AddWithValue("@price", txt_pcsPrice.Text);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

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
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_purchasePCS.Rows.Count - 1; i++)
            {
                drow = dataGridView_purchasePCS.Rows[i];
                if (Convert.ToBoolean(drow.Cells[4].Value) == true) //checking if  checked or not.  
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
            txt_pcsName.Text = "";
            txt_pcsQuantity.Text = "";
            txt_pcsPrice.Text = "";
            txt_pcsName.Focus();
        }

        //Uncheck checkboxes
        void Uncheck_checkboxes()
        {
            foreach (DataGridViewRow drv in dataGridView_purchasePCS.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[4].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[4].Value = false;
                }
            }
        }

        private void btn_clearPCS_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
        }
    }
}
