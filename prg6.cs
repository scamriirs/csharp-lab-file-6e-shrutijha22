using System;

class Program
{
    public static void Main()
    {
        int rows = 3;
        int columns = 3;

        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sum += matrix[i, j];
            }
        }
      Console.WriteLine("Sum of elements of 2-D matrix: " + sum);
    }
}
output-Sum of elements of 2-D matrix: 45
