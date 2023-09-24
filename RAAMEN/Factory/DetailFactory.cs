using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class DetailFactory
    {
        public static Detail createDetail(int headerId, int ramenId, int quantity)
        {
            Detail detail = new Detail();
            detail.HeaderId = headerId;
            detail.RamenId = ramenId;
            detail.Quantity = quantity;
            return detail;
        }
    }
}