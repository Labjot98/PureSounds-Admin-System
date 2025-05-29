<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
        </div>
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 11px; top: 41px; position: absolute; height: 283px; width: 327px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 319px; top: 626px; position: absolute; width: 179px" Text="Return To Main Menu" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 29px; top: 582px; position: absolute" Text="Enter Item Name"></asp:Label>
            <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 44px; top: 623px; position: absolute; right: 1039px" Text="Apply Filter" width="95px" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Height="30px" Width="53px" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete"  OnClick="btnDelete_Click" Width="57px" Height="31px" />
            <asp:Button ID="btnEdit" runat="server"   Text="Edit" OnClick="btnEdit_Click" Height="29px" Width="46px" />
        </p>
            <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 171px; top: 624px; position: absolute; margin-bottom: 0px;" Text="Clear Filter" OnClick="btnClearFilter_Click" />
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 151px; top: 581px; position: absolute; width: 200px"></asp:TextBox>
        </p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
