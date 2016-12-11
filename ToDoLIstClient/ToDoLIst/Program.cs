using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {    
        static void Main(string[] args)
        {
            bool CloseProgram = false;
            string UserInput;
            Console.WriteLine("Type 'L' for List, 'A' Add, 'D' Delete or 'C' Close");

            do
            {
                UserInput = Console.ReadLine().ToUpper();

                switch (UserInput)
                {
                    case "L" :
                        
                        for (int i = 0; i < length; i++)
                        {

                        }
                        Console.WriteLine();
                        break;

                    case "A":
                        Console.WriteLine("Enter ToDo Item: ");
                        string todoAdd = Console.ReadLine();
                        
                        break;

                    case "D":
                        break;

                    case "C":
                        CloseProgram = true;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid function");
                        break;

                }

            } while (CloseProgram == false);
     
        }
        public List<string> addItem(string n)
        {
            ToDoListBusinessLayer.BusinessLayer db = new ToDoListBusinessLayer.BusinessLayer();
            List<string> ToDoList = db.addToList(n);
            return ToDoList;
        }

        public List<string> viewList()
        {
            ToDoListBusinessLayer.BusinessLayer db = new ToDoListBusinessLayer.BusinessLayer();
            List<string> ToDoList = db.getToDoList();
            return ToDoList;
        }
    }
}
