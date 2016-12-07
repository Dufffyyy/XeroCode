using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeDateDataLayer
{
    public class DataLayer
    {
        public DateTime GetDateTime()
        {
             DateTime CurrentDateTime = DateTime.Now;

            return CurrentDateTime;
        }
    }
}
