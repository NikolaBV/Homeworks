using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mixedArray = { 1, 2, 3, 4, 5, };
            int[] evenArray;
            int[] oddArray;
            OrganizeArrays(mixedArray,out evenArray,out oddArray);
            Console.WriteLine("Mixed array: ");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine(mixedArray[i]);
            }
            Console.WriteLine("Even array: ");
            for (int i = 0; i < evenArray.Length; i++)
            {
                Console.WriteLine(evenArray[i]);
            }
            Console.WriteLine("Odd array: ");
            for (int i = 0; i < oddArray.Length; i++)
            {
                Console.WriteLine(oddArray[i]);
            }

        }
        public static void OrganizeArrays(int[] mixedArray,out int[] evenArray, out int[] oddArray)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            for (int i = 0; i < mixedArray.Length; i++)
            {
                if (mixedArray[i] % 2 == 0)
                {
                    evenList.Add(mixedArray[i]);
                }
                else
                {
                    oddList.Add(mixedArray[i]);
                }
            }
            evenArray = evenList.ToArray();
            oddArray = oddList.ToArray();
        }
    }
}
