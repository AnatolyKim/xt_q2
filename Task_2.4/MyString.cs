using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._4
{
    public class MyString
    {
        // Поиск символа
        public bool SearchChar(string phrase, char x)
        {
            bool flag=false;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == x)
                {
                    flag = true;
                }
            }
            return flag;
        }
        // Конвертация в символьный массив
        public char[] ConvertToCharArray(string phrase)
        {
            char[] charArray = new char[phrase.Length];
            for (int i = 0; i < phrase.Length; i++)
            {
                charArray[i] = phrase[i];
            }
            return charArray;
        }
        // Конвертация в строку
        public string ConvertToString(char[] chararr)
        {
            return new string(chararr);
        }
        // Конкатенация
        public string Concatenate(string phrase1,string phrase2)
        {
            char[] charArray1 = ConvertToCharArray(phrase1);
            char[] charArray2 = ConvertToCharArray(phrase2);
            char[] resultArray = new char[charArray1.Length + charArray2.Length];
            Array.Copy(charArray1, resultArray, charArray1.Length);
            Array.Copy(charArray2, 0, resultArray, charArray1.Length, charArray2.Length);
            return ConvertToString(resultArray);
        }
        // Проверка на равенство
        public bool IsEqual(string phrase1,string phrase2)
        {
            bool flag = false;
            char[] charArray1 = ConvertToCharArray(phrase1);
            char[] charArray2 = ConvertToCharArray(phrase2);
            if (charArray1.Length == charArray2.Length)
            {
                flag = true;
                for (int i = 0; i < charArray1.Length; i++)
                {
                    if (charArray1[i] != charArray2[i])
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }

    }
}
