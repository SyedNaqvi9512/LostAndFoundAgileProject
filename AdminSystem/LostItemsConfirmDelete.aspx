<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LostItemsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Confirm Delete</h2>
            <p>Are you sure you want to delete the following item?</p>
            <table>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="ButtonConfirmDelete" runat="server" Text="Confirm Delete" OnClick="ButtonConfirmDelete_Click" />
                        <asp:Button ID="ButtonCancelDelete" runat="server" Text="Cancel" OnClick="ButtonCancelDelete_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
