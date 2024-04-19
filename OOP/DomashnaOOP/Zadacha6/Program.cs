using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, };
            Console.Write("Which number are you looking for?: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Replace it with: ");
            int replacingValue = int.Parse(Console.ReadLine());
            Swap(ref array, target, replacingValue);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Swap(ref int[] array, int target, int replacingValue)
        {
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    flag = true;
                    array[i] = replacingValue;
                }

            }
            if(flag)
            {
                Console.WriteLine("Found and swapped");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
