using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RDP
{
    public partial class newlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user_id = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("validate.aspx?user_id=" + user_id);
        }

    }
}