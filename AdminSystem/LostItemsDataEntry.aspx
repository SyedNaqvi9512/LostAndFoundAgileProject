<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LostItemsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <div>
            <table>
    <tr>
        <td><asp:Label ID="LabeId" runat="server" Text="Enter Id:" /></td>
        <td><asp:TextBox ID="TextBoxId" runat="server" /></td>
    </tr>
    <tr>
        <td><asp:Label ID="LabelTitle" runat="server" Text="Enter Title:" /></td>
        <td><asp:TextBox ID="TextBoxTitle" runat="server" /></td>
    </tr>
    <tr>
        <td><asp:Label ID="LabelDescription" runat="server" Text="Enter Description:" /></td>
        <td><asp:TextBox ID="TextBoxDescription" runat="server" /></td>
    </tr>
    <tr>
        <td><asp:Label ID="LabelLocation" runat="server" Text="Enter Location:" /></td>
        <td><asp:TextBox ID="TextBoxLocation" runat="server" /></td>
    </tr>
    <tr>
        <td><asp:Label ID="LabelIsClaimed" runat="server" Text="Is Claimed:" /></td>
        <td><asp:TextBox ID="TextBoxIsClaimed" runat="server" /></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="LabelError" runat="server" ForeColor="Red" />
        </td>
    </tr>
               
    <tr>
        <td>
            <asp:Button ID="ButtonOk" runat="server" Text="OK" OnClick="ButtonOk_Click" /></td>
        <td>
    <asp:Button ID="ButtonFind" runat="server" Text="Find" OnClick="ButtonFind_Click" />
</td>
        
        <td><asp:Button ID="ButtonCancel" runat="server" Text="Cancel" /></td>
    </tr>

</table>

        </div>
    </form>
</body>
</html>
