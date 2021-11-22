using System;
using System.Web.UI;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Text;
using System.Data.SqlClient;

namespace RDP
{

    public partial class check1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String mycon = "Data Source=SR99\\SQLEXPRESS;Initial Catalog=RDP_DB; Integrated Security=True";
            String myquery = "Select * from personal_details where user_id=10";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                name.Text = ds.Tables[0].Rows[0]["full_name"].ToString();
                name1.Text = ds.Tables[0].Rows[0]["full_name"].ToString();
            }
            con.Close();

            btnExport_Click(btnExport, null);

        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(Server.MapPath("~/Files/") + "okaynow" + ".PDF", FileMode.Create, System.IO.FileAccess.Write);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            pnlDetails.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 65, 72, 95, 20);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            MemoryStream ms = new MemoryStream();
            PdfWriter.GetInstance(pdfDoc, file);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            file.Close();
            Response.Redirect("deanpage.aspx");
        }

    }
}