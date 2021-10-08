<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RRN_Genaration.aspx.cs" Inherits="RDP.RRN_Genaration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-5 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <b><label>Guide Name</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Enter Guide Name"></asp:TextBox>
                        </div>
                         <b><label>Research Topic</label></b>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Sentiment Analysis" Value="1" />
                              <asp:ListItem Text="Block Chain" Value="2" />
                              </asp:DropDownList>
                        </div>
                         <b><label>Department Name</label></b>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="CSE" Value="1" />
                              <asp:ListItem Text="BCA" Value="2" />
                              </asp:DropDownList>
                        </div>
                         <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                         <center>
                        <div class="form-group">
                           <asp:Button Border Style ="margin-top:10px" class="btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text=" Generate RRN and Submit" Width="300px" OnClick="Button1_Click" />
                        </div>
                             </center>
                        <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                     </div>
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"style="color: white" asp:Button class="btn btn-secondary" Width="100px"><< Back to Home</a><br><br>
         </div>
      </div>
   </div>
</asp:Content>
