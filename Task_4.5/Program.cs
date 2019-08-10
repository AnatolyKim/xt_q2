using System;

namespace Task_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input phrase:");
            string input = Console.ReadLine();
            bool result=input.IsIntPositive();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    static class IntChecker
    {
        public static bool IsIntPositive(this string phrase)
        {
            char[] array= new char[] { };
            array=phrase.ToCharArray();
            bool result = false;
            foreach (char c in array)
            {
                if (char.IsPunctuation(c)) return result;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i]) > 48 && array[i] < 58) result = true; // Сравнение с таблицей ASCII
                else break;
            }
            return result;
        }
    }
}
