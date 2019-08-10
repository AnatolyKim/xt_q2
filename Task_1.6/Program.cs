using System;

namespace Task_1._6
{
    class Program
    {
        static int fontnumber; // Переменная вводимая пользователем
        static void Main(string[] args)
        {
            Fonts status = 0; // Значение шрифта по умолчанию
            Console.WriteLine("Парамметры надписи: " + $"{status}");
            while (true) // Вывод запроса и меню
            {
                OutputMenu();
                Fontnumber = int.Parse(Console.ReadLine());
                status = SetFont(fontnumber, status);
                Console.WriteLine("Парамметры надписи: " + $"{status}");
            //Console.ReadKey();
            }
        }
        static void OutputMenu() // Вывод меню
        {
            Console.WriteLine(
                "Введите:" + '\n' +
                "1:bold" + '\n' +
                "2:italic" + '\n' +
                "3:underline");
        }

        [Flags] // Хранение шрифтов
        enum Fonts
        {
            None = 0,
            bold = 1,
            italic = 2,
            underline = 4
        }

        static Fonts SetFont(int x,Fonts s) // Установка шрифта 
        {
            Fonts allowedFonts = s;
            int id =(int) Math.Pow(2, (x - 1)); // Установка соотношения вводимой перемменной с номером шрифта для битовых операций
                if (allowedFonts.HasFlag((Fonts)id))
                {
                    allowedFonts = allowedFonts^(Fonts)id;
                }
                else
                {
                    allowedFonts = allowedFonts|(Fonts)id;
                }
            return allowedFonts;
        }
        static int Fontnumber //Свойство переменной вводимой пользователем
        {
            get { return fontnumber; }
            set
            {

                if (value> 3||value<=0)
                {
                    throw new ArgumentException("Input right font number");
                }
                else fontnumber = value;
            }
        }
    }
}
