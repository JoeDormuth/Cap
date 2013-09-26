<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true"
    CodeBehind="Feature.aspx.cs" Inherits="Capstone.Application.Web.Feature" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .divstyle1
        {
            text-align: center;
        }
        .divstyle3
        {
            text-align: center;
        }
        .body
        {
            background-color: black;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="divstyle1">
        <br />
        <br />
        <asp:Label Text="Feature" runat="server"></asp:Label>
        <!--tab spacing to line up the label with the fields -->
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label Text="Feature Type" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="FeatureName" runat="server"></asp:TextBox>
        &nbsp; &nbsp;
        <asp:DropDownList ID="ddlFeatureType" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Animation</asp:ListItem>
            <asp:ListItem>Navigation</asp:ListItem>
            <asp:ListItem>Full Web Page</asp:ListItem>
            <asp:ListItem>Complete Web Site</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="divstyle3">
        <asp:Label Text="Feature Description" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="txtDescription" runat="server" Height="84px" Width="333px"></asp:TextBox>
        <br />
        <br />
        <asp:Label Text="Reference" runat="server"></asp:Label>
        <!--tab spacing to line up the label with the fields -->
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label Text="Estimated Hours" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="txtReference" runat="server"></asp:TextBox>
        &nbsp;
        <asp:TextBox ID="txtTimeEstimate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label Text="Assigned Developer" runat="server"></asp:Label>
        <asp:DropDownList ID="ddlDeveloper" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="153px" />
    </div>
</asp:Content>
