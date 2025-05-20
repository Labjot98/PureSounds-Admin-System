<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
        </div>

        <asp:ListBox runat="server" ID="lstCustomerList" Height="240px" Width="260px"></asp:ListBox>
        <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; width: 60px" Text="Add" />
        </p>
    </form>
</body>
</html>

