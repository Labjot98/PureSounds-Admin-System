<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 130px; top: 190px; position: absolute; height: 15px; width: 122px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 28px; top: 61px; position: absolute" Text="Stock Login Page"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 130px; top: 152px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 25px; top: 152px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 34px; top: 194px; position: absolute" Text="Password:"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 70px; top: 248px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 159px; top: 247px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 324px; top: 189px; position: absolute; height: 19px"></asp:Label>
    </form>
</body>
</html>
