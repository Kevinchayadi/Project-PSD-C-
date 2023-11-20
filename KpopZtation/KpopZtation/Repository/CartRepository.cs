using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CartRepository
    {
        Database1Entities db = Singelton.getInstance();
        public String AddCart(Cart data)
        {
            db.Carts.Add(data);
            db.SaveChanges();
            return "Product Add Success!";
        }

        public List<Cart> FindId(int id)
        {
            return (from Cart in db.Carts where Cart.CustomerID == id select Cart).ToList();
        }
    }
}