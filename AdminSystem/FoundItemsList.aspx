<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FoundItemsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstFoundItemsList" runat="server"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" Text="AddBtn" OnClick="btnAdd_Click" />
        </div>
    </form>
</body>
</html>
