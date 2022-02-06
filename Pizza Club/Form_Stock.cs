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
    public partial class Form_Stock : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;

        public Form_Stock()
        {
            InitializeComponent();
        }

        private void Form_Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_stockGrams' table. You can move, or remove it, as needed.
            this.tbl_stockGramsTableAdapter.Fill(this.databasePCDataSet.tbl_stockGrams);
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_stockPCS' table. You can move, or remove it, as needed.
            this.tbl_stockPCSTableAdapter.Fill(this.databasePCDataSet.tbl_stockPCS);


            dataGridView_stockPCS.Columns[0].ReadOnly = true;
            dataGridView_stockPCS.Columns[1].ReadOnly = true;
            dataGridView_stockPCS.Columns[2].ReadOnly = true;
            dataGridView_stockPCS.Columns[3].ReadOnly = false;

            dataGridView_stockGrams.Columns[0].ReadOnly = true;
            dataGridView_stockGrams.Columns[1].ReadOnly = true;
            dataGridView_stockGrams.Columns[2].ReadOnly = true;
            dataGridView_stockGrams.Columns[3].ReadOnly = false;

        }

        //Clear textboxes
        private void ClearTextBoxes()
        {
            txt_StockGramsId.Clear();
            txt_StockGramsName.Clear();
            txt_StockGramsQty.Clear();

            txt_StockPcsId.Clear();
            txt_StockPcsName.Clear();
            txt_StockPcsQty.Clear();
            
        }

        //Uncheck checkboxes
        void Uncheck_checkboxes()
        {
            foreach (DataGridViewRow drv in dataGridView_stockPCS.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[3].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[3].Value = false;
                }
            }

            foreach (DataGridViewRow drv in dataGridView_stockGrams.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[3].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[3].Value = false;
                }
            }
        }

        private void btn_clearStock_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
        }

        // stock pices buttons
        private void btn_updateStockPcs_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE tbl_stockPCS SET quantity = @quantity WHERE Id = @Id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", txt_StockPcsId.Text);
                cmd.Parameters.AddWithValue("@quantity", txt_StockPcsQty.Text);

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                cmd.Parameters.Clear();

                btn_viewStockPcs_Click(sender, e);
                MessageBox.Show("Stock information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
            
        }

        private void btn_deleteStockPcs_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_stockPCS.Rows.Count - 1; i++)
            {
                drow = dataGridView_stockPCS.Rows[i];
                if (Convert.ToBoolean(drow.Cells[3].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_stockPCS where Id='" + s + "'", sqlcon);
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

            btn_viewStockPcs_Click(sender, e);
            MessageBox.Show("Stock record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        private void btn_viewStockPcs_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_stockPCS";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_stockPCS.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        //select a record to show in text boxes
        private void dataGridView_stockPCS_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_stockPCS.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_StockPcsId.Text = row.Cells[0].Value.ToString();
                    txt_StockPcsName.Text = row.Cells[1].Value.ToString();
                    txt_StockPcsQty.Text = row.Cells[2].Value.ToString();
                }
            }
            catch
            {
            }
        }

        //check and increment id for usageGrams table
        private int usageGramsId = 1;
        void auto_increment_usageId(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(Id) from tbl_usageGrams";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    usageGramsId = 1;
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    usageGramsId = a;
                }
            }
            sqlcon.Close();
        }

        //get selected row qty value
        private int prevQty = 0;
        private void dataGridView_stockGrams_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_stockGrams.SelectedRows.Count > 0)
            {
                int selectedrowindex = dataGridView_stockGrams.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_stockGrams.Rows[selectedrowindex];
                prevQty = Convert.ToInt32(selectedRow.Cells[2].Value);
            }
        }

        // stock grams
        private void btn_updateStockGrams_Click(object sender, EventArgs e)
        {
            //calculate usage grams Qty
            int usageQty = prevQty - Convert.ToInt32(txt_StockGramsQty.Text);

            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE tbl_stockGrams SET quantity = @quantity WHERE Id = @Id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", txt_StockGramsId.Text);
                cmd.Parameters.AddWithValue("@quantity", txt_StockGramsQty.Text);

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                cmd.Parameters.Clear();

                btn_viewStockGrams_Click(sender, e);
                MessageBox.Show("Stock information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                auto_increment_usageId(sender, e);
                //add usage value to tbl_usageGrams table  (usage = prevStock - newStock)
                SqlCommand cmd1 = new SqlCommand("Insert into tbl_usageGrams Values (@Id, @name, @usageQty, @date, @select)", sqlcon);
                cmd1.CommandType = CommandType.Text;

                cmd1.Parameters.AddWithValue("@Id", usageGramsId);
                cmd1.Parameters.AddWithValue("@name", txt_StockGramsName.Text);
                cmd1.Parameters.AddWithValue("@usageQty", usageQty);
                cmd1.Parameters.AddWithValue("@date", DateTime.Now);
                cmd1.Parameters.AddWithValue("@select", false);

                sqlcon.Open();
                cmd1.ExecuteNonQuery();
                sqlcon.Close();

                ClearTextBoxes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
            
        }

        private void btn_deleteStockGrams_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_stockGrams.Rows.Count - 1; i++)
            {
                drow = dataGridView_stockGrams.Rows[i];
                if (Convert.ToBoolean(drow.Cells[3].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_stockGrams where Id='" + s + "'", sqlcon);
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

            btn_viewStockGrams_Click(sender, e);
            MessageBox.Show("Stock record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        private void btn_viewStockGrams_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_stockGrams";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_stockGrams.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        //select a record to show in text boxes
        private void dataGridView_stockGrams_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_stockGrams.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_StockGramsId.Text = row.Cells[0].Value.ToString();
                    txt_StockGramsName.Text = row.Cells[1].Value.ToString();
                    txt_StockGramsQty.Text = row.Cells[2].Value.ToString();
                }
            }
            catch
            {
            }
        }
    }
}
