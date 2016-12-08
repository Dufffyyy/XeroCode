using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLIstDBLayer
{
    public class DataLayer
    {
        List<string> ToDoList { get; set; }

        public List<string> AddItem(string n)
        {
            ToDoList.Add(n);
            return ToDoList;
        }

        public List<string> RemoveItem(string n)
        {
            ToDoList.Remove(n);
            return ToDoList;
        }

        public List<string> ViewItems()
        {
            return ToDoList;
        }

    }
}
