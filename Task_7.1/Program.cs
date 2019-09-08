using System;
using System.Text.RegularExpressions;

namespace Task_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text with data in format dd-mm-yyyy:");
            var input = Console.ReadLine();
            Console.WriteLine(CheckDate(input));
        }

        static string CheckDate(string input)
        {
            Regex Data = new Regex(@"([0-2][0-9]-[0][0-9]-[0-9]{4})|([3][0-1]-[0][0-9]-[0-9]{4})|([0-2][0-9]-[1][0-2]-[0-9]{4})|([3][0-1]-[1][0-2]-[0-9]{4})");
            var match = Data.Match(input);
            string result;
            if (match.Success) result = $"Text \"{input}\" is containing date";
            else result = "Date was not found";
            return result;
        }
    }
}
