<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>

    <!--CSS File -->
    <link rel="stylesheet" href="./Styles/DeleteStyles.css"/>

    <!--Google Fonts-->
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet" />

    <!--Font Awesome for delete icon-->
    <script src="https://kit.fontawesome.com/75dd946e92.js" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <i class="fa-solid fa-trash fa-2xl delete-icon"></i>
        <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        <div class="btn-cont">
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </div>
    </form>
</body>
</html>
