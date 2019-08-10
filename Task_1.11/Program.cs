using System;

namespace Task_1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some words");
            string phrase = Console.ReadLine();
            double result = CalculateAverageLength(phrase);
            Console.WriteLine("Average word length is: {0:0.00}", result);
            Console.ReadKey();
        }

        static double CalculateAverageLength(string x) //Вычисление средней длины слова в строке
        {
            int punctuation = 0;
            int breaks = 0;
            int wordnumber = 0;
            char[] row = x.ToCharArray();
            for (int i = 0; i < row.Length; i++) // Подсчет знаков пунктуации и пробелов в строке
            {
                if (char.IsSeparator(row[i])) { breaks++; }
                if (char.IsPunctuation(row[i])) { punctuation++; }
            }
            for (int i = 0; i < row.Length - 1; i++) // Подсчет количества слов в строке
            {
                if (char.IsLetterOrDigit(row[i]) && (char.IsSeparator(row[i + 1]) || char.IsPunctuation(row[i + 1]))) { wordnumber++; }
            }
            if (char.IsLetterOrDigit(row[row.Length - 1])) { wordnumber++; } // Прибавление последнего слова в строке если, оно не соотвествовало условию выше
            double y = (double)(row.Length - punctuation - breaks) / wordnumber; // Вычисление средней длины слова
            return y;
        }
    }
}
