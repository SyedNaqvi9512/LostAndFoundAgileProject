<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LostItemsViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>This viewer page</h1>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr><th>Lost Item ID</th><td><asp:Label ID="lblId" runat="server" /></td></tr>
                <tr><th>Title</th><td><asp:Label ID="lblTitle" runat="server" /></td></tr>
                <tr><th>Description</th><td><asp:Label ID="lblDescription" runat="server" /></td></tr>
                <tr><th>Location</th><td><asp:Label ID="lblLocation" runat="server" /></td></tr>
                <tr><th>Date Lost</th><td><asp:Label ID="lblDateLost" runat="server" /></td></tr>
                <tr><th>Is Claimed</th><td><asp:Label ID="lblIsClaimed" runat="server" /></td></tr>
            </table>
            <br />
            <asp:Button ID="btnList" runat="server" Text="Go to List Page" OnClick="btnList_Click" />
        </div>
    </form>
</body>
</html>
