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
        if (!IsPostBack)
        {
            clsLostItems AnLostItems = Session["AnLostItems"] as clsLostItems;
            if (AnLostItems != null)
            {
                lblId.Text = AnLostItems.Id.ToString();
                lblTitle.Text = AnLostItems.Title;
                lblDescription.Text = AnLostItems.Description;
                lblLocation.Text = AnLostItems.Location;
                lblDateLost.Text = AnLostItems.DateLost.ToString("yyyy-MM-dd");
                lblIsClaimed.Text = AnLostItems.IsClaimed;
            }
        }
    }

    protected void btnList_Click(object sender, EventArgs e)
    {
        Response.Redirect("LostItemsList.aspx");
    }
}