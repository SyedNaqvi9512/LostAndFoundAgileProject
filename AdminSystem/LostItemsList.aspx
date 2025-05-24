<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LostItemsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstLostItemsList" runat="server"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Label ID="LabelError" runat="server" ForeColor="Red" />
           
          
        </div>
    </form>
</body>
</html>
