using System;
using System.Linq;
using System.Threading;

namespace Task_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 7, 9, 7, 10 };
            Thread process1 = new Thread(
                () =>
                {
                    Sort(array);
                    OnComplete?.Invoke();
                    int[] sorted = Sort(array);
                    PrintMass(sorted);
                }
             );
            Thread process2 = new Thread(
                () =>
                {
                    Sort(array);
                    OnComplete?.Invoke();
                    int[] sorted = Sort(array);
                    PrintMass(sorted);
                }
             );
            OnComplete += PrintStatus;
            process1.Start();
            process2.Start();
            Console.ReadKey();
        }

        public static bool Compare<T>(T x, T y) where T : IComparable<T>
        {
            bool flag = (x.CompareTo(y) > 0);
            return flag;
        }

        public static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length == 1)
            {
                return array;
            }
            int middle = array.Length / 2;
            T[] lefthalf = new T[middle];
            T[] righthalf = new T[middle + array.Length % 2];
            return Merge(Sort(array.Take(middle).ToArray()), Sort(array.Skip(middle).ToArray()), Compare);
        }

        static T[] Merge<T>(T[] arr1, T[] arr2, Func<T, T, bool> func)
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
        public static event Action OnComplete;
        public static void PrintStatus()
        {
            Console.WriteLine("Sorting completed");
        }

        public static void PrintMass<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

    }
}
