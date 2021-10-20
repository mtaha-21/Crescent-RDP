using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RDP
{
    public partial class test : System.Web.UI.Page
    {
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedItem.Value;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private int eee
        {
            get
            {
                if (Session["eee"] == null)
                    return 1000;

                return (int)Session["eee"];


            }
            set
            {
                Session["eee"] = value;
            }
        }
        private int ece
        {
            get
            {
                if (Session["ece"] == null)
                    return 1000;

                return (int)Session["ece"];


            }
            set
            {
                Session["ece"] = value;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string dept = " ";
            string month = " ";
            string year = " ";
            if (DropDownList2.SelectedValue == "2021")
            {
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    if (DropDownList3.SelectedValue == "JAN")
                    {
                        month = "JAN";
                    }
                    else if (DropDownList3.SelectedValue == "FEB")
                    {
                        month = "FEB";
                    }
                    else if (DropDownList3.SelectedValue == "MAR")
                    {
                        month = "MAR";
                    }
                    else if (DropDownList3.SelectedValue == "APR")
                    {
                        month = "APR";
                    }
                    else if (DropDownList3.SelectedValue == "MAY")
                    {
                        month = "MAY";
                    }
                    else if (DropDownList3.SelectedValue == "JUN")
                    {
                        month = "JUN";
                    }
                    else if (DropDownList3.SelectedValue == "JUL")
                    {
                        month = "JUL";
                    }
                    else if (DropDownList3.SelectedValue == "AUG")
                    {
                        month = "AUG";
                    }
                    else if (DropDownList3.SelectedValue == "SEP")
                    {
                        month = "SEP";
                    }
                    else if (DropDownList3.SelectedValue == "OCT")
                    {
                        month = "OCT";
                    }
                    else if (DropDownList3.SelectedValue == "NOV")
                    {
                        month = "NOV";
                    }
                    else
                    {
                        month = "DEC";
                    }
                    eee++;

                    TextBox2.Text = dept + month + year + eee.ToString();
                }
            }
            else
            {
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    if (DropDownList3.SelectedValue == "JAN")
                    {
                        month = "JAN";
                    }
                    else if (DropDownList3.SelectedValue == "FEB")
                    {
                        month = "FEB";
                    }
                    else if (DropDownList3.SelectedValue == "MAR")
                    {
                        month = "MAR";
                    }
                    else if (DropDownList3.SelectedValue == "APR")
                    {
                        month = "APR";
                    }
                    else if (DropDownList3.SelectedValue == "MAY")
                    {
                        month = "MAY";
                    }
                    else if (DropDownList3.SelectedValue == "JUN")
                    {
                        month = "JUN";
                    }
                    else if (DropDownList3.SelectedValue == "JUL")
                    {
                        month = "JUL";
                    }
                    else if (DropDownList3.SelectedValue == "AUG")
                    {
                        month = "AUG";
                    }
                    else if (DropDownList3.SelectedValue == "SEP")
                    {
                        month = "SEP";
                    }
                    else if (DropDownList3.SelectedValue == "OCT")
                    {
                        month = "OCT";
                    }
                    else if (DropDownList3.SelectedValue == "NOV")
                    {
                        month = "NOV";
                    }
                    else
                    {
                        month = "DEC";
                    }
                    eee++;

                    TextBox2.Text = dept + month + year + eee.ToString();
                }
            }
            if (DropDownList2.SelectedValue == "2021")
            {
                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    if (DropDownList3.SelectedValue == "JAN")
                    {
                        month = "JAN";
                    }
                    else if (DropDownList3.SelectedValue == "FEB")
                    {
                        month = "FEB";
                    }
                    else if (DropDownList3.SelectedValue == "MAR")
                    {
                        month = "MAR";
                    }
                    else if (DropDownList3.SelectedValue == "APR")
                    {
                        month = "APR";
                    }
                    else if (DropDownList3.SelectedValue == "MAY")
                    {
                        month = "MAY";
                    }
                    else if (DropDownList3.SelectedValue == "JUN")
                    {
                        month = "JUN";
                    }
                    else if (DropDownList3.SelectedValue == "JUL")
                    {
                        month = "JUL";
                    }
                    else if (DropDownList3.SelectedValue == "AUG")
                    {
                        month = "AUG";
                    }
                    else if (DropDownList3.SelectedValue == "SEP")
                    {
                        month = "SEP";
                    }
                    else if (DropDownList3.SelectedValue == "OCT")
                    {
                        month = "OCT";
                    }
                    else if (DropDownList3.SelectedValue == "NOV")
                    {
                        month = "NOV";
                    }
                    else
                    {
                        month = "DEC";
                    }
                    ece++;

                    TextBox2.Text = dept + month + year + ece.ToString();
                }
            }
            else
            {
                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    if (DropDownList3.SelectedValue == "JAN")
                    {
                        month = "JAN";
                    }
                    else if (DropDownList3.SelectedValue == "FEB")
                    {
                        month = "FEB";
                    }
                    else if (DropDownList3.SelectedValue == "MAR")
                    {
                        month = "MAR";
                    }
                    else if (DropDownList3.SelectedValue == "APR")
                    {
                        month = "APR";
                    }
                    else if (DropDownList3.SelectedValue == "MAY")
                    {
                        month = "MAY";
                    }
                    else if (DropDownList3.SelectedValue == "JUN")
                    {
                        month = "JUN";
                    }
                    else if (DropDownList3.SelectedValue == "JUL")
                    {
                        month = "JUL";
                    }
                    else if (DropDownList3.SelectedValue == "AUG")
                    {
                        month = "AUG";
                    }
                    else if (DropDownList3.SelectedValue == "SEP")
                    {
                        month = "SEP";
                    }
                    else if (DropDownList3.SelectedValue == "OCT")
                    {
                        month = "OCT";
                    }
                    else if (DropDownList3.SelectedValue == "NOV")
                    {
                        month = "NOV";
                    }
                    else
                    {
                        month = "DEC";
                    }
                    ece++;

                    TextBox2.Text = dept + month + year + ece.ToString();
                }
            }
            if (DropDownList2.SelectedValue == "2022")
            {
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    if (DropDownList3.SelectedValue == "JAN")
                    {
                        month = "JAN";
                    }
                    else if (DropDownList3.SelectedValue == "FEB")
                    {
                        month = "FEB";
                    }
                    else if (DropDownList3.SelectedValue == "MAR")
                    {
                        month = "MAR";
                    }
                    else if (DropDownList3.SelectedValue == "APR")
                    {
                        month = "APR";
                    }
                    else if (DropDownList3.SelectedValue == "MAY")
                    {
                        month = "MAY";
                    }
                    else if (DropDownList3.SelectedValue == "JUN")
                    {
                        month = "JUN";
                    }
                    else if (DropDownList3.SelectedValue == "JUL")
                    {
                        month = "JUL";
                    }
                    else if (DropDownList3.SelectedValue == "AUG")
                    {
                        month = "AUG";
                    }
                    else if (DropDownList3.SelectedValue == "SEP")
                    {
                        month = "SEP";
                    }
                    else if (DropDownList3.SelectedValue == "OCT")
                    {
                        month = "OCT";
                    }
                    else if (DropDownList3.SelectedValue == "NOV")
                    {
                        month = "NOV";
                    }
                    else
                    {
                        month = "DEC";
                    }
                    eee++;

                    TextBox2.Text = dept + month + year + eee.ToString();
                }
            }
            else
            {
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    if (DropDownList3.SelectedValue == "JAN")
                    {
                        month = "JAN";
                    }
                    else if (DropDownList3.SelectedValue == "FEB")
                    {
                        month = "FEB";
                    }
                    else if (DropDownList3.SelectedValue == "MAR")
                    {
                        month = "MAR";
                    }
                    else if (DropDownList3.SelectedValue == "APR")
                    {
                        month = "APR";
                    }
                    else if (DropDownList3.SelectedValue == "MAY")
                    {
                        month = "MAY";
                    }
                    else if (DropDownList3.SelectedValue == "JUN")
                    {
                        month = "JUN";
                    }
                    else if (DropDownList3.SelectedValue == "JUL")
                    {
                        month = "JUL";
                    }
                    else if (DropDownList3.SelectedValue == "AUG")
                    {
                        month = "AUG";
                    }
                    else if (DropDownList3.SelectedValue == "SEP")
                    {
                        month = "SEP";
                    }
                    else if (DropDownList3.SelectedValue == "OCT")
                    {
                        month = "OCT";
                    }
                    else if (DropDownList3.SelectedValue == "NOV")
                    {
                        month = "NOV";
                    }
                    else
                    {
                        month = "DEC";
                    }
                    eee++;

                    TextBox2.Text = dept + month + year + eee.ToString();
                }
            }
            if (DropDownList2.SelectedValue == "2022")
            {
                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    if (DropDownList3.SelectedValue == "JAN")
                    {
                        month = "JAN";
                    }
                    else if (DropDownList3.SelectedValue == "FEB")
                    {
                        month = "FEB";
                    }
                    else if (DropDownList3.SelectedValue == "MAR")
                    {
                        month = "MAR";
                    }
                    else if (DropDownList3.SelectedValue == "APR")
                    {
                        month = "APR";
                    }
                    else if (DropDownList3.SelectedValue == "MAY")
                    {
                        month = "MAY";
                    }
                    else if (DropDownList3.SelectedValue == "JUN")
                    {
                        month = "JUN";
                    }
                    else if (DropDownList3.SelectedValue == "JUL")
                    {
                        month = "JUL";
                    }
                    else if (DropDownList3.SelectedValue == "AUG")
                    {
                        month = "AUG";
                    }
                    else if (DropDownList3.SelectedValue == "SEP")
                    {
                        month = "SEP";
                    }
                    else if (DropDownList3.SelectedValue == "OCT")
                    {
                        month = "OCT";
                    }
                    else if (DropDownList3.SelectedValue == "NOV")
                    {
                        month = "NOV";
                    }
                    else
                    {
                        month = "DEC";
                    }
                    ece++;

                    TextBox2.Text = dept + month + year + ece.ToString();
                }
            }
            else
            {
                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    if (DropDownList3.SelectedValue == "JAN")
                    {
                        month = "JAN";
                    }
                    else if (DropDownList3.SelectedValue == "FEB")
                    {
                        month = "FEB";
                    }
                    else if (DropDownList3.SelectedValue == "MAR")
                    {
                        month = "MAR";
                    }
                    else if (DropDownList3.SelectedValue == "APR")
                    {
                        month = "APR";
                    }
                    else if (DropDownList3.SelectedValue == "MAY")
                    {
                        month = "MAY";
                    }
                    else if (DropDownList3.SelectedValue == "JUN")
                    {
                        month = "JUN";
                    }
                    else if (DropDownList3.SelectedValue == "JUL")
                    {
                        month = "JUL";
                    }
                    else if (DropDownList3.SelectedValue == "AUG")
                    {
                        month = "AUG";
                    }
                    else if (DropDownList3.SelectedValue == "SEP")
                    {
                        month = "SEP";
                    }
                    else if (DropDownList3.SelectedValue == "OCT")
                    {
                        month = "OCT";
                    }
                    else if (DropDownList3.SelectedValue == "NOV")
                    {
                        month = "NOV";
                    }
                    else
                    {
                        month = "DEC";
                    }
                    ece++;

                    TextBox2.Text = dept + month + year + ece.ToString();
                }
            }
        }

    }
}