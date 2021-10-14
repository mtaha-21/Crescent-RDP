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
                              <asp:ListItem Text="EEE" Value="Electrical and Electronic Engineering" />
                              <asp:ListItem Text="ECE" Value="Electrical and Communication Engineering" />
                              <asp:ListItem Text="AERO" Value="Aeronautical Engineering" />
                              <asp:ListItem Text="POLY" Value="Polymer Engineering" />
                              <asp:ListItem Text="MECH" Value="Mechanical Engineering" />
                              <asp:ListItem Text="CSE" Value="Computer Science Engineering" />
                              <asp:ListItem Text="MCA" Value="Master of Computer Applications" />
                              <asp:ListItem Text="MSC" Value="Master of Science" />
                              <asp:ListItem Text="MA" Value="Master of Arts" />
                              <asp:ListItem Text="MCOM" Value="Master of Commerce" />
                            </asp:DropDownList>
                        </div>
                         </div>
                        <div class="col-md-4">
                        <div class="form-group">
                            <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                              <asp:ListItem Text="Year" Value="Year" />
                              <asp:ListItem Text="2000" Value="2000" />
                              <asp:ListItem Text="2001" Value="2001" />
                              <asp:ListItem Text="2002" Value="2002" />
                              <asp:ListItem Text="2003" Value="2003" />
                              <asp:ListItem Text="2004" Value="2004" />
                              <asp:ListItem Text="2005" Value="2005" />
                              <asp:ListItem Text="2006" Value="2006" />
                              <asp:ListItem Text="2007" Value="2007" />
                              <asp:ListItem Text="2008" Value="2008" />
                              <asp:ListItem Text="2009" Value="2009" />
                              <asp:ListItem Text="2010" Value="2010" />
                              <asp:ListItem Text="2011" Value="2011" />
                              <asp:ListItem Text="2012" Value="2012" />
                              <asp:ListItem Text="2013" Value="2013" />
                              <asp:ListItem Text="2014" Value="2014" />
                              <asp:ListItem Text="2015" Value="2015" />
                              <asp:ListItem Text="2016" Value="2016" />
                              <asp:ListItem Text="2017" Value="2017" />
                              <asp:ListItem Text="2018" Value="2018" />
                              <asp:ListItem Text="2019" Value="2019" />
                              <asp:ListItem Text="2020" Value="2020" />
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
                               </asp:DropDownList>
                        </div>
                        </div>
                         <div class="col-md-4">
                         <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                              <asp:ListItem Text="Month" Value="Month" />
                              <asp:ListItem Text="January" Value="1" />
                              <asp:ListItem Text="February" Value="2" />
                              <asp:ListItem Text="March" Value="3" />
                              <asp:ListItem Text="April" Value="4" />
                              <asp:ListItem Text="May" Value="5" />
                              <asp:ListItem Text="June" Value="6" />
                              <asp:ListItem Text="July" Value="7" />
                              <asp:ListItem Text="August" Value="8" />
                              <asp:ListItem Text="September" Value="9" />
                              <asp:ListItem Text="October" Value="10" />
                              <asp:ListItem Text="November" Value="11" />
                              <asp:ListItem Text="December" Value="12" />
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
                                <asp:Button Border Style ="margin-top:10px" class="btn btn-success" ID="Button1" runat="server" Text="Generate RRN" Width="210px"/>
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
                                 <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Generated RRN"></asp:TextBox>
                             </center>
                         </div>
                        </div>
                       <div class="col offset-8">
                           <div class="form-group">
                           <asp:Button Border Style ="margin-top:10px" class="btn btn-info" ID="Button3" runat="server" Text="Edit" Width="100px" />
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
