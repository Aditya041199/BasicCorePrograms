using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestAmongThree
    {
        public void Largest()
        {
            Console.WriteLine("Find the Largest Number Among The Three");
            Console.WriteLine("Enter The Numbers");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            if (first >= second && first >= third)
            {
                Console.WriteLine(first + " Is The Largest Among The Three Numbers");
            }
            else if (second >= third)
            {
                Console.WriteLine(second + " Is The Largest Among The Three Numbers");
            }
            else
            {
                Console.WriteLine(third + " Is The Largest Among The Three Numbers");
            }
        }
    }
}
