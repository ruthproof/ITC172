using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShowService" in both code and config file together.
[ServiceContract]
public interface IShowService
{
    [OperationContract]
    List<string> getArtist();

    [OperationContract]
    List<string> getVenues();

    [OperationContract]
    List<ShowInfo> showsByVenues(string venueName);
    [OperationContract]
    List<ShowInfo> getShowsByArtist(string artistName);
    
}

[DataContract]
public class ShowInfo
{
    [DataMember]
    public string ShowName {get; set;}
    [DataMember]
    public string ShowDate { get; set; }
    [DataMember]
    public string ShowStartTime { get; set; }

}
public class ArtistInfo
{
    [DataMember]
    public string ShowName { get; set; }
    [DataMember]
    public string ShowDate { get; set; }
    [DataMember]
    public string VenueName { get; set; }
}