using System;

namespace Task_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input size of array");
            int size = int.Parse(Console.ReadLine());
            int[] array = CreateArray(size);
            PrintArray(array);
            int sum = SumPositive(array); // Вывод суммы положительных членом массива
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static int[] CreateArray(int x) // Создание одномерного массива размером х и заполнение его случайными числами от -50 до 50
        {
            Random rand = new Random();
            int[] arr = new int[x];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-50, 50);
            }
            return arr;
        }
        static void PrintArray(int[] array) // Вывод массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        static int SumPositive(int[] array) // Сложение положительных членом массива
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
