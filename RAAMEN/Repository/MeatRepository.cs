using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class MeatRepository
    {
        static RaamenDatabaseEntities1 db = new RaamenDatabaseEntities1();

        public static String getMeatBasedOnId(int id)
        {
            return db.Meats.Find(id).Name;
        }
    }
}