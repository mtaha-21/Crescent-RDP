<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="RDP.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style>
        .backimg {
    background-image: url(imgs/Frontpage.png);
    width: auto;
    height: auto;
    background-repeat: no-repeat;
    background-color: white;
    background-size: cover;
}
    </style>
    <div class="backimg">
    <div class="container">
      <div class="row">
         <div class="col-md-6 mx-auto">
            <div id="loginbox" class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="150px" src="imgs/adminuser.png"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>LOGIN</h3>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <label>Admin ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Admin ID"></asp:TextBox>
                        </div>
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                         <center>
                        <div class="form-group">
                           <asp:Button border Style ="margin-top:20px" class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" Width="200px" />
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