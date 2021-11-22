<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Thankyou.aspx.cs" Inherits="RDP.Thankyou" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .backimg {
    background-image:url('../imgs/c8e0e0.png');
    width: auto;
    height: 600px;
    background-repeat: no-repeat;
    background-color: white;
    background-size: cover;
}
    </style>
    <div class="backimg">
        <br /><br /><br />
    <center>
        <img id="tq" src="imgs/226-2268087_blue-check-mark-png.png" width="200px" height="200px"/>
    </center>
    <br />
    <center>
        <h3 style="color:forestgreen;">Thank you!</h3>
        <br />
        <h3 style="color: black;">Your form has been Submitted Successfully</h3>
        <h3><a style="color: darkblue;" href="homepage.aspx">Go back</a></h3>
    </center>
    </div>
</asp:Content>
