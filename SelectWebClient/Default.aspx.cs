using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ServiceReference1.ShowServiceClient sc = new ServiceReference1.ShowServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillArtistDropDown();
            GetVenues();
        }
    }

    protected void FillArtistDropDown()
    {
        string[] artist = sc.getArtist();
        ArtistDropDownList.DataSource = artist;
        ArtistDropDownList.DataBind();
    }

    protected void ArtistDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetShowByArtist();
    }

    protected void GetShowByArtist()
    {
        string artname = ArtistDropDownList.SelectedItem.Text;
        ServiceReference1.ShowInfo[] show = sc.getShowsByArtist(artname);
        GridView1.DataSource = show;
        GridView1.DataBind();
    }

   

    protected void GetVenues()
    {
        string[] venue = sc.getVenues();
        VenueDropDownList.DataSource = venue;
        VenueDropDownList.DataBind();
    }

    protected void VenueDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        string venuename = VenueDropDownList.SelectedItem.Text;
        ServiceReference1.ShowInfo[] show = sc.showsByVenues(venuename);
        GridView1.DataSource = show;
        GridView1.DataBind();
    }
}

