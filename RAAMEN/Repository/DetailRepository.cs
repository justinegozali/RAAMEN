using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class DetailRepository
    {
        static RaamenDatabaseEntities1 db = new RaamenDatabaseEntities1();

        public static List<Detail> getDetail(int headerId)
        {
            List<Detail> detail = (from dat in db.Details where dat.HeaderId == headerId select dat).ToList();
            return detail;
        }
        public static void insertDetail(Detail detail)
        {
            db.Details.Add(detail);
            db.SaveChanges();
            return;
        }
        
    }
}