<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true"
    CodeBehind="Project.aspx.cs" Inherits="Capstone.Application.Web.Project.Project" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
        <head>
            <title></title>
        </head>
        <body>
            <div>
                <asp:Repeater ID="Tasks" runat="server">
        <HeaderTemplate>
            <table>
                <thead>
                    <tr>
                        <th>Tasks</th><th>Completed?</th>
                    </tr>
                </thead>
            </table>
        </HeaderTemplate>
        <ItemTemplate>
            <table>
                <tr>
                    <td class="top">
                        <table class="left, Table">
                            <tr>
                                <td>
                                    <h2 class="divstyle3">
                                        Tasks</h2>
                                    <asp:Repeater ID="Tasks" runat="server">
                                        <HeaderTemplate>
                                            <table class="Table">
                                                <tr>
                                                    <th>
                                                        Tasks
                                                    </th>
                                                    <th>
                                                        Completed?
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
                                            </table>
                                        </ItemTemplate>
                                    </asp:Repeater>
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
                                            History</h2>
                                        <asp:Repeater ID="Repeater1" runat="server">
                                            <HeaderTemplate>
                                                <table class="Table">
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
                                                </table>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <h2 class="divstyle3">
                                            Release</h2>
                                        <asp:Repeater ID="Releases" runat="server">
                                            <HeaderTemplate>
                                                <table class="Table">
                                                    <tr>
                                                        <th>
                                                            Name
                                                        </th>
                                                        <th>
                                                            Type
                                                        </th>
                                                        <th>
                                                            Start Date
                                                        </th>
                                                        <th>
                                                            Finish Date
                                                        </th>
                                                        <th>
                                                            Status
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
                                                    <td>
                                                    </td>
                                                </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
                </asp:Repeater>
            </div>
        </body>
</asp:Content>
