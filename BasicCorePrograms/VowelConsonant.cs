using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelConsonant
    {
        public void Alphabet()
        {
            Console.WriteLine("Findout Whether The Given Alphabet Is A Vowel Or Consonant");
            Console.WriteLine("Enter Alphabet To Find");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine(ch + " Is A Vowel");
                    break;
                case 'i':
                    Console.WriteLine(ch + " Is A Vowel");
                    break;
                case 'o':
                    Console.WriteLine(ch + " Is A Vowel");
                    break;
                case 'u':
                    Console.WriteLine(ch + " Is A Vowel");
                    break;
                case 'e':
                    Console.WriteLine(ch + " Is A Vowel");
                    break;
                default:
                    Console.WriteLine(ch + " Is A Consonant");
                    break;
            }
        }
    }
}
