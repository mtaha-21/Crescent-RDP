using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Text;

namespace RDP
{
    public partial class rrn_gen : System.Web.UI.Page
    {
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedItem.Value;
        }

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
                scholar.Text = ds.Tables[0].Rows[0]["full_name"].ToString();
            }
            con.Close();
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
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Automobile Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select Automobile_Engineering from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Chartered Accountant")
            {
                SqlCommand cmd = new SqlCommand("Select Chartered_Accountant from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Chemistry")
            {
                SqlCommand cmd = new SqlCommand("Select Chemistry from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Civil Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select Civil_Engineering from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Commerce")
            {
                SqlCommand cmd = new SqlCommand("Select Commerce from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Computer Science Egineering")
            {
                SqlCommand cmd = new SqlCommand("Select CSE from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select ECE from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select EEE from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select EIE from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "English")
            {
                SqlCommand cmd = new SqlCommand("Select English from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Islamic Studies")
            {
                SqlCommand cmd = new SqlCommand("Select Islamic_Studies from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Information Technology")
            {
                SqlCommand cmd = new SqlCommand("Select IT from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Maths & AS")
            {
                SqlCommand cmd = new SqlCommand("Select Maths_AS from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Mechanical Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select Mech from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Mgt Studies")
            {
                SqlCommand cmd = new SqlCommand("Select Mgt_Studies from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Physics")
            {
                SqlCommand cmd = new SqlCommand("Select Physics from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "Polymer Engineering")
            {
                SqlCommand cmd = new SqlCommand("Select Polymer from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select SLS from dept_code", connstrng);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox5.Text = dr.GetValue(0).ToString();
                }
            }


            if (DropDownList2.SelectedValue == "2021")
            {
                SqlCommand cmd2 = new SqlCommand("Select twenty_one from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2022")
            {
                SqlCommand cmd2 = new SqlCommand("Select twenty_two from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2023")
            {
                SqlCommand cmd2 = new SqlCommand("Select twenty_three from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2024")
            {
                SqlCommand cmd2 = new SqlCommand("Select twenty_four from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2025")
            {
                SqlCommand cmd2 = new SqlCommand("Select twenty_five from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2026")
            {
                SqlCommand cmd2 = new SqlCommand("Select twenty_six from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2027")
            {
                SqlCommand cmd2 = new SqlCommand("Select twenty_seven from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2028")
            {
                SqlCommand cmd2 = new SqlCommand("Select twenty_eight from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2029")
            {
                SqlCommand cmd2 = new SqlCommand("Select twenty_nine from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2030")
            {
                SqlCommand cmd2 = new SqlCommand("Select thirty from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2031")
            {
                SqlCommand cmd2 = new SqlCommand("Select thirty_one from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2032")
            {
                SqlCommand cmd2 = new SqlCommand("Select thirty_two from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2033")
            {
                SqlCommand cmd2 = new SqlCommand("Select thirty_three from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else if (DropDownList2.SelectedValue == "2034")
            {
                SqlCommand cmd2 = new SqlCommand("Select thirty_four from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("Select thirty_five from year", connstrng);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.Read())
                {
                    TextBox2.Text = dr1.GetValue(0).ToString();
                }
                dr1.Close();
            }

            if (DropDownList3.SelectedValue == "MAY")
            {
                SqlCommand cmd3 = new SqlCommand("Select may from defl_val", connstrng);
                SqlDataReader dr2 = cmd3.ExecuteReader();
                if (dr2.Read())
                {
                    TextBox8.Text = dr2.GetValue(0).ToString();
                }
            }
            else
            {
                SqlCommand cmd3 = new SqlCommand("Select dec from defl_val", connstrng);
                SqlDataReader dr2 = cmd3.ExecuteReader();
                if (dr2.Read())
                {
                    TextBox8.Text = dr2.GetValue(0).ToString();
                }
                dr2.Close();
            }
            
            
            {
                int r;
                SqlCommand cmd = new SqlCommand("Select max(temp_roll) from RRN_details", connstrng);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    var d = sdr[0].ToString();
                    if (d == "")
                    {
                        TextBox9.Text = "7000";//set the value in textbox which name is id
                    }
                    else if (d == TextBox9.Text)
                    {

                    }

                    else
                    {

                        r = Convert.ToInt32(sdr[0].ToString());
                        r = r + 1;
                        TextBox9.Text = r.ToString();
                    }
                }
                connstrng.Close();

                string yr = TextBox2.Text;
                string co = TextBox5.Text;
                string defl = TextBox8.Text;
                string inr = TextBox9.Text;
                TextBox6.Text = yr + "-" + co + "-" + defl + "-" + inr;                
            }
        }
        
        string connection = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connstrng = new SqlConnection(strcon);
                if (connstrng.State == System.Data.ConnectionState.Closed)
                {
                    connstrng.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO RRN_details(RRN,Dept_name,Guide_name,Research_topic,temp_roll,user_id)values(@RRN,@Dept_name,@Guide_name,@Research_topic,@temp_roll,@user_id)", connstrng);
                cmd.Parameters.AddWithValue("@RRN", TextBox2.Text + TextBox5.Text + TextBox8.Text + TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@Dept_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Guide_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Research_topic", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@temp_roll", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@user_id", Request.QueryString["user_id"].Trim());
                cmd.ExecuteNonQuery();
                connstrng.Close();
                Response.Write("<script>alert(tot);</script>");
                Response.Write("<script>alert('Details has been submitted successfully');</script>");
            }
            catch
            {
                Response.Write("<script>alert('" + "Something you've missed" + "');</script>");
            }

            string to = "samronald17@gmail.com"; //To address    
            string from = "uisbibin@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "APPROVE THE SCHOLAR BELOW";
            message.Subject = "HELLO DEAN";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("uisbibin@gmail.com", "");
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

            using (var conn = new SqlConnection(connection))
            {

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update personal_details set status1 = 0, status2 = 1 where user_id=" + Request.QueryString["user_id"], conn);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                conn.Close();
            }

            string user_id = Request.QueryString["user_id"];
            Response.Redirect("pdf.aspx?user_id=" + user_id);

        }

    }
}