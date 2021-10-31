using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RDP
{
    public partial class trial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string strcon = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private object roll;

        protected void Button3_Click(object sender, EventArgs e)
        {
            Autogenrate();
        }

        public void Autogenrate()
        {
            int r;
            try
            {
                SqlConnection connstrng = new SqlConnection(strcon);
                connstrng.Open();
                SqlCommand cmd = new SqlCommand("Select max(roll) from rrn_gen", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {



                    var d = dr[0].ToString();
                    if (d == "")
                    {

                        TextBox1.Text = "7000";//set the value in textbox which name is id

                    }
                    else
                    {

                        r = Convert.ToInt32(dr[0].ToString());
                        r = r + 1;
                        TextBox1.Text = r.ToString();
                    }
                }
                connstrng.Close();
                connstrng.Open();
                SqlCommand com = new SqlCommand("INSERT INTO rrn_gen(roll)values(@roll)", connstrng);
                com.Parameters.AddWithValue("@roll", TextBox1.Text.Trim());

                //cmd.CommandText = "insert rrn_gen values('" + roll.Text + "')";
                com.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                connstrng.Close();

            }

            catch (Exception ex)
            {
                Response.Write("<script>alert(" + ex.Message + ")</script>");
            }

        }
    }
    }
