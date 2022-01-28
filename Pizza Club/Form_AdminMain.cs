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
    }
}
