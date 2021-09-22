<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="RDP.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container">
      <div class="row">
         <div class="col-md-5 mx-auto">
            <div id="sgbg" class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                            <img width=150px src="imgs/2063715.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Admin Login</h3>
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
                        <b><label>Admin ID</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Admin ID"></asp:TextBox>
                        </div>
                        <b><label>Password</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                         <center>
                        <div class="form-group">
                           <asp:Button Border Style ="margin-top:20px" class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" Width="200px" />
                        </div>
                             </center>
                     </div>
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"style="color:yellow"><< Back to Home</a><br><br>
         </div>
      </div>
   </div>
</asp:Content>