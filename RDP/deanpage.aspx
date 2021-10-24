<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="deanpage.aspx.cs" Inherits="RDP.deanpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <center>
    <p>YOU ARE IN DEAN PAGE</p>
                  <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h5>SCHOLAR LIST TO BE APPROVED</h5>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:connstrng %>' SelectCommand="SELECT [role_no], [full_name] FROM [personal_details] WHERE status = 1"></asp:SqlDataSource>
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                         <asp:GridView class="table table-striped table-bordered" ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="role_no" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                             <Columns>
                                 <asp:BoundField DataField="role_no" HeaderText="role_no" SortExpression="role_no" InsertVisible="False" ReadOnly="True"></asp:BoundField>
                                 <asp:BoundField DataField="full_name" HeaderText="full_name" SortExpression="full_name"></asp:BoundField>
                                 <asp:CommandField SelectText="Approve" ShowSelectButton="True" ButtonType="button"/>
                             </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
       </center>
</asp:Content>
