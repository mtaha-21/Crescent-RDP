using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

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
        private RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
         
       // protected void DropDownList_Month(object sender, EventArgs e)
        //{
          // if (DropDownList3.value = 1)
            //{

            //}
        //}
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
        private int aero
        {
            get
            {
                if (Session["aero"] == null)
                    return 1000;

                return (int)Session["aero"];


            }
            set
            {
                Session["aero"] = value;
            }
        }
        private int poly
        {
            get
            {
                if (Session["poly"] == null)
                    return 1000;

                return (int)Session["poly"];


            }
            set
            {
                Session["poly"] = value;
            }
        }
        private int mech
        {
            get
            {
                if (Session["mech"] == null)
                    return 1000;

                return (int)Session["mech"];


            }
            set
            {
                Session["mech"] = value;
            }
        }
        private int cse
        {
            get
            {
                if (Session["cse"] == null)
                    return 1000;

                return (int)Session["cse"];


            }
            set
            {
                Session["cse"] = value;
            }
        }
        private int mca
        {
            get
            {
                if (Session["mca"] == null)
                    return 1000;

                return (int)Session["mca"];


            }
            set
            {
                Session["mca"] = value;
            }
        }
        private int msc
        {
            get
            {
                if (Session["msc"] == null)
                    return 1000;

                return (int)Session["msc"];


            }
            set
            {
                Session["msc"] = value;
            }
        }
        private int ma
        {
            get
            {
                if (Session["ma"] == null)
                    return 1000;

                return (int)Session["ma"];


            }
            set
            {
                Session["ma"] = value;
            }
        }
        private int mcom
        {
            get
            {
                if (Session["mcom"] == null)
                    return 1000;

                return (int)Session["mcom"];


            }
            set
            {
                Session["mcom"] = value;
            }
        }
        //public object DropDownList3 { get; private set; }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dept = " ";
            string month = " ";
            string year = " ";
            if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering" && DropDownList2.SelectedValue == "2021")
            {
                dept = "EEE";
                year = "2021";
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


            if (DropDownList1.SelectedValue == "Electrical and Communication Engineering" && DropDownList2.SelectedValue=="2021")
            {
                dept = "ECE";
                year = "2021";
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
            if (DropDownList1.SelectedValue == "Aeronautical Engineering" && DropDownList2.SelectedValue=="2021")
            {
                dept = "AERO";
                year = "2021";
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

                aero++;

                TextBox2.Text = dept + month + year + aero.ToString();
            }


            if (DropDownList1.SelectedValue == "Polymer Engineering" && DropDownList2.SelectedValue=="2021")
            {
                dept = "POLY";
                year = "2021";
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

                poly++;

                TextBox2.Text = dept + month + year + poly.ToString();
            }
            if (DropDownList1.SelectedValue == "Mechanical Engineering" && DropDownList2.SelectedValue == "2021" )
            {
                dept = "MECH";
                year = "2021";
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

                mech++;

                TextBox2.Text = dept + month + year + mech.ToString();
            }
            if (DropDownList1.SelectedValue == "Computer Science Engineering" && DropDownList2.SelectedValue == "2021" ) 
            {
                dept = "CSE";
                year = "2021";
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

                cse++;

                TextBox2.Text = dept + month + year + cse.ToString();
            }
            if (DropDownList1.SelectedValue == "Master of Computer Applications" && DropDownList2.SelectedValue=="2021")
            {
                dept = "MCA";
                year = "2021";
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

                mca++;

                TextBox2.Text = dept + month + year + mca.ToString();
            }
            if (DropDownList1.SelectedValue == "Master of Science" && DropDownList2.SelectedValue == "2021" )
            {
                dept = "MSC";
                year = "2021";
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

                msc++;

                TextBox2.Text = dept + month + year + msc.ToString();
            }
            if (DropDownList1.SelectedValue == "Master of Arts" && DropDownList2.SelectedValue == "2021" ) 
            {
                dept = "MA";
                year = "2021";
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

                ma++;

                TextBox2.Text = dept + month + year + ma.ToString();
            }
            if (DropDownList1.SelectedValue == "Master of Commerce" && DropDownList2.SelectedValue == "2021" )
            {
                dept = "MCOM";
                year = "2021";
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

                mcom++;
                TextBox2.Text = dept + month + year + mcom.ToString();
            }
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering" && DropDownList2.SelectedValue == "2022" )
            {
                dept = "EEE";
                year = "2022";
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


            if (DropDownList1.SelectedValue == "Electrical and Communication Engineering" && DropDownList2.SelectedValue=="2022")
            {
                dept = "ECE";
                year = "2022";
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
            if (DropDownList1.SelectedValue == "Aeronautical Engineering" && DropDownList2.SelectedValue=="2022")
            {
                dept = "AERO";
                year = "2022";

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

                aero++;

                TextBox2.Text = dept + month + year + aero.ToString();
            }


            if (DropDownList1.SelectedValue == "Polymer Engineering" && DropDownList2.SelectedValue=="2022")
            {
                dept = "POLY";
                year = "2022";
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

                poly++;

                TextBox2.Text = dept + month + year + poly.ToString();
            }
            if (DropDownList1.SelectedValue == "Mechanical Engineering" && DropDownList2.SelectedValue=="2022")
            {
                dept = "MECH";
                year = "2022";
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

                mech++;

                TextBox2.Text = dept + month + year + mech.ToString();
            }
            if (DropDownList1.SelectedValue == "Computer Science Engineering" && DropDownList2.SelectedValue == "2022" )
            {
                dept = "CSE";
                year = "2022";
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

                cse++;

                TextBox2.Text = dept + month + year + cse.ToString();
            }
            if (DropDownList1.SelectedValue == "Master of Computer Applications" && DropDownList2.SelectedValue == "2022" )
            {
                dept = "MCA";
                year = "2022";
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

                mca++;

                TextBox2.Text = dept + month + year + mca.ToString();
            }
            if (DropDownList1.SelectedValue == "Master of Science" && DropDownList2.SelectedValue == "2022" )
            {
                dept = "MSC";
                year = "2022";
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

                msc++;

                TextBox2.Text = dept + month + year + msc.ToString();
            }
            if (DropDownList1.SelectedValue == "Master of Arts" && DropDownList2.SelectedValue=="2022")
            {
                dept = "MA";
                year = "2022";
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

                ma++;

                TextBox2.Text = dept + month + year + ma.ToString();
            }
            if (DropDownList1.SelectedValue == "Master of Commerce" && DropDownList2.SelectedValue == "2022")
            {
                dept = "MCOM";
                year = "2022";
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

                mcom++;

                TextBox2.Text = dept + month + year + mcom.ToString();
            }
            if (DropDownList2.SelectedValue == "2023")
            {
                year = "2023";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";
                
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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2024")
            {
                year = "2024";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2025")
            {
                year = "2025";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2026")
            {
                year = "2026";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2027")
            {
                year = "2027";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2028")
            {
                year = "2028";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2029")
            {
                year = "2029";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2030")
            {
                year = "2030";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2031")
            {
                year = "2031";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2032")
            {
                year = "2032";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
            if(DropDownList2.SelectedValue == "2033")
            {
                year = "2033";
                if (DropDownList1.SelectedValue == "Electrical and Electronic Engineering")
                {
                    dept = "EEE";

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


                if (DropDownList1.SelectedValue == "Electrical and Communication Engineering")
                {
                    dept = "ECE";

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
                if (DropDownList1.SelectedValue == "Aeronautical Engineering")
                {
                    dept = "AERO";

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

                    aero++;

                    TextBox2.Text = dept + month + year + aero.ToString();
                }


                if (DropDownList1.SelectedValue == "Polymer Engineering")
                {
                    dept = "POLY";

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

                    poly++;

                    TextBox2.Text = dept + month + year + poly.ToString();
                }
                if (DropDownList1.SelectedValue == "Mechanical Engineering")
                {
                    dept = "MECH";
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

                    mech++;

                    TextBox2.Text = dept + month + year + mech.ToString();
                }
                if (DropDownList1.SelectedValue == "Computer Science Engineering")
                {
                    dept = "CSE";

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

                    cse++;

                    TextBox2.Text = dept + month + year + cse.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Computer Applications")
                {
                    dept = "MCA";
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

                    mca++;

                    TextBox2.Text = dept + month + year + mca.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Science")
                {
                    dept = "MSC";
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

                    msc++;

                    TextBox2.Text = dept + month + year + msc.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Arts")
                {
                    dept = "MA";
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

                    ma++;

                    TextBox2.Text = dept + month + year + ma.ToString();
                }
                if (DropDownList1.SelectedValue == "Master of Commerce")
                {
                    dept = "MCOM";
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

                    mcom++;

                    TextBox2.Text = dept + month + year + mcom.ToString();
                }
            }
        }
        // And your method with textBox


        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //  TextBox2.Text = Wins.ToString();
        //}
        public void Button20(object sender, EventArgs e)
        {

        }

    }
}
