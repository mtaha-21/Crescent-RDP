using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RDP
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    droplist.Visible = false; //menu
                    LinkButton3.Visible = false; //logout
                    LinkButton7.Visible = false; //user
                }
                else if (Session["role"].Equals("ADMIN"))
                {
                    droplist.Visible = true; //menu
                    LinkButton3.Visible = true; //logout
                    LinkButton7.Visible = true; //user
                    LinkButton7.Text = "ADMIN"; 

                }
                else if (Session["role"].Equals("DEAN"))
                {
                    droplist.Visible = false; //menu
                    LinkButton3.Visible = true; //logout
                    LinkButton7.Visible = true; //user
                    LinkButton7.Text = "DEAN";

                }
                else if (Session["role"].Equals("GUEST"))
                {
                    droplist.Visible = false; //menu
                    LinkButton3.Visible = true; //logout
                    LinkButton7.Visible = true; //user
                    LinkButton7.Text = "GUEST";

                }
            }
            catch (Exception)
            {

            }
            
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["role"] = null;
            droplist.Visible = false; //menu
            LinkButton3.Visible = false; //logout
            LinkButton7.Visible = false; //user
            Response.Redirect("homepage.aspx");
        }
    }
}