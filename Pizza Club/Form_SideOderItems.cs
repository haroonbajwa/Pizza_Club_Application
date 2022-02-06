using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pizza_Club
{
    public partial class Form_SideOderItems : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public Form_SideOderItems()
        {
            InitializeComponent();
        }
        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_sideOrder";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_SideOrderId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_SideOrderId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_SideOrderName.Text == String.Empty)
            {
                MessageBox.Show(" Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SideOrderName.Focus();
                return false;
            }
            else if (txt_SideOrderPrice.Text == String.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SideOrderPrice.Focus();
                return false;
            }
           
            return true;
        }
        private void btn_addSideOder_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_sideOrder Values (@id, @name, @price, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_SideOrderId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_SideOrderName.Text);
                    cmd.Parameters.AddWithValue("@price", txt_SideOrderPrice.Text);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    btn_viewSideOrder_Click(sender, e);
                    MessageBox.Show("New SideOrder item added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        private void btn_updateSideOrder_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_sideOrder SET name = @Name, price = @price WHERE Id = @id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txt_SideOrderId.Text);
                cmd.Parameters.AddWithValue("@Name", txt_SideOrderName.Text);
                cmd.Parameters.AddWithValue("@price", txt_SideOrderPrice.Text);
               
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                btn_viewSideOrder_Click(sender, e);
                MessageBox.Show("SideOder item information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                auto_increment_id(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
        }

        private void btn_deleteSideOrder_Click(object sender, EventArgs e)
        {

            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_SideOrder.Rows.Count - 1; i++)
            {
                drow = dataGridView_SideOrder.Rows[i];
                if (Convert.ToBoolean(drow.Cells[3].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_sideOrder where Id='" + s + "'", sqlcon);
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

            btn_viewSideOrder_Click(sender, e);
            MessageBox.Show("Record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        private void btn_viewSideOrder_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_sideOrder";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_SideOrder.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
        }

        private void Form_SideOderItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_sideOrder' table. You can move, or remove it, as needed.
            this.tbl_sideOrderTableAdapter.Fill(this.databasePCDataSet.tbl_sideOrder);

            dataGridView_SideOrder.Columns[0].ReadOnly = true;
            dataGridView_SideOrder.Columns[1].ReadOnly = true;
            dataGridView_SideOrder.Columns[2].ReadOnly = true;
            dataGridView_SideOrder.Columns[3].ReadOnly = false;

            auto_increment_id(sender, e);
           
        }

        //Clear textboxes
        private void ClearTextBoxes()
        {
            txt_SideOrderName.Clear();
            txt_SideOrderPrice.Clear();
            txt_SideOrderName.Focus();
        }

        //Uncheck checkboxes
        void Uncheck_checkboxes()
        {
            foreach (DataGridViewRow drv in dataGridView_SideOrder.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[3].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[3].Value = false;
                }
            }
        }

        private void btn_clearSideOrder_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
            auto_increment_id(sender, e);
        }

        private void dataGridView_SideOrder_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_SideOrder.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_SideOrderId.Text = row.Cells[0].Value.ToString();
                    txt_SideOrderName.Text = row.Cells[1].Value.ToString();
                    txt_SideOrderPrice.Text = row.Cells[2].Value.ToString();
                }
            }
            catch
            {
            }
        }
    }
}
