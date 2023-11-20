using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CartFactory
    {
        public static Cart createcart(int custo, int album, int qty)
        {
            Cart data = new Cart();
            data.CustomerID = custo;
            data.AlbumID = album;
            data.Qty = qty;
            return data;
        }

    }
}