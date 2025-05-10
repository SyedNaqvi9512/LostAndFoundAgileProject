using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsFoundItems AnFoundItems = new clsFoundItems();
        AnFoundItems = (clsFoundItems)Session["AnFoundItems"];
        Response.Write(AnFoundItems.Id);
        Response.Write(AnFoundItems.Title);
        Response.Write(AnFoundItems.Location);
    }
}