<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer List</title>

    <!--CSS File -->
    <link rel="stylesheet" href="./Styles/ListStyles.css"/>

    <!--Google Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">

        <div class="filter-main-cont">
            <div class="filter-input-cont">
                <asp:Label ID="lblFilterFullname" runat="server" Text="Enter a name"></asp:Label>
                <asp:TextBox ID="txtFilterFullname" runat="server" ></asp:TextBox>

            </div>
            <div class="apply-filter-btn-cont">
                 <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
                 <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" />
            </div>
        </div>

        <asp:ListBox runat="server" ID="lstCustomerList" ></asp:ListBox>

        <div class="bottom-btn-cont">
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click"  Text="Delete" />
        <asp:Button ID="btnReturnToMain" runat="server" OnClick="btnReturn_Click"  Text="Return to Main Menu" />
        </div>

        <asp:Label ID="lblError" runat="server" ></asp:Label>
     
    </form>
</body>
</html>

