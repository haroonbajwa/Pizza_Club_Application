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
    public partial class Form_AddRecord : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        public Form_AddRecord()
        {
            InitializeComponent();
        }

        //Clear textboxes expense
        private void ClearTextBoxesExpense()
        {
            txt_expenseName.Clear();
            txt_expensePrice.Clear();
            txt_expenseName.Focus();
        }

        //Clear textboxes purchase
        private void ClearTextBoxesPurchase()
        {
            txt_purchaseName.Clear();
            txt_purchasePrice.Clear();
            txt_purchaseName.Focus();
        }

        //Clear textboxes purchase
        private void ClearTextBoxesPayment()
        {
            txt_paymentName.Clear();
            txt_paymentPrice.Clear();
            txt_paymentName.Focus();
        }

        //Auto Increment Expense Id
        void auto_increment_expenseId(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_expense";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_expenseId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_expenseId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //Auto Increment Purchase Id
        void auto_increment_purchaseId(object sender, EventArgs e)
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

        //Auto Increment Payment Id
        void auto_increment_paymentId(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_onlinePayment";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_paymentId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_paymentId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED of Expense
        private bool IsValidExpense()
        {
            if (txt_expenseName.Text == String.Empty)
            {
                MessageBox.Show("Expense Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_expenseName.Focus();
                return false;
            }
            else if (txt_expensePrice.Text == String.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_expensePrice.Focus();
                return false;
            }

            return true;
        }

        //CHECK IF ANY BOX IS NOT FILLED of Purchase
        private bool IsValidPurchase()
        {
            if (txt_purchaseName.Text == String.Empty)
            {
                MessageBox.Show("Purchase Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //CHECK IF ANY BOX IS NOT FILLED of Purchase
        private bool IsValidPayment()
        {
            if (txt_paymentName.Text == String.Empty)
            {
                MessageBox.Show("Payment Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_paymentName.Focus();
                return false;
            }
            else if (txt_paymentPrice.Text == String.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_paymentPrice.Focus();
                return false;
            }

            return true;
        }


        //close button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.fw.Show();
        }

        //on form load
        private void Form_Details_Load(object sender, EventArgs e)
        {
            auto_increment_expenseId(sender, e);
            auto_increment_purchaseId(sender, e);
            auto_increment_paymentId(sender, e);
        }

        //add expense
        private void btn_expenseAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidExpense())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_expense Values (@id, @name, @price,@date, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_expenseId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_expenseName.Text);
                    cmd.Parameters.AddWithValue("@price", txt_expensePrice.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("New Expense added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxesExpense();
                    auto_increment_expenseId(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        //add purchase
        private void btn_purchaseAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidPurchase())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_purchase Values (@id, @name, @price,@date, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_purchaseId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_purchaseName.Text);
                    cmd.Parameters.AddWithValue("@price", txt_purchasePrice.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("New Purchase added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxesPurchase();
                    auto_increment_purchaseId(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        //add online payment
        private void btn_paymentAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidPayment())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_onlinePayment Values (@id, @name, @price,@date, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_paymentId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_paymentName.Text);
                    cmd.Parameters.AddWithValue("@price", txt_paymentPrice.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("New Online Payment added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxesPayment();
                    auto_increment_paymentId(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }
    }
}
