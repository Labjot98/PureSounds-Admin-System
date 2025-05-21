<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Staff Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 9px; top: 129px; position: absolute" Text="UserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 110px; top: 124px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 14px; top: 184px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 110px; top: 179px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 290px; top: 148px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 15px; top: 261px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 116px; top: 262px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
