using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads N, number representing rows and cols of a matrix:

            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int cols = size;
            char[,] matrix = new char[rows, cols];

            FillMatrix(matrix);

            CheckSymbol(matrix);

        }

        private static void CheckSymbol(char[,] matrix)
        {
            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (symbol == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix ");

        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string text = Console.ReadLine();
                char[] Symbols = text.ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Symbols[col];
                }
            }
        }
    }
}
