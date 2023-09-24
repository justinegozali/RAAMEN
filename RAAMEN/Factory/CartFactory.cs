using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int userId, int ramenId, int quantity)
        {
            Cart cart = new Cart();
            cart.UserId = userId;
            cart.RamenId = ramenId;
            cart.Quantity = quantity;
            return cart;
        }
    }
}