using System;

namespace Task_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input positive integer number"); // Ввод высоты пирамиды
            int x = int.Parse(Console.ReadLine());
            BuildPyramid(x);
            Console.ReadKey();
        }

        static void BuildPyramid(int x)
        {
            if (x == 1) // При высоте 1
            {
                Console.WriteLine("*");
            }
            else // При высоте пирамиды X
            {
                int middle = (2 * x - 1) / 2;
                for (int i = 0; i < x; i++) // Вывод пирамиды с заполением от вычисленной середины
                {
                    for (int j = 0; j < 2 * x - 1; j++)
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
        }
    }
}
