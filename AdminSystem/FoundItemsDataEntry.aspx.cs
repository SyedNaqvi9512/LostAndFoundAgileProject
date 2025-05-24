using ClassLibrary;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the Id from the session variable
        Id = Convert.ToInt32(Session["FoundItemsId"]);
        if (IsPostBack == false)
        {
            // If this is not a new record, display the current data
            if (Id != -1)
            {
                DisplayFoundItems();
            }
        }

    }

    private void DisplayFoundItems()
    {
        // Create an instance of the found items class
        clsFoundItems AnFoundItems = new clsFoundItems();
        // Find the record using the Id
        AnFoundItems.Find(Id);
        // Display the data in the textboxes
        TextBoxId.Text = AnFoundItems.Id.ToString();
        TextBoxTitle.Text = AnFoundItems.Title;
        TextBoxLocation.Text = AnFoundItems.Location;
        TextBoxDateFound.Text = AnFoundItems.DateFound.ToString("yyyy-MM-dd");
        TextBoxIsReturned.Text = AnFoundItems.IsReturned;
    }

    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        clsFoundItems AnFoundItems = new clsFoundItems();
        int id;
        // Validate Id input
        if (!int.TryParse(TextBoxId.Text, out id))
        {
            LabelError.Text = "Please enter a valid numeric Id.";
            return;
        }
        AnFoundItems.Id = id;

        string Title = TextBoxTitle.Text;
        string Location = TextBoxLocation.Text;
        string IsReturned = TextBoxIsReturned.Text;
        string DateFound = TextBoxDateFound.Text;

        // Validate using your business logic
        string error = AnFoundItems.Valid(Title, Location, DateFound, IsReturned);

        // Additional date validation for UI
        DateTime parsedDate;
        if (error == "")
        {
            if (!DateTime.TryParse(DateFound, out parsedDate))
            {
                LabelError.Text = "Please enter a valid date.";
                return;
            }
            if (parsedDate < new DateTime(1753, 1, 1) || parsedDate > new DateTime(9999, 12, 31))
            {
                LabelError.Text = "Date must be between 01/01/1753 and 12/31/9999.";
                return;
            }
            if (parsedDate > DateTime.Now.Date)
            {
                LabelError.Text = "Date cannot be in the future.";
                return;
            }

            AnFoundItems.Title = Title;
            AnFoundItems.Location = Location;
            AnFoundItems.DateFound = parsedDate;
            AnFoundItems.IsReturned = IsReturned;
            
            // Add the item to the collection
            clsFoundItemsCollection AnFoundItemsCollection = new clsFoundItemsCollection();
            AnFoundItemsCollection.ThisFoundItems = AnFoundItems;
            AnFoundItemsCollection.Add();
            //if this is a new record  , Id = -1 then add the data
            if (Id == -1)
            {
                //set the ThisFoundItem property
                AnFoundItemsCollection.ThisFoundItems = AnFoundItems;

                // Set the Id to the newly added record's Id
                AnFoundItems.Id = AnFoundItemsCollection.ThisFoundItems.Id;
            }
            else
            {

                // Find the record to update
                AnFoundItemsCollection.ThisFoundItems.Find(Id);
                // Set the ThisFoundItems property to the new data
                AnFoundItemsCollection.ThisFoundItems = AnFoundItems;
                // Update the existing record
                AnFoundItemsCollection.Update();
            }

            Session["AnFoundItems"] = AnFoundItems;
            Response.Redirect("FoundItemsViewer.aspx");


        }
        else
        {
            LabelError.Text = error;
        }
    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        clsFoundItems AnFoundItems = new clsFoundItems();
        int Id;

        // Validate if the entered Id is a valid integer
        if (int.TryParse(TextBoxId.Text, out Id))
        {
            // Attempt to find the record
            if (AnFoundItems.Find(Id))
            {
                // Populate the textboxes with the retrieved data
                TextBoxTitle.Text = AnFoundItems.Title;
                TextBoxLocation.Text = AnFoundItems.Location;
                TextBoxIsReturned.Text = AnFoundItems.IsReturned;
                LabelError.Text = ""; // Clear any previous error messages
            }
            else
            {
                // Display an error if the record is not found
                LabelError.Text = "Record not found.";
            }
        }
        else
        {
            // Display an error if the Id is invalid
            LabelError.Text = "Please enter a valid numeric Id.";
        }
    }
}