using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Azure;

namespace mani_hardware_shop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];
                lbl_Id.Text = Row.Cells[0].Value.ToString();
                txt_Item.Text = Row.Cells[1].Value.ToString();
                txt_Price.Text = Row.Cells[3].Value.ToString();
                txt_Stock.Text = Row.Cells[4].Value.ToString();
                txt_Manufacturing.Text = Row.Cells[5].Value.ToString();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            fetch();

            lbl_User.Text = login.billedby;
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
                SqlCommand cmd1 = new SqlCommand("fetchcategory1", con);


                cmd1.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                if(cmb_Category.Items.Count == 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                        cmb_Category.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
                }
               

                con.Close();
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {

            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();


                SqlCommand cmd1 = new SqlCommand("additem", con);
                SqlParameter param1 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd1.Parameters.Add(param1).Value = txt_Item.Text;
                SqlParameter param2 = new SqlParameter("@Category", SqlDbType.VarChar);
                cmd1.Parameters.Add(param2).Value = cmb_Category.SelectedItem;
                SqlParameter param3 = new SqlParameter("@Price", SqlDbType.Decimal);
                cmd1.Parameters.Add(param3).Value = Convert.ToDecimal(txt_Price.Text);
                SqlParameter param4 = new SqlParameter("@Stock", SqlDbType.Int);
                cmd1.Parameters.Add(param4).Value = Convert.ToInt32(txt_Stock.Text);
                SqlParameter param5 = new SqlParameter("@Manufacturing", SqlDbType.VarChar);
                cmd1.Parameters.Add(param5).Value = txt_Manufacturing.Text;

                cmd1.CommandType = CommandType.StoredProcedure;
                int i = cmd1.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("insert Data successfully");
                }
                cmb_Category.Items.Remove(0);
                fetch();

                con.Close();
                txt_Item.Clear();
                
                txt_Price.Clear();
                txt_Stock.Clear();
                txt_Manufacturing.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }

        }



        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }







        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Billing_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing billing = new Billing();
            billing.Show();
        }



        private void lbl_User_Click(object sender, EventArgs e)
        {
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();


                SqlCommand cmd1 = new SqlCommand("updateitem", con);
                SqlParameter param6 = new SqlParameter("@Id", SqlDbType.Int);
                cmd1.Parameters.Add(param6).Value = Convert.ToInt32(lbl_Id.Text);
                SqlParameter param1 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd1.Parameters.Add(param1).Value = txt_Item.Text;
                SqlParameter param2 = new SqlParameter("@Category", SqlDbType.VarChar);
                cmd1.Parameters.Add(param2).Value = cmb_Category.SelectedItem;
                SqlParameter param3 = new SqlParameter("@Price", SqlDbType.Decimal);
                cmd1.Parameters.Add(param3).Value = Convert.ToDecimal(txt_Price.Text);
                SqlParameter param4 = new SqlParameter("@Stock", SqlDbType.Int);
                cmd1.Parameters.Add(param4).Value = Convert.ToInt32(txt_Stock.Text);
                SqlParameter param5 = new SqlParameter("@Manufacturing", SqlDbType.VarChar);
                cmd1.Parameters.Add(param5).Value = txt_Manufacturing.Text;

                cmd1.CommandType = CommandType.StoredProcedure;
                int i = cmd1.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Update Data successfully");
                }
                cmb_Category.Items.RemoveAt(0);
                fetch();

                con.Close();
                txt_Item.Clear();
               
                txt_Price.Clear();
                txt_Stock.Clear();
                txt_Manufacturing.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();


                SqlCommand cmd1 = new SqlCommand("deleteitem", con);
                SqlParameter param6 = new SqlParameter("@Id", SqlDbType.Int);
                cmd1.Parameters.Add(param6).Value = Convert.ToInt32(lbl_Id.Text);


                cmd1.CommandType = CommandType.StoredProcedure;
                int i = cmd1.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Update Data successfully");
                }
                cmb_Category.Items.RemoveAt(0);
                fetch();

                con.Close();
                txt_Item.Clear();
               
                txt_Price.Clear();
                txt_Stock.Clear();
                txt_Manufacturing.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected");
            }
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
