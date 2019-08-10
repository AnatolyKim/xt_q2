using System;

namespace Task_0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input positive integer number");
            int x = int.Parse(Console.ReadLine());
            CheckSimpleNumber(x);
            Console.ReadKey();
        }
        static void CheckSimpleNumber(int x) // Проверка на принадлежность простым числам
        {

            if (x == 2)
            {
                Console.WriteLine("Number is simple");
            }
            else if (x == 1 || x % 2 == 0)
            {
                Console.WriteLine("Number is not simple");
            }
            else
            {
                bool flag = true;
                for (int i = 3; i < x;)
                {
                    if (x % i == 0)
                    {
                        Console.WriteLine("Number is not simple");
                        flag = false;
                        break;
                    }
                    i = i + 2;
                }
                if (flag == true)
                {
                    Console.WriteLine("Number is simple");
                }

            }

        }
    }
}
