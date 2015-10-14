namespace P1_FillTheMatrix
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            
            PatternA(matrix);
            PrintMatrix(matrix);

            PatternB(matrix);
            PrintMatrix(matrix);
        }

        private static void PatternA(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    Console.Write("[ {0} , {1} ]: ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }

        private static void PatternB(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int col = 0; col < size; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < size; row++)
                    {
                        Console.Write("[ {0} , {1} ]: ", row, col);
                        matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    for (int row = size - 1; row >= 0; row--)
                    {
                        Console.Write("[ {0} , {1} ]: ", row, col);
                        matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            Console.WriteLine();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("{0}", matrix[row, col].ToString().PadLeft(6));
                }

                Console.WriteLine("\n");
            }
        }
    }
}