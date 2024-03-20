// Zadacha 1

namespace AlgoritmiHomework
{
    class Program
    {
        public static void Main(string[] args)
        {
            int arraySize;
           
            do
            {
                Console.Write("Vuvedete razmera na masiva: ");
                arraySize = int.Parse(Console.ReadLine());
            }
            while(arraySize > 20 );
            

            float[] array = new float[arraySize];

            PopulateArray(array);
            PrintArray(array);
            Console.WriteLine("The sum up to the second element is " + sumOfElements(array, 2));
        }
        public static void PopulateArray(float[] array)
        {
            int i = 0;
            int input;
            do
            {
                
                Console.Write("Vuvedete element: ");
                input = int.Parse(Console.ReadLine());
                array[i] = input;
                Console.WriteLine("");
                i++;
            }
            while( i < array.Length || input < 0);

        }
        public static void PrintArray(float[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("element: " + array[i]);
            }
        }
        public static float sumOfElements(float[] array, int upToElement)
        {
            float sum = 0;
            for (int i = 0; i < upToElement; i++)
            {
                sum = sum + array[i];
            }

            return sum;
        }
    }
}

// Zadacha 2

namespace Zadacha2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int arraySize;
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            Random random = new Random();
            do
            {
                Console.Write("Enter the number of elements: ");
                arraySize = int.Parse(Console.ReadLine());
            }
            while (arraySize <= 0);

            int[] array = new int[arraySize];

            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = random.Next(1, 4);  
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (!hashMap.ContainsKey(array[i])) 
                {
                    hashMap.Add(array[i], 1);
                }
                else
                {
                    hashMap[array[i]]++;
                }
            }
            var maxElement = hashMap.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("Most frequent element: "+ maxElement );
        }
    }
}

// Zadacha 3

namespace Zdacha3
{
    class ZadachaTreta
    {
        public static void Main(String[] args)
        {
            int matrixRows;
            int matrixCols;
            do
            {
                Console.WriteLine("Enter matrix dimensions");
                matrixRows = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter matrix dimensions");
                matrixCols = int.Parse(Console.ReadLine());
            }
            while (matrixRows <= 0 || matrixCols <= 0);

            int[,] matrix = new int[matrixRows,matrixCols];
            PopulateMatrix(matrix);
            int sumOfRows = 0;
            int sumOfMainDiagonal = 0;
            int sumOfCounterDiagonal = 0;
            int sumOfAllColumns = 0;
            int[] columnSums = new int[matrix.GetLength(1)];
           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int element = matrix[i, j];
                    sumOfRows += element;
                    if(i == j)
                    {
                        sumOfMainDiagonal += element;
                    }
                    if(i + j == matrix.GetLength(0) - 1)
                    {
                        sumOfCounterDiagonal += element;
                    }
                    columnSums[j] += element;
                    Console.WriteLine("Element at position ({0},{1}) is: {2}", i, j, element);
                }
            }
            Console.WriteLine("Sum of the rows is: "+ sumOfRows +
                " sum of the main diagonal is: " +
                sumOfMainDiagonal + " sum of the counter diagonal is " + sumOfCounterDiagonal);
            for (int i = 0; i < columnSums.Length; i++)
            {
                sumOfAllColumns += columnSums[i];
            }
            Console.WriteLine("The sum of all columns is " + sumOfAllColumns);
            if (isMagicSquare(sumOfRows, sumOfMainDiagonal, sumOfCounterDiagonal, sumOfAllColumns))
            {
                Console.WriteLine("The square is magic");
            }
            else
            {
                Console.WriteLine("The square is not magic");
            }

        }
        public static bool isMagicSquare(int sumOfRows, int sumOfMainDiagonal, int sumOfCounterDiagonal, int sumOfAllColumns)
        {
            return sumOfRows == sumOfAllColumns && sumOfMainDiagonal == sumOfCounterDiagonal;
        }
        static void PopulateMatrix(int[,] matrix)
        {
            bool matrixIsPopulated = false;

            while (!matrixIsPopulated)
            {
                matrixIsPopulated = true;

                Console.WriteLine("Please enter values for the matrix (between 1 and 20):");

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"Enter value for position [{i},{j}]: ");
                        if (!int.TryParse(Console.ReadLine(), out matrix[i, j]) || matrix[i, j] < 1 || matrix[i, j] > 20)
                        {
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 20.");
                            matrixIsPopulated = false; 
                            break;
                        }
                    }

                    if (!matrixIsPopulated)
                        break;
                }
            }
        }
    }
}