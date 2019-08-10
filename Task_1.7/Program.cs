using System;

namespace Task_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array size");
            int size = int.Parse(Console.ReadLine());
            CreateArray(size);
            Console.ReadKey();
        }

        static void CreateArray(int x) // Создание и вывод сортированного массива
        {
                Random rnd = new Random();
                Console.WriteLine("Random int array:");
                int[] arrint = new int[x];
                for (int i = 0; i < arrint.Length; i++) // Заполнение случайными числами от 0 до 100
                {
                    arrint[i] = rnd.Next(0, 100);
                }
                for (int i = 0; i < arrint.Length; i++) // Вывод массива
                {
                    Console.Write(arrint[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Sorted array");
                Sorter o = new Sorter();
                arrint = o.MergeSort(arrint);  // Передача массива в функцию сортировки
                for (int i = 0; i < arrint.Length; i++) //Вывод сортированного массива
                {
                    Console.Write(arrint[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Minimum value " + arrint[0]); // Вывод минимального значения
                Console.WriteLine("Maximum value " + arrint[arrint.Length - 1]); //Вывод максимального значения
        } 
    }
}
