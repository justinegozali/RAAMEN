using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class RamenController
    {
        public static List<Raman> getAllRamen()
        {
            return RamenHandler.getAllRamen();
        }
        public static Raman getRamenBasedOnId(int id)
        {
            return RamenHandler.getRamenBasedOnId(id);
        }
        public static bool priceValidation(String s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static String insertRamen(String meat, String name, String broth, String price)
        {
            if (name.Equals("") || broth.Equals("") || price.Equals(""))
            {
                return "No input";
            }
            else if (!name.Contains("Ramen"))
            {
                return "Name must contains Ramen";
            }
            else if (!meat.Equals("Chicken") && !meat.Equals("Karaage") && !meat.Equals("Beef") && !meat.Equals("Ebi Tempura"))
            {
                return "Meat must be selected";
            }
            else if (priceValidation(price) == false)
            {
                return "Price must be number";
            }
            else if (int.Parse(price) < 3000)
            {
                return "Price must be at least 3000";
            }
            else
            {
                return RamenHandler.insertRamen(meat, name, broth, price);
            }
        }
        public static String updateRamen(int id, String meat, String name, String broth, String price)
        {
            if (name.Equals("") || broth.Equals("") || price.Equals(""))
            {
                return "No input";
            }
            else if (!name.Contains("Ramen"))
            {
                return "Name must contains Ramen";
            }
            else if (!meat.Equals("Chicken") && !meat.Equals("Karaage") && !meat.Equals("Beef") && !meat.Equals("Ebi Tempura"))
            {
                return "Meat must be selected";
            }
            else if (priceValidation(price) == false)
            {
                return "Price must be number";
            }
            else if (int.Parse(price) < 3000)
            {
                return "Price must be at least 3000";
            }
            else
            {
                return RamenHandler.updateRamen(id, meat, name, broth, price);
            }
        }
        public static void deleteRamen(int id)
        {
            RamenHandler.deleteRamen(id);
            return;
        }
    }
}