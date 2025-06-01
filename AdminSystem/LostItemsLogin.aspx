<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LostItemsLogin.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>

            <asp:Label ID="lblUsername" runat="server" Text="Username:" AssociatedControlID="txtUsername" /><br />
            <asp:TextBox ID="txtUsername" runat="server" /><br /><br />

            <asp:Label ID="lblPassword" runat="server" Text="Password:" AssociatedControlID="txtPassword" /><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br /><br />

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br /><br />

            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
           
        </div>
    </form>
</body>
</html>
