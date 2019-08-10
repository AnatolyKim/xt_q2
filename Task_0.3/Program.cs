using System;

namespace Task_0._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input positive odd number");
            int x = int.Parse(Console.ReadLine());
            PrintStarFigure(x);
            Console.ReadKey();
        }

        static void PrintStarFigure(int x) // Вывод квадрата пробелом в центре
        {
            if (x == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                int middle = x / 2;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        if (i == middle && j == middle)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
