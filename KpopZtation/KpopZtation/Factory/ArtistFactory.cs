using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class ArtistFactory
    {
        public static Artist CreateArtis(String Name, String Img)
        {
            Artist artis = new Artist();
            artis.ArtistName = Name;
            artis.ArtistImage = Img;
            return artis;
        }
    }
}