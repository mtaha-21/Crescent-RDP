using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RDP
{
    public partial class updatelist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role_no = GridView2.SelectedRow.Cells[0].Text;
            Response.Redirect("rrn_gen.aspx?role_no=" + role_no);
        }
    }
}