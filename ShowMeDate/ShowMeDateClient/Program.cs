using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeDateClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMeDateBusiness.BusinessLayer businessDateTime = new ShowMeDateBusiness.BusinessLayer();
            DateTime CurrentDateTime = businessDateTime.GetDateTime();
            Console.WriteLine(CurrentDateTime);

            Console.ReadKey();
        }
    }
}

