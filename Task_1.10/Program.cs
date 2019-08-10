using System;

namespace Task_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input row number");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Input column number");
            int length = int.Parse(Console.ReadLine());
            int[,] array = CreateArray(height, length);
            PrintArray(array);
            int result = SumEvenPosotions(array);
            Console.WriteLine($"Sum of even positions is {result}");
            Console.ReadKey();
        }

        static int[,] CreateArray(int x, int y) // Создание массива и заполнение случайными числами от 0 до 50
        {
            Random rand = new Random();
            int[,] arr = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = rand.Next(0, 50);
                }
            }
            return arr;
        }
        static void PrintArray(int[,] array) // Вывод массива
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,5}", array[i, j]));
                }
                Console.WriteLine();
            }
        }
        static int SumEvenPosotions(int[,] array) // Вычисление суммы четных позиций
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
