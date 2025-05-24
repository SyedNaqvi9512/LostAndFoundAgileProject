using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["LostItemsId"] = -1; // Set the session variable to -1 to indicate a new item
        // Redirect to the LostItemsDataEntry page
        Response.Redirect("LostItemsDataEntry.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Int32 lostItemsID;
        if (lstLostItemsList.SelectedIndex != -1) 
        {
            // Get the primary key value of the selected item
            lostItemsID = Convert.ToInt32(lstLostItemsList.SelectedValue);
            // Store the primary key in the session variable
            Session["LostItemsId"] = lostItemsID;
            // Redirect to the LostItemsDataEntry page
            Response.Redirect("LostItemsDataEntry.aspx");
        }
        else
        {
            // Display a message if no item is selected
            LblError.Text = "Please select an item to update.";

        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 lostItemsID;
        if (lstLostItemsList.SelectedIndex != -1)
        {
            // Get the primary key value of the selected item
            lostItemsID = Convert.ToInt32(lstLostItemsList.SelectedValue);
            // Store the primary key in the session variable
            Session["LostItemsId"] = lostItemsID;
            // Redirect to the LostItemsDataEntry page
            Response.Redirect("LostItemsConfirmDelete.aspx");
        }
        else
        {
            // Display a message if no item is selected
            LblError.Text = "Please select an item to delete.";
        }

    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
     
        string filterTitle = txtFilterTitle.Text.Trim();
        ClassLibrary.clsLostItemsCollection collection = new ClassLibrary.clsLostItemsCollection();
        collection.ReportByTitle(filterTitle);
        lstLostItemsList.DataSource = collection.LostItemsList;
        lstLostItemsList.DataValueField = "Id";
        lstLostItemsList.DataTextField = "Title";
        lstLostItemsList.DataBind();
    
}
}