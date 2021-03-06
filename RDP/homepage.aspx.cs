using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using Xceed.Wpf.Toolkit;


namespace RDP
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load (object sender, EventArgs e)
        {

        }

        public static string mycon = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        protected void Button20 (object sender, EventArgs e)
        {
            if (txtun.Text == "" || txtpw.Text == "")
            {
                Response.Write("<script>alert('Enter User Name and Password');</script>");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(mycon);
                SqlDataAdapter sda = new SqlDataAdapter("Select Usertype from user_table where Username like'"+txtun.Text+"'COLLATE SQL_Latin1_General_CP1_CS_AS and Password like'"+txtpw.Text+"'COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count==1)
                {
                    string ut = dt.Rows[0][0].ToString();
                    Session["role"] = ut;
                    if (ut == "ADMIN")
                    {
                        Response.Redirect("adminpage.aspx");
                    }
                    else if (ut == "DEAN")
                    {
                        Response.Redirect("deanpage.aspx");
                    }
                    else if (ut == "GUEST")
                    {
                        Response.Redirect("app_form.aspx");
                    }

                }
                else
                {
                    Response.Write("<script>alert('Check User name and password');</script>");
                }
            }
            catch (Exception)
            {

                }
        }

    }
}