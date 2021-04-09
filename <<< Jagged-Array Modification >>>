using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class StartUp
    {
        static void Main(string[] args)
        {  
            //Write a program that reads a matrix from the console. On the first line you will get matrix rows.
            //On next rows lines you will get elements for each column separated with space.
            //You will be receiving commands in the following format:
        	// Add {row} {col} {value} – Increase the number at the given coordinates with the value.
        	// Subtract {row} {col} {value} – Decrease the number at the given coordinates by the value.
            // Coordinates might be invalid. In this case you should print "Invalid coordinates".
            // When you receive "END" you should print the matrix and stop the program.


            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];
            
            FillMatrix(matrix);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                
                string[] data = command.Split();
                int row = int.Parse(data[1]);
                int col = int.Parse(data[2]);

                bool isValid = row >= 0 && row < matrix.Length && col >= 0 && col < matrix.Length;

                if (isValid)
                {
                     string commands = data[0];
                     int value = int.Parse(data[3]);

                    switch (commands)
                    {
                        case "Add":
                            matrix[row][col] += value;
                            break;
                        case "Subtract":
                            matrix[row][col] -= value;
                            break;
                    }                   
                }
                else
                {                    
                    Console.WriteLine("Invalid coordinates");
                }                            
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = new int[numbers.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = numbers[col];
                }


            }
        }
    }
}
