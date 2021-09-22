<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RRN.aspx.cs" Inherits="RDP.RRN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
<html>
<head>
  <title>Javascript Arrays</title>
  <script type="text/Javascript">

var array = [];
function addtolist(){
    var fname = document.getElementById("fname").value;
    var roll = document.getElementById("rNo").value;
    array.push({
      fname: fname,
      roll: roll
    });
    alert ("Ok, " + fname + " added in the class list with roll no. " + roll);

    for (var i = 0; i<array.length; i++){
      console.log(i, 'kk')
        document.write("</br>"+ fname + ":" + roll);
    }
}

  </script>
</head>
<body>
  <h1 id= "title">Roll No. Entry</h1>
  <p1> Enter Roll No. and First Name and Click Submit </p1><br><br>
  <label for="fname"> First Name: </label><br>
  <input type="text" id="fname" name="fname"/><br>
  <label for="rNo"> Roll No: </label><br>
  <input type="number" id="rNo" name="rNo"/><br><br>
  <input type="submit" value="Submit" onclick="addtolist()">
  
</body>
</html>






































</asp:Content>
