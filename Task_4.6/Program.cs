using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_4._6
{
    class Program
    {
        delegate int[] ConditionSearch(int[] mass);
        static void Main(string[] args)
        {
            int[] mass = new int[] { 45, 3, 4,-68, 12, -35, 47, -8, 1 };
            //ConditionSearch search = new ConditionSearch(SearchPositiveNumbers);
            //ConditionSearch search = delegate (int[] arr) { return SearchPositiveNumbers(mass); };
            ConditionSearch search = (int[] arr) => SearchNegativeNumbers(mass);
            int[] result = search(mass);
            foreach (int c in result) Console.Write($"{c} ");
            Console.ReadKey();
        }

        static int[] SearchPositiveNumbers(int[] mass)
        {
            int size=0;
            int index = 0;
            foreach (int number in mass) if (number > 0) size++;
            int[] resultArray = new int[size];
            foreach (int number in mass)
            {
                if (number > 0)
                {
                    resultArray[index] = number;
                    index++;
                }
            }
            return resultArray;
        }

        static int[] SearchNegativeNumbers(int[] mass)
        {
            int size = 0;
            int index = 0;
            foreach (int number in mass) if (number < 0) size++;
            int[] resultArray = new int[size];
            foreach (int number in mass)
            {
                if (number < 0)
                {
                    resultArray[index] = number;
                    index++;
                }
            }
            return resultArray;
        }

        static void SearchLinq(int[] mass)
        {
            var result = from n in mass
                         where n > 0
                         select n;
        }

        //public static int[] SearchByDelegate(int[] mass,Func<int[],int[]> search)
        //{
        //    return search(mass);
        //}


    }
}
