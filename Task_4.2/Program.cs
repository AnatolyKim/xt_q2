using System;
using System.Linq;

namespace Task_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input phrase:");
            string input = Console.ReadLine();
            string[] mass = input.Split(new string[] { " " }, StringSplitOptions.None);
            string[] sorted=Sort(mass);
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write($"{sorted[i]}\t");
            }
            Console.ReadKey();
        }

        public static bool Compare(string x, string y)
        {

            bool flag=(x.CompareTo(y) > 0);
            return flag;
        }
        public static string[] Sort(string[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            int middle = array.Length / 2;
            string [] lefthalf = new string[middle];
            string [] righthalf = new string[middle + array.Length % 2];
            return Merge(Sort(array.Take(middle).ToArray()), Sort(array.Skip(middle).ToArray()), Compare);
        }

        static string[] Merge(string[] arr1, string[] arr2, Func<string,string,bool> func)
        {
            int ptr1 = 0, ptr2 = 0;
            string[] merged = new string[arr1.Length + arr2.Length];

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
