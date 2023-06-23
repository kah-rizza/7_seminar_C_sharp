using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        double[] columnAverages = new double[cols];

        for (int col = 0; col < cols; col++)
        {
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                sum += array[row, col];
            }

            columnAverages[col] = (double)sum / rows;
        }

        Console.WriteLine("Среднее арифметическое каждого столбца:");

        for (int col = 0; col < cols; col++)
        {
            Console.WriteLine(columnAverages[col].ToString("0.0"));
        }
    }
}
