<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Homework.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Name:</td>
            <td>
                <asp:TextBox runat="server" ID="txtname"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Username:</td>
            <td>
                <asp:TextBox runat="server" ID="txtuname"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password:</td>
            <td>
                <asp:TextBox runat="server" ID="txtpsd"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Confirm Password:</td>
            <td>
                <asp:TextBox runat="server" ID="txtcnfpsd"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Country:</td>
            <td>
                <asp:DropDownList ID="ddlcountry" runat="server"></asp:DropDownList></td>
        </tr>

        <tr>
            <td>Company:</td>
            <td>
                <asp:DropDownList ID="ddlcompany" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Job Profile:</td>
            <td>
                <asp:DropDownList ID="ddljob" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Qualification:</td>
            <td>
                <asp:DropDownList ID="ddlqualifiaction" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button runat="server" ID="btnsave" Text="Save" OnClick="btnsave_Click"></asp:Button></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:GridView ID="grd" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </td>
        </tr>

    </table>

</asp:Content>
