using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class RamenRepository
    {
        static RaamenDatabaseEntities1 db = new RaamenDatabaseEntities1();

        public static List<Raman> getAllRamen()
        {
            return db.Ramen.ToList();
        }
        public static Raman getRamenBasedOnId(int id)
        {
            return db.Ramen.Find(id);
        }
        public static int getLastRamenId()
        {
            return db.Ramen.Last().Id;
        }
        public static String insertRamen(Raman raman)
        {
            db.Ramen.Add(raman);
            db.SaveChanges();
            return "Insert Success";
        }
        public static String updateRamen(int id, int meatId, String name, String broth, String price)
        {
            Raman ramen = getRamenBasedOnId(id);
            ramen.Name = name;
            ramen.MeatId = meatId;
            ramen.Broth = broth;
            ramen.Price = price;
            db.SaveChanges();
            return "Update Success";
        }
        public static void deleteRamen(int id)
        {
            Raman ramen = getRamenBasedOnId(id);
            db.Ramen.Remove(ramen);
            db.SaveChanges();
        }
    }
}