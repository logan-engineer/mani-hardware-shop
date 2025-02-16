using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mani_hardware_shop
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            fetchcategory();

            lbl_User.Text = login.billedby;
        }
        void fetchcategory()
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();

                SqlCommand cmd = new SqlCommand("fetchcategory", con);


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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();


                SqlCommand cmd = new SqlCommand("addcategory", con);
                SqlParameter param1 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_Category.Text;
                cmd.CommandType = CommandType.StoredProcedure;

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("insert Data successfully");
                }
                fetchcategory();

                con.Close();

                txt_Category.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }




        private void lbl_User_Click(object sender, EventArgs e)
        {
            lbl_User.Text = login.billedby;
        }






        private void btn_Item_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btn_Billing_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Billing billing = new Billing();
            billing.Show();
        }

        private void btn_Customer_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            customer Customer = new customer();
            Customer.Show();
        }

        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();


                SqlCommand cmd = new SqlCommand("updatecategory", con);
                SqlParameter param1 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_Category.Text;
                SqlParameter param2 = new SqlParameter("@Id", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = Convert.ToInt32(lbl_Id.Text);
                cmd.CommandType = CommandType.StoredProcedure;

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("update Data successfully");
                }
                fetchcategory();

                con.Close();

                txt_Category.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();


                SqlCommand cmd = new SqlCommand("deletecategory", con);

                SqlParameter param2 = new SqlParameter("@Id", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = Convert.ToInt32(lbl_Id.Text);
                cmd.CommandType = CommandType.StoredProcedure;

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("delete Data successfully");
                }
                fetchcategory();

                con.Close();

                txt_Category.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];
                lbl_Id.Text = Row.Cells[0].Value.ToString();
                txt_Category.Text = Row.Cells[1].Value.ToString();
               
            }
        }
    }
}
