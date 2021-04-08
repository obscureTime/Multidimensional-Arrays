using System;
using System.Linq;

namespace ConsoleApp1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // Write program that reads a matrix from the console and print:
            //• Count of rows
            //•	Count of cols
            //•	Sum of all matrix elements

            int[] dimensions = Console.ReadLine()
                .Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int sumElements = 0;
            foreach (var element in matrix)
            {
                sumElements += element;
            }

            // Count of rows
            Console.WriteLine(rows);

            //Count of cols
            Console.WriteLine(cols);

            //Sum of all matrix elements
            Console.WriteLine(sumElements);

        }
    }
}
