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
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:connstrng %>' SelectCommand="SELECT [full_name], [user_id] FROM [personal_details] WHERE status = 0"></asp:SqlDataSource>
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                         <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                             <Columns>
                                 <asp:BoundField DataField="user_id" HeaderText="Roll no" SortExpression="user_id"></asp:BoundField>
                                 <asp:BoundField DataField="full_name" HeaderText="Name" SortExpression="full_name"></asp:BoundField>
                                 <asp:CommandField ShowSelectButton="True" SelectText="VIEW" ButtonType="button"></asp:CommandField>
                             </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>

</asp:Content>
