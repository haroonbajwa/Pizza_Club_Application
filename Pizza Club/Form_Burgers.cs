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
    public partial class Form_Burgers : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");
        public Form_Burgers()
        {
            InitializeComponent();
        }

        DataTable dt;

        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_burgers";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_BurgerId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_BurgerId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_BurgerName.Text == String.Empty)
            {
                MessageBox.Show("Burger Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_BurgerName.Focus();
                return false;
            }
            else if (txt_BurgerPrice.Text == String.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_BurgerPrice.Focus();
                return false;
            }
            return true;
        }

        private void btn_addBurger_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_burgers Values (@id, @name, @price, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_BurgerId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_BurgerName.Text);
                    cmd.Parameters.AddWithValue("@price", txt_BurgerPrice.Text);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    btn_viewBurger_Click(sender, e);
                    MessageBox.Show("New Burger added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        private void btn_updateBurger_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_burgers SET name = @name, price = @price WHERE id = @id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txt_BurgerId.Text);
                cmd.Parameters.AddWithValue("@name", txt_BurgerName.Text);
                cmd.Parameters.AddWithValue("@price", txt_BurgerPrice.Text);


                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                btn_viewBurger_Click(sender, e);
                MessageBox.Show("Burger information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                auto_increment_id(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deleteBurger_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_burgers.Rows.Count - 1; i++)
            {
                drow = dataGridView_burgers.Rows[i];
                if (Convert.ToBoolean(drow.Cells[3].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_burgers where id='" + s + "'", sqlcon);
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

            btn_viewBurger_Click(sender, e);
            MessageBox.Show("Record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        private void btn_viewBurger_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_burgers";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_burgers.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void Form_Burgers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_burgers' table. You can move, or remove it, as needed.
            this.tbl_burgersTableAdapter.Fill(this.databasePCDataSet.tbl_burgers);

            dataGridView_burgers.Columns[0].ReadOnly = true;
            dataGridView_burgers.Columns[1].ReadOnly = true;
            dataGridView_burgers.Columns[2].ReadOnly = true;
            dataGridView_burgers.Columns[3].ReadOnly = false;

            auto_increment_id(sender, e);

        }

        private void btn_clearBurger_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
            auto_increment_id(sender, e);
        }

        //Clear textboxes
        private void ClearTextBoxes()
        {
            txt_BurgerName.Clear();
            txt_BurgerPrice.Clear();
            txt_BurgerName.Focus();
        }

        //Uncheck checkboxes
        void Uncheck_checkboxes()
        {
            foreach (DataGridViewRow drv in dataGridView_burgers.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[3].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[3].Value = false;
                }
            }
        }

        //select record to show in text boxes
        private void dataGridView_burgers_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_burgers.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_BurgerId.Text = row.Cells[0].Value.ToString();
                    txt_BurgerName.Text = row.Cells[1].Value.ToString();
                    txt_BurgerPrice.Text = row.Cells[2].Value.ToString();
                }
            }
            catch
            {
            }
        }
    }
}
