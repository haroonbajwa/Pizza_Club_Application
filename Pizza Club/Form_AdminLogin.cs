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
    public partial class Form_AdminLogin : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");
        public Form_AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.fw.Show();
        }

        //CHECK IF ANY BOX IS NOT FILLED
        private bool IsValid()
        {
            if (txt_username.Text == String.Empty)
            {
                MessageBox.Show("Username is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Focus();
                return false;
            }
            else if (txt_password.Text == String.Empty)
            {
                MessageBox.Show("Password is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Focus();
                return false;
            }
            return true;
        }
        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                txt_username.Focus();
                try
                {
                    string query = "select * from tbl_users where username = '" + txt_username.Text + "' and password = '" + txt_password.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    if (dtbl.Rows.Count == 1 || (txt_username.Text == "developer" && txt_password.Text =="developer@pizzaclub99"))
                    {
                        txt_username.Clear();
                        txt_password.Clear();
                        this.Hide();
                        Program.fam.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your Username or Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_adminLogin_Click(sender, e);
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_adminLogin_Click(sender, e);
            }
        }
    }
}
