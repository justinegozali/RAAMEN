using RAAMEN.Factory;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class HeaderHandler
    {
        public static List<Header> getAllHeader()
        {
            return HeaderRepository.getAllHeader();
        }
        public static List<Header> getHeaderBasedOnId(int customerid)
        {
            return HeaderRepository.getHeaderBasedOnId(customerid);
        }
        public static List<Header> getUnhandledHeader()
        {
            return HeaderRepository.getUnhandledHeader();
        }
        public static Header insertHeader(int customerId)
        {
            Header header = HeaderFactory.createHeader(customerId);
            HeaderRepository.insertHeader(header);
            return header;
        }
        public static void handleHeader(int id, int staffId)
        {
            HeaderRepository.handleHeader(id, staffId);
            return;
        }
        public static int totalPriceHeader(Header header)
        {
            int totalPrice = 0;
            List<Detail> detail = DetailHandler.getDetail(header.Id);
            foreach (Detail data in detail)
            {
                Raman ramen = RamenHandler.getRamenBasedOnId(data.RamenId);
                totalPrice += ((int)data.Quantity * int.Parse(ramen.Price));
            }
            return totalPrice;
        }
        public static int grandTotalPrice()
        {
            int grandTotalPrice = 0;
            List<Header> header = getAllHeader();
            foreach(Header data in header)
            {
                grandTotalPrice += totalPriceHeader(data);
            }
            return grandTotalPrice;
        }
    }
}