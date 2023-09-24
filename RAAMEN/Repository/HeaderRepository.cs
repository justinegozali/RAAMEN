using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class HeaderRepository
    {
        static RaamenDatabaseEntities1 db = new RaamenDatabaseEntities1();

        public static List<Header> getAllHeader()
        {
            return db.Headers.ToList();
        }
        public static List<Header> getHeaderBasedOnId(int customerid)
        {
            List<Header> header = (from dat in db.Headers where dat.CustomerId == customerid select dat).ToList();
            return header;
        }
        public static List<Header> getUnhandledHeader()
        {
            List<Header> header = (from dat in db.Headers where dat.StaffId == null select dat).ToList();
            return header;
        }
        public static void insertHeader(Header header)
        {
            db.Headers.Add(header);
            db.SaveChanges();
            return;
        }
        public static void handleHeader(int id, int staffId)
        {
            Header header = (from dat in db.Headers where dat.Id == id select dat).FirstOrDefault();
            header.StaffId = staffId;
            db.SaveChanges();
            return;
        }
    }
}