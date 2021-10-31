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


            string dept = " ";
            string month = " ";
            string year = " ";
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "029";

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "028";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Aerospace Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "021";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Automobile Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "022";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "21";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "21";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "22";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "22";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "23";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "23";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "24";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "24";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "25";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "25";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "26";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "26";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "27";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "27";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "28";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "28";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "29";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "29";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "30";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "30";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "31";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "31";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "32";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "32";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "33";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Chartered Accountant")
                    {
                        year = "33";
                        month = "370";
                        dept = "023";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "21";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "21";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "22";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "22";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "23";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "23";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "24";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "24";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "25";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "25";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "26";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "26";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "27";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "27";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "28";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "28";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "29";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "29";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "30";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "30";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "31";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "31";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "32";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "32";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "33";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Chemistry")
                    {
                        year = "33";
                        month = "370";
                        dept = "024";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Civil Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "025";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "21";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "21";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "22";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "22";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "23";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "23";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "24";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "24";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "25";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "25";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "26";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "26";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "27";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "27";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "28";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "28";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "29";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "29";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "30";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "30";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "31";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "31";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "32";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "32";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "33";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Commerce")
                    {
                        year = "33";
                        month = "370";
                        dept = "026";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Computer Science Egineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "027";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Electronic and Instrumentation Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "21";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "21";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "22";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "22";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "23";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "23";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "24";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "24";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "25";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "25";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "26";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "26";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "27";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "27";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "28";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "28";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "29";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "29";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "30";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "30";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "31";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "31";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "32";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "32";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "33";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "33";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "English")
                    {
                        year = "21";
                        month = "370";
                        dept = "031";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "21";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "22";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "22";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "23";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "23";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "24";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "24";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "25";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "25";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "26";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "26";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "27";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "27";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "28";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "28";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "29";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "29";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "30";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "30";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "31";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "31";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "32";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "32";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "33";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Islamic Studies")
                    {
                        year = "33";
                        month = "370";
                        dept = "032";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "21";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "21";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "22";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "22";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "23";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "23";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "24";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "24";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "25";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "25";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "26";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "26";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "27";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "27";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "28";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "28";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "29";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "29";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "30";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "30";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "31";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "31";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "32";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "32";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "33";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Information Technology")
                    {
                        year = "33";
                        month = "370";
                        dept = "033";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }

            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "21";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "21";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "22";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "22";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "23";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "23";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "24";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "24";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "25";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "25";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "26";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "26";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "27";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "27";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "28";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "28";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "29";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "29";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "30";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "30";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "31";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "31";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "32";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "32";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "33";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Maths & AS")
                    {
                        year = "33";
                        month = "370";
                        dept = "034";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }

            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Mechanical Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "035";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }

            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "21";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "21";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "22";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "22";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "23";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "23";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "24";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "24";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "25";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "25";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "26";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "26";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "27";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "27";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "28";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "28";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "29";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "29";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "30";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "30";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "31";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "31";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "32";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "32";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "33";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Mgt Studies")
                    {
                        year = "33";
                        month = "370";
                        dept = "036";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }

            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "21";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "21";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "22";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "22";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "23";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "23";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "24";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "24";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "25";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "25";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "26";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "26";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "27";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "27";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "28";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "28";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "29";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "29";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "30";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "30";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "31";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "31";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "32";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "32";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "33";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Physics")
                    {
                        year = "33";
                        month = "370";
                        dept = "037";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }

            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "21";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "22";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "23";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "24";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "25";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "26";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "27";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "28";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "29";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "30";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "31";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "32";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "Polymer Engineering")
                    {
                        year = "33";
                        month = "370";
                        dept = "038";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }

            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "21";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2021")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "21";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "22";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2022")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "22";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "23";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2023")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "23";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "24";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2024")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "24";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "25";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2025")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "25";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "26";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2026")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "26";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "27";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2027")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "27";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "28";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2028")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "28";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "29";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2029")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "29";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "30";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2030")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "30";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "31";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2031")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "31";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "32";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2032")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "32";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            if (DropDownList3.SelectedValue == "MAY")
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "33";
                        month = "370";
                        dept = "030";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }
            else
            {
                if (DropDownList2.SelectedValue == "2033")
                {
                    if (DropDownList1.SelectedValue == "SLS")
                    {
                        year = "33";
                        month = "370";
                        dept = "039";


                        TextBox2.Text = year + dept + month.ToString();
                    }
                }

            }
            Autogenrate();
            string code = TextBox2.Text;
            string no = TextBox5.Text;
            TextBox6.Text = code + no;
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

                        TextBox5.Text = "7000";//set the value in textbox which name is id

                    }
                    else
                    {

                        r = Convert.ToInt32(dr[0].ToString());
                        r = r + 1;
                        TextBox5.Text = r.ToString();
                    }
                }
                connstrng.Close();
                connstrng.Open();

                SqlCommand com = new SqlCommand("INSERT INTO rrn_gen(roll)values(@roll)", connstrng);
                com.Parameters.AddWithValue("@roll", TextBox5.Text.Trim());
                


                com.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                connstrng.Close();

            }

            catch (Exception ex)
            {
                Response.Write("<script>alert(" + ex.Message + ")</script>");
            }
        }

            protected void Button2_Click(object sender, EventArgs e)
            {
            string code = TextBox2.Text;
            string no = TextBox5.Text;
            TextBox6.Text = code + no;
            try
                {
                    SqlConnection connstrng = new SqlConnection(strcon);
                    if (connstrng.State == System.Data.ConnectionState.Closed)
                    {
                        connstrng.Open();
                    }
                    SqlCommand cmd = new SqlCommand("INSERT INTO RRN_info(RRN,Dept_name,Guide_name,Research_topic)values(@RRN,@Dept_name,@Guide_name,@Research_topic)", connstrng);
                    cmd.Parameters.AddWithValue("@RRN", TextBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@Dept_name", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Guide_name", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Research_topic", TextBox4.Text.Trim());
                    cmd.ExecuteNonQuery();
                    connstrng.Close();
                    Response.Write("<script>alert('Details has been submitted successfully');</script>");
                }
                catch
                {
                    Response.Write("<script>alert('" + "Something you've missed" + "');</script>");
                }
            }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.ReadOnly = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox6.Text = TextBox2.Text + TextBox5.Text;
        }

            
            
        }
    }


    
    



    //try
    //{ 

    //    SqlConnection connstrng = new SqlConnection(strcon);
    //if (connstrng.State == System.Data.ConnectionState.Closed)
    //{
    //    connstrng.Open();
    //}
    //SqlCommand command = new SqlCommand("INSERT INTO rrn_gen (rrn) VALUES (@i + 1)", connstrng);
    //command.Parameters.AddWithValue("@rrn", TextBox5.Text.Trim());
    //    command.ExecuteNonQuery();
    //    connstrng.Close();
    //    Response.Write("<script>alert('RRN submitted successfully'); window.location='homepage.aspx';</script>")
    //}
    //catch (Exception ex)
    //{
    //    Response.Write("<script>alert('" + ex.Message + "');</script>");
    //}


        

       
    
