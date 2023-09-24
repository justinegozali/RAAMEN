using RAAMEN.Factory;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class RamenHandler
    {
        public static List<Raman> getAllRamen()
        {
            return RamenRepository.getAllRamen();
        }
        public static Raman getRamenBasedOnId(int id)
        {
            return RamenRepository.getRamenBasedOnId(id);
        }
        public static int getLastRamenId()
        {
            List<Raman> ramen = RamenRepository.getAllRamen();
            Raman last = ramen.Last();
            return last.Id;
        }
        public static int meatCategory(String meat)
        {
            if (meat.Equals("Chicken"))
            {
                return 1;
            }
            else if (meat.Equals("Karaage"))
            {
                return 2;
            }
            else if (meat.Equals("Beef"))
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        public static String insertRamen(String meat, String name, String broth, String price)
        {
            int meatId = meatCategory(meat);
            Raman ramen = RamenFactory.createRamen(meatId, name, broth, price);
            return RamenRepository.insertRamen(ramen);
        }
        public static String updateRamen(int id, String meat, String name, String broth, String price)
        {
            int meatId = meatCategory(meat);
            return RamenRepository.updateRamen(id, meatId, name, broth, price);
        }
        public static void deleteRamen(int id)
        {
            RamenRepository.deleteRamen(id);
            return;
        }
    }
}