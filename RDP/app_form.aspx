<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="app_form.aspx.cs" Inherits="RDP.app_form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" />
    <div class="row">
        <div class="col-md-8 mx-auto">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col">
                            <center>
                                <h5>APPLICATION FORM</h5>
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <hr>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <b>
                                <label1>Full Name</label1></b>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Enter your full name"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <b>
                                <label1>Date Of Birth</label1></b>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Date"></asp:TextBox>

                            </div>
                        </div>
                        <div class="col-md-8">
                            <b>
                                <label1>Age</label1></b>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox14" runat="server" placeholder="Enter your age" TextMode="Number"></asp:TextBox>

                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <b>
                                    <label1>Gender</label1></b>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList20" runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                                        <asp:ListItem Text="Male" Value="Male" />
                                        <asp:ListItem Text="Female" Value="Female" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <b>
                                    <label1>Nationality</label1></b>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList19" runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                                        <asp:ListItem Text="India" Value="India" />
                                        <asp:ListItem Text="Foreign" Value="Foreign" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-8">
                                <b>
                                    <label1>If Foreign, Enter your Country</label1></b>
                                <div class="form-group">
                                    <asp:DropDownList ID="Country" runat="server">

                                        <asp:ListItem Value="AF">Afghanistan</asp:ListItem>

                                        <asp:ListItem Value="AL">Albania</asp:ListItem>

                                        <asp:ListItem Value="DZ">Algeria</asp:ListItem>

                                        <asp:ListItem Value="AS">American Samoa</asp:ListItem>

                                        <asp:ListItem Value="AD">Andorra</asp:ListItem>

                                        <asp:ListItem Value="AO">Angola</asp:ListItem>

                                        <asp:ListItem Value="AI">Anguilla</asp:ListItem>

                                        <asp:ListItem Value="AQ">Antarctica</asp:ListItem>

                                        <asp:ListItem Value="AG">Antigua And Barbuda</asp:ListItem>

                                        <asp:ListItem Value="AR">Argentina</asp:ListItem>

                                        <asp:ListItem Value="AM">Armenia</asp:ListItem>

                                        <asp:ListItem Value="AW">Aruba</asp:ListItem>

                                        <asp:ListItem Value="AU">Australia</asp:ListItem>

                                        <asp:ListItem Value="AT">Austria</asp:ListItem>

                                        <asp:ListItem Value="AZ">Azerbaijan</asp:ListItem>

                                        <asp:ListItem Value="BS">Bahamas</asp:ListItem>

                                        <asp:ListItem Value="BH">Bahrain</asp:ListItem>

                                        <asp:ListItem Value="BD">Bangladesh</asp:ListItem>

                                        <asp:ListItem Value="BB">Barbados</asp:ListItem>

                                        <asp:ListItem Value="BY">Belarus</asp:ListItem>

                                        <asp:ListItem Value="BE">Belgium</asp:ListItem>

                                        <asp:ListItem Value="BZ">Belize</asp:ListItem>

                                        <asp:ListItem Value="BJ">Benin</asp:ListItem>

                                        <asp:ListItem Value="BM">Bermuda</asp:ListItem>

                                        <asp:ListItem Value="BT">Bhutan</asp:ListItem>

                                        <asp:ListItem Value="BO">Bolivia</asp:ListItem>

                                        <asp:ListItem Value="BA">Bosnia And Herzegowina</asp:ListItem>

                                        <asp:ListItem Value="BW">Botswana</asp:ListItem>

                                        <asp:ListItem Value="BV">Bouvet Island</asp:ListItem>

                                        <asp:ListItem Value="BR">Brazil</asp:ListItem>

                                        <asp:ListItem Value="IO">British Indian Ocean Territory</asp:ListItem>

                                        <asp:ListItem Value="BN">Brunei Darussalam</asp:ListItem>

                                        <asp:ListItem Value="BG">Bulgaria</asp:ListItem>

                                        <asp:ListItem Value="BF">Burkina Faso</asp:ListItem>

                                        <asp:ListItem Value="BI">Burundi</asp:ListItem>

                                        <asp:ListItem Value="KH">Cambodia</asp:ListItem>

                                        <asp:ListItem Value="CM">Cameroon</asp:ListItem>

                                        <asp:ListItem Value="CA">Canada</asp:ListItem>

                                        <asp:ListItem Value="CV">Cape Verde</asp:ListItem>

                                        <asp:ListItem Value="KY">Cayman Islands</asp:ListItem>

                                        <asp:ListItem Value="CF">Central African Republic</asp:ListItem>

                                        <asp:ListItem Value="TD">Chad</asp:ListItem>

                                        <asp:ListItem Value="CL">Chile</asp:ListItem>

                                        <asp:ListItem Value="CN">China</asp:ListItem>

                                        <asp:ListItem Value="CX">Christmas Island</asp:ListItem>

                                        <asp:ListItem Value="CC">Cocos (Keeling) Islands</asp:ListItem>

                                        <asp:ListItem Value="CO">Colombia</asp:ListItem>

                                        <asp:ListItem Value="KM">Comoros</asp:ListItem>

                                        <asp:ListItem Value="CG">Congo</asp:ListItem>

                                        <asp:ListItem Value="CK">Cook Islands</asp:ListItem>

                                        <asp:ListItem Value="CR">Costa Rica</asp:ListItem>

                                        <asp:ListItem Value="CI">Cote D'Ivoire</asp:ListItem>

                                        <asp:ListItem Value="HR">Croatia (Local Name: Hrvatska)</asp:ListItem>

                                        <asp:ListItem Value="CU">Cuba</asp:ListItem>

                                        <asp:ListItem Value="CY">Cyprus</asp:ListItem>

                                        <asp:ListItem Value="CZ">Czech Republic</asp:ListItem>

                                        <asp:ListItem Value="DK">Denmark</asp:ListItem>

                                        <asp:ListItem Value="DJ">Djibouti</asp:ListItem>

                                        <asp:ListItem Value="DM">Dominica</asp:ListItem>

                                        <asp:ListItem Value="DO">Dominican Republic</asp:ListItem>

                                        <asp:ListItem Value="TP">East Timor</asp:ListItem>

                                        <asp:ListItem Value="EC">Ecuador</asp:ListItem>

                                        <asp:ListItem Value="EG">Egypt</asp:ListItem>

                                        <asp:ListItem Value="SV">El Salvador</asp:ListItem>

                                        <asp:ListItem Value="GQ">Equatorial Guinea</asp:ListItem>

                                        <asp:ListItem Value="ER">Eritrea</asp:ListItem>

                                        <asp:ListItem Value="EE">Estonia</asp:ListItem>

                                        <asp:ListItem Value="ET">Ethiopia</asp:ListItem>

                                        <asp:ListItem Value="FK">Falkland Islands (Malvinas)</asp:ListItem>

                                        <asp:ListItem Value="FO">Faroe Islands</asp:ListItem>

                                        <asp:ListItem Value="FJ">Fiji</asp:ListItem>

                                        <asp:ListItem Value="FI">Finland</asp:ListItem>

                                        <asp:ListItem Value="FR">France</asp:ListItem>

                                        <asp:ListItem Value="GF">French Guiana</asp:ListItem>

                                        <asp:ListItem Value="PF">French Polynesia</asp:ListItem>

                                        <asp:ListItem Value="TF">French Southern Territories</asp:ListItem>

                                        <asp:ListItem Value="GA">Gabon</asp:ListItem>

                                        <asp:ListItem Value="GM">Gambia</asp:ListItem>

                                        <asp:ListItem Value="GE">Georgia</asp:ListItem>

                                        <asp:ListItem Value="DE">Germany</asp:ListItem>

                                        <asp:ListItem Value="GH">Ghana</asp:ListItem>

                                        <asp:ListItem Value="GI">Gibraltar</asp:ListItem>

                                        <asp:ListItem Value="GR">Greece</asp:ListItem>

                                        <asp:ListItem Value="GL">Greenland</asp:ListItem>

                                        <asp:ListItem Value="GD">Grenada</asp:ListItem>

                                        <asp:ListItem Value="GP">Guadeloupe</asp:ListItem>

                                        <asp:ListItem Value="GU">Guam</asp:ListItem>

                                        <asp:ListItem Value="GT">Guatemala</asp:ListItem>

                                        <asp:ListItem Value="GN">Guinea</asp:ListItem>

                                        <asp:ListItem Value="GW">Guinea-Bissau</asp:ListItem>

                                        <asp:ListItem Value="GY">Guyana</asp:ListItem>

                                        <asp:ListItem Value="HT">Haiti</asp:ListItem>

                                        <asp:ListItem Value="HM">Heard And Mc Donald Islands</asp:ListItem>

                                        <asp:ListItem Value="VA">Holy See (Vatican City State)</asp:ListItem>

                                        <asp:ListItem Value="HN">Honduras</asp:ListItem>

                                        <asp:ListItem Value="HK">Hong Kong</asp:ListItem>

                                        <asp:ListItem Value="HU">Hungary</asp:ListItem>

                                        <asp:ListItem Value="IS">Icel And</asp:ListItem>

                                        <asp:ListItem Value="IN">India</asp:ListItem>

                                        <asp:ListItem Value="ID">Indonesia</asp:ListItem>

                                        <asp:ListItem Value="IR">Iran (Islamic Republic Of)</asp:ListItem>

                                        <asp:ListItem Value="IQ">Iraq</asp:ListItem>

                                        <asp:ListItem Value="IE">Ireland</asp:ListItem>

                                        <asp:ListItem Value="IL">Israel</asp:ListItem>

                                        <asp:ListItem Value="IT">Italy</asp:ListItem>

                                        <asp:ListItem Value="JM">Jamaica</asp:ListItem>

                                        <asp:ListItem Value="JP">Japan</asp:ListItem>

                                        <asp:ListItem Value="JO">Jordan</asp:ListItem>

                                        <asp:ListItem Value="KZ">Kazakhstan</asp:ListItem>

                                        <asp:ListItem Value="KE">Kenya</asp:ListItem>

                                        <asp:ListItem Value="KI">Kiribati</asp:ListItem>

                                        <asp:ListItem Value="KP">Korea, Dem People'S Republic</asp:ListItem>

                                        <asp:ListItem Value="KR">Korea, Republic Of</asp:ListItem>

                                        <asp:ListItem Value="KW">Kuwait</asp:ListItem>

                                        <asp:ListItem Value="KG">Kyrgyzstan</asp:ListItem>

                                        <asp:ListItem Value="LA">Lao People'S Dem Republic</asp:ListItem>

                                        <asp:ListItem Value="LV">Latvia</asp:ListItem>

                                        <asp:ListItem Value="LB">Lebanon</asp:ListItem>

                                        <asp:ListItem Value="LS">Lesotho</asp:ListItem>

                                        <asp:ListItem Value="LR">Liberia</asp:ListItem>

                                        <asp:ListItem Value="LY">Libyan Arab Jamahiriya</asp:ListItem>

                                        <asp:ListItem Value="LI">Liechtenstein</asp:ListItem>

                                        <asp:ListItem Value="LT">Lithuania</asp:ListItem>

                                        <asp:ListItem Value="LU">Luxembourg</asp:ListItem>

                                        <asp:ListItem Value="MO">Macau</asp:ListItem>

                                        <asp:ListItem Value="MK">Macedonia</asp:ListItem>

                                        <asp:ListItem Value="MG">Madagascar</asp:ListItem>

                                        <asp:ListItem Value="MW">Malawi</asp:ListItem>

                                        <asp:ListItem Value="MY">Malaysia</asp:ListItem>

                                        <asp:ListItem Value="MV">Maldives</asp:ListItem>

                                        <asp:ListItem Value="ML">Mali</asp:ListItem>

                                        <asp:ListItem Value="MT">Malta</asp:ListItem>

                                        <asp:ListItem Value="MH">Marshall Islands</asp:ListItem>

                                        <asp:ListItem Value="MQ">Martinique</asp:ListItem>

                                        <asp:ListItem Value="MR">Mauritania</asp:ListItem>

                                        <asp:ListItem Value="MU">Mauritius</asp:ListItem>

                                        <asp:ListItem Value="YT">Mayotte</asp:ListItem>

                                        <asp:ListItem Value="MX">Mexico</asp:ListItem>

                                        <asp:ListItem Value="FM">Micronesia, Federated States</asp:ListItem>

                                        <asp:ListItem Value="MD">Moldova, Republic Of</asp:ListItem>

                                        <asp:ListItem Value="MC">Monaco</asp:ListItem>

                                        <asp:ListItem Value="MN">Mongolia</asp:ListItem>

                                        <asp:ListItem Value="MS">Montserrat</asp:ListItem>

                                        <asp:ListItem Value="MA">Morocco</asp:ListItem>

                                        <asp:ListItem Value="MZ">Mozambique</asp:ListItem>

                                        <asp:ListItem Value="MM">Myanmar</asp:ListItem>

                                        <asp:ListItem Value="NA">Namibia</asp:ListItem>

                                        <asp:ListItem Value="NR">Nauru</asp:ListItem>

                                        <asp:ListItem Value="NP">Nepal</asp:ListItem>

                                        <asp:ListItem Value="NL">Netherlands</asp:ListItem>

                                        <asp:ListItem Value="AN">Netherlands Ant Illes</asp:ListItem>

                                        <asp:ListItem Value="NC">New Caledonia</asp:ListItem>

                                        <asp:ListItem Value="NZ" Selected="True">New Zealand</asp:ListItem>

                                        <asp:ListItem Value="NI">Nicaragua</asp:ListItem>

                                        <asp:ListItem Value="NE">Niger</asp:ListItem>

                                        <asp:ListItem Value="NG">Nigeria</asp:ListItem>

                                        <asp:ListItem Value="NU">Niue</asp:ListItem>

                                        <asp:ListItem Value="NF">Norfolk Island</asp:ListItem>

                                        <asp:ListItem Value="MP">Northern Mariana Islands</asp:ListItem>

                                        <asp:ListItem Value="NO">Norway</asp:ListItem>

                                        <asp:ListItem Value="OM">Oman</asp:ListItem>

                                        <asp:ListItem Value="PK">Pakistan</asp:ListItem>

                                        <asp:ListItem Value="PW">Palau</asp:ListItem>

                                        <asp:ListItem Value="PA">Panama</asp:ListItem>

                                        <asp:ListItem Value="PG">Papua New Guinea</asp:ListItem>

                                        <asp:ListItem Value="PY">Paraguay</asp:ListItem>

                                        <asp:ListItem Value="PE">Peru</asp:ListItem>

                                        <asp:ListItem Value="PH">Philippines</asp:ListItem>

                                        <asp:ListItem Value="PN">Pitcairn</asp:ListItem>

                                        <asp:ListItem Value="PL">Poland</asp:ListItem>

                                        <asp:ListItem Value="PT">Portugal</asp:ListItem>

                                        <asp:ListItem Value="PR">Puerto Rico</asp:ListItem>

                                        <asp:ListItem Value="QA">Qatar</asp:ListItem>

                                        <asp:ListItem Value="RE">Reunion</asp:ListItem>

                                        <asp:ListItem Value="RO">Romania</asp:ListItem>

                                        <asp:ListItem Value="RU">Russian Federation</asp:ListItem>

                                        <asp:ListItem Value="RW">Rwanda</asp:ListItem>

                                        <asp:ListItem Value="KN">Saint K Itts And Nevis</asp:ListItem>

                                        <asp:ListItem Value="LC">Saint Lucia</asp:ListItem>

                                        <asp:ListItem Value="VC">Saint Vincent, The Grenadines</asp:ListItem>

                                        <asp:ListItem Value="WS">Samoa</asp:ListItem>

                                        <asp:ListItem Value="SM">San Marino</asp:ListItem>

                                        <asp:ListItem Value="ST">Sao Tome And Principe</asp:ListItem>

                                        <asp:ListItem Value="SA">Saudi Arabia</asp:ListItem>

                                        <asp:ListItem Value="SN">Senegal</asp:ListItem>

                                        <asp:ListItem Value="SC">Seychelles</asp:ListItem>

                                        <asp:ListItem Value="SL">Sierra Leone</asp:ListItem>

                                        <asp:ListItem Value="SG">Singapore</asp:ListItem>

                                        <asp:ListItem Value="SK">Slovakia (Slovak Republic)</asp:ListItem>

                                        <asp:ListItem Value="SI">Slovenia</asp:ListItem>

                                        <asp:ListItem Value="SB">Solomon Islands</asp:ListItem>

                                        <asp:ListItem Value="SO">Somalia</asp:ListItem>

                                        <asp:ListItem Value="ZA">South Africa</asp:ListItem>

                                        <asp:ListItem Value="GS">South Georgia , S Sandwich Is.</asp:ListItem>

                                        <asp:ListItem Value="ES">Spain</asp:ListItem>

                                        <asp:ListItem Value="LK">Sri Lanka</asp:ListItem>

                                        <asp:ListItem Value="SH">St. Helena</asp:ListItem>

                                        <asp:ListItem Value="PM">St. Pierre And Miquelon</asp:ListItem>

                                        <asp:ListItem Value="SD">Sudan</asp:ListItem>

                                        <asp:ListItem Value="SR">Suriname</asp:ListItem>

                                        <asp:ListItem Value="SJ">Svalbard, Jan Mayen Islands</asp:ListItem>

                                        <asp:ListItem Value="SZ">Sw Aziland</asp:ListItem>

                                        <asp:ListItem Value="SE">Sweden</asp:ListItem>

                                        <asp:ListItem Value="CH">Switzerland</asp:ListItem>

                                        <asp:ListItem Value="SY">Syrian Arab Republic</asp:ListItem>

                                        <asp:ListItem Value="TW">Taiwan</asp:ListItem>

                                        <asp:ListItem Value="TJ">Tajikistan</asp:ListItem>

                                        <asp:ListItem Value="TZ">Tanzania, United Republic Of</asp:ListItem>

                                        <asp:ListItem Value="TH">Thailand</asp:ListItem>

                                        <asp:ListItem Value="TG">Togo</asp:ListItem>

                                        <asp:ListItem Value="TK">Tokelau</asp:ListItem>

                                        <asp:ListItem Value="TO">Tonga</asp:ListItem>

                                        <asp:ListItem Value="TT">Trinidad And Tobago</asp:ListItem>

                                        <asp:ListItem Value="TN">Tunisia</asp:ListItem>

                                        <asp:ListItem Value="TR">Turkey</asp:ListItem>

                                        <asp:ListItem Value="TM">Turkmenistan</asp:ListItem>

                                        <asp:ListItem Value="TC">Turks And Caicos Islands</asp:ListItem>

                                        <asp:ListItem Value="TV">Tuvalu</asp:ListItem>

                                        <asp:ListItem Value="UG">Uganda</asp:ListItem>

                                        <asp:ListItem Value="UA">Ukraine</asp:ListItem>

                                        <asp:ListItem Value="AE">United Arab Emirates</asp:ListItem>

                                        <asp:ListItem Value="GB">United Kingdom</asp:ListItem>

                                        <asp:ListItem Value="US">United States</asp:ListItem>

                                        <asp:ListItem Value="UM">United States Minor Is.</asp:ListItem>

                                        <asp:ListItem Value="UY">Uruguay</asp:ListItem>

                                        <asp:ListItem Value="UZ">Uzbekistan</asp:ListItem>

                                        <asp:ListItem Value="VU">Vanuatu</asp:ListItem>

                                        <asp:ListItem Value="VE">Venezuela</asp:ListItem>

                                        <asp:ListItem Value="VN">Viet Nam</asp:ListItem>

                                        <asp:ListItem Value="VG">Virgin Islands (British)</asp:ListItem>

                                        <asp:ListItem Value="VI">Virgin Islands (U.S.)</asp:ListItem>

                                        <asp:ListItem Value="WF">Wallis And Futuna Islands</asp:ListItem>

                                        <asp:ListItem Value="EH">Western Sahara</asp:ListItem>

                                        <asp:ListItem Value="YE">Yemen</asp:ListItem>

                                        <asp:ListItem Value="YU">Yugoslavia</asp:ListItem>

                                        <asp:ListItem Value="ZR">Zaire</asp:ListItem>

                                        <asp:ListItem Value="ZM">Zambia</asp:ListItem>

                                        <asp:ListItem Value="ZW">Zimbabwe</asp:ListItem>

                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <b>
                                    <label1>Passport</label1></b>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox3" runat="server" placeholder="Enter your passport number"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-8">
                                <b>
                                    <label1>Social Status</label1></b>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                                        <asp:ListItem Text="ST" Value="ST" />
                                        <asp:ListItem Text="SC" Value="SC" />
                                        <asp:ListItem Text="BC" Value="BC" />
                                        <asp:ListItem Text="MBC" Value="MBC" />
                                        <asp:ListItem Text="OC" Value="OC" />
                                        <asp:ListItem Text="Others" Value="Others" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <b>
                                    <label1>Marital Status</label1></b>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                                        <asp:ListItem Text="Married" Value="Married" />
                                        <asp:ListItem Text="Unmarried" Value="Unmarried" />
                                        <asp:ListItem Text="Divorced" Value="Divorced" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-8">
                                <b>
                                    <label1>Telephone</label1></b>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox4" runat="server" placeholder="Enter your telephone" TextMode="Phone"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <b>
                                    <label1>Mobile Number</label1></b>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox5" runat="server" placeholder="Enter your mobile number" TextMode="Phone"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <b>
                                    <label1>Email-ID</label1></b>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Enter your mail id" TextMode="Email"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <b>
                                    <label>Residential Address</label></b>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <b>
                                    <label1>Office Address</label1></b>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <b>
                                        <label1>Address for Communication</label1></b>
                                    <div class="form-group">
                                        <asp:DropDownList class="form-control" ID="DropDownList21" runat="server">
                                            <asp:ListItem Text="Select" Value="select" />
                                            <asp:ListItem Text="RA" Value="Residential Address" />
                                            <asp:ListItem Text="PA" Value="Office Address" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-8">
                                    <b>
                                        <label1>Category</label1></b>
                                    <div class="form-group">
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList22" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="Part Time" Value="Part Time" />
                                                <asp:ListItem Text="Full Time" Value="Full Time" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-8">
                                    <b>
                                        <label1>Type of Registration</label1></b>
                                    <div class="form-group">
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList23" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="Sponsored" Value="Sponsored" />
                                                <asp:ListItem Text="Not Sponsored" Value="Not Sponsored" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-8">
                                    <b>
                                        <label1>If Part time</label1>
                                    </b>
                                    <div class="form-group">
                                        <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                                            <asp:ListItem Text="Select" Value="select" />
                                            <asp:ListItem Text="University Staff" Value="University Staff" />
                                            <asp:ListItem Text="Other Colleges/University" Value="Other Colleges/University" />
                                            <asp:ListItem Text="Industry(Government)" Value="Industry(Government)" />
                                            <asp:ListItem Text="Industry(Private)" Value="Industry(Private)" />
                                            <asp:ListItem Text="Research Centre" Value="Research Centre" />
                                            <asp:ListItem Text="Others" Value="Others" />
                                        </asp:DropDownList>
                                        <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="If others, specify"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <hr>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-8">
                                        <b>
                                            <label1>UG:- </label1>
                                        </b>
                                        <b>
                                            <label1>University/College</label1></b>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Enter the name of the College/University"></asp:TextBox>
                                        </div>
                                        <b>
                                            <label1>Year of Passing</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList4" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="2000" Value="2000" />
                                                <asp:ListItem Text="2001" Value="2001" />
                                                <asp:ListItem Text="2002" Value="2002" />
                                                <asp:ListItem Text="2003" Value="2003" />
                                                <asp:ListItem Text="2004" Value="2004" />
                                                <asp:ListItem Text="2005" Value="2005" />
                                                <asp:ListItem Text="2006" Value="2006" />
                                                <asp:ListItem Text="2007" Value="2007" />
                                                <asp:ListItem Text="2008" Value="2008" />
                                                <asp:ListItem Text="2009" Value="2009" />
                                                <asp:ListItem Text="2010" Value="2010" />
                                                <asp:ListItem Text="2011" Value="2011" />
                                                <asp:ListItem Text="2012" Value="2012" />
                                                <asp:ListItem Text="2013" Value="2013" />
                                                <asp:ListItem Text="2014" Value="2014" />
                                                <asp:ListItem Text="2015" Value="2015" />
                                                <asp:ListItem Text="2016" Value="2016" />
                                                <asp:ListItem Text="2017" Value="2017" />
                                                <asp:ListItem Text="2018" Value="2018" />
                                                <asp:ListItem Text="2019" Value="2019" />
                                                <asp:ListItem Text="2020" Value="2020" />
                                                <asp:ListItem Text="2021" Value="2021" />
                                                <asp:ListItem Text="2022" Value="2022" />
                                                <asp:ListItem Text="2023" Value="2023" />
                                                <asp:ListItem Text="2024" Value="2024" />
                                                <asp:ListItem Text="2025" Value="2025" />
                                                <asp:ListItem Text="2026" Value="2026" />
                                                <asp:ListItem Text="2027" Value="2027" />
                                                <asp:ListItem Text="2028" Value="2028" />
                                                <asp:ListItem Text="2029" Value="2029" />
                                                <asp:ListItem Text="2030" Value="2030" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Month of Passing</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList10" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="January" Value="January" />
                                                <asp:ListItem Text="February" Value="February" />
                                                <asp:ListItem Text="March" Value="March" />
                                                <asp:ListItem Text="April" Value="April" />
                                                <asp:ListItem Text="May" Value="May" />
                                                <asp:ListItem Text="June" Value="June" />
                                                <asp:ListItem Text="July" Value="July" />
                                                <asp:ListItem Text="August" Value="August" />
                                                <asp:ListItem Text="September" Value="September" />
                                                <asp:ListItem Text="October" Value="October" />
                                                <asp:ListItem Text="November" Value="November" />
                                                <asp:ListItem Text="December" Value="December" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Class</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList6" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="1st Class" Value="First Class" />
                                                <asp:ListItem Text="2nd Class" Value="Second Class" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-8">
                                        <b>
                                            <label1>PG:- </label1>
                                        </b>
                                        <b>
                                            <label1>University/College</label1></b>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="Enter the name of the College/University"></asp:TextBox>
                                        </div>
                                        <b>
                                            <label1>Year of Passing</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList7" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="2000" Value="2000" />
                                                <asp:ListItem Text="2001" Value="2001" />
                                                <asp:ListItem Text="2002" Value="2002" />
                                                <asp:ListItem Text="2003" Value="2003" />
                                                <asp:ListItem Text="2004" Value="2004" />
                                                <asp:ListItem Text="2005" Value="2005" />
                                                <asp:ListItem Text="2006" Value="2006" />
                                                <asp:ListItem Text="2007" Value="2007" />
                                                <asp:ListItem Text="2008" Value="2008" />
                                                <asp:ListItem Text="2009" Value="2009" />
                                                <asp:ListItem Text="2010" Value="2010" />
                                                <asp:ListItem Text="2011" Value="2011" />
                                                <asp:ListItem Text="2012" Value="2012" />
                                                <asp:ListItem Text="2013" Value="2013" />
                                                <asp:ListItem Text="2014" Value="2014" />
                                                <asp:ListItem Text="2015" Value="2015" />
                                                <asp:ListItem Text="2016" Value="2016" />
                                                <asp:ListItem Text="2017" Value="2017" />
                                                <asp:ListItem Text="2018" Value="2018" />
                                                <asp:ListItem Text="2019" Value="2019" />
                                                <asp:ListItem Text="2020" Value="2020" />
                                                <asp:ListItem Text="2021" Value="2021" />
                                                <asp:ListItem Text="2022" Value="2022" />
                                                <asp:ListItem Text="2023" Value="2023" />
                                                <asp:ListItem Text="2024" Value="2024" />
                                                <asp:ListItem Text="2025" Value="2025" />
                                                <asp:ListItem Text="2026" Value="2026" />
                                                <asp:ListItem Text="2027" Value="2027" />
                                                <asp:ListItem Text="2028" Value="2028" />
                                                <asp:ListItem Text="2029" Value="2029" />
                                                <asp:ListItem Text="2030" Value="2030" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Month of Passing</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList8" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="January" Value="January" />
                                                <asp:ListItem Text="February" Value="February" />
                                                <asp:ListItem Text="March" Value="March" />
                                                <asp:ListItem Text="April" Value="April" />
                                                <asp:ListItem Text="May" Value="May" />
                                                <asp:ListItem Text="June" Value="June" />
                                                <asp:ListItem Text="July" Value="July" />
                                                <asp:ListItem Text="August" Value="August" />
                                                <asp:ListItem Text="September" Value="September" />
                                                <asp:ListItem Text="October" Value="October" />
                                                <asp:ListItem Text="November" Value="November" />
                                                <asp:ListItem Text="December" Value="December" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Class</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList9" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="1st Class" Value="First Class" />
                                                <asp:ListItem Text="2nd Class" Value="Second Class" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Part time / Full time</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList14" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="Part Time" Value="Part Time" />
                                                <asp:ListItem Text="Full Time" Value="Full Time" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-8">
                                        <b>
                                            <label1>Master of Philosophy:- </label1>
                                        </b>
                                        <b>
                                            <label1>University/College</label1></b>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="Enter the name of the College/University"></asp:TextBox>
                                        </div>
                                        <b>
                                            <label1>Year of Passing</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList5" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="2000" Value="2000" />
                                                <asp:ListItem Text="2001" Value="2001" />
                                                <asp:ListItem Text="2002" Value="2002" />
                                                <asp:ListItem Text="2003" Value="2003" />
                                                <asp:ListItem Text="2004" Value="2004" />
                                                <asp:ListItem Text="2005" Value="2005" />
                                                <asp:ListItem Text="2006" Value="2006" />
                                                <asp:ListItem Text="2007" Value="2007" />
                                                <asp:ListItem Text="2008" Value="2008" />
                                                <asp:ListItem Text="2009" Value="2009" />
                                                <asp:ListItem Text="2010" Value="2010" />
                                                <asp:ListItem Text="2011" Value="2011" />
                                                <asp:ListItem Text="2012" Value="2012" />
                                                <asp:ListItem Text="2013" Value="2013" />
                                                <asp:ListItem Text="2014" Value="2014" />
                                                <asp:ListItem Text="2015" Value="2015" />
                                                <asp:ListItem Text="2016" Value="2016" />
                                                <asp:ListItem Text="2017" Value="2017" />
                                                <asp:ListItem Text="2018" Value="2018" />
                                                <asp:ListItem Text="2019" Value="2019" />
                                                <asp:ListItem Text="2020" Value="2020" />
                                                <asp:ListItem Text="2021" Value="2021" />
                                                <asp:ListItem Text="2022" Value="2022" />
                                                <asp:ListItem Text="2023" Value="2023" />
                                                <asp:ListItem Text="2024" Value="2024" />
                                                <asp:ListItem Text="2025" Value="2025" />
                                                <asp:ListItem Text="2026" Value="2026" />
                                                <asp:ListItem Text="2027" Value="2027" />
                                                <asp:ListItem Text="2028" Value="2028" />
                                                <asp:ListItem Text="2029" Value="2029" />
                                                <asp:ListItem Text="2030" Value="2030" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Month of Passing</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList11" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="January" Value="January" />
                                                <asp:ListItem Text="February" Value="February" />
                                                <asp:ListItem Text="March" Value="March" />
                                                <asp:ListItem Text="April" Value="April" />
                                                <asp:ListItem Text="May" Value="May" />
                                                <asp:ListItem Text="June" Value="June" />
                                                <asp:ListItem Text="July" Value="July" />
                                                <asp:ListItem Text="August" Value="August" />
                                                <asp:ListItem Text="September" Value="September" />
                                                <asp:ListItem Text="October" Value="October" />
                                                <asp:ListItem Text="November" Value="November" />
                                                <asp:ListItem Text="December" Value="December" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Class</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList12" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="1st Class" Value="First Class" />
                                                <asp:ListItem Text="2nd Class" Value="Second Class" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Part time / Full time</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList13" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="Part Time" Value="Part Time" />
                                                <asp:ListItem Text="Full Time" Value="Full Time" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-8">
                                        <b>
                                            <label1>Other Qualifications:-</label1></b>
                                        <b>
                                            <label1>University/College</label1></b>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="TextBox13" runat="server" placeholder="Enter the name of the College/University"></asp:TextBox>
                                        </div>
                                        <b>
                                            <label1>Year of Passing</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList15" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="2000" Value="2000" />
                                                <asp:ListItem Text="2001" Value="2001" />
                                                <asp:ListItem Text="2002" Value="2002" />
                                                <asp:ListItem Text="2003" Value="2003" />
                                                <asp:ListItem Text="2004" Value="2004" />
                                                <asp:ListItem Text="2005" Value="2005" />
                                                <asp:ListItem Text="2006" Value="2006" />
                                                <asp:ListItem Text="2007" Value="2007" />
                                                <asp:ListItem Text="2008" Value="2008" />
                                                <asp:ListItem Text="2009" Value="2009" />
                                                <asp:ListItem Text="2010" Value="2010" />
                                                <asp:ListItem Text="2011" Value="2011" />
                                                <asp:ListItem Text="2012" Value="2012" />
                                                <asp:ListItem Text="2013" Value="2013" />
                                                <asp:ListItem Text="2014" Value="2014" />
                                                <asp:ListItem Text="2015" Value="2015" />
                                                <asp:ListItem Text="2016" Value="2016" />
                                                <asp:ListItem Text="2017" Value="2017" />
                                                <asp:ListItem Text="2018" Value="2018" />
                                                <asp:ListItem Text="2019" Value="2019" />
                                                <asp:ListItem Text="2020" Value="2020" />
                                                <asp:ListItem Text="2021" Value="2021" />
                                                <asp:ListItem Text="2022" Value="2022" />
                                                <asp:ListItem Text="2023" Value="2023" />
                                                <asp:ListItem Text="2024" Value="2024" />
                                                <asp:ListItem Text="2025" Value="2025" />
                                                <asp:ListItem Text="2026" Value="2026" />
                                                <asp:ListItem Text="2027" Value="2027" />
                                                <asp:ListItem Text="2028" Value="2028" />
                                                <asp:ListItem Text="2029" Value="2029" />
                                                <asp:ListItem Text="2030" Value="2030" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Month of Passing</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList16" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="January" Value="January" />
                                                <asp:ListItem Text="February" Value="February" />
                                                <asp:ListItem Text="March" Value="March" />
                                                <asp:ListItem Text="April" Value="April" />
                                                <asp:ListItem Text="May" Value="May" />
                                                <asp:ListItem Text="June" Value="June" />
                                                <asp:ListItem Text="July" Value="July" />
                                                <asp:ListItem Text="August" Value="August" />
                                                <asp:ListItem Text="September" Value="September" />
                                                <asp:ListItem Text="October" Value="October" />
                                                <asp:ListItem Text="November" Value="November" />
                                                <asp:ListItem Text="December" Value="December" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Class</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList17" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="1st Class" Value="First Class" />
                                                <asp:ListItem Text="2nd Class" Value="Second Class" />
                                            </asp:DropDownList>
                                        </div>
                                        <b>
                                            <label1>Part time / Full time</label1></b>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList18" runat="server">
                                                <asp:ListItem Text="Select" Value="select" />
                                                <asp:ListItem Text="Part Time" Value="Part Time" />
                                                <asp:ListItem Text="Full Time" Value="Full Time" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <b>
                                            <label1>Bachelor Degree:-</label1></b>
                                        <div class="col-md-8">
                                            <div class="form-group">
                                                <b>
                                                    <label1>Discipline</label1></b>
                                                <asp:TextBox class="form-control" ID="TextBox29" runat="server" placeholder="Enter the course"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label1>SEM 1</label1>
                                                <asp:TextBox class="form-control" ID="TextBox15" runat="server" placeholder="Enter Sem 1 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label>SEM 2</label>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox16" runat="server" placeholder="Enter Sem 2 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label>SEM 3</label>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox17" runat="server" placeholder="Enter Sem 3 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label>SEM 4</label>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox18" runat="server" placeholder="Enter Sem 4 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label1>SEM 5</label1>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox19" runat="server" placeholder="Enter Sem 5 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label1>SEM 6</label1>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox20" runat="server" placeholder="Enter Sem 6 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label1>SEM 7</label1>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox21" runat="server" placeholder="Enter Sem 7 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label1>SEM 8</label1>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox22" runat="server" placeholder="Enter Sem 8 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <b>
                                            <label1>Master Degree:-</label1></b>
                                        <div class="col-md-8">
                                            <div class="form-group">
                                                <b>
                                                    <label1>Discipline</label1></b>
                                                <asp:TextBox class="form-control" ID="TextBox30" runat="server" placeholder="Enter the course"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label1>SEM 1</label1>
                                                <asp:TextBox class="form-control" ID="TextBox23" runat="server" placeholder="Enter Sem 1 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <label1>SEM 2</label1>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox24" runat="server" placeholder="Enter Sem 2 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <label1>SEM 3</label1>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox25" runat="server" placeholder="Enter Sem 3 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <label1>SEM 4</label1>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox26" runat="server" placeholder="Enter Sem 4 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <label1>SEM 5</label1>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox27" runat="server" placeholder="Enter Sem 5 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <label1>SEM 6</label1>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox28" runat="server" placeholder="Enter Sem 6 CGPA" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <b>
                                            <label1>Professional Experience:-</label1></b>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Specify</label1></b>
                                            <div class="form-group">
                                                <asp:DropDownList class="form-control" ID="DropDownList24" runat="server">
                                                    <asp:ListItem Text="Select" Value="select" />
                                                    <asp:ListItem Text="Teacher" Value="Teacher" />
                                                    <asp:ListItem Text="Research" Value="Research" />
                                                    <asp:ListItem Text="Industrial" Value="Industrial" />
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Name of the Organization you have worked for</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox32" runat="server" placeholder="Enter the name of the Organization"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Designation</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox31" runat="server" placeholder="Enter your Designation"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Number of years Worked</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox33" runat="server" placeholder="Enter the number of years" TextMode="Number"></asp:TextBox>
                                            </div>
                                            <div class="col-md-8">
                                                <b>
                                                    <label1>Work Mode</label1></b>
                                                <div class="form-group">
                                                    <asp:DropDownList class="form-control" ID="DropDownList25" runat="server">
                                                        <asp:ListItem Text="Select" Value="select" />
                                                        <asp:ListItem Text="Regular" Value="Regular" />
                                                        <asp:ListItem Text="Contract" Value="Contract" />
                                                        <asp:ListItem Text="Temporay" Value="Temporay" />
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <b>
                                            <label1>Enter the fields below,if you have worked in more than one Organization:-</label1></b>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Specify</label1></b>
                                            <div class="form-group">
                                                <asp:DropDownList class="form-control" ID="DropDownList26" runat="server">
                                                    <asp:ListItem Text="Select" Value="select" />
                                                    <asp:ListItem Text="Teacher" Value="Teacher" />
                                                    <asp:ListItem Text="Research" Value="Research" />
                                                    <asp:ListItem Text="Industrial" Value="Industrial" />
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Enter the fields below,if you have worked in more than one Organization</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox34" runat="server" placeholder="Enter the name of the Organization"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Designation</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox35" runat="server" placeholder="Enter your Designation"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Number of years Worked</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox36" runat="server" placeholder="Enter the number of years" TextMode="Number"></asp:TextBox>
                                            </div>
                                            <div class="col-md-8">
                                                <b>
                                                    <label1>Work Mode</label1></b>
                                                <div class="form-group">
                                                    <asp:DropDownList class="form-control" ID="DropDownList27" runat="server">
                                                        <asp:ListItem Text="Select" Value="select" />
                                                        <asp:ListItem Text="Regular" Value="Regular" />
                                                        <asp:ListItem Text="Contract" Value="Contract" />
                                                        <asp:ListItem Text="Temporay" Value="Temporay" />
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <b>
                                            <label>Details of the Current Employment:-</label></b>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Name and Address of the Employer</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox37" runat="server" placeholder="Enter your Name with Address"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Desigantion</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox38" runat="server" placeholder="Enter your Designation"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Mode of Employment</label1></b>
                                            <div class="form-group">
                                                <asp:DropDownList class="form-control" ID="DropDownList28" runat="server">
                                                    <asp:ListItem Text="Select" Value="select" />
                                                    <asp:ListItem Text="Regular" Value="Regular" />
                                                    <asp:ListItem Text="Contract" Value="Contract" />
                                                    <asp:ListItem Text="Temporay" Value="Temporay" />
                                                    <asp:ListItem Text="Part Time" Value="Part Time" />
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Scale of Pay</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox39" runat="server" placeholder="Enter your Scale of Pay"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Working Since Date</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox40" runat="server" placeholder="Enter the date" TextMode="Date"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <b>
                                                <label1>Total Years of Experience</label1></b>
                                            <div class="form-group">
                                                <asp:TextBox class="form-control" ID="TextBox41" runat="server" placeholder="Enter total years of experience" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col">
                                                <hr>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-8">
                                                <div class="form-group">
                                                    <asp:Label ID="label1" runat="server" Text="upload receipt"></asp:Label>
                                                    <asp:FileUpload ID="fileUpload" runat="server"></asp:FileUpload>
                                                    <asp:Button ID="upload" runat="server" Text="UPLOAD" OnClick="upload_Click" />
                                                    <asp:Label ID="label3" runat="server" readonly="tue"></asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-8 offset-3">
                                                <center>
                                                    <div class="form-group">
                                                        <asp:Button Style="margin-top: 20px" class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="SUBMIT" Width="200px" OnClick="Button1_Click" />
                                                    </div>
                                                </center>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col">
                                                <hr>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                </div>
            </div>
        </div>
    </div>
    </div>



</asp:Content>
