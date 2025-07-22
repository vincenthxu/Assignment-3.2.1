using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Assignment_3._2._1
{
    public class Matrix
    {
        public int[,] Values { get; set; }
        public Matrix(int[,] values) 
        {
            Values = values;
        }
        public Matrix(Random rng, int row = 2, int column = 2, int maxValue = int.MaxValue)
        {
            Values = new int[row, column];
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Values[r, c] = rng.Next(maxValue);
                }
            }
        }
        public void Print(int padLength = 0, char padChar = ' ')
        {
            for (int row = 0; row < Values.GetLength(0); row++)
            {
                for (int col = 0; col < Values.GetLength(1); col++)
                {
                    Console.Write($"|{Values[row, col].ToString().PadLeft(padLength, padChar)}");
                }
                Console.WriteLine("|");
            }
        }
    }
}
