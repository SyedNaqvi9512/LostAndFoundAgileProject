using ClassLibrary;
using System;
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
        AnFoundItems.Title = TextBoxTitle.Text;
        AnFoundItems.Location = TextBoxLocation.Text;
        AnFoundItems.IsReturned = TextBoxIsReturned.Text;
        Session["AnFoundItems"] = AnFoundItems;
        Response.Redirect("FoundItemsViewer.aspx");
    }
}