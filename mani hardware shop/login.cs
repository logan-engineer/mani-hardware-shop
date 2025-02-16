using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace mani_hardware_shop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static string billedby;
        private void btn_Login_Click(object sender, EventArgs e)
        {

            string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = fetchDBDetails;

            con.Open();

            if (txt_Username.Text != string.Empty || txt_Password.Text != string.Empty)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("checkuser", con);
                    SqlParameter param1 = new SqlParameter("@Username", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = txt_Username.Text;
                    SqlParameter param2 = new SqlParameter("@Password", SqlDbType.VarChar);
                    cmd.Parameters.Add(param2).Value = txt_Password.Text;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    string p = ds.Tables[0].Rows[0][0].ToString();
                    billedby = p;
                    int i = cmd.ExecuteNonQuery();



                    if (p == txt_Username.Text)
                    {
                        MessageBox.Show("welcome " + p);

                        this.Hide();
                        Home product = new Home();
                        product.Show();


                    }
                    else
                    {
                        MessageBox.Show("enter valid username and password");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("enter valid username and password");
                    txt_Password.Clear();
                    txt_Username.Clear();
                }

            }








            else
            {
                MessageBox.Show("enter username and password");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot_password forgot_Password=new forgot_password();
            this.Hide();
            forgot_Password.Show();
        }
    }
}
