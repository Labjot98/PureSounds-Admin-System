<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 12px; top: 38px; position: absolute; height: 19px" Text="Supplier ID" width="107px"></asp:Label>
        <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 132px; top: 34px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 15px; top: 64px; position: absolute; " Text="Supplier Name" width="107px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 132px; top: 63px; position: absolute; margin-top: 0px" ></asp:TextBox>
        <asp:Label ID="lblSupplierLocation" runat="server" style="z-index: 1; left: 15px; top: 93px; position: absolute" Text="Supplier Location"></asp:Label>
        <asp:TextBox ID="txtSupplierLocation" runat="server" style="z-index: 1; left: 132px; top: 94px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 15px; top: 130px; position: absolute" Text="Date Added" width="107px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 132px; top: 130px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:Label ID="lblSupplierQuality" runat="server" style="z-index: 1; left: 15px; top: 160px; position: absolute" Text="Supplier Quality" width="107px"></asp:Label>
        <asp:TextBox ID="txtSupplierQuality" runat="server" style="z-index: 1; left: 132px; top: 159px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSupplierCost" runat="server" style="z-index: 1; left: 15px; top: 196px; position: absolute" Text="Supplier Cost" width="107px"></asp:Label>
        <asp:TextBox ID="txtSupplierCost" runat="server" style="z-index: 1; left: 132px; top: 198px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkStockAvailable" runat="server" style="z-index: 1; left: 132px; top: 233px; position: absolute" Text="Stock Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 282px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 15px; top: 351px; position: absolute; right: 1607px; width: 31px; height: 30px;" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 74px; top: 351px; position: absolute; width: 62px; height: 30px;" Text="Cancel" />
        <p>
            &nbsp;</p>

    </form>
</body>
</html>
