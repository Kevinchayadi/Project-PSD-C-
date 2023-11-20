using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class AlbumFactory
    {
        public static Album createAlbum(String name, int id, String Desc, int price, int stock, String img)
        {
            Album album = new Album();
            album.AlbumName = name;
            album.ArtistID = id;
            album.AlbumDescription = Desc;
            album.AlbumPrice = price;
            album.AlbumStock = stock;
            album.AlbumImage = img;
            return album;
        }
    }
}