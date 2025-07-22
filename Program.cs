using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 10000;
            Matrix matrix = new(new Random(), row: 10, column: 10, maxValue: maxValue);
            matrix.Print(padLength: maxValue.ToString().Length);
        }
    }
}
