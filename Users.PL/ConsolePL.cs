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
            Console.WriteLine("4 - Add new award");
            Console.WriteLine("5 - Show award list");
            Console.WriteLine("6 - Award user");
            Console.WriteLine("7 - Exit");

            if (int.TryParse(Console.ReadLine(), out int selectedAction)
                &&selectedAction<8
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
                        Award award = new Award();
                        Console.WriteLine("Input title:");
                        award.SetTitle(Console.ReadLine());
                        UserManager.AddAward(award);
                        SelectAction();
                        break;
                    case 5:
                        ICollection<Award> awards = UserManager.GetAwardList();
                        PrintAwardList(awards);
                        SelectAction();
                        break;
                    case 6:
                        Console.WriteLine("Select award by ID:");
                        ICollection<Award> awardlist = UserManager.GetAwardList();
                        PrintAwardList(awardlist);
                        int selectedAwardID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Select user by ID:");
                        ICollection<User> userlist = UserManager.GetAllUsers();
                        PrintAllUsersInfo(userlist);
                        int selectedUser = int.Parse(Console.ReadLine());
                        UserManager.AwardUser(selectedAwardID, selectedUser);
                        SelectAction();
                        break;
                    case 7:
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
                Console.Write($"ID: {user.ID}--Name: {user.Name}--Birth Date: {user.BirthDate.ToString("dd.MM.yyyy")}--Age: {user.Age}-- Awards: ");
                foreach (var award in user.Awards) Console.Write($"{award} ");
                Console.WriteLine();
            }
        }
        public static void PrintAwardList(ICollection<Award> awards)
        {
            foreach (var award in awards)
            {
                Console.WriteLine($"ID: {award.AwardID}--Title: {award.Title}");
            }
        }

    }
}
