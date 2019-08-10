using System;

namespace Task_0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Input number");
                int x = int.Parse(Console.ReadLine());
                OutputNumberLine(x);
                Console.ReadKey();
            }
        }

        static void OutputNumberLine(int x)
        {
            for (int i = 1; i < x; i++)
            {
                Console.Write($"{i},");
            }
            Console.Write(x);
        }
    }
}
