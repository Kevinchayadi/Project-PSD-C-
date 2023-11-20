using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class AlbumRepository
    {
        Database1Entities db = Singelton.getInstance();
        public List<Album> GetAllDataAlbum()
        {

            return (from Albums in db.Albums select Albums).ToList();
        }

        public Album findAlbumByname(String name)
        {

            return (from Albums in db.Albums where Albums.AlbumName == name select Albums).FirstOrDefault();
        }
        public Album findAlbumById(int id)
        {

            return (from Albums in db.Albums where Albums.AlbumID == id select Albums).FirstOrDefault();
        }

        public String updateAlbum(int id, Album update)
        {
            Album data = db.Albums.Find(id);
            data.AlbumName = update.AlbumName;
            data.AlbumDescription = update.AlbumDescription;
            data.AlbumPrice = update.AlbumPrice;
            data.AlbumStock = update.AlbumStock;
            data.AlbumImage = update.AlbumImage;
            data.ArtistID = update.ArtistID;
            db.SaveChanges();
            return "update Album successfully!";
        }


        public void AddAlbum(Album album)
        {
            db.Albums.Add(album);
            db.SaveChanges();
        }

        public List<Album> GetData(List<Cart> data)
        {
            List<Album> find = new List<Album>();
            Album album = new Album();
            foreach (Cart cart in data)
            {
                album = (from Album in db.Albums where Album.AlbumID == cart.AlbumID select Album).FirstOrDefault();
                album.AlbumStock = cart.Qty;
                find.Add(album);
            }
            return find;
        }

        public void deleteAlbum(int albumId)
        {
            Album album = db.Albums.Find(albumId);
            db.Albums.Remove(album);
            db.SaveChanges();
        }
    }
}