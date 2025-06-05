<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 14px; top: 35px; position: absolute" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 160px; top: 35px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 420px; top: 32px; position: absolute; width: 60px" Text="Find" />

        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 14px; top: 70px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 160px; top: 70px; position: absolute; width: 220px"></asp:TextBox>
       
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 14px; top: 105px; position: absolute" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 160px; top: 105px; position: absolute; width: 220px"></asp:TextBox>
        
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 14px; top: 140px; position: absolute" Text="Total Amount"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 160px; top: 140px; position: absolute; width: 220px"></asp:TextBox>
        
        <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 14px; top: 175px; position: absolute" Text="Status"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server" style="z-index: 1; left: 160px; top: 175px; position: absolute; width: 220px"></asp:TextBox>
        
        <asp:Label ID="lblPaymentMethod" runat="server" style="z-index: 1; left: 14px; top: 210px; position: absolute; height: 19px" Text="Payment Method"></asp:Label>
        <asp:TextBox ID="txtPaymentMethod" runat="server" style="z-index: 1; left: 160px; top: 210px; position: absolute; width: 220px"></asp:TextBox>
        
        <asp:CheckBox ID="chkDiscountApplied" runat="server" style="z-index: 1; left: 160px; top: 245px; position: absolute" Text="Discount Applied" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 284px; position: absolute"></asp:Label>

        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 312px; position: absolute; width: 59px; height: 28px;" Text="OK" />
        <asp:Button ID="btnCancel" OnClick="btnOK_Cancel" runat="server" style="z-index: 1; left: 100px; top: 315px; width: 60px; position: absolute" Text="Cancel" />
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
            <asp:Button ID="btnReturn" runat="server" Height="27px" style="margin-left: 195px" OnClick="btnReturn_Click" Text="Return to Main Menu" Width="141px" />
        </p>
    </form>
</body>
</html>
