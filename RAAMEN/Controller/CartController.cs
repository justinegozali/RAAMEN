using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class CartController
    {
        public static bool numberValidation(String s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static List<Cart> getCart(int userId)
        {
            return CartHandler.getCart(userId);
        }
        public static String insertCart(int userId, String ramenId, String quantity)
        {
            if (ramenId.Equals("") || quantity.Equals(""))
            {
                return "No input";
            }
            else if (numberValidation(ramenId) == false)
            {
                return "MenuId must be number";
            }
            else if (int.Parse(ramenId) > RamenHandler.getLastRamenId() || int.Parse(ramenId) < 0)
            {
                return "Menu not found";
            }
            else if (numberValidation(quantity) == false)
            {
                return "Quantity must be number";
            }
            else
            {
                return CartHandler.insertCart(userId, int.Parse(ramenId), int.Parse(quantity));
            }
        }
        public static String clearCart(int userId)
        {
            return CartHandler.clearCart(userId);
        }
    }
}