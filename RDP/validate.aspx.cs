using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RDP
{
    public partial class validate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String mycon = "Data Source=SR99\\SQLEXPRESS;Initial Catalog=RDP_DB; Integrated Security=True";
            String myquery = "Select * from application where user_id=" + Request.QueryString["user_id"];
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
                TextBox2.Text = ds.Tables[0].Rows[0]["dob"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["contact_no"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["email"].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0]["state"].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0]["city"].ToString();
                TextBox7.Text = ds.Tables[0].Rows[0]["pincode"].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0]["full_address"].ToString();

            }
            con.Close();
        }

        string connection = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        protected void Button30_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connection))
            {

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update application set status = 1 where user_id=" + Request.QueryString["user_id"], conn);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                Response.Write("<script>alert('Validated Successfully');window.location='newlist.aspx';</script>");   
                conn.Close();
            }
        }

    }
}