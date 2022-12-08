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
                Console.WriteLine("1.FlipCoin" + "\n" + "2.Leap Year" + "\n" + "3.Power Of Two" + "\n" + "4.Harmonic Number" + "\n" + "5.Prime Factor" + "\n" + "6.Quotient And Remainder" + "\n" + "7.Swapping Numbers" + "\n" + "8.Even And Odd" + "\n" + "9.Vowel Or Consonant" + "\n" + "10.Largest Number" + "\n" + "11.Exit");
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
                    case 4:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.Harmonic();
                        break;
                    case 5:
                        PrimeFactor primeFactor = new PrimeFactor();
                        primeFactor.Factor();
                        break;
                    case 6:
                        QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                        quotientAndRemainder.QuoRem();
                        break;
                    case 7:
                        SwapNumbers swapNumbers = new SwapNumbers();
                        swapNumbers.Swap();
                        break;
                    case 8:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.Even();
                        break;
                    case 9:
                        VowelConsonant vowelConsonant = new VowelConsonant();
                        vowelConsonant.Alphabet();
                        break;
                    case 10:
                        LargestAmongThree largestAmongThree = new LargestAmongThree();
                        largestAmongThree.Largest();
                        break;
                    default:
                        break;
                }
            }
        }
        
    }
}
