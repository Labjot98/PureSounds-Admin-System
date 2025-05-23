<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>

    <!--CSS File -->
    <link rel="stylesheet" href="./Styles/LoginStyles.css"/>

    <!--Google Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="img-cont">
            <img src="https://images.pexels.com/photos/3756771/pexels-photo-3756771.jpeg?auto=compress&cs=tinysrgb&w=600" alt="This is an image"/>
        </div>
        <div class="main-cont">
            <h2>Customer System Login</h2>
            <p>Enter username and password to access your account</p>

            <div class="input-field">
                <asp:Label ID="lblUserName" runat="server" Text="Username"></asp:Label> 
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>  
            </div>

            <div class="input-field">
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox> 
            </div>

            <div class="btn-cont">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /> 
            </div>

            <div class="error-cont">
                <asp:Label ID="lblError" runat="server" ></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
