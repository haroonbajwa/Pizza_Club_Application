using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Club
{
    static class Program
    {

        public static Form_AdminLogin fal;
        public static Form_Welcome fw;
        public static Form_AdminMain fam;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fal = new Form_AdminLogin();
            fw = new Form_Welcome();
            fam = new Form_AdminMain();
            Application.Run(new Form_Welcome());
        }
    }
}
