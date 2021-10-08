<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Mailu.aspx.cs" Inherits="RDP.Mailu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
    <script src="https://smtpjs.com/v3/smtp.js">
     </script> 
    <script src="index.js"></script>
    <body>
	<form method="post">
		<center><input type="button" value="Send Email" onclick="sendEmail()"/></center>
	</form>  
  </body>
</head>
</asp:Content>
