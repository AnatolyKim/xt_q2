using System;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input positive integer number");
            int x = int.Parse(Console.ReadLine());
            BuildTriangle(x);
            Console.ReadKey();
        }

        static void BuildTriangle(int x) // Вывод треугольника высоты X
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
