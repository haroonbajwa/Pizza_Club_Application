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
    public partial class Form_AllIngredients : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public Form_AllIngredients()
        {
            InitializeComponent();
        }

        private void Form_AllIngredients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_allIngredients' table. You can move, or remove it, as needed.
            this.tbl_allIngredientsTableAdapter.Fill(this.databasePCDataSet.tbl_allIngredients);
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_allIngredients' table. You can move, or remove it, as needed.
            //this.tbl_allIngredientsTableAdapter.Fill(this.databasePCDataSet.tbl_allIngredients);


            dataGridView_Ingredients.Columns[0].ReadOnly = true;
            dataGridView_Ingredients.Columns[1].ReadOnly = true;
            dataGridView_Ingredients.Columns[2].ReadOnly = true;
            dataGridView_Ingredients.Columns[3].ReadOnly = false;

            auto_increment_id(sender, e);
        }

        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_allIngredients";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_ingId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_ingId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_ingName.Text == String.Empty)
            {
                MessageBox.Show("Ingredient Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ingName.Focus();
                return false;
            }
            else if (combo_ingType.Text == String.Empty)
            {
                MessageBox.Show("Ingredient type is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_ingType.Focus();
                return false;
            }
            return true;
        }

        private void btn_clear_ing_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
            auto_increment_id(sender, e);
        }

        private void btn_addIng_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_allIngredients Values (@id, @name, @type, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_ingId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_ingName.Text);
                    cmd.Parameters.AddWithValue("@type", combo_ingType.Text);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    btn_viewIng_Click(sender, e);
                    MessageBox.Show("New Ingredient added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        private void btn_updateIng_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_allIngredients SET name = @ingName, type = @type WHERE Id = @id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txt_ingId.Text);
                cmd.Parameters.AddWithValue("@ingName", txt_ingName.Text);
                cmd.Parameters.AddWithValue("@type", combo_ingType.Text);

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                btn_viewIng_Click(sender, e);
                MessageBox.Show("Pizza information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                auto_increment_id(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
        }

        private void btn_deleteIng_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_Ingredients.Rows.Count - 1; i++)
            {
                drow = dataGridView_Ingredients.Rows[i];
                if (Convert.ToBoolean(drow.Cells[3].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_allIngredients where id='" + s + "'", sqlcon);
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

            btn_viewIng_Click(sender, e);
            MessageBox.Show("Record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        private void btn_viewIng_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_allIngredients";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_Ingredients.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
        }

        //Clear textboxes
        private void ClearTextBoxes()
        {
            txt_ingName.Clear();
            combo_ingType.SelectedIndex = -1;
            txt_ingName.Focus();
        }

        //Uncheck checkboxes
        void Uncheck_checkboxes()
        {
            foreach (DataGridViewRow drv in dataGridView_Ingredients.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[3].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[3].Value = false;
                }
            }
        }

        //select a record to show in text boxes
        private void dataGridView_Ingredients_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_Ingredients.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_ingId.Text = row.Cells[0].Value.ToString();
                    txt_ingName.Text = row.Cells[1].Value.ToString();
                    combo_ingType.Text = row.Cells[2].Value.ToString();
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }
    }
}
