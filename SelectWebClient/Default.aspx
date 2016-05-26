<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ArtistDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ArtistDropDownList_SelectedIndexChanged" style="height: 22px"></asp:DropDownList>
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:DropDownList ID="VenueDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="VenueDropDownList_SelectedIndexChanged">
        </asp:DropDownList>
    </form>
</body>
</html>
