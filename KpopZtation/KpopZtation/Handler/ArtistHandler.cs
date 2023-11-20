using KpopZtation.Factory;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class ArtistHandler
    {
        ArtistRepository tr = new ArtistRepository();
        public String insertArtist(String name, String link)
        {
            Artist artist = ArtistFactory.CreateArtis(name, link);
            tr.AddArtis(artist);
            return " ADD Artist success!!";

        }
        public Artist findArtisById(int id)
        {
            return (tr.findArtisById(id));
        }

        public String UpdateArtist(String data, String link, String name)
        {
            Artist artist = tr.findArtist(data);
            return tr.UpdateArtist(artist.ArtistID, link, name);
        }
        public void DeleteArtist(String data)
        {
            Artist artist = tr.findArtist(data);
            tr.DeleteArtist(artist.ArtistID);
        }
    }
}