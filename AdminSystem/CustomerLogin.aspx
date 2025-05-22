<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 260px">
    <form id="form1" runat="server">
        <div>
            <h2>Customer System Login</h2>

            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 60px; top: 80px; position: absolute" Text="UserName"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 160px; top: 80px; position: absolute; width: 220px"></asp:TextBox>

            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 60px; top: 120px; position: absolute" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 160px; top: 120px; position: absolute; width: 220px" TextMode="Password"></asp:TextBox>

            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 160px; top: 180px; position: absolute; width: 60px" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 270px; top: 180px; position: absolute; width: 60px" Text="Cancel" />

            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 60px; top: 240px; position: absolute" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
