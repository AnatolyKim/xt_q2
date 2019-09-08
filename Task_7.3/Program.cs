using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Task_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            var input = Console.ReadLine();
            var output = FindEmails(input);
            if (output.Count != 0)
            {
                Console.WriteLine("Next emails were found:");
                foreach (var mail in output) Console.WriteLine(mail);
            }
            else Console.WriteLine("No emails found");
        }

            static List<string> FindEmails(string input)
        {
            List<string> result = new List<string>();
            Regex Data = new Regex(@"\b([a-z]|[0-9])([a-z]|[0-9]|-|_|\.)*([a-z]|[0-9])*@[a-z]{2,6}\.(([a-z]|[0-9])([a-z]|[0-9]|-)*([a-z]|[0-9])\.)?[a-z]{2,}\b", RegexOptions.IgnoreCase );
            var matches = Data.Matches(input);
            foreach (Match item in matches)
            {
                result.Add(item.Value);
            }
            return result;
        }
    }
}
