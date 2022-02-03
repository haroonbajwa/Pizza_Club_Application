using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Club
{
    public partial class Form_AdminMain : Form
    {
        private Form activeForm;
        public Form_AdminMain()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.fw.Show();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_admin_main.Controls.Add(childForm);
            this.panel_admin_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_pizzas_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fp, sender);
        }

        private void btn_purchasePcs_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fpp, sender);
        }

        private void btn_burgers_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fb, sender);
        }

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fd, sender);
        }

        private void btn_allIngredients_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fai, sender);
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fs, sender);

        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fc, sender);
        }

        private void btn_adminUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fu, sender);
        }

        private void btn_sideOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fso, sender);
        }

        private void btn_purchaseGrms_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fpg, sender);
        }

        private void btn_expenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fe, sender);
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.fvsales, sender);
        }
    }
}
