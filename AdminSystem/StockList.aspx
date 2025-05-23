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
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 12px; top: 16px; position: absolute; height: 372px; width: 327px"></asp:ListBox>
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
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Height="25px" />
            <asp:Button ID="btnEdit" runat="server"   Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete"  OnClick="btnDelete_Click" Width="47px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 30px; top: 561px; position: absolute" Text="Enter Item Name"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 49px; top: 602px; position: absolute; right: 1334px" Text="Apply Filter" width="95px" />
        </p>
            <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 185px; top: 602px; position: absolute; margin-bottom: 0px;" Text="Clear Filter" OnClick="btnClearFilter_Click" />
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 152px; top: 561px; position: absolute; width: 200px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
