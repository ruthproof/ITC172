using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShowService" in code, svc and config file together.
public class ShowService : IShowService
{

    ShowTrackerEntities db = new ShowTrackerEntities();
    //list all venues *CHECK*
    //list all artists *CHECK*
    //list all shows
    //List all shows for Venue(ShowName, ShowDate, ShowTime)
    //List all shows for Artist(ShowName, ShowDate, ShowTime, AristName)
    //test each method to show if it fails or not
    public List<string> getArtist()
    {
        var art = from a in db.Artists
                  orderby a.ArtistName
                  select new { a.ArtistName };

        List<string> artists = new List<string>();
        foreach(var ar in art)
        {
            artists.Add(ar.ArtistName);
        }

        return artists;
    }

 

    public List<string> getVenues()
    {
        
            var VenueNames = from a in db.Venues
                      orderby a.VenueName
                      select new { a.VenueName };

            List<string> venue = new List<string>();
            foreach (var ve in VenueNames)
            {
                venue.Add(ve.VenueName);
            }

            return venue;
        
        //throw new NotImplementedException();
    }

    public List<ShowInfo> showsByVenues(string venueName)
    {
        List<ShowInfo> venues = new List<ShowInfo>();
        var vens = from v in db.Venues
                   from s in v.Shows
                   where v.VenueName == venueName
                   select new
                   {
                       s.ShowName,
                       s.ShowDate,
                       s.ShowTime
                   };
        List<ShowInfo> VenueShow = new List<ShowInfo>();
        foreach (var ve in vens)
            {
            ShowInfo info = new ShowInfo();
            info.ShowName = ve.ShowName;
            info.ShowDate = ve.ShowDate.ToString();
            info.ShowStartTime = ve.ShowTime.ToString();
            VenueShow.Add(info);
            }

            return VenueShow;
        }

    public List<ShowInfo> getShowsByArtist(string artistName)
    {
        List<ShowInfo> artists = new List<ShowInfo>();
        var arts = from a in db.Shows
                   from sd in a.ShowDetails
                   where sd.Artist.ArtistName == artistName
                   select new
                   {
                       a.ShowName,
                       a.ShowDate,
                       a.ShowTime
                   };
        List<ShowInfo> ArtistShow = new List<ShowInfo>();
        foreach (var ar in arts)
        {
            ShowInfo info = new ShowInfo();
            info.ShowName = ar.ShowName;
            info.ShowDate = ar.ShowDate.ToString();
            info.ShowStartTime = ar.ShowTime.ToString();
            ArtistShow.Add(info);
        }

        return ArtistShow;
    }


}

