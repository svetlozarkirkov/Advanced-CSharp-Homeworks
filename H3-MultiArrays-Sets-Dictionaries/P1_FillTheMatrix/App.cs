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

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("[ {0} , {1} ]: ", j, i);
                    matrix[j, i] = int.Parse(Console.ReadLine());
                }
            }
        }

        private static void PatternB(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("[ {0} , {1} ]: ", j, i);
                        matrix[j, i] = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    for (int j = size - 1; j >= 0; j--)
                    {
                        Console.Write("[ {0} , {1} ]: ", j, i);
                        matrix[j, i] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0}", matrix[i, j].ToString().PadLeft(6));
                }

                Console.WriteLine("\n");
            }
        }
    }
}
