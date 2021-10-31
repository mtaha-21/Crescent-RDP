<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="trial.aspx.cs" Inherits="RDP.trial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
  <div class="row">
                       <div class="col-md-8">
                        <b><label>RRN</label></b>
                         <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
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
                                <asp:Button Border Style ="margin-top:10px" class="btn btn-success" ID="Button3" runat="server" Text="Generate RRN" Width="210px" OnClick="Button3_Click"/>
                                </div>
                            </center>
          </div>
      </div>
        </div>
</asp:Content>
