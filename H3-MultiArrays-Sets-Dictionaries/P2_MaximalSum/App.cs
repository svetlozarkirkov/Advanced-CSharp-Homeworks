namespace P2_MaximalSum
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter N x M: ");
            int[] inputRowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = inputRowsAndCols[0];
            int cols = inputRowsAndCols[1];
            if (rows < 3 || cols < 3)
            {
                Console.WriteLine("Rows and cols must be at least 3 each!");
                return;
            }

            int[,] matrix = new int[rows, cols];
            
            for (int i = 0; i < rows; i++)
            {
                Console.Write("Enter row {0}: ", i);
                var row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int maximalSum = int.MinValue;
            int[,] maximalSumMatrix = new int[3, 3];
                
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int[,] currentExtractedMatrix = ExtractMatrix(matrix, i, j);
                    int currentExtractedMatrixSum = CalculateMatrixSum(currentExtractedMatrix);
                        
                    if (currentExtractedMatrixSum > maximalSum)
                    {
                        maximalSum = currentExtractedMatrixSum;
                        maximalSumMatrix = currentExtractedMatrix;
                    }
                }
            }

            Console.WriteLine("Sum = {0}", maximalSum);
            PrintMatrix(maximalSumMatrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}", matrix[i, j].ToString().PadLeft(5));
                }

                Console.WriteLine("\n");
            }
        }

        private static int CalculateMatrixSum(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        private static int[,] ExtractMatrix(int[,] matrix, int row, int col)
        {
            int[,] extractedMatrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    extractedMatrix[i, j] = matrix[row + i, col + j];
                }
            }
            
            return extractedMatrix;
        }
    }
}