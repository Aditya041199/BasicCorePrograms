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
                Console.WriteLine("1.FlipCoin" + "\n" + "2.Leap Year" + "\n" + "3.Power Of Two" + "\n" + "4. Exit");
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
                    case 3:
                        PowerOfTwo powerOfTwo = new PowerOfTwo();
                        powerOfTwo.Table();
                        break;
                    default:
                        break;
                }
            }
        }
        
    }
}
