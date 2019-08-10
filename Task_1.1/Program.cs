using System;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input side - a"); 
            int x = int.Parse(Console.ReadLine());
            x = CheckNumber(x);
            Console.WriteLine("Input side - b");
            int y = int.Parse(Console.ReadLine());
            y = CheckNumber(y);
            CalculateArea(x, y);
            Console.WriteLine($"Rectangle area is {CalculateArea(x, y)}");
            Console.ReadKey();
        }
        static int CalculateArea(int x, int y) // Вычисление площади прямоугольника
        {
            return x * y;
        }
        static int CheckNumber(int z) // Проверка вводимого пользователем параметра
        {
            while (z <= 0)
            {
                Console.WriteLine("Input correct number");
                z = int.Parse(Console.ReadLine());
            }
            return z;
        }
    }
}
