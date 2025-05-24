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
        // Get the Id from the session variable
        LostItemsId = Convert.ToInt32(Session["LostItemsId"]);
        if (!IsPostBack)
        {
            // If the Id is not -1, it means we are editing an existing item
            if (LostItemsId != -1)
            {
                DisplayLostItems();
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
            // If the Id is -1, it means we are adding a new item
            AnLostItemsCollection.ThisLostItems = AnLostItems;
            if (LostItemsId == -1)
            {
                //set the thisLostItems property
                AnLostItemsCollection.ThisLostItems = AnLostItems;


                // Add a new item to the collection
                AnLostItemsCollection.Add();
            }
            else
            {
                //find record to update
                AnLostItemsCollection.ThisLostItems.Find(LostItemsId);
                //set the ThisLostItems property
                AnLostItemsCollection.ThisLostItems = AnLostItems;

                // Update the existing item in the collection
                AnLostItemsCollection.Update();
            }
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