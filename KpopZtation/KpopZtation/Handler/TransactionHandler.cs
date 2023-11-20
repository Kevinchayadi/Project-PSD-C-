using KpopZtation.Factory;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class TransactionHandler
    {
        TransactionRepository th = new TransactionRepository();

        public void AddData(int CustomerID, int AlbumID, int Qty, DateTime time)
        {
            TransactionHeader data = TransactionFactory.createTH(time, CustomerID);
            th.AddTransactionHeader(data);
            TransactionDetail data1 = TransactionFactory.CreateTD(AlbumID, Qty);
            th.AddTransactionDetail(data1);
        }

        public List<TransactionHeader> GetData(int id)
        {
            return th.GetData(id);
        }
    }
}