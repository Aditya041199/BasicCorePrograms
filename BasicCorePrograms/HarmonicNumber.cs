using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            double num = 0;
            Console.WriteLine("Enter the number");
            double N = Convert.ToInt32(Console.ReadLine());
            for (double i = 1; i != N; i++)
            {
                num += (double)(1 / i);
                Console.WriteLine(" Series is " + num);
            }
        }

    }
}