<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblHeading" runat="server" style="z-index: 1; left: 333px; top: 79px; position: absolute" Text="PureSound Main Menu"></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="z-index: 1; left: 113px; top: 130px; position: absolute" Text="Customer" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOrders" runat="server" OnClick="btnOrders_Click" style="z-index: 1; left: 239px; top: 130px; position: absolute" Text="Orders" />
        <p>
            <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" style="z-index: 1; left: 336px; top: 129px; position: absolute" Text="Staff" />
        </p>
        <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" style="z-index: 1; left: 423px; top: 130px; position: absolute" Text="Stock" />
        <asp:Button ID="btnSupplier" runat="server" OnClick="btnSupplier_Click" style="z-index: 1; left: 531px; top: 129px; position: absolute" Text="Supplier" />
    </form>
</body>
</html>
