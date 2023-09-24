using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class HeaderController
    {
        public static List<Header> getAllHeader()
        {
            return HeaderHandler.getAllHeader();
        }
        public static List<Header> getHeaderBasedOnId(int customerid)
        {
            return HeaderHandler.getHeaderBasedOnId(customerid);
        }
        public static List<Header> getUnhandledHeader()
        {
            return HeaderHandler.getUnhandledHeader();
        }
        public static Header insertHeader(int customerId)
        {
            return HeaderHandler.insertHeader(customerId);
        }
        public static void handleHeader(int id, int staffId)
        {
            HeaderHandler.handleHeader(id, staffId);
            return;
        }
        public static int totalPriceHeader(Header header)
        {
            return HeaderHandler.totalPriceHeader(header);
        }
        public static int grandTotalPrice()
        {
            return HeaderHandler.grandTotalPrice();
        }
    }
}