using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        private RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private int i
        {
            get
            {
                if (Session["i"] == null)
                    return 7000;

                return (int)Session["i"];


            }
            set
            {
                Session["i"] = value;
            }
        }
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
                        i++;

                        TextBox2.Text =  year + dept + month + i.ToString();
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
                        i++;

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
                        i++;

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
                        i++;

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
                        i++;

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
                        i++;

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
                        i++;

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
                        dept = "028";
                        i++;

                        TextBox2.Text = year + dept + month.ToString();
                    }
                }
            }


        }

    }
}