using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_CRUD_OOP_LIST
{
    internal class Program//Nơi để menu
    {
        /*
         *  CRUD BINGCHILLING
         *
        */
        static void Main(string[] args)
        {
            BingchillingService blService = new BingchillingService();
            blService.InDsKem();
        }
    }
}
