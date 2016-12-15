using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DisplayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            getDisplay();
        }

        public static void getDisplay()
        {
            BusinessLayer.BusinessLayer display = new BusinessLayer.BusinessLayer();
            display.getDisplay();
        }
    }

}
