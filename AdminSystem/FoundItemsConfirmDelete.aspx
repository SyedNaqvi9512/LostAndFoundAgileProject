<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FoundItemsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Confirm Delete</h2>
            <p>Are you sure you want to delete this item?</p>
            <asp:Label ID="LabelItemDetails" runat="server" Text="Item details will be displayed here." />
            <br />
            <asp:Button ID="ButtonConfirmDelete" runat="server" Text="Yes, Delete" OnClick="ButtonConfirmDelete_Click" />
            <asp:Button ID="ButtonCancelDelete" runat="server" Text="No, Cancel" OnClick="ButtonCancelDelete_Click" />
            <br />
            <asp:Label ID="LabelError" runat="server" ForeColor="Red" />

        </div>
    </form>
</body>
</html>
