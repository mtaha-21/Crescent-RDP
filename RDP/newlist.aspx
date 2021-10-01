<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="newlist.aspx.cs" Inherits="RDP.newlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h5>NEW SCHOLAR LIST</h5>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:connstrng %>' SelectCommand="SELECT * FROM [application]"></asp:SqlDataSource>
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                         <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                             <Columns>
                                 <asp:BoundField DataField="full_name" HeaderText="Name" SortExpression="full_name"></asp:BoundField>
                                 <asp:BoundField DataField="dob" HeaderText="DOB" SortExpression="dob"></asp:BoundField>
                                 <asp:BoundField DataField="contact_no" HeaderText="Contact no" SortExpression="contact_no"></asp:BoundField>
                                 <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email"></asp:BoundField>
                                 <asp:BoundField DataField="state" HeaderText="State" SortExpression="state"></asp:BoundField>
                                 <asp:BoundField DataField="city" HeaderText="City" SortExpression="city"></asp:BoundField>
                                 <asp:BoundField DataField="pincode" HeaderText="Pincode" SortExpression="pincode"></asp:BoundField>
                                 <asp:BoundField DataField="full_address" HeaderText="Address" SortExpression="full_address"></asp:BoundField>
                                 <asp:ButtonField ButtonType="button" Text="SUBMIT" CommandName="Details" />
                             </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>

</asp:Content>
