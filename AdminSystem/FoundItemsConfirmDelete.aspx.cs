using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Id = Convert.ToInt32(Session["FoundItemsId"]);
    }

    protected void ButtonConfirmDelete_Click(object sender, EventArgs e)
    {
        // Create an instance of the found items collection
        clsFoundItemsCollection FoundItems = new clsFoundItemsCollection();
        // Find the record to delete
        FoundItems.ThisFoundItems.Find(Id);
        // Delete the record
        FoundItems.Delete();
        // Redirect to the list page
        Response.Redirect("FoundItemsList.aspx");

    }

    protected void ButtonCancelDelete_Click(object sender, EventArgs e)
    {
        // Redirect to the list page without deleting
        Response.Redirect("FoundItemsList.aspx");

    }
}