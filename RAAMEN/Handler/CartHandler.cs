using RAAMEN.Factory;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class CartHandler
    {
        public static List<Cart> getCart(int userId)
        {
            return CartRepository.getCart(userId);
        }
        public static String insertCart(int userId, int ramenId, int quantity)
        {
            Cart cart = CartFactory.createCart(userId, ramenId, quantity);
            return CartRepository.insertCart(cart);
        }
        public static String clearCart(int userId)
        {
            return CartRepository.clearCart(userId);
        }
    }
}