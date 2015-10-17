namespace P4_SequenceInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter number of rows: ");
            int inputRows = int.Parse(Console.ReadLine());
            Console.Write("Enter number of cols: ");
            int inputCols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[inputRows, inputCols];
            for (int currentRow = 0; currentRow < inputRows; currentRow++)
            {
                for (int currentCol = 0; currentCol < inputCols; currentCol++)
                {
                    Console.Write("Cell [{0},{1}]: ", currentRow, currentCol);
                    matrix[currentRow, currentCol] = Console.ReadLine();
                }
            }

            PrintMatrix(matrix);
            
            var collectedSequences = new List<List<string>>();
            
            ProcessHorizontals(matrix, collectedSequences);
            ProcessVerticals(matrix, collectedSequences);
            ProcessLeftToRightDiagonal(matrix, collectedSequences);
            ProcessRightToLeftDiagonal(matrix, collectedSequences);
            
            // PrintSequences(collectedSequences);
            if (collectedSequences.Count > 1)
            {
                Console.WriteLine(
                    "Longest found sequence: {0}",
                    string.Join(", ", collectedSequences.OrderByDescending(seq => seq.Count).Take(1).ElementAt(0)));
            }
            else
            {
                Console.WriteLine("No sequences found!");
            }
        }

        /// <summary>
        /// Prints the matrix in a user-friendly way.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        private static void PrintMatrix(string[,] matrix)
        {
            Console.WriteLine("\n");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col].PadLeft(10));
                }

                Console.WriteLine("\n\n");
            }
        }

        /// <summary>
        /// Prints all of the found sequences in a user-friendly way.
        /// </summary>
        /// <param name="sequences">The sequences.</param>
        private static void PrintSequences(List<List<string>> sequences)
        {
            foreach (var seq in sequences)
            {
                Console.WriteLine("[ {0} ]", string.Join(", ", seq));
            }
        }

        /// <summary>
        /// Processes all of the horizontals.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="output">The output.</param>
        private static void ProcessHorizontals(string[,] matrix, ICollection<List<string>> output)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var currentSequence = new List<string> { matrix[row, col] };

                    while (col < matrix.GetLength(1)
                        && matrix[row, col].Equals(matrix[row, col + 1]))
                    {
                        currentSequence.Add(matrix[row, col + 1]);
                        col++;
                    }

                    if (currentSequence.Count > 1)
                    {
                        output.Add(currentSequence);
                    }
                }
            }
        }

        /// <summary>
        /// Processes all of the verticals.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="output">The output.</param>
        private static void ProcessVerticals(string[,] matrix, ICollection<List<string>> output)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    var currentSequence = new List<string> { matrix[row, col] };

                    while (row < matrix.GetLength(0) - 1
                        && matrix[row, col].Equals(matrix[row + 1, col]))
                    {
                        currentSequence.Add(matrix[row + 1, col]);
                        row++;
                    }

                    if (currentSequence.Count > 1)
                    {
                        output.Add(currentSequence);
                    }
                }
            }
        }

        /// <summary>
        /// Processes the main left to right diagonal.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="output">The output.</param>
        private static void ProcessLeftToRightDiagonal(string[,] matrix, ICollection<List<string>> output)
        {
            for (int cell = 0; cell < matrix.GetLength(0) - 1; cell++)
            {
                var currentSequence = new List<string> { matrix[cell, cell] };

                while (cell < matrix.GetLength(0) - 1 && 
                    matrix[cell, cell].Equals(matrix[cell + 1, cell + 1]))
                {
                    currentSequence.Add(matrix[cell, cell]);
                    cell++;
                }

                if (currentSequence.Count > 1)
                {
                    output.Add(currentSequence);
                }
            }
        }

        /// <summary>
        /// Processes the main right to left diagonal.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="output">The output.</param>
        private static void ProcessRightToLeftDiagonal(string[,] matrix, ICollection<List<string>> output)
        {
            for (int row = 0, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1 && col > 0; row++)
            {
                var currentSequence = new List<string> { matrix[row, col] };

                while (col > 0 && row < matrix.GetLength(0) - 1 
                    && matrix[row, col].Equals(matrix[row + 1, col - 1]))
                {
                    currentSequence.Add(matrix[row + 1, col - 1]);
                    row++;
                    col--;
                }

                if (currentSequence.Count > 1)
                {
                    output.Add(currentSequence);
                }
            }
        }
    }
}