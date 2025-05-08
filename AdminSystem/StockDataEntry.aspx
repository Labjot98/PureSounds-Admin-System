<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtItemID" runat="server" style="z-index: 1; left: 123px; top: 90px; position: absolute; height: 16px"></asp:TextBox>
        <p>
            <asp:Label ID="lblItemID" runat="server" style="z-index: 1; left: 24px; top: 91px; position: absolute; height: 19px" Text="Item ID" width="75px"></asp:Label>
        </p>
        <asp:Label ID="lblItemName" runat="server" height="19px" style="z-index: 1; left: 24px; top: 123px; position: absolute" Text="Item Name" width="75px"></asp:Label>
        <asp:TextBox ID="txtItemName" runat="server" style="z-index: 1; left: 123px; top: 122px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDatePosted" runat="server" style="z-index: 1; left: 24px; position: absolute; top: 158px" Text="Date Posted"></asp:Label>
        <asp:TextBox ID="txtDatePosted" runat="server" style="z-index: 1; left: 123px; top: 157px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" height="19px" style="z-index: 1; left: 24px; top: 196px; position: absolute" Text="Quantity" width="75px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 123px; top: 195px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 24px; top: 238px; position: absolute; height: 19px; width: 75px; right: 1017px" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 123px; top: 237px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblBrand" runat="server" height="19px" style="z-index: 1; left: 24px; top: 271px; position: absolute" Text="Brand" width="75px"></asp:Label>
        <asp:TextBox ID="txtBrand" runat="server" style="z-index: 1; left: 123px; top: 270px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkBluetooth" runat="server" style="z-index: 1; left: 123px; top: 306px; position: absolute" Text="Bluetooth" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; position: absolute; top: 327px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 18px; top: 360px; position: absolute" Text="ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 58px; top: 361px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
