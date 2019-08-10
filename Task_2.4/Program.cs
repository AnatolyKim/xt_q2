using System;

namespace Task_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input phrase 1:");
            string phrase = Console.ReadLine();
            Console.WriteLine("Input phrase 2:");
            string key = Console.ReadLine();
            MyString c = new MyString();
            Console.WriteLine(c.IsEqual(phrase,key));
            Console.ReadKey();
        }
    }
}
