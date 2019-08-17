using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Entities;
using System.IO;

namespace Storage.DAL
{
    public static class MemoryStorage
    {
        static string writePath = @"D:\Sample\Users.txt";
        static string writeAwardsPath = @"D:\Sample\Awards.txt";
        public static int UserIndex { get; private set; }
        public static int AwardIndex { get; private set; }
        public static List<User> Users { get; private set; }
        public static List<Award> AwardList { get; private set; }
        static MemoryStorage()
        {
            Users = new List<User>();
            AwardList = new List<Award>();
        }

        public static void Add(User user)
        {
            Users.Add(user);
            user.ID=++UserIndex;
            WriteToFile(user);
        }

        public static void AddAward(Award award)
        {
            AwardList.Add(award);
            award.AwardID = ++AwardIndex;
            WriteToFile(award);
        }

        public static void Remove(int id)
        {
            foreach (var n in Users.Where(User => User.ID == id).ToArray()) Users.Remove(n);
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                foreach (var user in Users)
                {
                    string data = $"ID: {user.ID}--Name: {user.Name}--Birth Date: {user.BirthDate.ToString("dd.MM.yyyy")}-- Age: {user.Age}";
                    sw.WriteLine(data);
                }
            }
        }

        public static ICollection<User> GetAll()
        {
            return Users;
        }

        public static ICollection<Award> GetAllAwards()
        {
            return AwardList;
        }

        public static void WriteToFile(User user)
        {
            string data = $"ID: {user.ID}--Name: {user.Name}--Birth Date: {user.BirthDate.ToString("dd.MM.yyyy")}-- Age: {user.Age}";
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(data);
            }
        }

        public static void WriteToFile(Award award)
        {
            string data = $"ID: {award.AwardID}--Name: {award.Title}";
            using (StreamWriter sw = new StreamWriter(writeAwardsPath, true, System.Text.Encoding.Default)) sw.WriteLine(data);
        }

        public static void AwardUser(int awardID, int userID)
        {
            foreach (var user in Users.Where(User => User.ID == userID).ToArray())
            {
                foreach (var n in AwardList.Where(Award => Award.AwardID == awardID).ToArray()) user.Awards.Add(n.Title);
            }
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                foreach(var user in Users)
                {
                    string data = $"ID: {user.ID}--Name: {user.Name}--Birth Date: {user.BirthDate.ToString("dd.MM.yyyy")}-- Age: {user.Age}-- Awards: ";
                    sw.Write(data);
                    foreach (var award in user.Awards) sw.Write($"{award} ");
                    sw.WriteLine();
                }
            }
        }
    }
}
