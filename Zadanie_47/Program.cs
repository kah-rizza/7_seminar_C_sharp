using System;

class Program
{
    static void Main()
    {
        int m = 3;  // Количество строк
        int n = 4;  // Количество столбцов

        // Создание генератора случайных чисел
        Random random = new Random();

        // Создание двумерного массива
        double[,] array = new double[m, n];

        // Заполнение массива случайными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble() * 20 - 10; // Генерация числа от -10 до 10
            }
        }

        // Вывод массива
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}