using System;
using System.Collections.Generic;

namespace Task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input count of people in circle:");
            int count = int.Parse(Console.ReadLine());
            PeopleInCircle c = new PeopleInCircle();
            c.FillCircleByPeopleID(count);
            c.ReduceCircleByEvenNumber(c.people);
            Console.WriteLine(c.people.Count);
            foreach (int ID in c.people)
            {
                Console.Write($"{ID}\t");
            }
            Console.ReadKey();
        }
    }
}
