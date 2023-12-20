using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtation.Controller
{
    public class AlbumArtistController
    {
        public String ArtistDetail(String role)
        {
            if (role.Equals("Admin"))
            {

                return ("ArtistDetailAdmin.aspx");
            }
            else
            {
                return ("ArtistDetail.aspx");
            }
        }

        public bool checkeddata(String name)
        {
            if (name == "") return false;
            return true;
        }

        public String CheckArtisname(bool data)
        {
            if (data == false) return "Nama Artist kosong!!";
            return "";
        }

        public String Checkalbumname(bool data)
        {
            if (data == false) return "Nama Album kosong!!";
            return "";
        }
        public String CheckAlbumdesc(bool data, int lenght)
        {
            if (data == false) return "Description Album kosong!!";
            if (lenght >= 255) return "Max 255 character!!";
            return "";
        }
        public String CheckAlbumPrice(bool data, int price)
        {
            if (data == false) return "Price Alvum kosong!!";
            if (price < 100000 || price > 1000000) return "Price must filled beetween 100000 and 1000000!";
            return "";
        }
        public String CheckAlbumstock(bool data, int stock)
        {
            if (data == false) return "Price Alvum kosong!!";
            if (stock <= 0) return "Stock must filled more than 0!";
            return "";
        }

        public String checkimg(FileUpload fileUpload)
        {
            if (fileUpload.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(fileUpload.PostedFile.FileName);
                if (fileExtension == ".png" || fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".jfif")
                {
                    if (fileUpload.FileBytes.Length <= 2 * 1024 * 1024)
                    {

                        return "";
                    }
                    else
                    {
                        return " Maximum file 2 MB!!";
                    }
                }
                else
                {
                    return "Jenis File harus .png, .jpg, .jpeg, or .jfif,";
                }
            }
            else
            {
                return "harus memilih salah satu gambar";
            }
        }
    }
}