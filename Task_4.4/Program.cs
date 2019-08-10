using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Task_4._4
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 1, 2, 3, 4, 5 };
            int res = mass.GetSum();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
    static class MathOperation
    {
        public static T GetSum<T>(this T[] x)
        {
            T result = x[0];
            var param1 = Expression.Parameter(typeof(T), "result");
            var param2 = Expression.Parameter(typeof(T), $"x[i]");
            var sum = (Func<T, T, T>)Expression
                  .Lambda(Expression.Add(param1, param2), param1, param2)
                  .Compile();
            for (int i = 1; i < x.Length; i++)
            {
                T temp = sum(result, x[i]);
                result = temp;
            }
            return result;
        }
    }
}
