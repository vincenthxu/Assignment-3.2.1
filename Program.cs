using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int[,] matrix = Generate2DArray(row: 10, column: 10, max: max);
            Print2DArray(matrix, padLength: max.ToString().Length);
        }
        static void Print2DArray(int[,] matrix, int padLength = 0, char padChar = ' ')
        {
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"|{matrix[row, col].ToString().PadLeft(padLength, padChar)}");
                }
                Console.WriteLine("|");
            }
        }
        static int[,] Generate2DArray(int row = 2, int column = 2, int max = int.MaxValue)
        {
            int[,] matrix = new int[row, column];
            Random rng = new Random(max);
            for(int r = 0; r < row; r++)
            {
                for(int c = 0; c < column; c++)
                {
                    matrix[r, c] = rng.Next(max);
                }
            }
            return matrix;
        }
    }
}
