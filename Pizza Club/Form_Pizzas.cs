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
    public partial class Form_Pizzas : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public Form_Pizzas()
        {
            InitializeComponent();
        }

        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_pizzas";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_pizzaId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_pizzaId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_pizzaName.Text == String.Empty)
            {
                MessageBox.Show("Pizza Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pizzaName.Focus();
                return false;
            }
            else if (txt_priceS.Text == String.Empty)
            {
                MessageBox.Show("Price(S) is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_priceS.Focus();
                return false;
            }
            else if (txt_priceM.Text == String.Empty)
            {
                MessageBox.Show("Price(M) is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_priceM.Focus();
                return false;
            }
            else if (txt_priceL.Text == String.Empty)
            {
                MessageBox.Show("Price(L) number is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_priceL.Focus();
                return false;
            }
            else if (txt_priceXL.Text == String.Empty)
            {
                MessageBox.Show("Price(XL) is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_priceXL.Focus();
                return false;
            }
            return true;
        }

        private void btn_addPizza_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_pizzas Values (@id, @name, @priceS, @priceM, @priceL, @priceXL, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_pizzaId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_pizzaName.Text);
                    cmd.Parameters.AddWithValue("@priceS", txt_priceS.Text);
                    cmd.Parameters.AddWithValue("@priceM", txt_priceM.Text);
                    cmd.Parameters.AddWithValue("@priceL", txt_priceL.Text);
                    cmd.Parameters.AddWithValue("@priceXL", txt_priceXL.Text);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    btn_viewPizzas_Click(sender, e);
                    MessageBox.Show("New Pizza added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        private void btn_updatePizza_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_pizzas SET name = @pizzaName, priceS = @priceS, priceM = @priceM, priceL = @priceL, priceXL = @priceXL WHERE id = @id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txt_pizzaId.Text);
                cmd.Parameters.AddWithValue("@pizzaName", txt_pizzaName.Text);
                cmd.Parameters.AddWithValue("@priceS", txt_priceS.Text);
                cmd.Parameters.AddWithValue("@priceM", txt_priceM.Text);
                cmd.Parameters.AddWithValue("@priceL", txt_priceL.Text);
                cmd.Parameters.AddWithValue("@priceXL", txt_priceXL.Text);

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                btn_viewPizzas_Click(sender, e);
                MessageBox.Show("Pizza information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                auto_increment_id(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deletePizza_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_pizzas.Rows.Count - 1; i++)
            {
                drow = dataGridView_pizzas.Rows[i];
                if (Convert.ToBoolean(drow.Cells[6].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_pizzas where id='" + s + "'", sqlcon);
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

            btn_viewPizzas_Click(sender, e);
            MessageBox.Show("Record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        private void btn_viewPizzas_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_pizzas";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_pizzas.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void Form_Pizzas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_pizzas' table. You can move, or remove it, as needed.
            this.tbl_pizzasTableAdapter.Fill(this.databasePCDataSet.tbl_pizzas);
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_pizzas' table. You can move, or remove it, as needed.
            //this.tbl_pizzasTableAdapter.Fill(this.databasePCDataSet.tbl_pizzas);

            dataGridView_pizzas.Columns[0].ReadOnly = true;
            dataGridView_pizzas.Columns[1].ReadOnly = true;
            dataGridView_pizzas.Columns[2].ReadOnly = true;
            dataGridView_pizzas.Columns[3].ReadOnly = true;
            dataGridView_pizzas.Columns[4].ReadOnly = true;
            dataGridView_pizzas.Columns[5].ReadOnly = true;
            dataGridView_pizzas.Columns[6].ReadOnly = false;

            auto_increment_id(sender, e);

        }

        //Clear textboxes
        private void ClearTextBoxes()
        {
            txt_pizzaName.Clear();
            txt_priceS.Clear();
            txt_priceM.Clear();
            txt_priceL.Clear();
            txt_priceXL.Clear();
            txt_pizzaName.Focus();
        }

        //Uncheck checkboxes
        void Uncheck_checkboxes()
        {
            foreach (DataGridViewRow drv in dataGridView_pizzas.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[6].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[6].Value = false;
                }
            }
        }

        private void btn_clear_pizzas_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
        }

        private void dataGridView_pizzas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_pizzas.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }
                
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_pizzaId.Text = row.Cells[0].Value.ToString();
                    txt_pizzaName.Text = row.Cells[1].Value.ToString();
                    txt_priceS.Text = row.Cells[2].Value.ToString();
                    txt_priceM.Text = row.Cells[3].Value.ToString();
                    txt_priceL.Text = row.Cells[4].Value.ToString();
                    txt_priceXL.Text = row.Cells[5].Value.ToString();
                }
            }
            catch
            {
            }
        }
    }
}
