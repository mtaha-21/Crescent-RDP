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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static string mycon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public static string ut;

        protected void Button20(object sender, EventArgs e)
        {
            if (txtun.Text == "" || txtpw.Text == "")
            {
                System.Windows.MessageBox.Show("Enter User Name and Password");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(mycon);
                SqlDataAdapter sda = new SqlDataAdapter("Select Usertype from user_table where Username like'"+ txtun.Text +"'COLLATE SQL_Latin1_General_CP1_CS_AS and Password like'"+ txtpw.Text +"'COLLATE SQL_Latin1_General_CP1_CS_AS ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count==1)
                {
                    ut = dt.Rows[0][0].ToString();
                    if (ut == "ADMIN")
                    {
                        adminpage FRM = new adminpage();
                        FRM.Show();
                        this.Hide();
                    }
                    else if (ut == "DEAN")
                    {
                        deanpage FRM = new deanpage();
                        FRM.Show();
                        this.Hide();
                    }
                    else if (ut == "GUEST")
                    {
                        application FRM = new application();
                        FRM.Show();
                        this.Hide();
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Check User name and password");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }
    }
}