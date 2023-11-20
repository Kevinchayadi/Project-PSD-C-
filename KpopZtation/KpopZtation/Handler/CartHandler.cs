using KpopZtation.Factory;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CartHandler
    {
        CartRepository th = new CartRepository();
        public String adddata(int customer, int Album, int qty)
        {
            Cart data = CartFactory.createcart(customer, Album, qty);
            return th.AddCart(data);

        }

        public List<Cart> FindID(int name)
        {
            return th.FindId(name);
        }
    }
}