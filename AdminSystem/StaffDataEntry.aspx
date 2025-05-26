<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 573px; width: 853px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 27px; top: 156px; position: absolute; width: 101px;" Text="Date Joined"></asp:Label>
        <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 142px; top: 153px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateLeft" runat="server" style="z-index: 1; left: 27px; top: 210px; position: absolute" Text="Date Left" width="101px"></asp:Label>
        <asp:TextBox ID="txtDateLeft" runat="server" style="z-index: 1; left: 142px; top: 209px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblRank" runat="server" style="z-index: 1; left: 27px; top: 281px; position: absolute" Text="Rank" width="101px"></asp:Label>
        <asp:TextBox ID="txtRank" runat="server" OnTextChanged="txtRank_TextChanged" style="z-index: 1; left: 140px; top: 276px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblNINumber" runat="server" style="z-index: 1; left: 27px; top: 348px; position: absolute" Text="NI Number" width="101px"></asp:Label>
        <asp:TextBox ID="txtNINumber" runat="server" style="z-index: 1; left: 142px; top: 348px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 132px; top: 466px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 202px; top: 467px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 27px; top: 107px; position: absolute" Text="Name" width="101px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 142px; top: 103px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 27px; top: 58px; position: absolute" Text="Staff ID" width="101px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 142px; top: 57px; position: absolute"></asp:TextBox>
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
        <asp:CheckBox ID="chkIsFemale" runat="server" style="z-index: 1; left: 139px; top: 411px; position: absolute; margin-top: 4px;" Text="Is Female" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 462px; position: absolute; margin-top: 0px;" width="101px"></asp:Label>
        </p>
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
        <div style="margin-left: 200px">
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" Width="54px" />
            <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 321px; top: 466px; position: absolute" Text="Return to Main Menu" />
        </div>
    </form>
</body>
</html>
