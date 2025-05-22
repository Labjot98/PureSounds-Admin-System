<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
   
        <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; width: 60px; margin-left:60px" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; width: 60px; margin-left:60px" Text="No" />
        </p>
    </form>
</body>
</html>
