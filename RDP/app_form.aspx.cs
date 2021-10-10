using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace RDP
{
    public partial class app_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string strcon = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection connstrng = new SqlConnection(strcon);
                if (connstrng.State == System.Data.ConnectionState.Closed)
                {
                    connstrng.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO personal_details(full_name,date_of_birth,age,gender,nationality,if_foreign_country,passport,social_status,marital_status,telephone,mobile_number,email_id,residential_address,office_address,address_for_communication) values(@full_name,@date_of_birth,@age,@gender,@nationality,@if_foreign_country,@passport,@social_status,@marital_status,@telephone,@mobile_number,@email_id,@residential_address,@office_address,@address_for_communication)", connstrng);
                cmd.Parameters.AddWithValue("@full_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@date_of_birth", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@age", TextBox14.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", DropDownList20.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@nationality", DropDownList19.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@if_foreign_country", Country.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@passport", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@social_status", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@marital_status", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@telephone", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@mobile_number", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@email_id", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@residential_address", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@office_address", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@address_for_communication", DropDownList21.SelectedItem.Value);
                cmd.ExecuteNonQuery();
                connstrng.Close();
                Response.Write("<script>alert('Application submitted successfully'); window.location='homepage.aspx';</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }
    }
}