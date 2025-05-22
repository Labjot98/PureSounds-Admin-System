<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 485px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
        </div>

        <asp:ListBox runat="server" ID="lstCustomerList" Height="240px" Width="260px"></asp:ListBox>

        <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; width: 60px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; width: 60px; margin-left:60px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; width: 60px; margin-left:60px" Text="Delete" />
        </p>

        <div>
            <asp:Label ID="lblFilterFullname" runat="server" style="top:350px; position:absolute" Text="Enter a name"></asp:Label>
            <asp:TextBox ID="txtFilterFullname" runat="server" style="width: 220px; top:350px; left:100px; position:absolute"></asp:TextBox>

            <div>
                 <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="width: 100px; position:absolute; top:400px; left: 70px;" Text="Apply Filter" />
                 <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="width: 100px; position:absolute; top:400px; left: 180px;" Text="Clear Filter" />
            </div>
        </div>

        <asp:Label ID="lblError" runat="server" style="width:100px; position:absolute; top:450px"></asp:Label>
     
    </form>
</body>
</html>

