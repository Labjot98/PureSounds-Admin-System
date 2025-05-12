<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 27px; top: 156px; position: absolute; width: 101px;" Text="Date Joined"></asp:Label>
        <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 142px; top: 153px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateLeft" runat="server" style="z-index: 1; left: 27px; top: 210px; position: absolute" Text="Date Left" width="101px"></asp:Label>
        <asp:TextBox ID="txtDateLeft" runat="server" style="z-index: 1; left: 142px; top: 209px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblRank" runat="server" style="z-index: 1; left: 27px; top: 281px; position: absolute" Text="Rank" width="101px"></asp:Label>
        <asp:TextBox ID="txtRank" runat="server" OnTextChanged="txtRank_TextChanged" style="z-index: 1; left: 124px; top: 276px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblNINumber" runat="server" style="z-index: 1; left: 27px; top: 348px; position: absolute" Text="NI Number" width="101px"></asp:Label>
        <asp:TextBox ID="txtNINumber" runat="server" style="z-index: 1; left: 142px; top: 348px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkIsFemale" runat="server" style="z-index: 1; left: 142px; top: 401px; position: absolute" Text="Is Female" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 27px; top: 455px; position: absolute" width="101px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 142px; top: 468px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 216px; top: 469px; position: absolute" Text="Cancel" />
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
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
