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
    public partial class Form_Welcome : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");
        public Form_Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.fal.Show();
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.fsales.Show();
        }

        private void Form_Welcome_Load(object sender, EventArgs e)
        {
            SqlCommand check_computer = new SqlCommand("SELECT COUNT(*) FROM [tbl_computers] WHERE ([computer] = @computer)", sqlcon);
            check_computer.Parameters.AddWithValue("@computer", Environment.MachineName);
            sqlcon.Open();
            int UserExist = (int)check_computer.ExecuteScalar();
            sqlcon.Close();

            if (UserExist > 0)
            {
                //computer exist
            }
            else
            {
                //Username computer exist.
                DialogResult dresult = MessageBox.Show("You have no license to use this software. Please contact developer for more information.\n\nDeveloper Contact: 0304 2998055 ", "License Not Available"
                              , MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dresult == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
