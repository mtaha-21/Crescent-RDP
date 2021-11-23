using System;


namespace RDP
{
    public partial class deanpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user_id = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("approve.aspx?user_id=" + user_id);
        }
    }
}