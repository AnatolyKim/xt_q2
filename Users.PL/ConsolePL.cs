using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Entities;
using UserManager.BLL;

namespace Users.PL
{
    class ConsolePL
    {
        public static UsersManager UserManager { get; } = new UsersManager();
        static void Main(string[] args)
        {
            SelectAction();
            Console.ReadKey();
        }

        private static void SelectAction()
        {
            Console.WriteLine("Select action:");
            Console.WriteLine("1 - Add new user");
            Console.WriteLine("2 - Remove user");
            Console.WriteLine("3 - Show all users");
            Console.WriteLine("4 - Exit");

            if (int.TryParse(Console.ReadLine(), out int selectedAction)
                &&selectedAction<5
                &&selectedAction>0)
            {
                switch (selectedAction)
                {
                    case 1:
                        User user = new User();
                        Console.WriteLine("Input name:");
                        while (user.Name==null)
                        {
                            if (user.SetName(Console.ReadLine()) == false) Print(user.ErrorMessage);
                        }
                        Console.WriteLine("Input birth date in format - dd.mm.yyyy:");
                        while (user.BirthDate == default)
                        {
                            if (user.SetBirthDate(Console.ReadLine()) == false) Print(user.ErrorMessage);
                        }
                        user.SetAge(user.BirthDate);
                        UserManager.AddUser(user);
                        SelectAction();
                        break;
                    case 2:
                        if (UserManager.RemoveUser(Console.ReadLine()) == false) Print(UserManager.ErrorMessage);
                        SelectAction();
                        break;
                    case 3:
                        ICollection<User>users=UserManager.GetAllUsers();
                        PrintAllUsersInfo(users);
                        SelectAction();
                        break;
                    case 4:
                        return;
                }
            }
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintAllUsersInfo(ICollection<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name},{user.BirthDate},{user.Age}");
            }
        }
        
    }
}
