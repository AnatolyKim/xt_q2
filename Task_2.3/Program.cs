using System;

namespace Task_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных пользователем и присвоение их полями экзмпляра класса User
            User c = new User();
            Console.WriteLine("Input name");
            c.Name = Console.ReadLine();
            Console.WriteLine("Input surname");
            c.Surname = Console.ReadLine();
            Console.WriteLine("Input patronymic");
            c.Patronymic = Console.ReadLine();
            Console.WriteLine("Input birth year");
            c.BirthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Input birth month");
            c.BirthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Input birth day");
            c.BirthDay = int.Parse(Console.ReadLine());
            // Вывод полного имени, даты рождения и возраста
            Console.WriteLine($"Users full name is {c.Surname} {c.Name} {c.Patronymic}");
            Console.WriteLine($"Birth date: {c.BirthDate.ToLongDateString()}");
            Console.WriteLine($"Age is {c.Age}");
            Console.ReadKey();
        }
    }

}
