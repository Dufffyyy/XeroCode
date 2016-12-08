using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListBusinessLayer
{
    public class BusinessLayer
    {
        public List<string> getToDoList()
        {
            ToDoLIstDBLayer.DataLayer db = new ToDoLIstDBLayer.DataLayer();
            List<string> ToDoList = db.ViewItems();
            return ToDoList;
        }

    }

}
