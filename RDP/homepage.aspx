<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="RDP.homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .backimg {
            background-image: url(imgs/loginpage.jpg);
            width: auto;
            height: 559px;
            background-repeat: no-repeat;
            background-color: white;
            background-size: cover;
        }
    </style>
    <div class="backimg">
        <div class="container">
            <div class="row">
                <div id="check" class="col-md-4 offset-7">
                    <div id="loginbox" class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h3>LOGIN</h3>
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <label>Enter User Name</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtun" runat="server" placeholder="User Name"></asp:TextBox>
                                    </div>
                                    <label>Enter Password</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtpw" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <center>
                                        <div class="form-group">
                                            <asp:Button Style="margin-top: 20px" class="btn btn-success btn-block btn-lg" ID="btnlogin" runat="server" Text="Login" Width="200px" OnClick="Button20" />
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
</asp:Content>
