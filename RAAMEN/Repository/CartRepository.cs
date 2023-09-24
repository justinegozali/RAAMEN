using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class CartRepository
    {
        static RaamenDatabaseEntities1 db = new RaamenDatabaseEntities1();

        public static List<Cart> getCart(int userId)
        {
            List<Cart> cart = (from dat in db.Carts where dat.UserId == userId select dat).ToList();
            return cart;
        }
        public static String insertCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
            return "Insert Success";
        }
        public static String clearCart(int userId)
        {
            List<Cart> cart = getCart(userId);
            foreach (Cart data in cart)
            {
                db.Carts.Remove(data);
                db.SaveChanges();
            }
            return "Clear Cart Sucess";
        }
    }
}