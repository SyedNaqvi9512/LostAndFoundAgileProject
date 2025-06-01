<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <h1>Lost And Found System</h1>
            <p>Please select one of the options below:</p>
            
            <h2>Lost Items Management</h2>
            <ul>
                <li><a href="LostItemsLogin.aspx">View/Add/Edit LostItems Records</a></li>
            </ul>
            
            <h2>Found Items Management</h2>
            <ul>
                <li><a href="FoundItemsLogin.aspx">View/Add/Edit Found Items Records</a></li>
            </ul>
            
        </div>
        </div>
    </form>
</body>
</html>
