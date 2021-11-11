<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="RDP.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script type="text/javascript">  
        function ShowPreview(input) {
            if (input.files && input.files[0]) {
                var ImageDir = new FileReader();
                ImageDir.onload = function (e) {
                    $('#impPrev').attr('src', e.target.result);
                }
                ImageDir.readAsDataURL(input.files[0]);
            }
        }
    </script> 


                        <div class="panel panel-body" style="min-height: 256px">

                            <div class="col-md-9">

                                <div class="col-md-4">
                                    <div class="btn btn-primary">
                                        
                                        <asp:FileUpload type="file" ID="imageBrowes" runat="server" onchange="ShowPreview(this)" />
                                    </div>
                                    
                                        <img src="" class="img-thumbnail" ID="impPrev" />                                      
                                    
                                </div>

                            </div>

                        </div>
    <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
 
</asp:Content>
