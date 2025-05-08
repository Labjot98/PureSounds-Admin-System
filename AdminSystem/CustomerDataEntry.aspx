<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 14px; top: 35px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 160px; top: 35px; position: absolute; width: 220px"></asp:TextBox>

        <asp:Label ID="lblCustomerFullname" runat="server" style="z-index: 1; left: 14px; top: 70px; position: absolute" Text="Customer Fullname"></asp:Label>
        <asp:TextBox ID="txtCustomerFullname" runat="server" style="z-index: 1; left: 160px; top: 70px; position: absolute; width: 220px"></asp:TextBox>
       
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 14px; top: 105px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 160px; top: 105px; position: absolute; width: 220px"></asp:TextBox>
        
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 14px; top: 140px; position: absolute" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 160px; top: 140px; position: absolute; width: 220px"></asp:TextBox>
        
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 14px; top: 175px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 160px; top: 175px; position: absolute; width: 220px"></asp:TextBox>
        
        <asp:Label ID="lblCreatedOn" runat="server" style="z-index: 1; left: 14px; top: 210px; position: absolute; height: 19px" Text="Created On"></asp:Label>
        <asp:TextBox ID="txtCreatedOn" runat="server" style="z-index: 1; left: 160px; top: 210px; position: absolute; width: 220px"></asp:TextBox>
        
        <asp:CheckBox ID="chkBonusEligibility" runat="server" style="z-index: 1; left: 160px; top: 245px; position: absolute" Text=" Bonus Eligibility" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 280px; position: absolute"></asp:Label>

        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 315px; position: absolute; width: 60px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 100px; top: 315px; width: 60px; position: absolute" Text="Cancel" />

    </form>
</body>
</html>
