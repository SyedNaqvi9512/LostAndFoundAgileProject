using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 LostItemsId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Request.UrlReferrer == null)
        {
            // If the page is loaded directly (not via redirect), clear the session variable
            Session["LostItemsId"] = null;
        }
        int id;
        if (Session["LostItemsId"] != null && int.TryParse(Session["LostItemsId"].ToString(), out id))
        {
            LostItemsId = id;
        }
        else
        {
            LostItemsId = -1;
        }

        if (!IsPostBack)
        {
            // Only display if editing an existing item
            if (LostItemsId != -1)
            {
                DisplayLostItems();
            }
            else
            {
                // Clear all textboxes for a new entry
                TextBoxId.Text = "";
                TextBoxTitle.Text = "";
                TextBoxDescription.Text = "";
                TextBoxLocation.Text = "";
                TextBoxDateLost.Text = "";
                TextBoxIsClaimed.Text = "";
                LabelError.Text = "";
            }
        }
    }
    void DisplayLostItems()
    {
        // Create an instance of the clsLostItems class
        clsLostItems AnLostItems = new clsLostItems();
        // Find the record based on the Id
        AnLostItems.Find(LostItemsId);
        // Populate the textboxes with the data from the record
        TextBoxId.Text = AnLostItems.Id.ToString();
        TextBoxTitle.Text = AnLostItems.Title;
        TextBoxDescription.Text = AnLostItems.Description;
        TextBoxLocation.Text = AnLostItems.Location;
        TextBoxDateLost.Text = AnLostItems.DateLost.ToString("yyyy-MM-dd");
        TextBoxIsClaimed.Text = AnLostItems.IsClaimed;
    }


    protected void ButtonOk_Click(object sender, EventArgs e)
    {

        // Validate if the entered Id is a valid integer
        int id;
        if (!int.TryParse(TextBoxId.Text, out id))
        {
            LabelError.Text = "Please enter a valid numeric Id.";
            return;
        }

        // Gather input values
        string title = TextBoxTitle.Text;
        string description = TextBoxDescription.Text;
        string location = TextBoxLocation.Text;
        string dateLost = TextBoxDateLost.Text;
        string isClaimed = TextBoxIsClaimed.Text;

        // Create and validate the lost item
        clsLostItems lostItem = new clsLostItems();
        string error = lostItem.Valid(title, description, location, dateLost, isClaimed);

        if (error != "")
        {
            LabelError.Text = error;
            return;
        }

        // Assign values to the lost item
        lostItem.Id = id;
        lostItem.Title = title;
        lostItem.Description = description;
        lostItem.Location = location;
        lostItem.DateLost = Convert.ToDateTime(dateLost);
        lostItem.IsClaimed = isClaimed;

        // Create the collection and set the current item
        clsLostItemsCollection collection = new clsLostItemsCollection();
        collection.ThisLostItems = lostItem;

        if (LostItemsId == -1)
        {
            // Add new item
            collection.Add();
        }
        else
        {
            // Update existing item
            collection.Update();
        }

        // Store in session and redirect
        Session["AnLostItems"] = lostItem;
        Response.Redirect("LostItemsViewer.aspx");
    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        clsLostItems AnLostItems = new clsLostItems();
        int Id;
        bool Found = false;

        // Validate if the entered Id is a valid integer
        if (int.TryParse(TextBoxId.Text, out Id))
        {
            // Call the Find method
            Found = AnLostItems.Find(Id);

            // If a record is found, populate the textboxes
            if (Found)
            {
                TextBoxTitle.Text = AnLostItems.Title;
                TextBoxDescription.Text = AnLostItems.Description;
                TextBoxLocation.Text = AnLostItems.Location;
                TextBoxIsClaimed.Text = AnLostItems.IsClaimed;
                TextBoxId.Text = AnLostItems.Id.ToString();
                TextBoxDateLost.Text = AnLostItems.DateLost.ToString("yyyy-MM-dd");
                LabelError.Text = "";
            }
            else
            {
                // Display an error message if no record is found
                LabelError.Text = "Record not found.";
            }
        }
        else
        {
            // Show a validation error if ID is missing or invalid
            LabelError.Text = "Please enter a valid numeric Id.";
        }
    }
    }