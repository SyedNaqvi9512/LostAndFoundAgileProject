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
            <asp:Button ID="btnDelete" runat="server" Text="DeleteBtn" OnClick="btnDelete_Click" Style="height: 26px" />
            
            <asp:Button ID="btnEdit" runat="server" Text="EditBtn" OnClick="btnEdit_Click" style="height: 26px" />

            <asp:TextBox ID="txtFilterTitle" runat="server" />
            <asp:Button ID="btnFilter" runat="server" Text="FilterBtn" OnClick="btnFilter_Click" />
            <asp:Label ID="LablError" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
