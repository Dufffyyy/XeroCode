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

        public List<string> addToList(string n)
        {
            ToDoLIstDBLayer.DataLayer db = new ToDoLIstDBLayer.DataLayer();
            List<string> ToDoList = db.AddItem(n);
            return ToDoList;
        }

        public List<string> deleteItem(string n)
        {
            ToDoLIstDBLayer.DataLayer db = new ToDoLIstDBLayer.DataLayer();
            List<string> ToDoList = db.RemoveItem(n);
            return ToDoList;
        }


    }

}
