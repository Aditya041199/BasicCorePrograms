using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientAndRemainder
    {
        public void QuoRem()
        {
            Console.WriteLine("Calculate The Quotient And Remainder");
            int quotient, reminder;
            Console.WriteLine("Enter Dividend - ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Divisor - ");
            int divisor = int.Parse(Console.ReadLine());
            quotient = Math.DivRem(dividend, divisor, out reminder);
            Console.WriteLine("Quotient is  " + quotient + "  and Reminder is  " + reminder);
        }
    }
}
