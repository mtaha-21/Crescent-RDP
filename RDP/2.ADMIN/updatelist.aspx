<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="updatelist.aspx.cs" Inherits="RDP.updatelist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h5>UPDATED SCHOLAR LIST</h5>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:connstrng %>' SelectCommand="SELECT [user_id], [full_name] FROM [personal_details] WHERE status = 1"></asp:SqlDataSource>
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                         <asp:GridView class="table table-striped table-bordered" ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"  DataKeyNames="user_id" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                             <Columns>
                                 <asp:BoundField DataField="user_id" HeaderText="user_id" SortExpression="user_id" InsertVisible="False" ReadOnly="True"></asp:BoundField>
                                 <asp:BoundField DataField="full_name" HeaderText="full_name" SortExpression="full_name"></asp:BoundField>
                                 <asp:CommandField SelectText="Preview" ShowSelectButton="True" ButtonType="button"/>
                             </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>

</asp:Content>
