<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="RDP.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-5 mx-auto">
            <div id="userlogin" class="card">
               <div class="card-body">
                <!DOCTYPE html>
<head>
    <title>
        How to get selected value in 
        dropdown list using JavaScript?
    </title>
</head>
  
<body>
    <h1 style="color: green">
        GeeksForGeeks
    </h1>
      
    <b>
        How to get selected value in 
        dropdown list using JavaScript?
    </b>
      
    <p>
        Select one from the given options:
        <select id="select1">
            <option value="free">Free</option>
            <option value="basic">Basic</option>
            <option value="premium">Premium</option>
        </select>
    </p>
      
    <p>
        The value of the option selected is: 
        <span class="output"></span>
    </p>
      
    <button onclick="getOption()">
        Check option
    </button>
      
    <script type="text/javascript">s
        function getOption() {
            selectElement = document.querySelector('#select1');

            output =
                selectElement.options[selectElement.selectedIndex].value;

            document.querySelector('.output').textContent = output;
        }
    </script>
</body>
  
</html>
                   </div>
                </div>
             </div>
          </div>
        </div>
</asp:Content>
