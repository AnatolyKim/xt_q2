using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._7
{
    class Sorter
    {
        // Деление массива на подмассивы необходимой для сравнения величины.
        public int[] MergeSort(int[] array)
        {
            if (array.Length == 1) // Возврат массива минимальной длины.
            {
                return array;
            }

            int middle = array.Length / 2; // Выбор середины массива.
            int[] lefthalf = new int[middle]; // Создание массивов, которые будут содержать левую и правую части начального массива.
            int[] righthalf = new int[middle + array.Length % 2];

            for (int i = 0; i < middle; i++) // Заполнение левого и правого массивов.
            {
                lefthalf[i] = array[i];
            }

            for (int j = 0; j < middle + array.Length % 2; j++)
            {
                righthalf[j] = array[j + middle];
            }
            return Merge(MergeSort(lefthalf), MergeSort(righthalf));
            // return Merge(MergeSort(array.Take(middle).ToArray()), MergeSort(array.Skip(middle).ToArray())); Алтернатива созданию левого и правого массивов с помощью LINQ.
        }
        // Блок сравнения и соединения подмассивов.
        int[] Merge(int[] arr1, int[] arr2)
        {
            int ptr1 = 0, ptr2 = 0;
            int[] merged = new int[arr1.Length + arr2.Length]; // Создание нового массива для слияния упорядоченных подмассивов.

            for (int i = 0; i < merged.Length; ++i) // Сравнение подмассивов и заполнение массива сортированными значениями.
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
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
