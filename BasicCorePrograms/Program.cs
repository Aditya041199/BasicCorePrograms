using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.FlipCoin" + "\n" + "2.Leap Year" + "\n" + "3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.CheckHeadTail();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.FindLeap();
                        break;
                    default:
                        break;
                }
            }
        }
        
    }
}
