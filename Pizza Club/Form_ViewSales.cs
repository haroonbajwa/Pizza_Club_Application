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

            calculate_grossTotal();

        }

        //calculate gross total
        void calculate_grossTotal()
        {
            //calculate gross total from datagridview
            decimal sum = 0;
            for (int i = 0; i < dataGridView_viewSales.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView_viewSales.Rows[i].Cells[5].Value);
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
            calculate_grossTotal();
        }
    }
}
