using RAAMEN.Factory;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class DetailHandler
    {
        public static String insertDetail(int headerId, List<Cart> cart)
        {
            foreach (Cart data in cart)
            {
                Detail detail = DetailFactory.createDetail(headerId, data.RamenId, (int)data.Quantity);
                DetailRepository.insertDetail(detail);
            }
            return "Buy Cart Sucess";
        }
        public static List<Detail> getDetail(int headerId)
        {
            return DetailRepository.getDetail(headerId);
        }
    }
}