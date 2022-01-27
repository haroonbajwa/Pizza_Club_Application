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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");

        DataTable dt;
        public Form_Pizzas()
        {
            InitializeComponent();
        }

        private void btn_addPizza_Click(object sender, EventArgs e)
        {

        }

        private void btn_updatePizza_Click(object sender, EventArgs e)
        {

        }

        private void btn_deletePizza_Click(object sender, EventArgs e)
        {

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
            // TODO: This line of code loads data into the 'databaseDataSet.tbl_pizzas' table. You can move, or remove it, as needed.
            this.tbl_pizzasTableAdapter.Fill(this.databaseDataSet.tbl_pizzas);

        }
    }
}
