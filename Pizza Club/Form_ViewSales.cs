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
    public partial class Form_ViewSales : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        
        public Form_ViewSales()
        {
            InitializeComponent();
        }

        private void Form_ViewSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_sales' table. You can move, or remove it, as needed.
            this.tbl_salesTableAdapter.Fill(this.databasePCDataSet.tbl_sales);

            dataGridView_viewSales.Columns[0].ReadOnly = true;
            dataGridView_viewSales.Columns[1].ReadOnly = true;
            dataGridView_viewSales.Columns[2].ReadOnly = true;
            dataGridView_viewSales.Columns[3].ReadOnly = true;
            dataGridView_viewSales.Columns[4].ReadOnly = true;
            dataGridView_viewSales.Columns[5].ReadOnly = true;
            dataGridView_viewSales.Columns[6].ReadOnly = true;
            dataGridView_viewSales.Columns[7].ReadOnly = true;
            dataGridView_viewSales.Columns[8].ReadOnly = true;
            dataGridView_viewSales.Columns[9].ReadOnly = true;
            dataGridView_viewSales.Columns[10].ReadOnly = true;
            dataGridView_viewSales.Columns[11].ReadOnly = true;
            dataGridView_viewSales.Columns[12].ReadOnly = false;

            btn_refreshSales_Click(sender, e);
            calculate_grossTotal();

        }

        //calculate gross total
        void calculate_grossTotal()
        {
            //calculate gross total from datagridview
            decimal sum = 0;
            int preId = 0;
            for (int i = 0; i < dataGridView_viewSales.Rows.Count; ++i)
            {
                if (Convert.ToInt32(dataGridView_viewSales.Rows[i].Cells[0].Value) != preId)
                {
                    //add sale grosstotal value to gross total label
                    sum += Convert.ToInt32(dataGridView_viewSales.Rows[i].Cells[7].Value);
                }
                preId = Convert.ToInt32(dataGridView_viewSales.Rows[i].Cells[0].Value);

            }
            label_totalViewSales.Text = sum.ToString();
            if (sum == 0)
            {
                label_totalViewSales.Text = "0.00";
            }
        }

        private void btn_refreshSales_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_sales";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_viewSales.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            txt_searchSales.Clear();
            calculate_grossTotal();
            
        }

        //filter sales 
        private void btn_filterSales_Click(object sender, EventArgs e)
        {
            //all sales
            if (radio_allSales.Checked == true)
            {
                try
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_sales";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_viewSales.DataSource = dt;

                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
            //today sales
            else if (radio_todaySales.Checked == true)
            {
                try
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_sales where date = '" + DateTime.Today + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_viewSales.DataSource = dt;

                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
            //load 7 days sales
            else if (radio_7daysSales.Checked == true)
            {
                try
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_sales where date >= DATEADD(day,-7, GETDATE())";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_viewSales.DataSource = dt;

                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
            //load 30 days sales
            else if (radio_30daysSales.Checked == true)
            {
                try
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_sales where date >= DATEADD(day,-30,GETDATE()) AND date <= getdate()";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_viewSales.DataSource = dt;

                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
            //load sales of selected date
            else if (radio_selectDate.Checked == true)
            {
                try
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_sales where date = '" + dateTimePicker1.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_viewSales.DataSource = dt;

                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }

        private void btn_deleteSales_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_viewSales.Rows.Count - 1; i++)
            {
                drow = dataGridView_viewSales.Rows[i];
                if (Convert.ToBoolean(drow.Cells[12].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_sales where id='" + s + "'", sqlcon);
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

            btn_refreshSales_Click(sender, e);
            MessageBox.Show("Sale(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //search by products
        private void txt_searchSales_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(dt);
                DV.RowFilter = string.Format("productName LIKE '%{0}%'", txt_searchSales.Text);
                dataGridView_viewSales.DataSource = DV;
                calculate_grossTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
