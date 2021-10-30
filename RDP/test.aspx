<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="RDP.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-5 mx-auto">
            <div id="userlogin" class="card">
               <div class="card-body">
                   <div class="row">
                     <div class="col-md-4">
                        <div class="form-group">
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack = "true" OnSelectedIndexChanged = "DropDownList1_SelectedIndexChanged">
                          <asp:ListItem Text="Department" Value="department" />
                              <asp:ListItem Text="EEE" Value="Electrical and Electronic Engineering" />
                              <asp:ListItem Text="ECE" Value="Electrical and Communication Engineering" />
                            </asp:DropDownList>
                        </div>
                         </div>
                        <div class="col-md-4">
                        <div class="form-group">
                            <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                              <asp:ListItem Text="Year" Value="YEAR" />
                              <asp:ListItem Text="2021" Value="2021" />
                              <asp:ListItem Text="2022" Value="2022" />
                               </asp:DropDownList>
                        </div>
                        </div>
                         <div class="col-md-4">
                         <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                              <asp:ListItem Text="Month" Value="Month" />
                              <asp:ListItem Text="May" Value="MAY" />
                              <asp:ListItem Text="December" Value="DEC" />
                               </asp:DropDownList>
                        </div>
                        </div>
                      </div>
                   <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   <div class="row">
                            <center>
                                <div class="form-group">
                                <asp:Button Border Style ="margin-top:10px" class="btn btn-success" ID="Button1" runat="server" Text="Generate RRN" Width="210px" OnClick="Button1_Click"/>
                                </div>
                            </center>
                       <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                       <div class="col-md-6 offset-3">
                         <div class="form-group">
                             <center>
                                 <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" readonly></asp:TextBox>
                             </center>
                         </div>
                        </div>
                        <div class="row">
                       <div class="col-md-12">
                        <b><label>Department Name</label></b>
                         <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                        </div>
                           </div>
                            </div>
                   </div>
                </div>
             </div>
          </div>
        </div>
        </div>
</asp:Content>
