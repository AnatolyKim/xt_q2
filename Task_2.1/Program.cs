using System;

namespace Task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных пользователем и присвоение переменным экземпляра класса Round
            Round c = new Round();
            Console.WriteLine("Input coordinate X");
            c.CoordinateX = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinate Y");
            c.CoordinateY = double.Parse(Console.ReadLine());
            Console.WriteLine("Input radius value");
            c.Radius = double.Parse(Console.ReadLine());

            // Вывод координат, площади и длины окружности
            Console.WriteLine($"Your round has following coordinates X:{c.CoordinateX},Y:{c.CoordinateY}");
            Console.WriteLine("Round area equal {0:0.000}",c.Area);
            Console.WriteLine("Circle length equal {0:0.000}",c.CircleLength);
            Console.ReadKey();
        }
    }
}
