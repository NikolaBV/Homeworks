using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomashnaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadacha 1
            int numberOne = 10;
            int numberTwo = 20;

            Swap(ref numberOne,ref numberTwo);
            Console.WriteLine("Number 1: " + numberOne + " and number 2 is: " + numberTwo);
        }
        public static void Swap(ref int numberOne, ref int numberTwo)
        {
            int temp = numberOne;
            numberOne = numberTwo;
            numberTwo = temp;
        }
    }
}
