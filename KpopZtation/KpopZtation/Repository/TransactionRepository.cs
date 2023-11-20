using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class TransactionRepository
    {
        Database1Entities db = Singelton.getInstance();
        public void AddTransactionHeader(TransactionHeader data)
        {
            db.TransactionHeaders.Add(data);
            db.SaveChanges();
        }


        public TransactionHeader FindDataTH(int id)
        {
            return (from TransactionHeader th in db.TransactionHeaders where th.TransactionID == id select th).FirstOrDefault();
        }

        public void AddTransactionDetail(TransactionDetail data)
        {
            db.TransactionDetails.Add(data);
            db.SaveChanges();
        }

        public TransactionDetail FindDataTD(int id)
        {
            return (from TransactionDetail td in db.TransactionHeaders where td.TransactionID == id select td).FirstOrDefault();
        }

        public List<TransactionHeader> GetData(int id)
        {
            return (from TransactionHeader th in db.TransactionHeaders where th.TransactionID == id select th).ToList();
        }
    }
}