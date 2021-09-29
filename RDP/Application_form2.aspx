<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Application_form2.aspx.cs" Inherits="RDP.Application_form21" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid"/>
      <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">
                   <div class="row">
                     <div class="col">
                        <center>
                            <img width="100px" src="imgs/1389375.png"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>APPLICATION FORM</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col-md-8">
                        <b><label>Full Name</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Enter your full name"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-8">
                        <b><label>Date Of Birth</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Date"></asp:TextBox>
                       
                            </div>
                     </div>
                       <div class="col-md-8">
                        <b><label>Age</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox14" runat="server" placeholder="Enter your age" TextMode="Number"></asp:TextBox>
                       
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
                         <b><label>Gender</label></b>
                        <div class="form-group">
                            <form id="test">
                            <input type="radio" name="gender" value="0" class="btn btn-secondary" Width="100px">Male</input>
                            <input type="radio" name="gender" value="1" class="btn btn-secondary" Width="100px">Female</input>
                            </form>
                        </div>
                     </div>
                   <div class="col-md-8">
                        <b><label>Nationality</label></b>
                       <div class="form-group">
                            <form id="test">
                            <input type="radio" name="National" value="0" class="btn btn-secondary" Width="100px">Indian</input>
                            <input type="radio" name="National" value="1" class="btn btn-secondary" Width="100px">Foreign</input>
                            </form>
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
                        <b><label>If Foreign, Enter your Country</label></b>
                        <div class="form-group">
                            <select id="country" name="country">
   <option value="Afganistan">Afghanistan</option>
   <option value="Albania">Albania</option>
   <option value="Algeria">Algeria</option>
   <option value="American Samoa">American Samoa</option>
   <option value="Andorra">Andorra</option>
   <option value="Angola">Angola</option>
   <option value="Anguilla">Anguilla</option>
   <option value="Antigua & Barbuda">Antigua & Barbuda</option>
   <option value="Argentina">Argentina</option>
   <option value="Armenia">Armenia</option>
   <option value="Aruba">Aruba</option>
   <option value="Australia">Australia</option>
   <option value="Austria">Austria</option>
   <option value="Azerbaijan">Azerbaijan</option>
   <option value="Bahamas">Bahamas</option>
   <option value="Bahrain">Bahrain</option>
   <option value="Bangladesh">Bangladesh</option>
   <option value="Barbados">Barbados</option>
   <option value="Belarus">Belarus</option>
   <option value="Belgium">Belgium</option>
   <option value="Belize">Belize</option>
   <option value="Benin">Benin</option>
   <option value="Bermuda">Bermuda</option>
   <option value="Bhutan">Bhutan</option>
   <option value="Bolivia">Bolivia</option>
   <option value="Bonaire">Bonaire</option>
   <option value="Bosnia & Herzegovina">Bosnia & Herzegovina</option>
   <option value="Botswana">Botswana</option>
   <option value="Brazil">Brazil</option>
   <option value="British Indian Ocean Ter">British Indian Ocean Ter</option>
   <option value="Brunei">Brunei</option>
   <option value="Bulgaria">Bulgaria</option>
   <option value="Burkina Faso">Burkina Faso</option>
   <option value="Burundi">Burundi</option>
   <option value="Cambodia">Cambodia</option>
   <option value="Cameroon">Cameroon</option>
   <option value="Canada">Canada</option>
   <option value="Canary Islands">Canary Islands</option>
   <option value="Cape Verde">Cape Verde</option>
   <option value="Cayman Islands">Cayman Islands</option>
   <option value="Central African Republic">Central African Republic</option>
   <option value="Chad">Chad</option>
   <option value="Channel Islands">Channel Islands</option>
   <option value="Chile">Chile</option>
   <option value="China">China</option>
   <option value="Christmas Island">Christmas Island</option>
   <option value="Cocos Island">Cocos Island</option>
   <option value="Colombia">Colombia</option>
   <option value="Comoros">Comoros</option>
   <option value="Congo">Congo</option>
   <option value="Cook Islands">Cook Islands</option>
   <option value="Costa Rica">Costa Rica</option>
   <option value="Cote DIvoire">Cote DIvoire</option>
   <option value="Croatia">Croatia</option>
   <option value="Cuba">Cuba</option>
   <option value="Curaco">Curacao</option>
   <option value="Cyprus">Cyprus</option>
   <option value="Czech Republic">Czech Republic</option>
   <option value="Denmark">Denmark</option>
   <option value="Djibouti">Djibouti</option>
   <option value="Dominica">Dominica</option>
   <option value="Dominican Republic">Dominican Republic</option>
   <option value="East Timor">East Timor</option>
   <option value="Ecuador">Ecuador</option>
   <option value="Egypt">Egypt</option>
   <option value="El Salvador">El Salvador</option>
   <option value="Equatorial Guinea">Equatorial Guinea</option>
   <option value="Eritrea">Eritrea</option>
   <option value="Estonia">Estonia</option>
   <option value="Ethiopia">Ethiopia</option>
   <option value="Falkland Islands">Falkland Islands</option>
   <option value="Faroe Islands">Faroe Islands</option>
   <option value="Fiji">Fiji</option>
   <option value="Finland">Finland</option>
   <option value="France">France</option>
   <option value="French Guiana">French Guiana</option>
   <option value="French Polynesia">French Polynesia</option>
   <option value="French Southern Ter">French Southern Ter</option>
   <option value="Gabon">Gabon</option>
   <option value="Gambia">Gambia</option>
   <option value="Georgia">Georgia</option>
   <option value="Germany">Germany</option>
   <option value="Ghana">Ghana</option>
   <option value="Gibraltar">Gibraltar</option>
   <option value="Great Britain">Great Britain</option>
   <option value="Greece">Greece</option>
   <option value="Greenland">Greenland</option>
   <option value="Grenada">Grenada</option>
   <option value="Guadeloupe">Guadeloupe</option>
   <option value="Guam">Guam</option>
   <option value="Guatemala">Guatemala</option>
   <option value="Guinea">Guinea</option>
   <option value="Guyana">Guyana</option>
   <option value="Haiti">Haiti</option>
   <option value="Hawaii">Hawaii</option>
   <option value="Honduras">Honduras</option>
   <option value="Hong Kong">Hong Kong</option>
   <option value="Hungary">Hungary</option>
   <option value="Iceland">Iceland</option>
   <option value="Indonesia">Indonesia</option>
   <option value="India">India</option>
   <option value="Iran">Iran</option>
   <option value="Iraq">Iraq</option>
   <option value="Ireland">Ireland</option>
   <option value="Isle of Man">Isle of Man</option>
   <option value="Israel">Israel</option>
   <option value="Italy">Italy</option>
   <option value="Jamaica">Jamaica</option>
   <option value="Japan">Japan</option>
   <option value="Jordan">Jordan</option>
   <option value="Kazakhstan">Kazakhstan</option>
   <option value="Kenya">Kenya</option>
   <option value="Kiribati">Kiribati</option>
   <option value="Korea North">Korea North</option>
   <option value="Korea Sout">Korea South</option>
   <option value="Kuwait">Kuwait</option>
   <option value="Kyrgyzstan">Kyrgyzstan</option>
   <option value="Laos">Laos</option>
   <option value="Latvia">Latvia</option>
   <option value="Lebanon">Lebanon</option>
   <option value="Lesotho">Lesotho</option>
   <option value="Liberia">Liberia</option>
   <option value="Libya">Libya</option>
   <option value="Liechtenstein">Liechtenstein</option>
   <option value="Lithuania">Lithuania</option>
   <option value="Luxembourg">Luxembourg</option>
   <option value="Macau">Macau</option>
   <option value="Macedonia">Macedonia</option>
   <option value="Madagascar">Madagascar</option>
   <option value="Malaysia">Malaysia</option>
   <option value="Malawi">Malawi</option>
   <option value="Maldives">Maldives</option>
   <option value="Mali">Mali</option>
   <option value="Malta">Malta</option>
   <option value="Marshall Islands">Marshall Islands</option>
   <option value="Martinique">Martinique</option>
   <option value="Mauritania">Mauritania</option>
   <option value="Mauritius">Mauritius</option>
   <option value="Mayotte">Mayotte</option>
   <option value="Mexico">Mexico</option>
   <option value="Midway Islands">Midway Islands</option>
   <option value="Moldova">Moldova</option>
   <option value="Monaco">Monaco</option>
   <option value="Mongolia">Mongolia</option>
   <option value="Montserrat">Montserrat</option>
   <option value="Morocco">Morocco</option>
   <option value="Mozambique">Mozambique</option>
   <option value="Myanmar">Myanmar</option>
   <option value="Nambia">Nambia</option>
   <option value="Nauru">Nauru</option>
   <option value="Nepal">Nepal</option>
   <option value="Netherland Antilles">Netherland Antilles</option>
   <option value="Netherlands">Netherlands (Holland, Europe)</option>
   <option value="Nevis">Nevis</option>
   <option value="New Caledonia">New Caledonia</option>
   <option value="New Zealand">New Zealand</option>
   <option value="Nicaragua">Nicaragua</option>
   <option value="Niger">Niger</option>
   <option value="Nigeria">Nigeria</option>
   <option value="Niue">Niue</option>
   <option value="Norfolk Island">Norfolk Island</option>
   <option value="Norway">Norway</option>
   <option value="Oman">Oman</option>
   <option value="Pakistan">Pakistan</option>
   <option value="Palau Island">Palau Island</option>
   <option value="Palestine">Palestine</option>
   <option value="Panama">Panama</option>
   <option value="Papua New Guinea">Papua New Guinea</option>
   <option value="Paraguay">Paraguay</option>
   <option value="Peru">Peru</option>
   <option value="Phillipines">Philippines</option>
   <option value="Pitcairn Island">Pitcairn Island</option>
   <option value="Poland">Poland</option>
   <option value="Portugal">Portugal</option>
   <option value="Puerto Rico">Puerto Rico</option>
   <option value="Qatar">Qatar</option>
   <option value="Republic of Montenegro">Republic of Montenegro</option>
   <option value="Republic of Serbia">Republic of Serbia</option>
   <option value="Reunion">Reunion</option>
   <option value="Romania">Romania</option>
   <option value="Russia">Russia</option>
   <option value="Rwanda">Rwanda</option>
   <option value="St Barthelemy">St Barthelemy</option>
   <option value="St Eustatius">St Eustatius</option>
   <option value="St Helena">St Helena</option>
   <option value="St Kitts-Nevis">St Kitts-Nevis</option>
   <option value="St Lucia">St Lucia</option>
   <option value="St Maarten">St Maarten</option>
   <option value="St Pierre & Miquelon">St Pierre & Miquelon</option>
   <option value="St Vincent & Grenadines">St Vincent & Grenadines</option>
   <option value="Saipan">Saipan</option>
   <option value="Samoa">Samoa</option>
   <option value="Samoa American">Samoa American</option>
   <option value="San Marino">San Marino</option>
   <option value="Sao Tome & Principe">Sao Tome & Principe</option>
   <option value="Saudi Arabia">Saudi Arabia</option>
   <option value="Senegal">Senegal</option>
   <option value="Seychelles">Seychelles</option>
   <option value="Sierra Leone">Sierra Leone</option>
   <option value="Singapore">Singapore</option>
   <option value="Slovakia">Slovakia</option>
   <option value="Slovenia">Slovenia</option>
   <option value="Solomon Islands">Solomon Islands</option>
   <option value="Somalia">Somalia</option>
   <option value="South Africa">South Africa</option>
   <option value="Spain">Spain</option>
   <option value="Sri Lanka">Sri Lanka</option>
   <option value="Sudan">Sudan</option>
   <option value="Suriname">Suriname</option>
   <option value="Swaziland">Swaziland</option>
   <option value="Sweden">Sweden</option>
   <option value="Switzerland">Switzerland</option>
   <option value="Syria">Syria</option>
   <option value="Tahiti">Tahiti</option>
   <option value="Taiwan">Taiwan</option>
   <option value="Tajikistan">Tajikistan</option>
   <option value="Tanzania">Tanzania</option>
   <option value="Thailand">Thailand</option>
   <option value="Togo">Togo</option>
   <option value="Tokelau">Tokelau</option>
   <option value="Tonga">Tonga</option>
   <option value="Trinidad & Tobago">Trinidad & Tobago</option>
   <option value="Tunisia">Tunisia</option>
   <option value="Turkey">Turkey</option>
   <option value="Turkmenistan">Turkmenistan</option>
   <option value="Turks & Caicos Is">Turks & Caicos Is</option>
   <option value="Tuvalu">Tuvalu</option>
   <option value="Uganda">Uganda</option>
   <option value="United Kingdom">United Kingdom</option>
   <option value="Ukraine">Ukraine</option>
   <option value="United Arab Erimates">United Arab Emirates</option>
   <option value="United States of America">United States of America</option>
   <option value="Uraguay">Uruguay</option>
   <option value="Uzbekistan">Uzbekistan</option>
   <option value="Vanuatu">Vanuatu</option>
   <option value="Vatican City State">Vatican City State</option>
   <option value="Venezuela">Venezuela</option>
   <option value="Vietnam">Vietnam</option>
   <option value="Virgin Islands (Brit)">Virgin Islands (Brit)</option>
   <option value="Virgin Islands (USA)">Virgin Islands (USA)</option>
   <option value="Wake Island">Wake Island</option>
   <option value="Wallis & Futana Is">Wallis & Futana Is</option>
   <option value="Yemen">Yemen</option>
   <option value="Zaire">Zaire</option>
   <option value="Zambia">Zambia</option>
   <option value="Zimbabwe">Zimbabwe</option>
</select>
                           
                       
                            </div>
                     </div>
                     <div class="col-md-8">
                         <b><label>Passport</label></b>
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
                       <b><label>Social Status</label></b>
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
                        <b><label>Marital Status</label></b>
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
                         <b><label>Telephone</label></b>
                        <div class="form-group">
                            <asp:TextBox class="form-control" ID="TextBox4" runat="server" placeholder="Enter your telephone" TextMode="Phone"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-8">
                       <b><label>Mobile Number</label></b>
                       <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox5" runat="server" placeholder="Enter your mobile number" TextMode="Phone"></asp:TextBox>
                            </div>
                     </div>
                       <div class="col-md-8">
                        <b><label>Email-ID</label></b>
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
                         <b><label>Residential Address</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col">
                         <b><label>Office Address</label></b>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        </div>
                     </div>
                       <div class="row">
                       <div class="col">
                         <b><label>Address for Communication</label></b>
                        <div class="form-group">
                           <form id="test">
                            <input type="radio" name="Address" value="0" asp:Button class="btn btn-secondary" Width="100px">Residential Address</input>
                            <input type="radio" name="Address" value="1" asp:Button class="btn btn-secondary" Width="100px">Office Address</input>
                            </form>
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
                           <b><label>Category</label></b>
                        <div class="form-group">
                            <div class="form-group">
                            <form id="test">
                            <input type="radio" name="Category" value="0" asp:Button class="btn btn-secondary" Width="100px">Part Time</input>
                            <input type="radio" name="Category" value="1" asp:Button class="btn btn-secondary" Width="100px">Full Time</input>
                            </form>
                        </div>
                        </div>
                     </div>
                   <div class="col-md-8">
                        <b><label>Type of Registration</label></b>
                        <div class="form-group">
                           <div class="form-group">
                            <form id="test">
                            <input type="radio" name="Registration" value="0" asp:Button class="btn btn-secondary" Width="100px">Sponsored</input>
                            <input type="radio" name="Registration" value="1" asp:Button class="btn btn-secondary" Width="100px">Not Sponsored</input>
                            </form>
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
                        <label>If Part time</label> 
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
                        <b><label>UG:- </label></b>
                        <b><label>University/College</label></b>
                       <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Enter the name of the College/University"></asp:TextBox>
                            </div>
                       <b><label>Year of Passing</label></b>
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
                       <b><label>Month of Passing</label></b>
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
                              <asp:ListItem Text="Sepember" Value="September" />
                              <asp:ListItem Text="October" Value="October" />
                              <asp:ListItem Text="November" Value="November" />
                              <asp:ListItem Text="December" Value="December" />
                               </asp:DropDownList>
                       </div>
                       <b><label>Class</label></b>
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
                        <b><label>PG:- </label></b>
                        <b><label>University/College</label></b>
                       <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="Enter the name of the College/University"></asp:TextBox>
                            </div>
                       <b><label>Year of Passing</label></b>
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
                       <b><label>Month of Passing</label></b>
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
                              <asp:ListItem Text="Sepember" Value="September" />
                              <asp:ListItem Text="October" Value="October" />
                              <asp:ListItem Text="November" Value="November" />
                              <asp:ListItem Text="December" Value="December" />
                               </asp:DropDownList>
                       </div>
                       <b><label>Class</label></b>
                       <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList9" runat="server">
                           <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="1st Class" Value="First Class" />
                              <asp:ListItem Text="2nd Class" Value="Second Class" />
                           </asp:DropDownList>
                            </div>
                           <b><label>Part time / Full time</label></b>
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
                        <b><label>Master of Philosophy:- </label></b>
                        <b><label>University/College</label></b>
                       <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="Enter the name of the College/University"></asp:TextBox>
                            </div>
                       <b><label>Year of Passing</label></b>
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
                       <b><label>Month of Passing</label></b>
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
                              <asp:ListItem Text="Sepember" Value="September" />
                              <asp:ListItem Text="October" Value="October" />
                              <asp:ListItem Text="November" Value="November" />
                              <asp:ListItem Text="December" Value="December" />
                               </asp:DropDownList>
                       </div>
                       <b><label>Class</label></b>
                       <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList12" runat="server">
                           <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="1st Class" Value="First Class" />
                              <asp:ListItem Text="2nd Class" Value="Second Class" />
                           </asp:DropDownList>
                            </div>
                           <b><label>Part time / Full time</label></b>
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
                        <b><label>Other Qualifications:-</label></b>
                        <b><label>University/College</label></b>
                       <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox13" runat="server" placeholder="Enter the name of the College/University"></asp:TextBox>
                            </div>
                       <b><label>Year of Passing</label></b>
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
                       <b><label>Month of Passing</label></b>
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
                              <asp:ListItem Text="Sepember" Value="September" />
                              <asp:ListItem Text="October" Value="October" />
                              <asp:ListItem Text="November" Value="November" />
                              <asp:ListItem Text="December" Value="December" />
                               </asp:DropDownList>
                       </div>
                       <b><label>Class</label></b>
                       <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList17" runat="server">
                           <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="1st Class" Value="First Class" />
                              <asp:ListItem Text="2nd Class" Value="Second Class" />
                           </asp:DropDownList>
                            </div>
                           <b><label>Part time / Full time</label></b>
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
                               <b><label>Bachelor Degree:-</label></b>
                               <div class="col-md-8">
                        <div class="form-group">
                            <b><label>Discipline</label></b>
                           <asp:TextBox class="form-control" ID="TextBox29" runat="server" placeholder="Enter the course"></asp:TextBox>
                        </div>
                     </div>
                               <div class="col-md-8">
                        <div class="form-group">
                            <label>SEM 1</label>
                           <asp:TextBox class="form-control" ID="TextBox15" runat="server" placeholder="Enter Sem 1 CGPA" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-8">
                        <label>SEM 2</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox16" runat="server" placeholder="Enter Sem 2 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                               <div class="col-md-8">
                        <label>SEM 3</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox17" runat="server" placeholder="Enter Sem 3 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                               <div class="col-md-8">
                        <label>SEM 4</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox18" runat="server" placeholder="Enter Sem 4 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                            <div class="col-md-8">
                        <label>SEM 5</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox19" runat="server" placeholder="Enter Sem 5 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                               <div class="col-md-8">
                        <label>SEM 6</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox20" runat="server" placeholder="Enter Sem 6 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                               <div class="col-md-8">
                        <label>SEM 7</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox21" runat="server" placeholder="Enter Sem 7 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                               <div class="col-md-8">
                        <label>SEM 8</label>
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
                         <b><label>Master Degree:-</label></b>
                         <div class="col-md-8">
                        <div class="form-group">
                            <b><label>Discipline</label></b>
                           <asp:TextBox class="form-control" ID="TextBox30" runat="server" placeholder="Enter the course"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-8">
                        <div class="form-group">
                            <label>SEM 1</label>
                           <asp:TextBox class="form-control" ID="TextBox23" runat="server" placeholder="Enter Sem 1 CGPA" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-8">
                        <label>SEM 2</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox24" runat="server" placeholder="Enter Sem 2 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                               <div class="col-md-8">
                        <label>SEM 3</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox25" runat="server" placeholder="Enter Sem 3 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                               <div class="col-md-8">
                        <label>SEM 4</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox26" runat="server" placeholder="Enter Sem 4 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                            <div class="col-md-8">
                        <label>SEM 5</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox27" runat="server" placeholder="Enter Sem 5 CGPA" TextMode="Number"></asp:TextBox>
                            </div>
                     </div>
                               <div class="col-md-8">
                        <label>SEM 6</label>
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
                          <b><label>Professional Experience:-</label></b>
                     <div class="col-md-8">
                         <b><label>Specify</label></b>
                        <div class="form-group">
                           <form id="test">
                            <input type="radio" name="specify" value="0" class="btn btn-secondary" Width="100px">Teacher</input>
                            <input type="radio" name="specify" value="1" class="btn btn-secondary" Width="100px">Research</input>
                            <input type="radio" name="specify" value="2" class="btn btn-secondary" Width="100px">Industrial</input>
                            </form>
                        </div>
                     </div>
                   <div class="col-md-8">
                        <b><label>Name of the Organization you have worked for</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox32" runat="server" placeholder="Enter the name of the Organization" ></asp:TextBox>
                       </div>
                     </div>
                        <div class="col-md-8">
                        <b><label>Designation</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox31" runat="server" placeholder="Enter your Designation" ></asp:TextBox>
                       </div>
                     </div>
                          <div class="col-md-8">
                        <b><label>Number of years Worked</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox33" runat="server" placeholder="Enter the number of years" TextMode="Number" ></asp:TextBox>
                       </div>
                            <div class="col-md-8">
                        <b><label>Work Mode</label></b>
                        <div class="form-group">
                           <form id="test">
                            <input type="radio" name="worked" value="0" class="btn btn-secondary" Width="100px">Regular</input>
                            <input type="radio" name="worked" value="1" class="btn btn-secondary" Width="100px">contract</input>
                            <input type="radio" name="worked" value="2" class="btn btn-secondary" Width="100px">Temporary</input>
                            </form>
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
                          <b><label>Enter the fields below,if you have worked in more than one Organization:-</label></b>
                     <div class="col-md-8">
                         <b><label>Specify</label></b>
                        <div class="form-group">
                           <form id="test">
                            <input type="radio" name="specify" value="0" class="btn btn-secondary" Width="100px">Teacher</input>
                            <input type="radio" name="specify" value="1" class="btn btn-secondary" Width="100px">Research</input>
                            <input type="radio" name="specify" value="2" class="btn btn-secondary" Width="100px">Industrial</input>
                            </form>
                        </div>
                     </div>
                   <div class="col-md-8">
                        <b><label>Enter the fields below,if you have worked in more than one Organization</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox34" runat="server" placeholder="Enter the name of the Organization" ></asp:TextBox>
                       </div>
                     </div>
                        <div class="col-md-8">
                        <b><label>Designation</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox35" runat="server" placeholder="Enter your Designation" ></asp:TextBox>
                       </div>
                     </div>
                          <div class="col-md-8">
                        <b><label>Number of years Worked</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox36" runat="server" placeholder="Enter the number of years" TextMode="Number" ></asp:TextBox>
                       </div>
                            <div class="col-md-8">
                        <b><label>Work Mode</label></b>
                        <div class="form-group">
                           <form id="test">
                            <input type="radio" name="worked" value="0" class="btn btn-secondary" Width="100px">Regular</input>
                            <input type="radio" name="worked" value="1" class="btn btn-secondary" Width="100px">contract</input>
                            <input type="radio" name="worked" value="2" class="btn btn-secondary" Width="100px">Temporary</input>
                            </form>
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
                            <b><label>Details of the Current Employment:-</label></b>
                     <div class="col-md-8">
                         <b><label>Name and Address of the Employer</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox37" runat="server" placeholder="Enter your Name with Address"></asp:TextBox>
                        </div>
                     </div>
                   <div class="col-md-8">
                        <b><label>Desigantion</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox38" runat="server" placeholder="Enter your Designation"></asp:TextBox>
                       </div>
                     </div>
                        <div class="col-md-8">
                        <b><label>Mode of Employment</label></b>
                        <div class="form-group">
                           <form id="test">
                            <input type="radio" name="worked" value="0" class="btn btn-secondary" Width="100px">Regular</input>
                            <input type="radio" name="worked" value="1" class="btn btn-secondary" Width="100px">contract</input>
                            <input type="radio" name="worked" value="2" class="btn btn-secondary" Width="100px">Temporary</input>
                            <input type="radio" name="worked" value="3" class="btn btn-secondary" Width="100px">Part Time</input>
                            </form>
                       </div>
                     </div>
                        <div class="col-md-8">
                        <b><label>Scale of Pay</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox39" runat="server" placeholder="Enter your Scale of Pay"></asp:TextBox>
                       </div>
                     </div>
                        <div class="col-md-8">
                        <b><label>Working Since Date</label></b>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox40" runat="server" placeholder="Enter the date" TextMode="Date"></asp:TextBox>
                       </div>
                     </div>
                        <div class="col-md-8">
                        <b><label>Total Years of Experience</label></b>
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
                           <form>
                           <label for="fileUpload">Upload your Fee Receipt</label>
                           <input type="file" id="fileUpload">
                           </form>
                        </div>
                     </div>
                  </div>
                    <div class="row">
                     <div class="col-md-8 offset-3">
                        <center>     
                        <div class="form-group">
                           <asp:Button Border Style ="margin-top:20px" class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="SUBMIT" Width="200px"/>
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
             <a href="homepage.aspx"style="color: white" asp:Button class="btn btn-secondary" Width="100px"><< Back to Home</a><br><br>

</asp:Content>
