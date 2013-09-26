<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true"
    CodeBehind="Home.aspx.cs" Inherits="Capstone.Application.Web.Home.Home" %>

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
                Home</h1>
            
                <table align="center" class="Table">
                    <tr>
                        <td>
                            <table class="left, Table">
                                <tr>
                                    <td>
                                        <h2 class="divstyle3">
                                            Agenda</h2>
                                        <asp:DataList ID="Agenda" runat="server">
                                            <HeaderTemplate>
                                                <table class="Table">
                                                    <tr>
                                                        <th>
                                                            Title
                                                        </th>
                                                        <th>
                                                            Creation Date
                                                        </th>
                                                        <th>
                                                            Finish Date
                                                        </th>
                                                    </tr>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                            <FooterTemplate>
                                                <tr>
                                                </tr>
                                                </table>
                                            </FooterTemplate>
                                        </asp:DataList>
                                        <asp:Button ID="btnAddAgenda" runat="server" Text="Add" />&nbsp;
                                        <asp:Button ID="btnEditAgenda" runat="server" Text="Edit" />
                                        <br />
                                        <h2 class="divstyle3">
                                            Projects</h2>
                                        <asp:DataList ID="Repeater1" runat="server">
                                            <HeaderTemplate>
                                                <table class="Table">
                                                    <tr>
                                                        <th>
                                                            Name
                                                        </th>
                                                        <th>
                                                            Client
                                                        </th>
                                                        <th>
                                                            Status
                                                        </th>
                                                        <th>
                                                            Date
                                                        </th>
                                                    </tr>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                            <FooterTemplate>
                                                <tr>
                                                </tr>
                                                </table>
                                            </FooterTemplate>
                                        </asp:DataList>
                                        <asp:Button ID="btnAddProject" runat="server" Text="Add" />
                                        <asp:Button ID="btnEditProject" runat="server" Text="Edit" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td class="top">
                            <div class="Table">
                                <table class="left, Table">
                                    <tr>
                                        <td>
                                            <h2 class="divstyle3">
                                                Recent Activity</h2>
                                            <asp:DataList ID="Repeater3" runat="server">
                                                <HeaderTemplate>
                                                    <table class="Table" >
                                                        <tr>
                                                            <th>
                                                                Project Name
                                                            </th>
                                                            <th>
                                                                Client
                                                            </th>
                                                            <th>
                                                                Date Modified
                                                            </th>
                                                        </tr>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                        <td>
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    <tr>
                                                        </table>
                                                    </tr>
                                                </FooterTemplate>
                                            </asp:DataList>
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;
                                            <asp:Button ID="Button1" runat="server" Text="Search" />
                                            <br />
                                            <asp:DropDownList ID="DropDownList1" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                </table>
        </div>
</asp:Content>
