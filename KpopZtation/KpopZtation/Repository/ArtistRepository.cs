using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class ArtistRepository
    {
        Database1Entities db = Singelton.getInstance();
        public void AddArtis(Artist artist)
        {
            db.Artists.Add(artist);
            db.SaveChanges();
        }
        public List<Artist> GetAllArtist()
        {
            return (from Artist in db.Artists select Artist).ToList();
        }
        public Artist findArtist(String name)
        {
            return (from Artist in db.Artists where Artist.ArtistName == name select Artist).FirstOrDefault();
        }

        public String UpdateArtist(int id, String Img, String name)
        {
            Artist data = db.Artists.Find(id);
            data.ArtistName = name;
            data.ArtistImage = Img;
            db.SaveChanges();
            return "Update data Successfully!";
        }
        public void DeleteArtist(int id)
        {
            Artist data = db.Artists.Find(id);
            db.Artists.Remove(data);
            db.SaveChanges();
        }

        public Artist findArtisById(int id)
        {
            return (from artist in db.Artists where artist.ArtistID == id select artist).FirstOrDefault();
        }
    }
}