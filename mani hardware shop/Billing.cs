using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mani_hardware_shop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void fetch()
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();

                SqlCommand cmd = new SqlCommand("fetchitem", con);


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];


                con.Close();
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }
        }
        private void Billing_Load(object sender, EventArgs e)
        {

            fetch();
            txt_Customerid.Text = customer.customerid;
            txt_Billedby.Text = login.billedby;

            lbl_User.Text = login.billedby;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];
                txt_Item.Text = Row.Cells[1].Value.ToString();
                txt_Price.Text = Row.Cells[3].Value.ToString();
                txt_Productid.Text = Row.Cells[0].Value.ToString();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        double sum = 0;
        private void btn_Addbill_Click(object sender, EventArgs e)
        {

            int id= Convert.ToInt32(txt_Productid.Text);
            string productname = txt_Item.Text;
            int cost = (int)Convert.ToDecimal(txt_Price.Text);
            int quantity = Convert.ToInt32(cmb_Quantity.SelectedItem.ToString());

            int totalcost = cost * quantity;
            dataGridView2.Rows.Add(id,productname, cost, quantity, totalcost);



           


            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value);
            }
            txt_FinalCost.Text = sum.ToString("C");



        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            txt_Item.Clear();
            txt_Price.Clear();
            txt_FinalCost.Clear();

        }
        public static string billid;
        void trackbillid()
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();
                SqlCommand cmd = new SqlCommand("billid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                billid = ds.Tables[0].Rows[0][0].ToString();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("somthing wrong");
            }
        }
        void addbill()
        {
            string paymentmode = string.Empty;

            if (rdo_Card.Checked)
            {
                paymentmode = "Card";
            }
            else if (rdo_Cash.Checked)
            {
                paymentmode = "Cash";
            }
            else if (rdo_UPI.Checked)
            {
                paymentmode = "UPI";
            }
            else
            {
                paymentmode = "other";
            }
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();
                SqlCommand cmd = new SqlCommand("addbilling", con);
                SqlParameter param1 = new SqlParameter("@Billid", SqlDbType.Int);
                cmd.Parameters.Add(param1).Value = Convert.ToInt32(billid);
                SqlParameter param2 = new SqlParameter("@Billedby", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_Billedby.Text;
                SqlParameter param3 = new SqlParameter("@Customerid", SqlDbType.Int);
                cmd.Parameters.Add(param3).Value = Convert.ToInt32(txt_Customerid.Text);
                SqlParameter param4 = new SqlParameter("@Paymentmode", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = paymentmode;
                cmd.CommandType = CommandType.StoredProcedure;
                int j = cmd.ExecuteNonQuery();

                if (j != 0)
                {
                    MessageBox.Show("insert bill data successfully");
                   
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("somthing wrong");
            }
        }
        public void print()
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 300, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sum = string.Empty;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToString(dataGridView2.Rows[i].Cells[0].Value) + ",";

            }
            string sumprice = string.Empty;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sumprice += Convert.ToString(dataGridView2.Rows[i].Cells[1].Value) + ",";

            }
            string sumquantity = string.Empty;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sumquantity += Convert.ToString(dataGridView2.Rows[i].Cells[2].Value) + ",";

            }

            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();


                SqlCommand cmd = new SqlCommand("addselling", con);
                SqlParameter param1 = new SqlParameter("@Item", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = sum;
                SqlParameter param2 = new SqlParameter("@Price", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = sumprice;
                SqlParameter param3 = new SqlParameter("@Quantity", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = sumquantity;
                SqlParameter param4 = new SqlParameter("@Totalprice", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = txt_FinalCost.ToString();


                cmd.CommandType = CommandType.StoredProcedure;
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("insert selling data successfully");
                }


                trackbillid();
                addbill();
                fetch();
                print();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("somthing wrong");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_Item_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }



        private void lbl_User_Click(object sender, EventArgs e)
        {
            lbl_User.Text = login.billedby;
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category category = new Category();
            category.Show();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer Customer = new customer();
            Customer.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }
        int pid;
        string pname;
        Decimal pprice;
        int pqty;
        decimal ptotal;
        int pos = 75;
        DateTime dateTime = DateTime.Now;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Mani Hardware Shop", new Font("century Gothic", 12, FontStyle.Bold), Brushes.Green, new Point(70));
            e.Graphics.DrawString("Bill id: " + billid, new Font("century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(10, 20));
            e.Graphics.DrawString("Customer id: " +txt_Customerid.Text, new Font("century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(190, 20));
            e.Graphics.DrawString("Bill By: " + login.billedby, new Font("century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(10, 40));
            e.Graphics.DrawString("Bill Date: " +dateTime , new Font("century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(190, 40));
            e.Graphics.DrawString("-----------------------------------------------------------", new Font("century Gothic", 8, FontStyle.Bold), Brushes.Crimson, new Point(10,50));

            e.Graphics.DrawString("ID PRODUCTNAME PRICE Qty TOTAL", new Font("century Gothic", 10, FontStyle.Bold), Brushes.Green, new Point(26,60));
            foreach(DataGridViewRow row in dataGridView2.Rows)
            {
                pid=Convert.ToInt32(row.Cells[0].Value);
                pname = "" + Convert.ToString(row.Cells[1].Value);
                pprice = Convert.ToDecimal(row.Cells[2].Value);
                pqty=Convert.ToInt32(row.Cells[3].Value);
                ptotal=Convert.ToDecimal(row.Cells[4].Value);
                e.Graphics.DrawString(""+pid, new Font("century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26,pos));
                e.Graphics.DrawString("" + pname, new Font("century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(45, pos));
                e.Graphics.DrawString("" + pprice, new Font("century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(160, pos));
                e.Graphics.DrawString("" + pqty, new Font("century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(210, pos));
                e.Graphics.DrawString("" + ptotal, new Font("century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(245, pos));
                pos = pos + 20;
               
                
            }
            e.Graphics.DrawString("Grand Total: Rs" + sum, new Font("century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("************** Mani Hardware Shop ***************", new Font("century Gothic", 8, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            dataGridView2.Rows.Clear();
            txt_Item.Clear();
            txt_Price.Clear();
            txt_Productid.Clear();
            txt_FinalCost.Clear();
            dataGridView2.Refresh();
            pos = 100;
            sum = 0;
        }
        private void updateproduct()
        {
            int pqty = 0;
        }
    }
}
