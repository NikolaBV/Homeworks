using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int factoriel;
            Console.WriteLine(Factoriel(number, out factoriel));
        }
        public static int Factoriel(int number, out int factoriel)
        {

            factoriel = 1;
            for (int i = number; i > 0; i--) {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
