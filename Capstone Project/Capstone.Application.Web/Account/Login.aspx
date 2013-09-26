<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" MasterPageFile="~/Navigation.Master" Inherits="Capstone.Application.Web.Account.Login" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="Body" runat="server">
<div class="Login">
    <asp:Login ID="login1" runat="server" ></asp:Login>
</div>
</asp:Content>