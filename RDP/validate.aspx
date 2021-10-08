<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="validate.aspx.cs" Inherits="RDP.validate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
      <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h5>Scholar Profile</h5>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                     <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col-md-6">
                        <b><label1>Full Name</label1></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-6">
                        <b><label1>Date Of Birth</label1></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" ReadOnly="true"></asp:TextBox>
                       
                            </div>
                     </div>
                       <div class="col-md-8">
                        <b><label1>Age</label1></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" ReadOnly="true"></asp:TextBox>
                       
                            </div>
                     </div>


                  </div>
                   <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col-md-6">
                         <b><label1>Gender</label1></b>
                        <div class="form-group">
                            <asp:TextBox class="form-control" ID="TextBox4" runat="server" ReadOnly="true"></asp:TextBox>

                        </div>
                     </div>
                   <div class="col-md-6">
                        <b><label1>Nationality</label1></b>
                       <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox5" runat="server" ReadOnly="true"></asp:TextBox>
                          </div>
                     </div>
                       <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                       </div>
                       <div class="row">
                       <div class="col-md-8">
                        <b><label1>Country</label1></b>
                        <div>
                            <asp:TextBox class="form-control" ID="TextBox6" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-8">
                         <b><label1>Passport</label1></b>
                        <div class="form-group">
                            <asp:TextBox class="form-control" ID="TextBox7" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                        <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  </div>
                   <div class="row">
                   <div class="col-md-8">
                       <b><label1>Social Status</label1></b>
                       <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox8" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                     </div>
                       <div class="col-md-8">
                        <b><label1>Marital Status</label1></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox9" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                     </div>
                   <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                       </div>
                    <div class="row">
                     <div class="col-md-8">
                         <b><label1>Telephone</label1></b>
                        <div class="form-group">
                            <asp:TextBox class="form-control" ID="TextBox10" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-8">
                       <b><label1>Mobile Number</label1></b>
                       <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox11" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                     </div>
                       <div class="col-md-8">
                        <b><label1>Email-ID</label1></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                     </div>
                   <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                    </div>
                   <div class="row">
                     <div class="col">
                         <b><label>Residential Address</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox13" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col">
                         <b><label1>Office Address</label1></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox14" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                       <div class="row">
                       <div class="col">
                         <b><label1>Address for Communication</label1></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox15" runat="server" ReadOnly="true"></asp:TextBox>
                     </div>
                  </div>
                           </div>
                   <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                    <div class="row">

                  </div>
                   
                  <div class="row">
                     <div class="col">
                        
                  <center>     
                        <div class="form-group">
                           <asp:Button Style ="margin-top:20px" class="btn btn-success btn-block btn-lg" ID="Button30" runat="server" Text="VALIDATE" Width="200px" OnClick="Button30_Click" />
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
  </div>

</asp:Content>