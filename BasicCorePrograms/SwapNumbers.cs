using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Swap Two Numbers");
            Console.WriteLine("Enter The Numbers For Swapping");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping Numbers " + first + " , " + second);
            int temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After Swapping The Numbers Are " + first + " & " + second);
        }
    }
}
