using System;

namespace Task_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press key to get sum of numbers," +
            "that are lower than 1000 and multiple 3 and 5");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(GetSum(1000));
            Console.ReadKey();
        }

        static int GetSum(int x) // Вычиление суммы
        {
            int y = 0;
            for (int i = 1; i < x; i++) // Сложение чисел кратных 3 или 5
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    y += i;
                }
            }
            return y;
        }
    }
}
