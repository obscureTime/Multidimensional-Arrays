using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that read a matrix from console. Then find biggest sum of 2x2 submatrix and print it to console.
            
            int[] dimensions = Console.ReadLine()
                .Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            int maxValue = int.MinValue;
            int firstCordinate = 0;
            int secondCordinate = 0;
            int thirdCordinate = 0;
            int fourthCoridnate = 0;

            FillMatrix(matrix);
            for (int row = 0; row < rows - 1; row++)
            {
                int sum = 0;
                for (int col = 0; col < cols - 1; col++)
                {
                    sum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 1, col];

                    if (sum > maxValue)
                    {
                        maxValue = sum;
                        firstCordinate = matrix[row, col];
                        secondCordinate = matrix[row, col + 1];
                        thirdCordinate = matrix[row + 1, col];
                        fourthCoridnate = matrix[row + 1, col + 1];
                    }

                }
            }

            int[,] newMatrix =
            {
                {firstCordinate, secondCordinate},
                {thirdCordinate, fourthCoridnate}
            };

            for (int row = 0; row < newMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < newMatrix.GetLength(1); col++)
                {
                    Console.Write(newMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxValue);



        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
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
