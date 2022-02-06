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
    public partial class Form_Users : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;

        public Form_Users()
        {
            InitializeComponent();
        }

        //Auto Increment
        void auto_increment_id(object sender, EventArgs e)
        {
            int a;
            sqlcon.Open();
            string query = "Select Max(id) from tbl_users";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txt_userId.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txt_userId.Text = a.ToString();
                }
            }
            sqlcon.Close();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_userName.Text == String.Empty)
            {
                MessageBox.Show("Users name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userName.Focus();
                return false;
            }
            else if (txt_userUsername.Text == String.Empty)
            {
                MessageBox.Show("Username is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userUsername.Focus();
                return false;
            }
            else if (txt_userPassword.Text == String.Empty)
            {
                MessageBox.Show("User password is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userPassword.Focus();
                return false;
            }

            return true;
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tbl_users Values (@id, @name, @username, @password, @select)", sqlcon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", txt_userId.Text);
                    cmd.Parameters.AddWithValue("@name", txt_userName.Text);
                    cmd.Parameters.AddWithValue("@username", txt_userUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txt_userPassword.Text);
                    cmd.Parameters.AddWithValue("@select", false);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    btn_viewUser_Click(sender, e);
                    MessageBox.Show("New users added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    auto_increment_id(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_users SET name = @name, username = @username, password = @Password WHERE Id = @id", sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txt_userId.Text);
                cmd.Parameters.AddWithValue("@name", txt_userName.Text);
                cmd.Parameters.AddWithValue("@username", txt_userUsername.Text);
                cmd.Parameters.AddWithValue("@Password ", txt_userPassword.Text);



                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                btn_viewUser_Click(sender, e);
                MessageBox.Show("Users information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                auto_increment_id(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlcon.Close();
            }
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView_users.Rows.Count - 1; i++)
            {
                drow = dataGridView_users.Rows[i];
                if (Convert.ToBoolean(drow.Cells[4].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sqlcon.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_users where Id='" + s + "'", sqlcon);
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

            btn_viewUser_Click(sender, e);
            MessageBox.Show("Record(s) deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            auto_increment_id(sender, e);
        }

        private void btn_viewUser_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "select * from tbl_users";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_users.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
        }

        //Clear textboxes
        private void ClearTextBoxes()
        {
            txt_userName.Clear();
            txt_userUsername.Clear();
            txt_userPassword.Clear();
            txt_userName.Focus();
        }

        void Uncheck_checkboxes()
        {
            foreach (DataGridViewRow drv in dataGridView_users.Rows)
            {
                bool chkBoxSelect = Convert.ToBoolean(drv.Cells[4].Value);
                if (chkBoxSelect)
                {
                    drv.Cells[4].Value = false;
                }
            }
        }

        private void btn_clearUsers_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Uncheck_checkboxes();
            auto_increment_id(sender, e);
        }

        private void dataGridView_users_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView_users.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txt_userId.Text = row.Cells[0].Value.ToString();
                    txt_userName.Text = row.Cells[1].Value.ToString();
                    txt_userUsername.Text = row.Cells[2].Value.ToString();
                    txt_userPassword.Text = row.Cells[3].Value.ToString();

                }
            }
            catch
            {
            }
        }

        private void Form_Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_users' table. You can move, or remove it, as needed.
            this.tbl_usersTableAdapter.Fill(this.databasePCDataSet.tbl_users);

            dataGridView_users.Columns[0].ReadOnly = true;
            dataGridView_users.Columns[1].ReadOnly = true;
            dataGridView_users.Columns[2].ReadOnly = true;
            dataGridView_users.Columns[3].ReadOnly = true;
            dataGridView_users.Columns[4].ReadOnly = false;

            auto_increment_id(sender, e);
        }
    }
}
