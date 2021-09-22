<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="RDP.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/customstylesheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .backimg {
    background-image: url(imgs/loginpage.jpg);
    width: auto;
    height: 600px;
    background-repeat: no-repeat;
    background-color: white;
    background-size: cover;
}
    </style>
    <div class="backimg">
    <div class="container">
      <div class="row">
         <div class="col-md-6 mx-auto">
            <div id="userloginbox" class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="152px" src="imgs/generaluser.png"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>STUDENT LOGIN</h3>
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
                        <label>User Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="User Name"></asp:TextBox>
                        </div>
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                         <center>
                        <div class="form-group">
                        </div>
                        <div class="form-group">
                           &nbsp;<asp:Button Border Style ="margin-top:10px" class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" Width="200px" Height="55px" />
                           <a  href="usersignup.aspx"><input Border Style ="margin-top:10px; height: 55px;" class="btn btn-info btn-block btn-lg" Id="Button2" type="button" value="Register"/></a></div>
                             </center>
                     </div>
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br><br>
         </div>
      </div>
   </div>
 </div>
</asp:Content>