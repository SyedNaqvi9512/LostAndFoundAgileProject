<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LostItemsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
        .button-spacing {
            margin-right: 10px;
        }
        .button-color {
            background-color: #17a2b8;
            color: #fff;
            border: none;
            padding: 6px 18px;
            border-radius: 4px;
            cursor: pointer;
            font-size: 15px;
            transition: background 0.2s;
        }
        .button-color:hover {
            background-color: #138496;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="button-spacing button-color" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" CssClass="button-spacing button-color" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="button-spacing button-color" />
                    <asp:Button ID="btnFilter" runat="server" Text="Filter by ID" OnClick="btnFilter_Click" CssClass="button-spacing button-color" />
                    <asp:TextBox ID="txtFilterTitle" runat="server" CssClass="button-spacing" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CssClass="button-color" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="lstLostItemsList" runat="server" Rows="15" Width="400px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LablError" runat="server" ForeColor="Red" />
                </td>
            </tr>
        </table>
    </form>
</body>

</html>
