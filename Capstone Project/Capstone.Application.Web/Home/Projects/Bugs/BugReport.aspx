<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="BugReport.aspx.cs" Inherits="Capstone.Application.Web.Projects.Bugs.BugReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .divstyle1 {
            text-align: center;
        }
        .divstyle3 {
         text-align: center;
        }
        .body {
            background-color: black;
        }
        .table
        {
        	border-width:thin;
        	border-color:Lime;
        	text-align:center;
        }
        
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

    <div class="divstyle1">
    <h1>Bugs</h1>
    <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Bug Type:"></asp:Label>
    <asp:DropDownList ID="ddlBugType" runat="server">
    </asp:DropDownList>
    <br />
    <asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
    <table class="table">
    <tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
    <th>Creation Date</th>
    <th>Finish Date</th>
    <th>Time Spent</th>
    <th>Status</th>
    </tr>
    </HeaderTemplate>
    <ItemTemplate>
    <tr>
    <th>&nbsp;</th>
    <th>&nbsp;</th>
    <th>&nbsp;</th>
    <th>&nbsp;</th>
    <th>&nbsp;</th>
    <th>&nbsp;</th>
    <th>&nbsp;</th>
    </tr>
    </ItemTemplate>
    <FooterTemplate>
    </table>    
    </FooterTemplate>
    </asp:Repeater>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Enter Description:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Time Estimate:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Start Date:"></asp:Label>&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add" />&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Edit" />&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete" />
    </div>
</asp:Content>
