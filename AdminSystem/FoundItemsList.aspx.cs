using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Update the list box
            DisplayFoundItems();
        }
    }

    void DisplayFoundItems()
    {
        // Create an instance of the found items collection
        ClassLibrary.clsFoundItemsCollection FoundItems = new ClassLibrary.clsFoundItemsCollection();
        // Set the data source to the list of found items
        lstFoundItemsList.DataSource = FoundItems.FoundItemsList;
        // Set the name of the primary key
        lstFoundItemsList.DataValueField = "Id";
        // Set the name of the field to display
        lstFoundItemsList.DataTextField = "Title";
        // Bind the data to the list box
        lstFoundItemsList.DataBind();
    }
}