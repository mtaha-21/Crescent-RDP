<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="mailmerge.aspx.cs" Inherits="RDP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">         

    <asp:Button Border Style ="margin-top:10px; height: 55px;" class="btn btn-info btn-block btn-lg" Button ID="btnSendMail" runat="server" Text="send mail" OnClick="btnSendMail_Click" />
    <br />

    <asp:Label ID="Label1" runat="server"></asp:Label>

</asp:Content>
