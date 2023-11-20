using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader createTH(DateTime time, int CustomerID)
        {
            TransactionHeader data = new TransactionHeader();
            data.CustomerID = CustomerID;
            data.TransactionDate = time;
            return data;
        }

        public static TransactionDetail CreateTD(int AlbumID, int Qty)
        {
            TransactionDetail data = new TransactionDetail();
            data.AlbumID = AlbumID;
            data.Qty = Qty;
            return data;
        }
    }
}
