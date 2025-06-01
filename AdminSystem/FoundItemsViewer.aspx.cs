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
            ClassLibrary.clsFoundItems item = Session["AnFoundItems"] as ClassLibrary.clsFoundItems;
            if (item != null)
            {
                lblId.Text = item.Id.ToString();
                lblTitle.Text = item.Title;
                lblLocation.Text = item.Location;
                lblDateFound.Text = item.DateFound.ToString("yyyy-MM-dd");
                lblIsReturned.Text = item.IsReturned;
            }
        }
    }

    protected void btnList_Click(object sender, EventArgs e)
    {
        Response.Redirect("FoundItemsList.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("FoundItemsLogin.aspx");

    }
}