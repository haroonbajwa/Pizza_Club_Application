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
    public partial class Form_usageGrams : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public Form_usageGrams()
        {
            InitializeComponent();
        }

        //on form load
        private void Form_usageGrams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_usageGrams' table. You can move, or remove it, as needed.
            this.tbl_usageGramsTableAdapter.Fill(this.databasePCDataSet.tbl_usageGrams);

            dataGridView_usageGrams.Columns[0].ReadOnly = true;
            dataGridView_usageGrams.Columns[1].ReadOnly = true;
            dataGridView_usageGrams.Columns[2].ReadOnly = true;
            dataGridView_usageGrams.Columns[3].ReadOnly = true;
            dataGridView_usageGrams.Columns[4].ReadOnly = false;

        }

        private void ClearTextBoxes()
        {
            txt_usageId.Clear();
            txt_usageName.Clear();
            txt_usageQty.Clear();
        }

        private void btn_clearUsage_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btn_viewUsage_Click(sender, e);
        }

        private void btn_updateUsage_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_usageGrams SET name = @name, usageQty = @usageQty WHERE Id = @Id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", txt_usageId.Text);
                cmd.Parameters.AddWithValue("@name", txt_usageName.Text);
                cmd.Parameters.AddWithValue("@usageQty", txt_usageQty.Text);


                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                btn_viewUsage_Click(sender, e);
                MessageBox.Show("Grams Usage information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
        }

        private void btn_deleteUsage_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_usageGrams.Rows.Count - 1; i++)
            {
                drow = dataGridView_usageGrams.Rows[i];
                if (Convert.ToBoolean(drow.Cells[4].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_usageGrams where Id='" + s + "'", sqlcon);
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

            btn_viewUsage_Click(sender, e);
            MessageBox.Show("Record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        private void btn_viewUsage_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_usageGrams";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_usageGrams.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
        }

        //select a record to show in textboxes
        private void dataGridView_usageGrams_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_usageGrams.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_usageId.Text = row.Cells[0].Value.ToString();
                    txt_usageName.Text = row.Cells[1].Value.ToString();
                    txt_usageQty.Text = row.Cells[2].Value.ToString();
                }
            }
            catch
            {
            }
        }

        //get records by selecting specific date
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Close();
                sqlcon.Open();
                string query = "select * from tbl_usageGrams where date = '" + dateTimePicker1.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_usageGrams.DataSource = dt;

                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
        }
    }
}
