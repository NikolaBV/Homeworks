using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            bool isEven, isOdd;
            EvenOrOdd(number, out isEven, out isOdd);
            Console.WriteLine($"{number} is even: {isEven}, is odd: {isOdd}");
        }
        public static void EvenOrOdd(int number, out bool isEven, out bool isOdd)
        {
            if(number % 2 == 0) { 
                isEven = true;
                isOdd = false;
            }
            else
            {
                isEven = false;
                isOdd = true;
            }
        }

    }
}
