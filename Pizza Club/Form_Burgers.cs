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

        }

        private void btn_updateBurger_Click(object sender, EventArgs e)
        {

        }

        private void btn_deleteBurger_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewBurger_Click(object sender, EventArgs e)
        {

        }

        private void Form_Burgers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_burgers' table. You can move, or remove it, as needed.
            this.tbl_burgersTableAdapter.Fill(this.databasePCDataSet.tbl_burgers);

            auto_increment_id(sender, e);

        }

        private void btn_clearBurger_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
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
    }
}
