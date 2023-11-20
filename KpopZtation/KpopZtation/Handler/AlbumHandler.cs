using KpopZtation.Factory;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class AlbumHandler
    {
        AlbumRepository th = new AlbumRepository();
        public String insertAlbum(String name, int id, String Desc, int price, int stock, String img)
        {
            Album album = AlbumFactory.createAlbum(name, id, Desc, price, stock, img);
            th.AddAlbum(album);
            return "ADD album success!!";
        }
        public List<Album> getArtisAlbum(int artisId)
        {
            List<Album> albums = th.GetAllDataAlbum();
            List<Album> artistAlbums = new List<Album>();
            Album temp = new Album();
            foreach (Album album in albums)
            {
                if (album.ArtistID == artisId)
                {
                    temp.AlbumImage = "../Assets/Albums/" + album.AlbumImage;
                    album.AlbumImage = temp.AlbumImage;
                    artistAlbums.Add(album);
                }
            }
            return (artistAlbums);
        }

        public String UpdateAlbum(String data, String name, int id, String Desc, int price, int stock, String img)
        {
            Album album = AlbumFactory.createAlbum(name, id, Desc, price, stock, img);
            Album find = th.findAlbumByname(data);
            return th.updateAlbum(find.AlbumID, album);
        }

        public List<Album> GetData(List<Cart> data)
        {
            return th.GetData(data);
        }

        public void deleteAlbum(int albumId)
        {
            th.deleteAlbum(albumId);
        }
    }
}