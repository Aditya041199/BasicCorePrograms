using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            while (true)
            {
                Console.WriteLine("1.FlipCoin");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.CheckHeadTail();
                        break;
                    default:
                        break;
                }
            }
        }
        
    }
}
