﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="RDP.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <center>  
            <img src="imgs/Frontpage.png" class="responsive"/>
        </center>
    
   </section>

   <section>
      <div class="container">
         <div class="row">
            <div class="col-12">
                <br />
               <center>
                  <h2><strong> Research Application Process</strong></h2>
               </center>
                <br />
            </div>
         </div>
         <div class="row">
            <div class="col-md-4">
               <center>
                        <%--svg Signup image goes here--%>
                    <%--insert a link to the SVG image file--%>
                  <div> <a href="usersignup.aspx">
  
  
                    <svg version="1.0" xmlns="http://www.w3.org/2000/svg"
 width="1308.000000pt" height="1307.000000pt" viewBox="0 0 1308.000000 1307.000000"
 preserveAspectRatio="xMidYMid meet">

<g transform="translate(0.000000,1307.000000) scale(0.100000,-0.100000)"
fill="#00000" stroke="none">
<path d="M6177 13060 c-1940 -116 -3704 -1061 -4861 -2605 -390 -520 -717
-1128 -933 -1735 -348 -978 -456 -2069 -307 -3115 329 -2323 1904 -4303 4104
-5160 994 -388 2102 -523 3180 -389 1986 247 3756 1405 4792 3134 504 842 804
1772 900 2795 20 219 17 934 -5 1155 -84 832 -286 1548 -642 2275 -558 1139
-1432 2083 -2545 2749 -204 122 -669 351 -900 442 -609 241 -1197 379 -1865
439 -205 19 -714 27 -918 15z m968 -434 c770 -84 1433 -273 2100 -601 847
-417 1603 -1043 2179 -1805 667 -884 1072 -1899 1196 -3000 184 -1642 -297
-3276 -1339 -4550 -969 -1184 -2333 -1961 -3838 -2184 -329 -49 -492 -60 -888
-61 -391 0 -525 8 -843 51 -595 80 -1191 255 -1750 513 -894 412 -1704 1068
-2305 1866 -240 319 -425 619 -607 990 -631 1280 -790 2733 -454 4135 383
1599 1424 2997 2859 3840 77 45 246 134 375 199 679 338 1420 546 2170 611 69
5 143 12 165 14 112 11 839 -3 980 -18z"/>
<path d="M6550 10714 c-135 -36 -210 -118 -210 -229 l0 -45 -117 0 c-268 0
-509 -71 -699 -206 -173 -122 -311 -357 -369 -629 -9 -38 -23 -158 -32 -265
-16 -192 -12 -356 14 -612 l6 -58 -50 0 c-110 0 -189 -44 -234 -131 -50 -94
-33 -376 36 -612 33 -114 110 -269 157 -318 54 -56 130 -91 209 -97 l66 -4 11
-43 c17 -64 51 -97 206 -200 151 -100 289 -219 412 -355 288 -319 459 -643
541 -1025 26 -125 27 -142 27 -415 0 -303 -7 -393 -51 -590 -42 -194 -112
-364 -225 -555 -146 -244 -316 -448 -492 -589 -47 -38 -86 -73 -86 -78 0 -7
3517 -16 3790 -9 206 4 334 82 393 237 21 56 22 73 21 344 0 276 -1 288 -27
385 -58 217 -158 361 -330 476 -110 74 -159 99 -447 227 -261 117 -291 127
-625 221 -324 90 -445 131 -580 196 -131 63 -194 115 -232 193 -27 56 -28 61
-32 258 -2 167 0 206 12 231 9 16 84 106 168 199 289 322 324 368 409 547 62
132 95 225 106 300 l6 47 102 0 c131 0 194 18 246 70 49 49 100 155 143 300
57 190 72 279 72 435 0 157 -13 214 -65 277 -42 51 -91 71 -190 78 -69 4 -84
8 -82 20 68 295 70 622 4 850 -143 492 -555 877 -1157 1079 -82 27 -196 59
-252 71 -195 39 -473 51 -573 24z"/>
<path d="M4170 7190 c-618 -65 -1179 -447 -1450 -988 -110 -221 -158 -413
-167 -672 -16 -486 86 -823 361 -1188 244 -324 652 -582 1046 -662 386 -79
776 -24 1145 160 171 85 296 174 433 305 276 265 443 563 522 931 27 127 38
401 21 541 -74 604 -433 1113 -984 1394 -278 142 -630 210 -927 179z m335
-781 c60 -36 60 -34 65 -399 l5 -335 335 -5 c246 -4 341 -8 357 -18 46 -26 57
-66 61 -220 4 -157 -1 -182 -49 -228 l-30 -29 -340 -3 -339 -3 0 -330 c0 -374
0 -377 -73 -410 -35 -15 -66 -19 -182 -19 -159 0 -194 11 -230 71 -19 32 -20
55 -23 362 l-3 327 -327 0 c-303 0 -329 1 -356 19 -60 40 -66 61 -66 231 0
138 2 159 20 188 39 64 58 67 412 67 l317 0 3 330 c3 296 5 334 21 358 40 62
107 78 282 70 82 -4 118 -10 140 -24z"/>
</g>
</svg>

</a>
  
</div>
                        <%--svg image ends here--%>

                  <h6>Sign Up</h6>

               </center>
            </div>
            <div class="col-md-4">
               <center>
                   <%--svg Fill the app form image goes here--%>
                    <%--insert a link to the SVG image file--%>
                  <div> <a href="usersignup.aspx">
  
                    <svg version="1.0" xmlns="http://www.w3.org/2000/svg"
 width="64.000000pt" height="64.000000pt" viewBox="0 0 64.000000 64.000000"
 preserveAspectRatio="xMidYMid meet">

<g transform="translate(0.000000,64.000000) scale(0.100000,-0.100000)"
fill="#00000" stroke="none">
<path d="M10 604 c-13 -33 -13 -305 0 -324 21 -32 30 17 30 168 l0 152 129 0
129 0 4 -55 c3 -31 10 -61 16 -67 6 -6 36 -13 67 -16 l55 -5 -2 -211 -3 -211
-73 -3 c-52 -2 -72 -6 -69 -15 6 -17 152 -16 169 1 10 10 14 70 16 238 l3 225
-72 75 -72 74 -159 0 -158 0 -10 -26z m385 -112 c-43 -6 -55 4 -55 45 l0 37
41 -39 40 -40 -26 -3z"/>
<path d="M73 538 c5 -18 169 -18 175 0 3 9 -19 12 -88 12 -69 0 -91 -3 -87
-12z"/>
<path d="M530 484 c-6 -14 -10 -104 -10 -200 0 -167 1 -177 25 -224 14 -28 30
-50 35 -50 5 0 21 22 35 50 24 47 25 57 25 224 0 210 -4 226 -60 226 -34 0
-42 -4 -50 -26z m70 -29 c0 -18 -5 -25 -20 -25 -15 0 -20 7 -20 25 0 18 5 25
20 25 15 0 20 -7 20 -25z m0 -212 c0 -87 -5 -165 -10 -173 -21 -32 -30 17 -30
173 0 150 1 157 20 157 19 0 20 -7 20 -157z"/>
<path d="M73 478 c2 -9 25 -13 67 -13 42 0 65 4 68 13 3 9 -15 12 -68 12 -53
0 -71 -3 -67 -12z"/>
<path d="M73 398 c5 -18 329 -18 335 0 3 9 -35 12 -168 12 -133 0 -171 -3
-167 -12z"/>
<path d="M73 338 c5 -18 329 -18 335 0 3 9 -35 12 -168 12 -133 0 -171 -3
-167 -12z"/>
<path d="M76 271 c-89 -59 -89 -183 0 -242 35 -23 104 -25 144 -4 92 47 92
203 0 250 -40 21 -109 19 -144 -4z m159 -61 c6 -10 -82 -140 -95 -140 -3 0
-23 21 -44 46 -30 35 -36 48 -26 57 9 9 18 4 40 -21 l28 -34 38 51 c39 52 48
59 59 41z"/>
<path d="M273 278 c2 -9 25 -13 67 -13 42 0 65 4 68 13 3 9 -15 12 -68 12 -53
0 -71 -3 -67 -12z"/>
<path d="M333 98 c2 -7 19 -13 37 -13 18 0 35 6 38 13 2 8 -9 12 -38 12 -29 0
-40 -4 -37 -12z"/>
</g>
</svg>
</a>
  
</div>
                        <%--svg image ends here--%>
                  <h6>Fill Application Form</h6>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <%--svg "Wait for approval" image goes here--%>
                    <%--insert a link to the SVG image file--%>
                  <div> <a href="usersignup.aspx">
  
                    <svg version="1.0" xmlns="http://www.w3.org/2000/svg"
 width="24.000000pt" height="24.000000pt" viewBox="0 0 24.000000 24.000000"
 preserveAspectRatio="xMidYMid meet">

<g transform="translate(0.000000,24.000000) scale(0.100000,-0.100000)"
fill="#00000" stroke="none">
<path d="M20 140 l0 -80 80 0 80 0 0 80 0 80 -80 0 -80 0 0 -80z m101 -3 c-29
-30 -31 -30 -50 -13 -23 21 -18 44 5 25 12 -10 19 -8 36 9 12 11 26 18 31 15
5 -3 -5 -19 -22 -36z"/>
<path d="M200 110 l0 -70 -70 0 c-40 0 -70 -4 -70 -10 0 -6 33 -10 80 -10 l80
0 0 80 c0 47 -4 80 -10 80 -6 0 -10 -30 -10 -70z"/>
</g>
</svg>
</a>
  
</div>
                        <%--svg image ends here--%>
                  <h6>Wait For Approval</h6>       
               </center>
                <br/>
            </div>
         </div>
      </div>
   </section>
        <footer>
                    <div id="footer1" class="container-fluid">
                <div class="row">
                    <div class="col-xs-12 col-sm-12 col-md-12 text-center">
                        <p>
                                     <!-- Footer button code -->                     
                            <asp:LinkButton class="footerlinks" ID="LinkButton6" runat="server">Admin Login</asp:LinkButton>
                            &nbsp;
                                     <!-- Footer button ends code -->
                        </p>

                    </div>

                </div>
            </div>
    </footer>
</asp:Content>