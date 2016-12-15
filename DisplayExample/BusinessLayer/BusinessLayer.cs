using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class BusinessLayer
    {
        public void getDisplay()
        {
            DatabaseLayer.DatabaseLayer display = new DatabaseLayer.DatabaseLayer();
            display.display();
        }
    }
}
