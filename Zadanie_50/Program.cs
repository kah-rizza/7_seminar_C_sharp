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

        int[] position = { 1, 7 };

        int value = GetArrayElement(array, position);

        if (value != -1)
        {
            Console.WriteLine($"Значение элемента: {value}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет в массиве.");
        }
    }

    static int GetArrayElement(int[,] array, int[] position)
    {
        int row = position[0];
        int col = position[1];

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        if (row >= 0 && row < rows && col >= 0 && col < cols)
        {
            return array[row, col];
        }
        else
        {
            return -1;
        }
    }
}
