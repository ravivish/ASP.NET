<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Manage_Company.aspx.cs" Inherits="Homework.Manage_Company" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:GridView ID="grd" runat="server" AutoGenerateColumns="False" DataKeyNames="cid" OnRowDeleting="grd_RowDeleting" OnRowUpdating="grd_RowUpdating" OnRowEditing="grd_RowEditing" OnRowCancelingEdit="grd_RowCancelingEdit" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                    <Columns>
                        <asp:TemplateField HeaderText="Company Name">
                            <ItemTemplate>
                                <%#Eval("cname") %>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtcname1" runat="server" Text='<%#Eval("cname") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Company Location">
                            <ItemTemplate>
                                <%#Eval("cloc") %>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtcloc1" runat="server" Text='<%#Eval("cloc") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Company Url">
                            <ItemTemplate>
                                <%#Eval("curl") %>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtcurl" runat="server" Text='<%#Eval("curl") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Contact Person">
                            <ItemTemplate>
                                <%#Eval("ccperson") %>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtcperson1" runat="server" Text='<%#Eval("ccperson") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Contact Number">
                            <ItemTemplate>
                                <%#Eval("ccnumber") %>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtcnumber1" runat="server" Text='<%#Eval("ccnumber") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Comments">
                            <ItemTemplate>
                                <%#Eval("comments") %>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtcomments1" runat="server" Text='<%#Eval("comments") %>'></asp:TextBox>
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
