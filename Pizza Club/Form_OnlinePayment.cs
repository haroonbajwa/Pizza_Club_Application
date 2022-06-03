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
    public partial class Form_OnlinePayment : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public Form_OnlinePayment()
        {
            InitializeComponent();
        }

        private void Form_OnlinePayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_onlinePayment' table. You can move, or remove it, as needed.
            this.tbl_onlinePaymentTableAdapter.Fill(this.databasePCDataSet.tbl_onlinePayment);

            btn_clearPayment_Click(sender, e);

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

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_paymentName.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //add new online payment
        private void btn_addPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_onlinePayment Values (@id, @name, @price, @date, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_paymentId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_paymentName.Text);
                    cmd.Parameters.AddWithValue("@price", txt_paymentPrice.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    btn_viewPayment_Click(sender, e);
                    MessageBox.Show("Payment Added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        //delete payment
        private void btn_deletePayment_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from tbl_onlinePayment WHERE Id = '" + txt_paymentId.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }

            btn_viewPayment_Click(sender, e);
            MessageBox.Show("Payment record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        //view payment records
        private void btn_viewPayment_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_onlinePayment";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_payment.DataSource = dt;
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
            txt_paymentName.Text = "";
            txt_paymentPrice.Text = "";
            txt_searchPayment.Text = "";
            txt_paymentName.Focus();
        }

        //clear button
        private void btn_clearPayment_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            auto_increment_id(sender, e);
            btn_viewPayment_Click(sender, e);
            calculate_grossTotal();
        }

        //select record to sow in textboxes
        private void dataGridView_payment_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_payment.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_paymentId.Text = row.Cells[0].Value.ToString();
                    txt_paymentName.Text = row.Cells[1].Value.ToString();
                    txt_paymentPrice.Text = row.Cells[2].Value.ToString();
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
            for (int i = 0; i < dataGridView_payment.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView_payment.Rows[i].Cells[2].Value);
            }
            label_grossTotal.Text = sum.ToString();
            if (sum == 0)
            {
                label_grossTotal.Text = "0.00";
            }
        }

        //filter records
        private void btn_filterPayment_Click(object sender, EventArgs e)
        {
            if (radio_30DaysPayment.Checked == true)
            {
                try
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_onlinePayment where date >= DATEADD(day,-30,GETDATE()) AND date <= getdate()";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_payment.DataSource = dt;
                    calculate_grossTotal();

                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                    sqlcon.Close();
                }
            }
            else if (radio_selectDatePayment.Checked == true)
            {
                try
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_onlinePayment where date between '" + dateTimePicker1.Value.Date.AddHours(6) + "' AND '" + dateTimePicker1.Value.Date.AddHours(30) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_payment.DataSource = dt;
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

        //search online payment records
        private void txt_searchPayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(dt);
                DV.RowFilter = string.Format("name LIKE '%{0}%'", txt_searchPayment.Text);
                dataGridView_payment.DataSource = DV;
                calculate_grossTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
        }
    }
}
