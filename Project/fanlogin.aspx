<%@ Page Language="C#" AutoEventWireup="true" CodeFile="fanlogin.aspx.cs" Inherits="fanlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>Username <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox> </p>
    <p>Password <asp:TextBox ID="PasswordTextBox"  TextMode="Password" runat ="server"></asp:TextBox> </p>
    <p> <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /><asp:Label ID="LabelError" runat="server" Text=""></asp:Label> </p>
   
        <asp:LinkButton ID="LinkButton1"  PostBackUrl="register.aspx" runat="server">Register</asp:LinkButton>
    </div>
    </form>
</body>
</html>
