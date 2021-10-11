using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Text;

namespace RDP
{
    public partial class rrn_gen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String mycon = "Data Source=LAPTOP-U8B28I61\\SQLEXPRESS;Initial Catalog=RDP_DB; Integrated Security=True";
            String myquery = "Select * from personal_details where role_no=" + Request.QueryString["role_no"];
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                TextBox2.Text = ds.Tables[0].Rows[0]["full_name"].ToString();
            }
            con.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Random rnn = new Random();
            int randomnum = rnn.Next(100000, 1000000);
            TextBox1.Text = randomnum.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string to = "tahamb53@gmail.com"; //To address    
            string from = "rdpcrescent@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "YOUR JOB IS TO APPROVE THE SCHOLAR BELOW ";
            message.Subject = "HELLO DEAN";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("rdpcrescent@gmail.com", "Testing_123");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
                Response.Write("<script>alert('Mail sent Successfully');window.location='updatelist.aspx';</script>");
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}