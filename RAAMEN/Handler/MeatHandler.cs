using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class MeatHandler
    {
        public static String getMeatBasedOnId(int id)
        {
            return MeatRepository.getMeatBasedOnId(id);
        }
    }
}