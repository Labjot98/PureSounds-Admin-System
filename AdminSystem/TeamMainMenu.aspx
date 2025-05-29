<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <!--CSS File -->
    <link rel="stylesheet" href="./Styles/TeamMenuStyles.css"/>

    <!--Google Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblHeading" runat="server" Text="PureSound Main Menu"></asp:Label>
        </div>

        <div class="btnCont">
             <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Customer" />
             <asp:Button ID="btnOrders" runat="server" OnClick="btnOrders_Click" Text="Orders" />
             <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" Text="Staff" />
             <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click"  Text="Stock" />
             <asp:Button ID="btnSupplier" runat="server" OnClick="btnSupplier_Click"  Text="Supplier" />
        </div>
       
    </form>
</body>
</html>
