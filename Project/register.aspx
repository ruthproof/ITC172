<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td>Fan Name</td><td>
            <asp:TextBox ID="FanName" runat="server"></asp:TextBox></td></tr>
                <tr><td>FanEmail</td><td>
            <asp:TextBox ID="FanEmail" runat="server"></asp:TextBox></td></tr>
                <tr><td>FanUsername</td><td>
            <asp:TextBox ID="FanUsername" runat="server"></asp:TextBox></td></tr>
                <tr><td>FanPassword</td><td>
            <asp:TextBox ID="FanPassword" runat="server"></asp:TextBox></td></tr>

        <p> <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /><asp:Label ID="LabelError" runat="server" Text=""></asp:Label> </p>
   
        <asp:LinkButton ID="LinkButton1"  PostBackUrl="register.aspx" runat="server">Register</asp:LinkButton>
               


    </table>
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
