using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFactor
    {
        public void Factor()
        {
            Console.WriteLine("Compute The Prime Factorization Of N");
            int result = 1;
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }
            Console.WriteLine("Factorial of " + num + " is = " + result);
        }
    }
}
