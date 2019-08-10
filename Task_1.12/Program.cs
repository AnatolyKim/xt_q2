using System;

namespace Task_1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some words");
            string phrase = Console.ReadLine();  // Ввод основной строки
            Console.WriteLine("Input some words again");
            string keywords = Console.ReadLine(); // Ввод ключевой фразы
            DoubleLetter(phrase, keywords);
            Console.ReadKey();
        }
        static void DoubleLetter(string x, string y) // Дублирование символов вставкой подстроки в строку
        {
            string resultrow = x;
            int j = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (y.Contains(x[i]))
                {
                    j++;
                    resultrow = resultrow.Insert(i + j, $"{x[i]}");
                }
            }
            Console.WriteLine(resultrow);
        }
    }
}
