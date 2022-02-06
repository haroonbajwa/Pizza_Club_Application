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
   
    public partial class Form_Expense : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public Form_Expense()
        {
            InitializeComponent();
        }
        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
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
                    txt_ExpenseId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_ExpenseId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_ExpenseName.Text == String.Empty)
            {
                MessageBox.Show("Expense Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ExpenseName.Focus();
                return false;
            }
            else if (txt_ExpensePrice.Text == String.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ExpensePrice.Focus();
                return false;
            }

            return true;
        }

        private void btn_addExpense_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_expense Values (@id, @name, @price,@date, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_ExpenseId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_ExpenseName.Text);
                    cmd.Parameters.AddWithValue("@price", txt_ExpensePrice.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    btn_viewExpense_Click(sender, e);
                    MessageBox.Show("New Expense added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        private void btn_updateExpense_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_expense SET name = @Name, price = @price, date = @Date WHERE Id = @id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txt_ExpenseId.Text);
                cmd.Parameters.AddWithValue("@Name", txt_ExpenseName.Text);
                cmd.Parameters.AddWithValue("@price", txt_ExpensePrice.Text);
                cmd.Parameters.AddWithValue("@Date",DateTime.Now );

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                btn_viewExpense_Click(sender, e);
                MessageBox.Show("Expense information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                auto_increment_id(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
        }

        private void btn_deleteExpense_Click(object sender, EventArgs e)
        {

            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_expense.Rows.Count - 1; i++)
            {
                drow = dataGridView_expense.Rows[i];
                if (Convert.ToBoolean(drow.Cells[4].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_expense where Id='" + s + "'", sqlcon);
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

            btn_viewExpense_Click(sender, e);
            MessageBox.Show("Record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        private void btn_viewExpense_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_expense";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_expense.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
            calculate_grossTotal();
        }

        private void Form_Expense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_expense' table. You can move, or remove it, as needed.
            this.tbl_expenseTableAdapter.Fill(this.databasePCDataSet.tbl_expense);

            dataGridView_expense.Columns[0].ReadOnly = true;
            dataGridView_expense.Columns[1].ReadOnly = true;
            dataGridView_expense.Columns[2].ReadOnly = true;
            dataGridView_expense.Columns[3].ReadOnly = true;
            dataGridView_expense.Columns[4].ReadOnly = false;

            auto_increment_id(sender, e);
            btn_viewExpense_Click(sender, e);
        }

        //Clear textboxes
        private void ClearTextBoxes()
        {
            txt_ExpenseName.Clear();
            txt_ExpensePrice.Clear();
            txt_ExpenseName.Focus();
        }

        //Uncheck checkboxes
        void Uncheck_checkboxes()
        {
            foreach (DataGridViewRow drv in dataGridView_expense.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[4].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[4].Value = false;
                }
            }
        }

        private void btn_clearExpnse_Click(object sender, EventArgs e)
        {

            ClearTextBoxes();
            Uncheck_checkboxes();
            auto_increment_id(sender, e);
            btn_viewExpense_Click(sender, e);
        }

        private void dataGridView_expense_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_expense.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_ExpenseId.Text = row.Cells[0].Value.ToString();
                    txt_ExpenseName.Text = row.Cells[1].Value.ToString();
                    txt_ExpensePrice.Text = row.Cells[2].Value.ToString();
                }
            }
            catch
            {
                sqlcon.Close();
            }
        }

        public void calculate_grossTotal()
        {
            //calculate gross total from datagridview
            decimal sum = 0;
            for (int i = 0; i < dataGridView_expense.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView_expense.Rows[i].Cells[2].Value);
            }
            label_grossTotalExp.Text = sum.ToString();
            if (sum == 0)
            {
                label_grossTotalExp.Text = "0.00";
            }
        }

        //filter record by date
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Date = #{0}#", dateTimePicker1.Text);
            dataGridView_expense.DataSource = DV;
            calculate_grossTotal();
        }
    }
}
