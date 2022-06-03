using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Club
{
    public partial class Form_Details : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        DataTable dt;
        public Form_Details()
        {
            InitializeComponent();
        }

        //on form load
        private void Form_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_onlinePayment' table. You can move, or remove it, as needed.
            this.tbl_onlinePaymentTableAdapter.Fill(this.databasePCDataSet.tbl_onlinePayment);
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_expense' table. You can move, or remove it, as needed.
            this.tbl_expenseTableAdapter.Fill(this.databasePCDataSet.tbl_expense);
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_purchase' table. You can move, or remove it, as needed.
            this.tbl_purchaseTableAdapter.Fill(this.databasePCDataSet.tbl_purchase);
            // TODO: This line of code loads data into the 'databasePCDataSet.tbl_sales' table. You can move, or remove it, as needed.
            this.tbl_salesTableAdapter.Fill(this.databasePCDataSet.tbl_sales);

        }

        //close button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.fw.Show();
        }

        //get today's all data
        public void GetTodayData()
        {
            GetTodaySales();
            GetTodayPurchase();
            GetTodayExpense();
            GetTodayPayments();
            Count_TodayOrders();
        }

        //calculate gross total Sales
        void Calculate_SalesGrossTotal()
        {
            //calculate gross total from datagridview
            decimal sum = 0;
            int preId = 0;
            for (int i = 0; i < dataGridView_todaySales.Rows.Count; ++i)
            {
                if (Convert.ToInt32(dataGridView_todaySales.Rows[i].Cells[0].Value) != preId)
                {
                    //add sale grosstotal value to gross total label
                    sum += Convert.ToInt32(dataGridView_todaySales.Rows[i].Cells[7].Value);
                }
                preId = Convert.ToInt32(dataGridView_todaySales.Rows[i].Cells[0].Value);

            }
            label_todaySales.Text = sum.ToString();
            if (sum == 0)
            {
                label_todaySales.Text = "0.00";
            }
        }

        //calculate gross total Purchase
        void Calculate_PurchaseGrossTotal()
        {
            //calculate gross total from datagridview
            decimal sum = 0;
            int preId = 0;
            for (int i = 0; i < dataGridView_todayPurchase.Rows.Count; ++i)
            {
                if (Convert.ToInt32(dataGridView_todayPurchase.Rows[i].Cells[0].Value) != preId)
                {
                    //add purchase total value to gross total label
                    sum += Convert.ToInt32(dataGridView_todayPurchase.Rows[i].Cells[2].Value);
                }
                preId = Convert.ToInt32(dataGridView_todayPurchase.Rows[i].Cells[0].Value);

            }
            label_todayPurchase.Text = sum.ToString();
            if (sum == 0)
            {
                label_todayPurchase.Text = "0.00";
            }
        }

        //calculate gross total expense
        void Calculate_ExpenseGrossTotal()
        {
            //calculate gross total from datagridview
            decimal sum = 0;
            int preId = 0;
            for (int i = 0; i < dataGridView_todayExpense.Rows.Count; ++i)
            {
                if (Convert.ToInt32(dataGridView_todayExpense.Rows[i].Cells[0].Value) != preId)
                {
                    //add expense total value to gross total label
                    sum += Convert.ToInt32(dataGridView_todayExpense.Rows[i].Cells[2].Value);
                }
                preId = Convert.ToInt32(dataGridView_todayExpense.Rows[i].Cells[0].Value);

            }
            label_todayExpense.Text = sum.ToString();
            if (sum == 0)
            {
                label_todayExpense.Text = "0.00";
            }
        }

        //calculate gross total online payments
        void Calculate_PaymentsGrossTotal()
        {
            //calculate gross total from datagridview
            decimal sum = 0;
            int preId = 0;
            for (int i = 0; i < dataGridView_todayPayments.Rows.Count; ++i)
            {
                if (Convert.ToInt32(dataGridView_todayPayments.Rows[i].Cells[0].Value) != preId)
                {
                    //add online payments total value to gross total label
                    sum += Convert.ToInt32(dataGridView_todayPayments.Rows[i].Cells[2].Value);
                }
                preId = Convert.ToInt32(dataGridView_todayPayments.Rows[i].Cells[0].Value);

            }
            label_todayPayments.Text = sum.ToString();
            if (sum == 0)
            {
                label_todayPayments.Text = "0.00";
            }
        }

        void Count_TodayOrders()
        {
            int count = 0;
            int preId = 0;
            for (int i = 0; i < dataGridView_todaySales.Rows.Count-1; ++i)
            {
                if (Convert.ToInt32(dataGridView_todaySales.Rows[i].Cells[0].Value) != preId)
                {
                    //add online payments total value to gross total label
                    count++;
                }
                preId = Convert.ToInt32(dataGridView_todaySales.Rows[i].Cells[0].Value);

            }
            label_todayOrders.Text = count.ToString();
            if (count == 0)
            {
                label_todayOrders.Text = "0";
            }
        }

        private void GetTodaySales()
        {
            try
            {
                if (DateTime.Now < DateTime.Today.AddHours(6))
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_sales where date between '" + DateTime.Today.AddHours(-18) + "' AND '" + DateTime.Today.AddHours(6) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_todaySales.DataSource = dt;
                    Calculate_SalesGrossTotal();

                    sqlcon.Close();
                }
                else if (DateTime.Now >= DateTime.Today.AddHours(6))
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_sales where date between '" + DateTime.Today.AddHours(6) + "' AND '" + DateTime.Today.AddHours(30) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_todaySales.DataSource = dt;
                    Calculate_SalesGrossTotal();

                    sqlcon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
        }

        private void GetTodayPurchase()
        {
            try
            {
                if (DateTime.Now < DateTime.Today.AddHours(6))
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_purchase where date between '" + DateTime.Today.AddHours(-18) + "' AND '" + DateTime.Today.AddHours(6) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_todayPurchase.DataSource = dt;
                    Calculate_PurchaseGrossTotal();

                    sqlcon.Close();
                }
                else if (DateTime.Now >= DateTime.Today.AddHours(6))
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_purchase where date between '" + DateTime.Today.AddHours(6) + "' AND '" + DateTime.Today.AddHours(30) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_todayPurchase.DataSource = dt;
                    Calculate_PurchaseGrossTotal();

                    sqlcon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
        }

        private void GetTodayExpense()
        {
            try
            {
                if (DateTime.Now < DateTime.Today.AddHours(6))
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_expense where date between '" + DateTime.Today.AddHours(-18) + "' AND '" + DateTime.Today.AddHours(6) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_todayExpense.DataSource = dt;
                    Calculate_ExpenseGrossTotal();

                    sqlcon.Close();
                }
                else if (DateTime.Now >= DateTime.Today.AddHours(6))
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_expense where date between '" + DateTime.Today.AddHours(6) + "' AND '" + DateTime.Today.AddHours(30) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_todayExpense.DataSource = dt;
                    Calculate_ExpenseGrossTotal();

                    sqlcon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
        }

        private void GetTodayPayments()
        {
            try
            {
                if (DateTime.Now < DateTime.Today.AddHours(6))
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_onlinePayment where date between '" + DateTime.Today.AddHours(-18) + "' AND '" + DateTime.Today.AddHours(6) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_todayPayments.DataSource = dt;
                    Calculate_PaymentsGrossTotal();

                    sqlcon.Close();
                }
                else if (DateTime.Now >= DateTime.Today.AddHours(6))
                {
                    sqlcon.Close();
                    sqlcon.Open();
                    string query = "select * from tbl_onlinePayment where date between '" + DateTime.Today.AddHours(6) + "' AND '" + DateTime.Today.AddHours(30) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_todayPayments.DataSource = dt;
                    Calculate_PaymentsGrossTotal();

                    sqlcon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                sqlcon.Close();
            }
        }

        //daily report document
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.club1;
            Image img = bmp;
            e.Graphics.DrawImage(img, 5, 5, 80, 72);

            e.Graphics.DrawString("PIZZA CLUB", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(104, 20));
            e.Graphics.DrawString("Model Town Phase: 2", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(111, 50));
            e.Graphics.DrawString("Near Islam Medical College", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(101, 60));
            e.Graphics.DrawString("Pasrur Road Sialkot", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(113, 70));
            e.Graphics.DrawString("Daily Report", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(117, 90));

            if(DateTime.Now < DateTime.Today.AddHours(6))
            {
                e.Graphics.DrawString(DateTime.Today.AddDays(-1).ToShortDateString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(130, 110));
            }
            else if(DateTime.Now >= DateTime.Today.AddHours(6))
            {
                e.Graphics.DrawString(DateTime.Today.ToShortDateString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(130, 110));
            }
            int gap = 130;
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(0, gap));
            gap = gap + 15;
            e.Graphics.DrawString("Orders:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(70, gap));
            e.Graphics.DrawString(label_todayOrders.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(190, gap));
            gap = gap + 15;
            e.Graphics.DrawString("Sale:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(70, gap));
            e.Graphics.DrawString(label_todaySales.Text + ".00 Rs/-", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(190, gap));
            gap = gap + 15;
            e.Graphics.DrawString("Purchase:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(70, gap));
            e.Graphics.DrawString(label_todayPurchase.Text + ".00 Rs/-", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(190, gap));
            gap = gap + 15;
            e.Graphics.DrawString("Expense:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(70, gap));
            e.Graphics.DrawString(label_todayExpense.Text + ".00 Rs/-", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(190, gap));
            gap = gap + 15;
            e.Graphics.DrawString("Online Payment:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(70, gap));
            e.Graphics.DrawString(label_todayPayments.Text + ".00 Rs/-", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(190, gap));
            gap = gap + 15;
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(0, gap));
            gap = gap + 15;
        }

        //generate daily report
        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 500);
            printDocument1.Print();
        }

        //export sales xls file
        private void btn_exportSale_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Sales";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView_todaySales.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView_todaySales.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView_todaySales.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView_todaySales.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView_todaySales.Rows[i].Cells[j].Value.ToString();
                    }
                }

                CultureInfo ci = new CultureInfo("en-US");
                // save the application  
                workbook.SaveAs("c:\\DailySales\\"+DateTime.Now.Day + DateTime.Now.ToString("MMMM", ci) + DateTime.Now.Year +", "+DateTime.Now.Hour+"-"+DateTime.Now.Minute + "-" + DateTime.Now.Second, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //export purchase xls file
        private void btn_exportPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Purchase";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView_todayPurchase.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView_todayPurchase.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView_todayPurchase.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView_todayPurchase.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView_todayPurchase.Rows[i].Cells[j].Value.ToString();
                    }
                }

                CultureInfo ci = new CultureInfo("en-US");
                // save the application  
                workbook.SaveAs("c:\\DailyPurchase\\"+DateTime.Now.Day + DateTime.Now.ToString("MMMM", ci) + DateTime.Now.Year + ", " + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //export expense xls file
        private void btn_exportExpense_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Expense";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView_todayExpense.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView_todayExpense.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView_todayExpense.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView_todayExpense.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView_todayExpense.Rows[i].Cells[j].Value.ToString();
                    }
                }

                CultureInfo ci = new CultureInfo("en-US");
                // save the application  
                workbook.SaveAs("c:\\DailyExpense\\" + DateTime.Now.Day + DateTime.Now.ToString("MMMM", ci) + DateTime.Now.Year + ", " + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //export online payments xls file
        private void btn_exportPayment_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Payments";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView_todayPayments.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView_todayPayments.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView_todayPayments.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView_todayPayments.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView_todayPayments.Rows[i].Cells[j].Value.ToString();
                    }
                }

                CultureInfo ci = new CultureInfo("en-US");
                // save the application  
                workbook.SaveAs("c:\\DailyPayments\\" + DateTime.Now.Day + DateTime.Now.ToString("MMMM", ci) + DateTime.Now.Year + ", " + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
