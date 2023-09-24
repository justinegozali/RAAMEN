using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class RamenFactory
    {
        public static Raman createRamen(int meatId, String name, String broth, String price)
        {
            Raman ramen = new Raman();
            ramen.MeatId = meatId;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;
            return ramen;
        }
    }
}