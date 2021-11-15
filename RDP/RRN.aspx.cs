using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;

namespace RDP
{
    public partial class RRN : System.Web.UI.Page
    {
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedItem.Value;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string strcon = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        private RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connstrng = new SqlConnection(strcon);
            connstrng.Open();
            if (DropDownList1.SelectedValue == "Aerospace Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select Aerospace_Engineering from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Automobile Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select Automobile_Engineering from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Chartered Accountant")
            {
                SqlCommand cmd = new SqlCommand("Select Chartered_Accountant from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Chemistry")
            {
                SqlCommand cmd = new SqlCommand("Select Chemistry from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Civil Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select Civil_Engineering from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Commerce")
            {
                SqlCommand cmd = new SqlCommand("Select Commerce from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Computer Science Egineering")
            {
                SqlCommand cmd = new SqlCommand("Select CSE from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select ECE from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select EEE from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select EIE from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "English")
            {
                SqlCommand cmd = new SqlCommand("Select English from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Islamic Studies")
            {
                SqlCommand cmd = new SqlCommand("Select Islamic_Studies from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Information Technology")
            {
                SqlCommand cmd = new SqlCommand("Select IT from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Maths & AS")
            {
                SqlCommand cmd = new SqlCommand("Select Maths_AS from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Mechanical Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select Mech from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Mgt Studies")
            {
                SqlCommand cmd = new SqlCommand("Select Mgt_Studies from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Physics")
            {
                SqlCommand cmd = new SqlCommand("Select Physics from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else if (DropDownList1.SelectedValue == "Polymer Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select Polymer from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select SLS from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            SqlConnection constrng = new SqlConnection(strcon);
            constrng.Open();
            if (DropDownList2.SelectedValue == "2021")
            {
                SqlCommand cmd = new SqlCommand("Select twenty_one from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2022")
            {
                SqlCommand cmd = new SqlCommand("Select twenty_two from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2023")
            {
                SqlCommand cmd = new SqlCommand("Select twenty_three from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2024")
            {
                SqlCommand cmd = new SqlCommand("Select twenty_four from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2025")
            {
                SqlCommand cmd = new SqlCommand("Select twenty_five from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2026")
            {
                SqlCommand cmd = new SqlCommand("Select twenty_six from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2027")
            {
                SqlCommand cmd = new SqlCommand("Select twenty_seven from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2028")
            {
                SqlCommand cmd = new SqlCommand("Select twenty_eight from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2029")
            {
                SqlCommand cmd = new SqlCommand("Select twenty_nine from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2030")
            {
                SqlCommand cmd = new SqlCommand("Select thirty from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2031")
            {
                SqlCommand cmd = new SqlCommand("Select thirty_one from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2032")
            {
                SqlCommand cmd = new SqlCommand("Select thirty_two from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2033")
            {
                SqlCommand cmd = new SqlCommand("Select thirty_three from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else if (DropDownList2.SelectedValue == "2034")
            {
                SqlCommand cmd = new SqlCommand("Select thirty_four from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select thirty_five from year", constrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString() + "-";
                }
            }
            SqlConnection connecstrng = new SqlConnection(strcon);
            connecstrng.Open();
            if (DropDownList3.SelectedValue == "MAY")
            {
                SqlCommand cmd = new SqlCommand("Select may from defl_val", connecstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox8.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select dec from defl_val", connecstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox8.Text = dr.GetValue(0).ToString()+"-";
                }
            }
            string yr = TextBox2.Text;
            string co = TextBox5.Text;
            string defl = TextBox8.Text;
            string inr = TextBox9.Text;
            TextBox6.Text = yr + co + defl + inr;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Autogenrate();
            string yr = TextBox2.Text;
            string co = TextBox5.Text;
            string defl = TextBox8.Text;
            string inr = TextBox9.Text;
            string tot = yr + co + defl + inr;
            TextBox6.Text = yr + co + defl + inr;
            void Autogenrate()
            {
                int r;
                try
                {
                    SqlConnection costrng = new SqlConnection(strcon);
                    costrng.Open();
                    SqlCommand cmd = new SqlCommand("Select max(Roll_num) from roll_num", costrng);
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {



                        var d = sdr[0].ToString();
                        if (d == "")
                        {

                            TextBox9.Text = "7000";//set the value in textbox which name is id

                        }
                        else
                        {

                            r = Convert.ToInt32(sdr[0].ToString());
                            r = r + 1;
                            TextBox9.Text = r.ToString();
                        }
                    }
                    costrng.Close();
                    costrng.Open();

                    SqlCommand com = new SqlCommand("INSERT INTO roll_num(Roll_num)values(@Roll_num)", costrng);
                    com.Parameters.AddWithValue("@Roll_num", TextBox9.Text.Trim());



                    com.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    costrng.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert(" + ex.Message + ")</script>");
                }
            }
            try
            {
                SqlConnection connstrng = new SqlConnection(strcon);
                if (connstrng.State == System.Data.ConnectionState.Closed)
                {
                    connstrng.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO RRN_details(RRN,Dept_name,Guide_name,Research_topic)values(@RRN,@Dept_name,@Guide_name,@Research_topic)", connstrng);
                cmd.Parameters.AddWithValue("@RRN", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@Dept_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Guide_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Research_topic", TextBox4.Text.Trim());
                cmd.ExecuteNonQuery();
                connstrng.Close();
                Response.Write("<script>alert(tot);</script>");
                Response.Write("<script>alert('Details has been submitted successfully');</script>");
            }
            catch
            {
                Response.Write("<script>alert('" + "Something you've missed" + "');</script>");
            }
            
        }
    }
}

        

       
    
