<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Company.aspx.cs" Inherits="Homework.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function validation() {
            var data = "";
            data += checkname();
            data += checkloc();
            data += checkurl();
            data += checkemail();
            data += checkCP();
            data += checkCN();
            data += checkComments();
            if (data == "") {
                return true;
            }
            else {
                alert(data);
                return false;
            }
        }
        function checkname() {
            var p = document.getElementById('<%=txtcname.ClientID %>');
            if (p.value == "") {
                return "Please Enter your name\n";
            }
            else {
                return "";
            }
        }
        function checkloc() {
            var p = document.getElementById('<%=txtloc.ClientID %>');
            if (p.value == "") {
                return "Please Enter your Location\n";
            }
            else {
                return "";
            }
        }
        function checkurl() {
            var p = document.getElementById('<%=txturl.ClientID %>');
            if (p.value == "") {
                return "Please Enter your Url\n";
            }
            else {
                return "";
            }
        }

        function checkemail() {
            var p = document.getElementById('<%=txtemail.ClientID %>');
            if (p.value == "") {
                return "Please Enter your Email\n";
            }
            else {
                return "";
            }
        }
        function checkCP() {
            var p = document.getElementById('<%=txtcperson.ClientID %>');
            if (p.value == "") {
                return "Please Enter your Conatct Person Name\n";
            }
            else {
                return "";
            }
        }

        function checkCN() {
            var p = document.getElementById('<%=txtcnumber.ClientID %>');
            if (p.value == "") {
                return "Please Enter your Contact Person Number\n";
            }
            else {
                return "";
            }
        }
        function checkComments() {
            var p = document.getElementById('<%=txtcomments.ClientID %>');
            if (p.value == "") {
                return "Please Enter your Comments\n";
            }
            else {
                return "";
            }
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Company Name: </td>
            <td>
                <asp:TextBox ID="txtcname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Company Location: </td>
            <td>
                <asp:TextBox ID="txtloc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Company url: </td>
            <td>
                <asp:TextBox ID="txturl" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Company email: </td>
            <td>
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Company Contact Person: </td>
            <td>
                <asp:TextBox ID="txtcperson" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Company Contact Number: </td>
            <td>
                <asp:TextBox ID="txtcnumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Comments: </td>
            <td>
                <asp:TextBox ID="txtcomments" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="savebtn" runat="server" Text="Save" OnClick="savebtn_Click" OnClientClick="return validation()" />
            </td>
        </tr>
    </table>
</asp:Content>
