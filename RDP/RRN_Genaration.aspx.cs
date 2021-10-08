using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RDP
{
    public partial class RRN_Genaration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string strcon = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO RRN_gen (RRN,guide_name,research_topic,department_name) values(@RRN,@guide_name,@research_topic,@department_name)", con);
                cmd.Parameters.AddWithValue("@guide_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@research_topic", DropDownList2.Text.Trim());
                cmd.Parameters.AddWithValue("@department_name", DropDownList3.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('success');</script>");
            }
            catch (Exception)
            {
            }
        }
    }
}