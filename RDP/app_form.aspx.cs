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

            string filename = Path.GetFileName(imageBrowes.PostedFile.FileName);
            imageBrowes.SaveAs(Server.MapPath("Images/" + filename));

            try
            {
                SqlConnection connstrng = new SqlConnection(strcon);
                if (connstrng.State == System.Data.ConnectionState.Closed)
                {
                    connstrng.Open();
                }

                //Personal Details
                SqlCommand cmd1 = new SqlCommand("INSERT INTO personal_details(full_name, date_of_birth, age, gender, nationality, if_foreign_country, passport, social_status, marital_status, telephone, mobile_number, email_id, residential_address, office_address, address_for_communication,ImageName,ImagePath) values(@full_name, @date_of_birth, @age, @gender, @nationality, @if_foreign_country, @passport, @social_status, @marital_status, @telephone, @mobile_number, @email_id, @residential_address, @office_address, @address_for_communication,@ImageName,@ImagePath)", connstrng);
                cmd1.Parameters.AddWithValue("@full_name", TextBox1.Text.Trim());
                cmd1.Parameters.AddWithValue("@date_of_birth", TextBox2.Text.Trim());
                cmd1.Parameters.AddWithValue("@age", TextBox14.Text.Trim());
                cmd1.Parameters.AddWithValue("@gender", DropDownList20.SelectedItem.Value);
                cmd1.Parameters.AddWithValue("@nationality", DropDownList19.SelectedItem.Value);
                cmd1.Parameters.AddWithValue("@if_foreign_country", Country.SelectedItem.Value);
                cmd1.Parameters.AddWithValue("@passport", TextBox3.Text.Trim());
                cmd1.Parameters.AddWithValue("@social_status", DropDownList1.SelectedItem.Value);
                cmd1.Parameters.AddWithValue("@marital_status", DropDownList2.SelectedItem.Value);
                cmd1.Parameters.AddWithValue("@telephone", TextBox4.Text.Trim());
                cmd1.Parameters.AddWithValue("@mobile_number", TextBox5.Text.Trim());
                cmd1.Parameters.AddWithValue("@email_id", TextBox6.Text.Trim());
                cmd1.Parameters.AddWithValue("@residential_address", TextBox7.Text.Trim());
                cmd1.Parameters.AddWithValue("@office_address", TextBox10.Text.Trim());
                cmd1.Parameters.AddWithValue("@address_for_communication", DropDownList21.SelectedItem.Value);
                cmd1.Parameters.AddWithValue("@ImageName", filename);
                cmd1.Parameters.AddWithValue("@ImagePath", "Images/" + filename);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("Select max (user_id) from personal_details", connstrng);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                string uid = dr2.GetValue(0).ToString();

                    //Acadamic details
                    SqlCommand cmd = new SqlCommand("INSERT INTO academic_details(category,type_of_registration,if_part_time,ug_university_or_college,ug_year_of_passing,ug_month_of_passing,ug_class,pg_university_or_college,pg_year_of_passing,pg_month_of_passing,pg_class,pg_part_time_or_full_time,other_qualification,year_of_passing,month_of_passing,class,part_time_or_full_time,bachelor_degree_discipline,bsem_1,bsem_2,bsem_3,bsem_4,bsem_5,bsem_6 ,bsem_7,bsem_8,master_degree_discipline,msem_1,msem_2 ,msem_3 ,msem_4,msem_5,msem_6,specify,org_worked,designation,no_of_yrs_worked,work_mode,specify_name,name_of_org,designation1,yrs_worked,work_mode1,name_add_emp,designation2,mode_of_emp,scale_of_pay,working_since,total_yrs,user_id) values(@category,@type_of_registration,@if_part_time,@ug_university_or_college,@ug_year_of_passing,@ug_month_of_passing,@ug_class,@pg_university_or_college,@pg_year_of_passing,@pg_month_of_passing,@pg_class,@pg_part_time_or_full_time,@other_qualification,@year_of_passing,@month_of_passing,@class,@part_time_or_full_time,@bachelor_degree_discipline,@bsem_1,@bsem_2,@bsem_3,@bsem_4,@bsem_5,@bsem_6 ,@bsem_7,@bsem_8,@master_degree_discipline,@msem_1,@msem_2 ,@msem_3 ,@msem_4,@msem_5,@msem_6,@specify,@org_worked,@designation,@no_of_yrs_worked,@work_mode,@specify_name,@name_of_org,@designation1,@yrs_worked,@work_mode1,@name_add_emp,@designation2,@mode_of_emp,@scale_of_pay,@working_since,@total_yrs,@user_id)", connstrng);                
                cmd.Parameters.AddWithValue("@category", DropDownList22.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@type_of_registration", DropDownList23.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@if_part_time", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@ug_university_or_college", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@ug_year_of_passing", DropDownList4.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@ug_month_of_passing", DropDownList10.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@ug_class", DropDownList6.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@pg_university_or_college", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@pg_year_of_passing", DropDownList7.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@pg_month_of_passing", DropDownList8.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@pg_class", DropDownList9.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@pg_part_time_or_full_time", DropDownList14.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@other_qualification", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@year_of_passing", DropDownList5.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@month_of_passing", DropDownList11.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@class", DropDownList12.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@part_time_or_full_time", DropDownList13.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@bachelor_degree_discipline", TextBox14.Text.Trim());
                cmd.Parameters.AddWithValue("@bsem_1", DropDownList20.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@bsem_2", DropDownList19.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@bsem_3", Country.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@bsem_4", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@bsem_5", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@bsem_6", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@bsem_7", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@bsem_8", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@master_degree_discipline", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@msem_1", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@msem_2", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@msem_3", DropDownList21.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@msem_4", Country.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@msem_5", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@msem_6", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@specify", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@org_worked", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@designation", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@no_of_yrs_worked", TextBox36.Text.Trim());
                cmd.Parameters.AddWithValue("@work_mode", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@specify_name", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@name_of_org", DropDownList21.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@designation1", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@yrs_worked", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@work_mode1", TextBox14.Text.Trim());
                cmd.Parameters.AddWithValue("@name_add_emp", DropDownList20.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@designation2", DropDownList19.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@mode_of_emp", Country.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@scale_of_pay", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@working_since", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@total_yrs", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@user_id", uid);
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