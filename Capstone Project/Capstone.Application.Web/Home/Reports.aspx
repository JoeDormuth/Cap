<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Capstone.Application.Web.Projects.Reports" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 714px">
    
        <br />
        <br />
        <br />
        <asp:Image ID="imgOverallBurndown" runat="server" Height="167px" 
            Width="246px" />
        <asp:TextBox ID="txtToDo" runat="server">To Do</asp:TextBox>
        <asp:TextBox ID="txtCompleted" runat="server" 
            ontextchanged="txtCompleted_TextChanged">Completed</asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="imgReleaseBurndown" runat="server" 
            AlternateText="Release Burndown" Height="136px" Width="231px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="imgSprintBurndown" runat="server" 
            AlternateText="Sprint Burndown" Height="106px" Width="197px" />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
