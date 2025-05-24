using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        clsLostItems AnLostItems = new clsLostItems();
        AnLostItems.Id = Convert.ToInt32(TextBoxId.Text);
        string Title = TextBoxTitle.Text;
        string Description = TextBoxDescription.Text;
        string Location = TextBoxLocation.Text;
        string IsClaimed = TextBoxIsClaimed.Text;
        string DateLost = TextBoxDateLost.Text;



        string error = "";
        error = AnLostItems.Valid(Title,Description,Location,DateLost,IsClaimed);
        if (error == "")
        {
            AnLostItems.Id = Convert.ToInt32(TextBoxId.Text);
            AnLostItems.Title = Title;
            AnLostItems.Description = Description;
            AnLostItems.Location = Location;
            AnLostItems.DateLost = Convert.ToDateTime(DateLost);
            AnLostItems.IsClaimed = IsClaimed;

            // Create a new instance of the collection
            clsLostItemsCollection AnLostItemsCollection = new clsLostItemsCollection();
            // Set the ThisLostItems property to the new item
            AnLostItemsCollection.ThisLostItems = AnLostItems;
            // Add the item to the collection
            AnLostItemsCollection.Add();

            Session["AnLostItems"] = AnLostItems;
            Response.Redirect("LostItemsViewer.aspx");

        }
        else
        {
                       LabelError.Text = error;
        }
    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        clsLostItems AnLostItems = new clsLostItems();
        Int32 Id;
        Boolean Found = false;

        // Convert the entered Id from the TextBox
        Id = Convert.ToInt32(TextBoxId.Text);

        // Call the Find method
        Found = AnLostItems.Find(Id);

        // If a record is found, populate the textboxes
        if (Found == true)
        {
            TextBoxTitle.Text = AnLostItems.Title;
            TextBoxDescription.Text = AnLostItems.Description;
            TextBoxLocation.Text = AnLostItems.Location;
            TextBoxIsClaimed.Text = AnLostItems.IsClaimed;
            TextBoxId.Text = AnLostItems.Id.ToString();
        }
        else
        {
            // Display an error message if no record is found
            LabelError.Text = "Record not found.";
        }
    }
}