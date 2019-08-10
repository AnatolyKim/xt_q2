using System;

namespace Task_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input height:");
            int height = int.Parse(Console.ReadLine()); // Ввод высоты елки состоящей из x треугольников
            BuildChristmasTree(height);
            Console.ReadKey();
        }
        static void BuildChristmasTree(int x) // Вывод елки со звездой на вершине
        {
            PlaceStar(x);
            for (int k = 1; k <= x; k++)
            {
                BuildLevel(2 * k + 1, x);
            }

        }

        static void BuildLevel(int x, int y) // Вывод n-треугольника
        {
            int middle = (2 * y + 1) / 2;
            for (int i = 0; i <= x - i - 1; i++) // Вывод тругольника с заполнением от вычисленной середины
            {
                for (int j = 0; j < 2 * y + 1; j++)
                {
                    if (j >= middle - i && j <= middle + i)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        static void PlaceStar(int x) // Вывод звезды на вершине
        {
            for (int j = 0; j < 2 * x + 1; j++)
            {
                if (j == (2 * x + 1) / 2)
                {
                    Console.Write("*");
                }
                else Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
