<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PDF.aspx.cs" Inherits="RDP.PDF" %>

<!DOCTYPE html>

<html>
<head>
<meta charset="UTF-8">
<link href="https://fonts.googleapis.com/css?family=Open+Sans" rel="stylesheet" type="text/css">
<title>Lob.com Sample 8.5x11 Letter</title>
<style>
  *, *:before, *:after {
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
  }

  body {
    width: 8.5in;
    height: 11in;
    margin: 0;
    padding: 0;
  }

  .page {
    page-break-after: always;
    position: relative;
    width: 8.3in;
    height: 11.7in;
  }

  .page-content {
    position: absolute;
    width: 8.125in;
    height: 10.625in;
    left: 0.1875in;
    top: 0.1875in;
    background-color: rgba(0,0,0,0.2);
  }

  .text {
    position: relative;
    left: 50px;
    top: 20px;
    width: 6in;
    font-family: 'Open Sans';
    font-size: 11px;
  }

  #return-address-window {
    position: absolute;
    left: .625in;
    top: .5in;
    width: 3.25in;
    height: .875in;
    background-color: rgba(255,0,0,0.5);
  }

  #return-logo {
    position: absolute;
    left: .07in;
    top: .02in;
    width: 2.05in;
    height: .3in;
  }

</style>
</head>

<body>
  <div class="page">
    <div class="page-content">
      <div class="text" style="top: 1.5in">

<pre>
    Name of the Scholar is provisionally registered for Ph.D. programme under Full Time mode in the 
    Department of -------- of our Institute during July 2021 session under your supervision. The 
    broad area / topic of research is “-----------------------------------------”.
    .
        You are requested to strictly follow the provisions of Regulations 2016 for Ph.D. Programme. 
    As per clause 13.0, a Doctoral Committee will have to be formed. For this, you have to propose 
    names of four experts with doctoral qualifications, two from our Institute (from Other Schools) 
    and the names of two outside experts. On receipt of your proposal in the prescribed format, an 
    order will be issued constituting the Doctoral Committee, by the undersigned.
            
        Regarding course work, you may refer to clause 14.0 of the Ph.D. Regulations 2016. Minimum 
    no. of courses for 10 credits shall be prescribed by the Doctoral Committee. Of these courses, the 
    courses on “Research Methodology” & “Research and Publication Ethics” are the mandatory requirement.
    As the Doctoral Committee is to meet within three weeks from the date of communication of provisional
    registration of the candidate, kindly send your proposal within 10 days to enable Dean (R) to issue 
    orders forming the Doctoral Committee.

    Refer the link for Ph.D. Regulations https://crescent.education/research/about-us/ph-d-regulation/

    The Roll cum Registration Number allocated to the Research Scholar is “--------------------------”.

</pre>  2
      </div>
    </div>
    <div id="return-address-window">
      <div id="return-logo">
        logo.
      </div>
    </div>
  </div>
</body>

</html>