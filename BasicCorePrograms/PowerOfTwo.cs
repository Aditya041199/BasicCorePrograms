using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public void Table()
        {
            Console.WriteLine("Enter Number");
            int N =  Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= N && N < 31; i++)
            {
                double number = Math.Pow(2, i);
                Console.WriteLine("2^" + i + "="  + number);
            }
        }
    }
}
 