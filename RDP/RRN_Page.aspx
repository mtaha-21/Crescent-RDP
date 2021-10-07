<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RRN_Page.aspx.cs" Inherits="RDP.RRN_Page" %>
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
                        <b><label>RRN</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="RRN"></asp:TextBox>
                        </div>
                        <b><label>Guide Name</label></b>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="ST" Value="ST" />
                              <asp:ListItem Text="SC" Value="SC" />
                              </asp:DropDownList>
                        </div>
                         <b><label>Research Topic</label></b>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="ST" Value="ST" />
                              <asp:ListItem Text="SC" Value="SC" />
                              </asp:DropDownList>
                        </div>
                         <b><label>Department Name</label></b>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="ST" Value="ST" />
                              <asp:ListItem Text="SC" Value="SC" />
                              </asp:DropDownList>
                        </div>
                         <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                         <center>
                        <div class="form-group">
                           <asp:Button Border Style ="margin-top:10px" class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Submit" Width="200px" />
                        </div>
                             </center>
                     </div>
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"style="color: white" asp:Button class="btn btn-secondary" Width="100px"><< Back to Home</a><br><br>
         </div>
      </div>
   </div>
  </div>
</asp:Content>
