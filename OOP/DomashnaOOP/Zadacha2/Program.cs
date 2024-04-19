using System;


namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, };
            int min, max, avg;
            ArrayStats(numbers, out min, out max, out avg);
            Console.WriteLine($"Minimum is {min}, maximum is {max} and the average is {avg}");
        }
        public static void ArrayStats(int[] numbers, out int min, out int max, out int avg)
        {
            min = numbers[0];
            max = numbers[0];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum++;
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            avg = sum / (numbers.Length);
        }
    }
}
