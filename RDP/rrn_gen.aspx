<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="rrn_gen.aspx.cs" Inherits="RDP.rrn_gen" %>
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
                         <b><label1>VALIDATED SCHOLAR</label1></b>
                        <hr>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col">

                        <b><label1>RRN</label1></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" readonly="true"></asp:TextBox>
                        </div>

                       <b><label1>NAME</label1></b>
                         <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" readonly="true"></asp:TextBox>
                        </div>

                        <b><label1>Guide Name</label1></b>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Option 1" Value="text" />
                              <asp:ListItem Text="Option 2" Value="text" />
                              </asp:DropDownList>
                        </div>
                         <b><label1>Research Topic</label1></b>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Option 1" Value="text" />
                              <asp:ListItem Text="Option 2" Value="text" />
                              </asp:DropDownList>
                        </div>
                         <b><label1>Department Name</label1></b>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Option 1" Value="text" />
                              <asp:ListItem Text="Option 2" Value="text" />
                              </asp:DropDownList>
                        </div>
                         <div class="row">
                           <div class="col">
                        <hr>
                          </div>
                       </div>
                         <center>
                        <div class="form-group">
                            <asp:Button Style ="margin-top:10px" class="btn btn-success btn-block btn-lg" ID="Button5" runat="server" Text="Generate RRN" Width="200px" OnClick="Button5_Click" />
                           <asp:Button Style ="margin-top:10px" class="btn btn-success btn-block btn-lg" ID="Button4" runat="server" Text="Send" Width="200px" OnClick="Button4_Click" />
                        </div>
                         </center>
                   </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>

</asp:Content>
