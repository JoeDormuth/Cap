<%@ Page Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="Bug.aspx.cs" Inherits="Capstone.Application.Web.Projects.Sprints.Bugs.Bug" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

    <div>
    
        <asp:TextBox ID="txtBugDescription" runat="server" Height="280px" Width="427px">Bug Description Here</asp:TextBox>
    
    </div>
</asp:Content>