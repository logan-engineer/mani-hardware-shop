using Azure;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mani_hardware_shop
{
    public partial class forgot_password : Form
    {
        private static string otp;
        string randomcode;
        public forgot_password()
        {
            InitializeComponent();
        }

        private void forgot_password_Load(object sender, EventArgs e)
        {
            txt_Username.Visible = false;
            txt_Password.Visible = false;
            btn_Update.Visible = false;
            lbl_password.Visible = false;
            lbl_Username.Visible = false;
            txt_Otp.Visible = false;
            btn_Verify.Visible = false;
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_OTP_Click(object sender, EventArgs e)
        {

            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = fetchDBDetails;

                con.Open();


                SqlCommand cmd1 = new SqlCommand("updatepassword", con);
                cmd1.Parameters.AddWithValue("@Email", txt_Email.Text);



                cmd1.CommandType = CommandType.StoredProcedure;
                int i = cmd1.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                txt_Username.Text = ds.Tables[0].Rows[0][1].ToString();
                if (txt_Username.Text != null)
                {

                    string from, to, pass, messagebox;
                    Random rand = new Random();
                    randomcode = (rand.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (txt_Email.Text).ToString();
                    from = "loganat081@gmail.com";
                    pass = "pejj ivkz qtkw hvza";
                    messagebox = "your verification OTP: " + randomcode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Subject = "your verfication OTP";
                    message.Body = messagebox;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("OTP sent successfully");

                        txt_Email.Visible = false;
                        label1.Visible = false;
                        btn_Send.Visible = false;
                        txt_Otp.Visible = true;
                        btn_Verify.Visible = true;
                        otp = randomcode;

                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("OTP not sent successfully");
                    }

                }

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("somthing went wrong");
            }
        }
        private void btn_Verify_Click(object sender, EventArgs e)
        {
            if (randomcode == otp)
            {
                txt_Otp.Visible = false;
                btn_Send.Visible = false;
                txt_Username.Visible = true;
                txt_Password.Visible = true;
                btn_Update.Visible = true;
                lbl_password.Visible = true;
                lbl_Username.Visible = true;
                btn_Verify.Visible = false;
            }
            else
            {
                MessageBox.Show("incorrect otp");
            }


        }
        

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            string fetchDBDetails = ConfigurationManager.ConnectionStrings["loguconnection"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = fetchDBDetails;

            con.Open();


            SqlCommand cmd1 = new SqlCommand("update userdetails set password='" + txt_Password.Text + "' where name='" + txt_Username.Text + "' ", con);
            int i = cmd1.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("update password successfully");
            }
            else
                MessageBox.Show("update password not successfully");
            this.Hide();
            login login = new login();
            login.Show();
        }
    }
}
