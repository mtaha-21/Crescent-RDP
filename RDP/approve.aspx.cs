using System;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;
using System.Net.Mail;



namespace RDP
{
    public partial class Approve : System.Web.UI.Page
    {
        string mail_id = "";
        string name = "";
        string role_no = "";
        protected void Page_Load(object sender, EventArgs e)
        {



            String mycon = "Data Source=SR99\\SQLEXPRESS;Initial Catalog=RDP_DB; Integrated Security=True";
            String myquery = "Select * from personal_details where user_id=" + Request.QueryString["user_id"];

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
                TextBox1.Text = ds.Tables[0].Rows[0]["full_name"].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0]["date_of_birth"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["age"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["gender"].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0]["nationality"].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0]["if_foreign_country"].ToString();
                TextBox7.Text = ds.Tables[0].Rows[0]["passport"].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0]["social_status"].ToString();
                TextBox9.Text = ds.Tables[0].Rows[0]["marital_status"].ToString();
                TextBox10.Text = ds.Tables[0].Rows[0]["telephone"].ToString();
                TextBox11.Text = ds.Tables[0].Rows[0]["mobile_number"].ToString();
                TextBox12.Text = ds.Tables[0].Rows[0]["email_id"].ToString();
                TextBox13.Text = ds.Tables[0].Rows[0]["residential_address"].ToString();
                TextBox14.Text = ds.Tables[0].Rows[0]["office_address"].ToString();
                TextBox15.Text = ds.Tables[0].Rows[0]["address_for_communication"].ToString();
                mail_id = ds.Tables[0].Rows[0]["email_id"].ToString();
                name = ds.Tables[0].Rows[0]["full_name"].ToString();
                role_no = ds.Tables[0].Rows[0]["user_id"].ToString();

            }
            con.Close();


        }

        string connection = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        protected void Button30_Click(object sender, EventArgs e)
        {

            string to = mail_id;    
            string from = "as2551096@gmail.com";    
            MailMessage message = new MailMessage(from, to);

            string mailbody = $"Hello {name}, you have been approved by the dean.";
            message.Subject = "";
            message.Body = mailbody;
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(Server.MapPath("~/Files/") + role_no + ".PDF");
            message.Attachments.Add(attachment);
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);  
            System.Net.NetworkCredential basicCredential1 = new 
            System.Net.NetworkCredential("uisbibin@gmail.com", "Godissogood1");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
                Response.Write($"<script>alert('Approved Successfully !" +
                    $" Mail sent to scholar {name} {mail_id}');</script>");
            }

            catch (Exception ex)
            {
                throw ex;
            }


            using (var conn = new SqlConnection(connection))
            {

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update personal_details set status2 = 0 where user_id=" + Request.QueryString["user_id"], conn);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                Response.Write("<script>alert('Validated Successfully');window.location='deanpage.aspx';</script>");
                conn.Close();
            }
        }
    }
}