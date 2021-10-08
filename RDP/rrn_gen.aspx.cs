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
    public partial class rrn_gen : System.Web.UI.Page
    {
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
    }
}