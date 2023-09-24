using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class DetailController
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
        public static String insertDetail(int headerId, List<Cart> cart)
        {
            return DetailHandler.insertDetail(headerId, cart);
        }
        public static List<Detail> getDetail(int headerId)
        {
            return DetailHandler.getDetail(headerId);
        }
    }
}