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
        clsLostItems AnLostItems = new clsLostItems();
        AnLostItems = (clsLostItems)Session["AnLostItems"];
        Response.Write(AnLostItems.Id);
        Response.Write(AnLostItems.Title);
        Response.Write(AnLostItems.Description); 
        Response.Write(AnLostItems.Location);
        Response.Write(AnLostItems.IsClaimed);
    }
}