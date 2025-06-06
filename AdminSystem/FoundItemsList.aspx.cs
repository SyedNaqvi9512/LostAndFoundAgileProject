﻿using System;
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //session variable to indicate a new item
        Session["FoundItemsId"] = -1; // Set the session variable to -1 to indicate a new item

        // Redirect to the data entry page
        Response.Redirect("FoundItemsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Check if an item is selected
        if (lstFoundItemsList.SelectedIndex != -1)
        {
            // Get the selected item ID
            int FoundItemsId = Convert.ToInt32(lstFoundItemsList.SelectedValue);
            // Store the ID in the session variable
            Session["FoundItemsId"] = FoundItemsId;
            // Redirect to the data entry page
            Response.Redirect("FoundItemsDataEntry.aspx");
        }
        else
        {
            // Display a message if no item is selected
            LablError.Text = "Please select an item to edit.";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Check if an item is selected
        if (lstFoundItemsList.SelectedIndex != -1)
        {
            // Get the selected item ID
            int FoundItemsId = Convert.ToInt32(lstFoundItemsList.SelectedValue);
            // Store the ID in the session variable
            Session["FoundItemsId"] = FoundItemsId;
            // Redirect to the delete confirmation page
            Response.Redirect("FoundItemsConfirmDelete.aspx");
        }
        else
        {
            // Display a message if no item is selected
            LablError.Text = "Please select an item to delete.";
        }

    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        string filter = txtFilterTitle.Text.Trim();
        ClassLibrary.clsFoundItemsCollection collection = new ClassLibrary.clsFoundItemsCollection();

        int id;
        if (int.TryParse(filter, out id))
        {
            // Filter by ID
            collection.ReportById(id);
        }
        else
        {
            // Show validation error if not a valid ID
            LablError.Text = "Please enter a valid numeric Id to filter.";
            return;
        }

        lstFoundItemsList.DataSource = collection.FoundItemsList;
        lstFoundItemsList.DataValueField = "Id";
        lstFoundItemsList.DataTextField = "Title";
        lstFoundItemsList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clear the filter text box
        txtFilterTitle.Text = string.Empty;
        // Re-display all found items
        DisplayFoundItems();
        // Clear any error messages
        LablError.Text = string.Empty;

    }
}