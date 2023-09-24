using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class MeatController
    {
        public static String getMeatBasedOnId(int id)
        {
            return MeatHandler.getMeatBasedOnId(id);
        }
    }
}