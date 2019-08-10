using System;

namespace Task_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Employee();
            Console.WriteLine("Input experiance in years");
            c.Position = Console.ReadLine();
            Console.WriteLine(c.Experience);
            Console.ReadKey();
        }
    }
}
