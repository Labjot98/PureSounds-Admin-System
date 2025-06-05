<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>

    <!--CSS File -->
    <link rel="stylesheet" href="./Styles/DataEntryStyles.css"/>

    <!--Google Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="left-cont">
            <div class="input-field">
                <asp:Label ID="lblCustomerId" runat="server" class="lbl" Text="Customer ID"></asp:Label>
                <asp:TextBox ID="txtCustomerId" runat="server" class="txtBox" ></asp:TextBox>
            </div>

            <div class="input-field">
                <asp:Label ID="lblCustomerFullname" runat="server" class="lbl" Text="Customer Fullname"></asp:Label>
                <asp:TextBox ID="txtCustomerFullname" runat="server" class="txtBox"></asp:TextBox>
            </div>
       
            <div class="input-field">
                <asp:Label ID="lblEmail" runat="server" class="lbl" Text="Email"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" class="txtBox"></asp:TextBox>
            </div>
        
            <div class="input-field">
                <asp:Label ID="lblAddress" runat="server" class="lbl" Text="Address"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server" class="txtBox"></asp:TextBox>
            </div>
        
            <div class="input-field">
                <asp:Label ID="lblPassword" runat="server" class="lbl" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" class="txtBox"></asp:TextBox>
            </div>

            <div class="input-field">
                <asp:Label ID="lblCreatedOn" runat="server" class="lbl" Text="Created On"></asp:Label>
                <asp:TextBox ID="txtCreatedOn" runat="server" class="txtBox"></asp:TextBox>
            </div>
        
            <div class="chkBox">
                <asp:CheckBox ID="chkBonusEligibility" runat="server" Text=" Bonus Eligibility" />
            </div>

            <div class="bottom-btn-cont">
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                <asp:Button ID="btnReturnToMain" runat="server" OnClick="btnReturn_Click"  Text="Return to List" />
            </div>

            <asp:Label ID="lblError" runat="server" ></asp:Label>
        </div>

        <div class="right-cont">
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>

    </form>
</body>
</html>
