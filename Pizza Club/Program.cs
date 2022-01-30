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
        public static Form_Pizzas fp;
        public static purchase_pieces fpp;
        public static Form_Burgers fb;
        public static Form_Drinks fd;
        public static Form_AllIngredients fai;
        public static Form_Stock fs;
        public static Form_Customers fc;
        public static Form_Users fu;

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
            fp = new Form_Pizzas();
            fpp = new purchase_pieces();
            fb = new Form_Burgers();
            fd = new Form_Drinks();
            fai = new Form_AllIngredients();
            fs = new Form_Stock();
            fc = new Form_Customers();
            fu = new Form_Users();
            Application.Run(new Form_Welcome());
            // Application.Run(new Form_Pizzas());
        }
    }
}
