<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="RDP.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <center>      
            <img src="imgs/Frontpage.png" class="responsive" />
        </center> 
   </section>
   <section>
      <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Research Application Process</h2>
                  <p><b>We have a Simple 3 Step Process</b></p>
               </center>
            </div>
         </div>
         <div class="row">
            <div class="col-md-4">
               <center>
                   
                  <img width="150px" src="imgs/Register.png" />
                  <h4>Sign Up</h4>

                 

               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/appform.png"/>
                  <h4>Fill Application Form</h4>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/approve.png"/>
                  <h4>Wait For Approval</h4>
               </center>
            </div>
         </div>
      </div>
   </section>
</asp:Content>