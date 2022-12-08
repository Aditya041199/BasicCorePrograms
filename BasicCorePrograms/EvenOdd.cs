using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOdd
    {
        public void Even()
        {
            Console.WriteLine("Find If The Given Number Is Even Or Odd");
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Even Number");
            }
            else 
            {
                Console.WriteLine(num + " Is An Odd Number");
            }
        }
    }
}
