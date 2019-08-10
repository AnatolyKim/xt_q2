using System;
using System.Collections.Generic;
using System.Linq;


namespace Task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input random phrase:");
            string phrase = Console.ReadLine();
            var list = new StringModifier();
            List <string> preparedList= new List<string> { };
            preparedList = list.FillListRegistrIndepended(phrase);
            foreach (string word in preparedList.Distinct())
            {
                int count = list.GetRepeatedWordsCount(preparedList, word);
                Console.WriteLine($"{word} in your phrase - {count} times");
            }
        }
    }
}
