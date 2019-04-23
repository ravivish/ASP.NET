<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Homework.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>UserName:</td>
            <td>
                <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password:</td>
            <td>
                <asp:TextBox ID="txtpsd" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnsave" runat="server" Text="Login" OnClick="btnsave_Click"></asp:Button>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblmsg" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
