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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        clsFoundItems AnFoundItems = new clsFoundItems();
        AnFoundItems.Id = Convert.ToInt32(TextBoxId.Text);
        string Title = TextBoxTitle.Text;
        string Location = TextBoxLocation.Text;
        string IsReturned = TextBoxIsReturned.Text;
        string DateFound = TextBoxDateFound.Text;

        string error = "";
        error = AnFoundItems.Valid(Title, Location, DateFound, IsReturned);
        if (error == "")
        {
            AnFoundItems.Id = Convert.ToInt32(TextBoxId.Text);
            AnFoundItems.Title = Title;
            AnFoundItems.Location = Location;
            AnFoundItems.DateFound = Convert.ToDateTime(DateFound);
            AnFoundItems.IsReturned = IsReturned;
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