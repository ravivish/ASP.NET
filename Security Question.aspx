<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Security Question.aspx.cs" Inherits="Homework.Security_Question" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function validation() {
            var p = document.getElementById('<%=txtsque.ClientID%>');
             if (p.value == "") {
                 alert("Please Enter Security Question");
                 return false;
             }
             else {
                 return true;
             }
         }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td>Security Question:</td>
            <td>
                <asp:TextBox ID="txtsque" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="savebtn" runat="server" Text="Save" OnClick="savebtn_Click" OnClientClick="return validation()"></asp:Button>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:GridView ID="grd" runat="server" AutoGenerateColumns="false" DataKeyNames="sqid" OnRowEditing="grd_RowEditing" OnRowDeleting="grd_RowDeleting" OnRowCancelingEdit="grd_RowCancelingEdit" OnRowUpdating="grd_RowUpdating" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                    <Columns>
                        <asp:TemplateField HeaderText="Security Question">
                            <ItemTemplate>
                                <%#Eval("squestion") %>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtsque1" runat="server" Text='<%#Eval("squestion") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="btnedit" runat="server" Text="Edit" CommandName="Edit"></asp:LinkButton>
                                <asp:LinkButton ID="btndelete" runat="server" Text="Delete" CommandName="Delete"></asp:LinkButton>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:LinkButton ID="btnupdate" runat="server" Text="Update" CommandName="Update"></asp:LinkButton>
                                <asp:LinkButton ID="btncancel" runat="server" Text="Cancel" CommandName="Cancel"></asp:LinkButton>
                            </EditItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
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
