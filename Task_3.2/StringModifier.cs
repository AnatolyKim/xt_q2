using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task_3._2
{
    class StringModifier
    {
        List<string> InputString = new List<string> { };
        char[] CharSeparators = new char[] { ' ', '.' };

        public string[] SplitPhrase(string phrase)
        {
            string[] SplitedPhrase = phrase.Split(CharSeparators,StringSplitOptions.RemoveEmptyEntries);
            return SplitedPhrase;
        }

        public string ConvertToLower(string phrase)
        {
            string convertedPhrase = phrase.ToLower();
            return convertedPhrase;
        }
        public List<string> FillListRegistrIndepended(string phrase)
        {
            string converted=ConvertToLower(phrase);
            string [] wordmass=SplitPhrase(converted);
            for (int i = 0; i < wordmass.Length; i++)
            {
                InputString.Add(wordmass[i]);
            }
            return InputString;
        }

        public int GetRepeatedWordsCount(List<string>list, string word)
        {
            int count = 0;
            foreach(string element in list)
            {
                if (word.Equals(element))
                {
                    count++;
                }
            }
            return count;
        }

    }
}
