<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true"
    CodeBehind="Reports.aspx.cs" Inherits="Capstone.Application.Web.Home.Reports.Reports" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
<head>
        <title></title>
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
    </head>
    <body>
    <div class="divstyle1">
        <asp:Repeater ID="Tasks" runat="server">
            <HeaderTemplate>
                <table align="center" class="Table">
                    <tr>
                        <th>
                            Name
                        </th>
                        <th>
                            Description
                        </th>
                        <th>
                            Creation Date
                        </th>
                        <th>
                            Finish Date
                        </th>
                        <th>
                            Status
                        </th>
                        <th>
                            Done
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
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
            </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    </body>
    </html>
</asp:Content>
