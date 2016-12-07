using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeDateBusiness
{
    public class BusinessLayer
    {
        public DateTime GetDateTime()
        {
            ShowMeDateDataLayer.DataLayer db = new ShowMeDateDataLayer.DataLayer();
            DateTime CurrentDateTime = db.GetDateTime();
            return CurrentDateTime;
        }
       
    }
}
