<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RDP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:FileUpload ID="FileUpload1" runat="server" />
<br /><br />
<asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
<br /><br />
<asp:Label ID="lblMessage" runat="server"></asp:Label>
<br /><br />
<asp:HyperLink ID="hyperlink" runat="server">View Uploaded Image</asp:HyperLink>
<br /><br />
        </div>

   
    </form>
</body>
</html>
