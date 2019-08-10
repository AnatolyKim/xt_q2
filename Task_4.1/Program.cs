using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {4,7,9,7,10};
            int[] sorted=Sort(array);
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write($"{sorted[i]} ");
            }
            Console.ReadKey();
        }

        public static bool Compare<T>(T x, T y)
        {
            bool flag=false;
            // Не могу понять как реализовать сравнение без CompareTo
            // Сравнение, если x > y - true
            return flag;
        }

        public static T[] Sort<T>(T[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            int middle = array.Length / 2;
            T[] lefthalf = new T[middle];
            T[] righthalf = new T[middle + array.Length % 2];
            return Merge(Sort(array.Take(middle).ToArray()), Sort(array.Skip(middle).ToArray()),Compare);
        }

        static T[] Merge<T>(T[] arr1, T[] arr2, Func<T,T,bool> func)
        {
            int ptr1 = 0, ptr2 = 0;
            T[] merged = new T[arr1.Length + arr2.Length];

            for (int i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    if (func != null)
                    {
                        merged[i] = func(arr1[ptr1], arr2[ptr2]) ? arr2[ptr2++] : arr1[ptr1++];
                    }
                }
                else
                {
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                }
            }
            return merged;
        }
    }
}
