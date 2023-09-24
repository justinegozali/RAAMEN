using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class HeaderFactory
    {
        public static Header createHeader(int customerId)
        {
            Header header = new Header();
            header.CustomerId = customerId;
            header.Date = DateTime.Now;
            return header;
        }
    }
}