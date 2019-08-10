using System;

namespace Task_1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 1st dimension");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 2nd dimesion");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 3rd dimension");
            int third = int.Parse(Console.ReadLine());
            int[,,] array = CreateArray(first, second, third);
            PrintArray(array); // Вывод начального трехмерного массива
            PrintArray(ChangeToZero(array)); //Вывод измененного массива
            Console.ReadKey();
        }

        static int[,,] CreateArray(int x, int y, int z) // Создание массива и заполнение его случайными числами от -50 до 50
        {
            Random rand = new Random();
            int[,,] arr = new int[x, y, z];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        arr[i, j, k] = rand.Next(-50, 50);
                    }
                }
            }
            return arr;
        }
        static void PrintArray(int[,,] array) // Вывод массива
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(String.Format("{0,8}", array[i, j, k]));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static int[,,] ChangeToZero(int[,,] array) // Замена положительных чисел на 0 в массиве
        {
            int[,,] changed = array;
            for (int i = 0; i < changed.GetLength(0); i++)
            {
                for (int j = 0; j < changed.GetLength(1); j++)
                {
                    for (int k = 0; k < changed.GetLength(2); k++)
                    {
                        if (changed[i, j, k] > 0)
                        {
                            changed[i, j, k] = 0;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            return changed;
        }


    }
}
