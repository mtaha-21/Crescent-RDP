<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RRN.aspx.cs" Inherits="RDP.RRN" %>
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
                              <asp:ListItem Text="AERO" Value="Aerospace Engineering" />
                              <asp:ListItem Text="Automobile" Value="Automobile Engineering" />
                              <asp:ListItem Text="CA" Value="Chartered Accountant" />
                              <asp:ListItem Text="Chemistry" Value="Chemistry" />
                              <asp:ListItem Text="Civil" Value="Civil Engineering" />
                              <asp:ListItem Text="Commerce" Value="Commerce" />
                              <asp:ListItem Text="CSE" Value="Computer Science Egineering" />
                              <asp:ListItem Text="ECE" Value="Electrical and Communication Engineering" />
                              <asp:ListItem Text="EEE" Value="Electrical and Electronic Engineering" />
                              <asp:ListItem Text="EIE" Value="Electronic and Instrumentation Engineering" />
                              <asp:ListItem Text="English" Value="English" />
                              <asp:ListItem Text="Islamic Studies" Value="Islamic Studies" />
                              <asp:ListItem Text="IT" Value="Information Technology" />
                              <asp:ListItem Text="Maths & AS" Value="Maths & AS" />
                              <asp:ListItem Text="Mechanical" Value="Mechanical Engineering" />
                              <asp:ListItem Text="Mgt Studies" Value="Mgt Studies" />
                              <asp:ListItem Text="Physics" Value="Physics" />
                              <asp:ListItem Text="Polymer" Value="Polymer Engineering" />
                              <asp:ListItem Text="SLS" Value="SLS" />
                            </asp:DropDownList>
                        </div>
                         </div>
                        <div class="col-md-4">
                        <div class="form-group">
                            <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                              <asp:ListItem Text="Year" Value="YEAR" />
                              <asp:ListItem Text="2021" Value="2021" />
                              <asp:ListItem Text="2022" Value="2022" />
                              <asp:ListItem Text="2023" Value="2023" />
                              <asp:ListItem Text="2024" Value="2024" />
                              <asp:ListItem Text="2025" Value="2025" />
                              <asp:ListItem Text="2026" Value="2026" />
                              <asp:ListItem Text="2027" Value="2027" />
                              <asp:ListItem Text="2028" Value="2028" />
                              <asp:ListItem Text="2029" Value="2029" />
                              <asp:ListItem Text="2030" Value="2030" />
                              <asp:ListItem Text="2031" Value="2031" />
                              <asp:ListItem Text="2032" Value="2032" />
                              <asp:ListItem Text="2033" Value="2033" />
                               </asp:DropDownList>
                        </div>
                        </div>
                         <div class="col-md-4">
                         <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                              <asp:ListItem Text="Month" Value="MON" />
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
                                <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>
                                <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" ReadOnly></asp:TextBox>
                             </center>
                         </div>
                        </div>
                       <div class="col offset-8">
                           <div class="form-group">
                           <asp:Button Border Style ="margin-top:10px" class="btn btn-danger" ID="Button3" runat="server" Text="Edit" Width="100px" />
                        </div>
                        </div>
                        <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                </div>
                   <div class="row">
                       <div class="col-md-12">
                        <b><label>Department Name</label></b>
                         <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                        </div>
                           </div>
                       <div class="col-md-12">
                        <b><label>Guide Name</label></b>
                         <div class="form-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Enter guide name"></asp:TextBox>                                                    
                        </div>
                        </div>
                       <div class="col-md-12">
                        <b><label>Research Topic</label></b>
                         <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Enter research topic"></asp:TextBox>
                        </div>
                        </div>
                       </div>
                   <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                         <center>
                        <div class="form-group">
                           <asp:Button Border Style ="margin-top:10px" class="btn btn-success btn-block btn-lg" ID="Button2" runat="server" Text="Save and Send" Width="200px" />
                        </div>
                             </center>
                  
               </div>
            </div>
            <a href="homepage.aspx"style="color: white" asp:Button class="btn btn-secondary" Width="100px"><< Back to Home</a><br><br>
         </div>
      </div>
   </div>
</asp:Content>
