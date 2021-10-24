using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

namespace RDP
{
    public partial class deanpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role_no = GridView2.SelectedRow.Cells[0].Text;

            String mycon = "Data Source=AYESHA;Initial Catalog=RDP_DB; Integrated Security=True";
            String myquery = "Select full_name,email_id from personal_details where role_no=" + role_no;
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            string mail_id = "";
            string name = "";

            if (ds.Tables[0].Rows.Count > 0)
            {
                mail_id = ds.Tables[0].Rows[0]["email_id"].ToString();
                name = ds.Tables[0].Rows[0]["full_name"].ToString();
            }
            con.Close();


            string to = "aishasaiyed123@gmail.com"; //To address    
            string from = "rdpcrescent@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = $"Hello {name}, you have been approved by the dean.";
            message.Subject = "";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new System.Net.NetworkCredential("rdpcrescent@gmail.com", "Testing@1234");
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
            Response.Write($"<script>alert('Approved Successfully ! Mail sent to scholar {role_no} {mail_id}');window.location='newlist.aspx';</script>");
        }


        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}