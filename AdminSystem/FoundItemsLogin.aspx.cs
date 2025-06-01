using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsFoundItemsUsers AUser = new clsFoundItemsUsers();


        // Create the variables to store the username and password
        string UserName = txtUsername.Text;
        string Password = txtPassword.Text;

        // Create a variable to store the result of the find user operation
        Boolean Found = false;

        // Validate input fields
        if (string.IsNullOrWhiteSpace(UserName))
        {
            lblMessage.Text = "Enter a username.";
            return;
        }

        if (string.IsNullOrWhiteSpace(Password))
        {
            lblMessage.Text = "Enter a password.";
            return;
        }

        // Try to find the user
        Found = AUser.FindUser(UserName, Password);

        if (Found)
        {
            // Login successful
            Response.Redirect("FoundItemsList.aspx"); // or any destination page
        }
        else
        {
            // Login failed
            lblMessage.Text = "Login details are incorrect. Please try again.";
        }
    }


}
