<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="RDP.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .backimg {
    background-image: url('../imgs/32.png');                               
    width: auto;
    height: 559px;
    background-repeat: no-repeat;
    background-color: white;
    background-size: cover;
}
    </style>
    <div class="backimg">
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-5 mx-auto">
            <div id="loginbox"  class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtun" runat="server" placeholder="User Name" required></asp:TextBox>
                        </div>
                        <br />
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtpw" runat="server" placeholder="Password" TextMode="Password" required></asp:TextBox>
                        </div>
                         <center>
                        <div class="form-group">
                           <asp:Button Style="margin-top:20px" class="btn btn-secondary btn-block btn-lg" ID="btnlogin" runat="server" Text="Login" Width="200px" OnClick="Button20" />
                        </div>
                             </center>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
   </div>
</asp:Content>