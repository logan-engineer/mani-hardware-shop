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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("fetchcustomer", con);


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                customerid = ds.Tables[0].Rows[0][0].ToString();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }
        }
        public static string customerid;
        private void customer_Load(object sender, EventArgs e)
        {
            fetch();

            lbl_User.Text = login.billedby;
        }


        private void btn_Customer_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();
                MessageBox.Show("connected");

                SqlCommand cmd1 = new SqlCommand("addcustomer", con);
                SqlParameter param1 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd1.Parameters.Add(param1).Value = txt_Name.Text;
                SqlParameter param2 = new SqlParameter("@Gender", SqlDbType.VarChar);
                cmd1.Parameters.Add(param2).Value = cmb_Gender.SelectedItem;
                SqlParameter param3 = new SqlParameter("@Phone", SqlDbType.VarChar);
                cmd1.Parameters.Add(param3).Value = txt_Phone.Text;


                cmd1.CommandType = CommandType.StoredProcedure;
                int i = cmd1.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("insert Data successfully");
                }
                fetch();

                con.Close();
                txt_Name.Clear();
                cmb_Gender.Select();
                txt_Phone.Clear();
                Billing billing = new Billing();
                billing.Show();

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
                customerid = Row.Cells[0].Value.ToString();

                lbl_Id.Text = Row.Cells[0].Value.ToString();
                txt_Name.Text = Row.Cells[1].Value.ToString();

                txt_Phone.Text = Row.Cells[3].Value.ToString();


            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void lbl_User_Click(object sender, EventArgs e)
        {
            lbl_User.Text = login.billedby;
        }




        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void btn_Item_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btn_Category_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Category category = new Category();
            category.Show();
        }

        private void btn_Billing_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Billing billing = new Billing();
            billing.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();
               

                SqlCommand cmd1 = new SqlCommand("updatecustomer", con);
                SqlParameter param4 = new SqlParameter("@Id", SqlDbType.Int);
                cmd1.Parameters.Add(param4).Value = Convert.ToInt32(lbl_Id.Text);
                SqlParameter param1 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd1.Parameters.Add(param1).Value = txt_Name.Text;
                SqlParameter param2 = new SqlParameter("@Gender", SqlDbType.VarChar);
                cmd1.Parameters.Add(param2).Value = cmb_Gender.SelectedItem;
                SqlParameter param3 = new SqlParameter("@Phone", SqlDbType.VarChar);
                cmd1.Parameters.Add(param3).Value = txt_Phone.Text;


                cmd1.CommandType = CommandType.StoredProcedure;
                int i = cmd1.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("update Data successfully");
                }
                fetch();

                con.Close();
                txt_Name.Clear();
                cmb_Gender.Select();
                txt_Phone.Clear();
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
               
                SqlCommand cmd1 = new SqlCommand("deletecustomer", con);
                SqlParameter param1 = new SqlParameter("@Id", SqlDbType.Int);
                cmd1.Parameters.Add(param1).Value = Convert.ToInt32(lbl_Id.Text);
               


                cmd1.CommandType = CommandType.StoredProcedure;
                int i = cmd1.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("delete Data successfully");
                }
                fetch();

                con.Close();
                txt_Name.Clear();
                cmb_Gender.Select();
                txt_Phone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }

        }
    }
}
