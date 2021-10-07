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
                  </div>
                   <div class="row">
                     <div class="col-md-6">
                         <label>Full Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-6">
                        <label>Date Of Birth</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" ReadOnly="true"></asp:TextBox>
                       
                            </div>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col-md-6">
                         <label>Contact No</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-6">
                        <label>Email ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" ReadOnly="true"></asp:TextBox>
                       
                            </div>
                     </div>
                  </div>


                   <div class="row">
                     <div class="col-md-4">
                         <label>State</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-4">
                        <label>City</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox6" runat="server" ReadOnly="true"></asp:TextBox>
                       
                            </div>
                     </div>
                       <div class="col-md-4">
                        <label>Pincode</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" ReadOnly="true"></asp:TextBox>
                       
                            </div>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col">
                         <label>Full Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
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

</asp:Content>