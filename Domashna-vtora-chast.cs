 //Zadacha 1
 internal class Program
 {
     static void Main(string[] args)
     {
         float[] array = new float[9];
         int i = 0;
         do
         {
             Console.WriteLine("Enter element: ");
             float input = float.Parse(Console.ReadLine());
             if (input >= -99.99 && input <= 99.99)
             {
                 array[i] = input;
                 i++;
             }
         }
         while (i < 9);
         if (isIncreasinglyMonotone(array))
         {
             Console.WriteLine("The array is increasingly monotone");
         }
         else
         {
             Console.WriteLine("The array is not increasingly monotone");
         }
     }
     public static bool isIncreasinglyMonotone(float[] array)
     {
         for (int i = 1; i < array.Length; i++)
         {
             if (array[i] < array[i - 1])
             {
                 return false;
             }
         }
         return true;

     }
 }

//Zadacha2
  internal class Program
 {
     static void Main(string[] args)
     {
         int input;
         do
         {
             Console.WriteLine("Enter a natural number");
             input = int.Parse(Console.ReadLine());


         } while ((input < 10 || input > 100010) || input <= 0);

         Console.WriteLine(nextPrime(input));
     }
     static bool isPrime(int number)
     {
         if (number <= 1) return false;
         if (number <= 3) return true;

         if (number % 2 == 0 || number % 3 == 0)
             return false;

         for (int i = 5; i * i <= number; i = i + 6)
             if (number % i == 0 ||
                 number % (i + 2) == 0)
                 return false;

         return true;
     }
     static int nextPrime(int number)
     {

         if (number <= 1)
             return 2;

         int prime = number;
         bool found = false;

         while (!found)
         {
             prime++;

             if (isPrime(prime))
                 found = true;
         }
         return prime;
     }

 }

 //Zadacha3
  internal class Program
 {
     static void Main(string[] args)
     {
         int input;
         do
         {
             Console.WriteLine("Enter a natural number");
             input = int.Parse(Console.ReadLine());


         } while ((input < 10 || input > 100010) || input <= 0);
         int originalInput = input;

         //Iterative approach
         int sumOfDigits = 0;
         while (input > 0)
         {
            sumOfDigits+=input % 10;
             input = input / 10;
         }
         Console.WriteLine(sumOfDigits);
         Console.WriteLine(SumOfDigits(originalInput));
     }
     //Using recursion
     public static int SumOfDigits(int input)
     {

         if (input == 0) return 0;
         int lastDigit = input % 10;
         int remainingDigits = input / 10;
         return lastDigit + SumOfDigits(remainingDigits);
     }
 }