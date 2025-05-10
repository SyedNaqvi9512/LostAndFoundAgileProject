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
        AnLostItems.Title = TextBoxTitle.Text;
        AnLostItems.Description = TextBoxDescription.Text;
        AnLostItems.Location = TextBoxLocation.Text;
        AnLostItems.IsClaimed = TextBoxIsClaimed.Text;
        Session["AnLostItems"] = AnLostItems;
        Response.Redirect("LostItemsViewer.aspx");
    }
}