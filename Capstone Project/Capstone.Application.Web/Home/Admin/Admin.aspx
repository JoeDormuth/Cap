<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true"
    CodeBehind="Admin.aspx.cs" Inherits="Capstone.Application.Web.Home.Admin.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .divstyle1
        {
            text-align: center;
            margin-left: 10%;
            margin-right: 10%;
        }
        .divstyle3
        {
            text-align: left;
        }
        .body
        {
            background-color: black;
        }
        .repeater
        {
            width: 40%;
            border-width: Thin;
            border-color: Lime;
            text-align: center;
        }
        .Table
        {
            width: 100%;
            text-align: center;
        }
        .left
        {
            float: left;
        }
        .top
        {
            vertical-align: top;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="divstyle1">
        <h1>
            User Admin</h1>
        <table align="center" class="Table">
            <tr>
                <td>
                    <table class="Table, left">
                        <tr>
                            <td>
                                <asp:DataList ID="Repeater1" runat="server" ItemStyle-HorizontalAlign="Center">
                                    <HeaderTemplate>
                                        <table class="Table, left">
                                            <tr>
                                                <th>
                                                    User
                                                </th>
                                                <th>
                                                    Role
                                                </th>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>
                                </asp:DataList>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="Table">
                    <table class="Table">
                        <tr>
                            <td>
                                <asp:Label ID="lblUser" runat="server" Text="User"></asp:Label>&nbsp;
                                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>&nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label>&nbsp;
                                <asp:DropDownList ID="ddlRoleList" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Add" />&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="Edit" />&nbsp;
                                <asp:Button ID="Button3" runat="server" Text="Delete" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
