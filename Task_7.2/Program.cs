using System;
using System.Text.RegularExpressions;

namespace Task_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            var input = Console.ReadLine();
            Console.WriteLine(ReplaceHTMLtags(input));
        }

        static string ReplaceHTMLtags(string input)
        {
            string result="";
            Regex Data = new Regex(@"</?(!--\s?\w*\s?--|!DOCTYPE|a|abbr|address|area|article|aside|audio|p
|                                 |b|base|bdi|bdo|blockquote|body|br|button|canvas|caption|cite|code
|                                 |col|colgroup|data|datalist|dd|del|details|dfn|details|dialog|div
                                  |dl|dt|em|embed|fieldset|figcaption|figure|footer|form|h[1-6]|head
                                  |header|hr|html|i|iframe|img|input|ins|kbd|label|legend|li|link
                                  |main|map|mark|meta|meter|nav|noscript|object|ol|optgroup|option|output
                                  |p|param|picture|pre|progress|q|ruby|rb|rt|rtc|rp|s|samp|script
                                  |section|select|small|source|span|strong|style|sub|summary|sup|table
                                  |tbody|td|template|textarea|tfoot|th|thead|time|title|tr|track|u|ul
                                  |object|var|video|wbr|object)>");
            var matches = Data.Matches(input);
            foreach (Match item in matches)
            {
                result = input.Replace(item.Value, "_");
                input = result;
            } 
            return result;
        }
    }
}
