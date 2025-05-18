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
        if (!IsPostBack)
        {
            // Update the list box
            DisplayLostItems();
        }

    }
    void DisplayLostItems()
    {
        // Create an instance of the lost items collection
        ClassLibrary.clsLostItemsCollection LostItems = new ClassLibrary.clsLostItemsCollection();
        // Set the data source to the list of lost items
        lstLostItemsList.DataSource = LostItems.LostItemsList;
        // Set the name of the primary key
        lstLostItemsList.DataValueField = "Id";
        // Set the name of the field to display
        lstLostItemsList.DataTextField = "Title";
        // Bind the data to the list box
        lstLostItemsList.DataBind();
    }
}