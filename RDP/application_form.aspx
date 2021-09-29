<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="application_form.aspx.cs" Inherits="RDP.application_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <button type="submit">Submit form</button>
    <table id="example" class="display" style="width:100%">
        <thead>
            <tr>
               
                <th>degree</th>
                <th>discipline</th>
                <th>part-time/full-time</th>
                <th>University/College</th>
                <th>Month and year of passing</th>
                <th>CGPA</th>
                <th>Class</th>
                <th></th>
            </tr>
        </thead>
        <tbody>

    
            <tr>
                <td>UG</td>
                <td><input type="text" id="row-1-degree" name="row-1-degree" value="   "></td>

                <td><input type="text" id="row-1-part-time/full-time" name="row-1-part-time/full-time" value="    "></td>
                    <td><input type="text" id="row-2-position" name="row-2-position" value="Accountant"></td>
               
            </tr>
            <tr>
                <td>PG</td>
                <td><input type="text" id="row-2-age" name="row-2-age" value="63"></td>
                <td><input type="text" id="row-2-position" name="row-2-position" value="Accountant"></td>
                <td><select size="1" id="row-2-office" name="row-2-office">
                    <option value="Edinburgh">
                        Edinburgh
                    </option>
                    <option value="London">
                        London
                    </option>
                    <option value="New York">
                        New York
                    </option>
                    <option value="San Francisco">
                        San Francisco
                    </option>
                    <option value="Tokyo" selected="selected">
                        Tokyo
                    </option>
                </select></td>
            </tr>
            <tr>
                <td>M. phil</td>
                <td><input type="text" id="row-3-age" name="row-3-age" value="66"></td>
                <td><input type="text" id="row-3-position" name="row-3-position" value="Junior Technical Author"></td>
                <td><select size="1" id="row-3-office" name="row-3-office">
                    <option value="Edinburgh">
                        Edinburgh
                    </option>
                    <option value="London">
                        London
                    </option>
                    <option value="New York">
                        New York
                    </option>
                    <option value="San Francisco" selected="selected">
                        San Francisco
                    </option>
                    <option value="Tokyo">
                        Tokyo
                    </option>
                </select></td>
            </tr>
            <tr>
                <td>Others</td>
                <td><input type="text" id="row-4-age" name="row-4-age" value="22"></td>
                <td><input type="text" id="row-4-position" name="row-4-position" value="Senior Javascript Developer"></td>
                <td><select size="1" id="row-4-office" name="row-4-office">
                    <option value="Edinburgh" selected="selected">
                        Edinburgh
                    </option>
                    <option value="London">
                        London
                    </option>
                    <option value="New York">
                        New York
                    </option>
                    <option value="San Francisco">
                        San Francisco
                    </option>
                    <option value="Tokyo">
                        Tokyo
                    </option>
                </select></td>
            </tr>
            <tr>

 </select>
                </td>
            </tr>
        </tbody>
    </table>

    </asp:Content>
    