<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblHeading" runat="server" Text="Orders Login Page" ></asp:Label>
        </div>
        <div>
            <div>
                 <asp:Label ID="lblUserName" runat="server" Text="Username"></asp:Label> 
                 <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>  
            </div>
            <div>
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox> 
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /> 
            </div>
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" ></asp:Label>
        </div>
        
    </form>
</body>
</html>
