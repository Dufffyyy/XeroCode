using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeCheck;


namespace fibonacciSequence
{
    class Program
    {
        
        
        
        static void Main()
        {
            int fib = 0;
            int count = 1;
        

            while (fib <= 100)
            {
               
               // bool result = PrimeCheck.Program.PrimeChecker(fib);
               //// if (result == true)
               /// {
                Console.WriteLine(fib);
             //   }
                int temp = fib;
                fib = count;
                count = temp + fib;
            }
            Console.ReadLine();
        }
      
    }
}
