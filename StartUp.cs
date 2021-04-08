using System;
using System.Linq;

namespace MultidimensionalArrays
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Write program that read a matrix from console and print the sum for each column:

            int[] dimensions = Console.ReadLine()
                .Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix);
            SumMatrixColumns(matrix);

        }

        private static void SumMatrixColumns(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumColumns = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumColumns += matrix[row, col];
                }
                Console.WriteLine(sumColumns);

            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }

            }
        }
    }
}
