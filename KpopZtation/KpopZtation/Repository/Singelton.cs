using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class Singelton
    {
        public static Database1Entities db = null;

        public static Database1Entities getInstance()
        {
            if (db == null)
            {
                db = new Database1Entities();
            }
            return db;
        }
    }
}