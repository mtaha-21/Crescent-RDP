using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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



        public void Button20(object sender, EventArgs e)
        {

        }
    }
}