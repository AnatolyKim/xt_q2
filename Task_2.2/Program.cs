using System;

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных пользователем и присвоение переменным экземпляра класса Round
            Triangle c = new Triangle();
            Console.WriteLine("Input side a");
            c.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Input side b");
            c.B = double.Parse(Console.ReadLine());
            Console.WriteLine("Input side c");
            c.C = double.Parse(Console.ReadLine());

            // Вывод длин сторон, площади и периметра заданного треугольника
            Console.WriteLine($"Your triangle has following parameters a:{c.A}, b:{c.B}, c:{c.C}");
            Console.WriteLine("Triangle area equal {0:0.000}", c.Area);
            Console.WriteLine("Perimeter equal {0:0.000}", c.Perimeter);
            Console.ReadKey();
        }
    }
}
