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
    public partial class Form_Purchase : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public Form_Purchase()
        {
            InitializeComponent();
        }

        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_purchase";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_purchaseId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_purchaseId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_purchaseName.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_purchaseName.Focus();
                return false;
            }
            else if (txt_purchasePrice.Text == String.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_purchasePrice.Focus();
                return false;
            }
            return true;
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_purchase Values (@id, @name, @price, @date, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_purchaseId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_purchaseName.Text);
                    cmd.Parameters.AddWithValue("@price", txt_purchasePrice.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    btn_viewPurchase_Click(sender, e);
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

        private void btn_deletePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from tbl_purchase WHERE Id = '" + txt_purchaseId.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }

            btn_viewPurchase_Click(sender, e);
            MessageBox.Show("Purchase record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        private void btn_viewPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_purchase";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_purchase.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
            calculate_grossTotal();
        }

        //Clear textboxes
        private void ClearTextBoxes()
        {
            txt_purchaseName.Text = "";
            txt_purchasePrice.Text = "";
            txt_searchPurchase.Text = "";
            txt_purchaseName.Focus();
        }

        //clear button
        private void btn_clearPurchase_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            auto_increment_id(sender, e);
            btn_viewPurchase_Click(sender, e);
            calculate_grossTotal();
        }

        //select a record to show in text boxes
        private void dataGridView_purchase_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_purchase.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_purchaseId.Text = row.Cells[0].Value.ToString();
                    txt_purchaseName.Text = row.Cells[1].Value.ToString();
                    txt_purchasePrice.Text = row.Cells[2].Value.ToString();
                }
            }
            catch
            {
            }
        }

        public void calculate_grossTotal()
        {
            //calculate gross total from datagridview
            decimal sum = 0;
            for (int i = 0; i < dataGridView_purchase.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView_purchase.Rows[i].Cells[2].Value);
            }
            label_grossTotal.Text = sum.ToString();
            if (sum == 0)
            {
                label_grossTotal.Text = "0.00";
            }
        }

        private void btn_filterPurchase_Click(object sender, EventArgs e)
        {
            if (radio_30DaysPurchase.Checked == true)
            {
                try
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_purchase where date >= DATEADD(day,-30,GETDATE()) AND date <= getdate()";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_purchase.DataSource = dt;
                    calculate_grossTotal();

                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                    sqlcon.Close();
                }
            }
            else if (radio_selectDatePurchase.Checked == true)
            {
                try
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_purchase where date between '" + dateTimePicker1.Value.Date.AddHours(6) + "' AND '" + dateTimePicker1.Value.Date.AddHours(30) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_purchase.DataSource = dt;
                    calculate_grossTotal();

                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                    sqlcon.Close();
                }
            }
        }

        //search purchase record
        private void txt_searchPurchase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(dt);
                DV.RowFilter = string.Format("name LIKE '%{0}%'", txt_searchPurchase.Text);
                dataGridView_purchase.DataSource = DV;
                calculate_grossTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
        }

        private void Form_Purchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_purchase' table. You can move, or remove it, as needed.
            this.tbl_purchaseTableAdapter.Fill(this.databasePCDataSet.tbl_purchase);

            btn_clearPurchase_Click(sender, e);

        }
    }
}
