<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     
        <asp:ListBox runat="server" ID="lstOrderList" Height="240px" Width="260px"></asp:ListBox>
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </div>

        <div>
            <asp:Label ID="lblFilter" runat="server" Text="Enter a date: "></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" ></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" />
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click"  Text="Return to the Main Menu" />
        </div>

        <div>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>

    </form>
</body>
</html>
