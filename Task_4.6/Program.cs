using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_4._6
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] mass = new int[] { 45, 3, 4,-68, 12, -35, 47, -8, 1 };
            Predicate<int> condition = new Predicate<int>(IsPositive);
            int[] result1 = GetByCondition(mass,condition);
            Console.WriteLine("By delegate instance:");
            Print(result1);
            int[] result2 = GetByCondition(mass, delegate (int x) { return IsPositive(x); });
            Console.WriteLine("By anonymus method:");
            Print(result2);
            int[] result3 = GetByCondition(mass, (int x) => IsPositive(x));
            Console.WriteLine("By lambda:");
            Print(result1);
            int[] result4 = SearchPositiveByLinq(mass);
            Console.WriteLine("By LINQ:");
            Print(result4);
            Console.ReadKey();
        }

        static int[] SearchPositiveNumbers(int[] mass)
        {
            List<int> positive = new List<int>();
            foreach (int number in mass)
            {
                if (number > 0)
                {
                    positive.Add(number);
                }
            }
            return positive.ToArray();
        }

        static int[] SearchPositiveByLinq(int[] mass)
        {
            var result = (from n in mass
                         where n > 0
                         select n).ToArray();
            return result;
        }

        static int[] GetByCondition(int[] mass,Predicate<int> condition)
        {
            List<int> passed = new List<int>();
            if (condition == null)
            {
                throw new ArgumentException("No condition");
            }
            foreach (int elem in mass)
            {

                if (condition.Invoke(elem)) passed.Add(elem);
            }
            return passed.ToArray();
        }
        static bool IsPositive(int x) { return x > 0; }

        static void Print(int[] mass)
        {
            foreach (int num in mass)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
