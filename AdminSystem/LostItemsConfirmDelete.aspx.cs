using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 LostItemsId;
    protected void Page_Load(object sender, EventArgs e)
    {
        LostItemsId = Convert.ToInt32(Session["LostItemsId"]);

    }

    protected void ButtonConfirmDelete_Click(object sender, EventArgs e)
    {
        // Create an instance of the clsLostItemsCollection class
        clsLostItemsCollection LostItems = new clsLostItemsCollection();
        // Find the record based on the Id
        LostItems.ThisLostItems.Find(LostItemsId);
        // Delete the record
        LostItems.Delete();
        // Redirect to the LostItemsList page
        Response.Redirect("LostItemsList.aspx");

    }

    protected void ButtonCancelDelete_Click(object sender, EventArgs e)
    {
        // Redirect to the LostItemsList page without deleting
        Response.Redirect("LostItemsList.aspx");

    }
}