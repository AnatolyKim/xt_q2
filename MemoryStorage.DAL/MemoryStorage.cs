using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Entities;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Storage.DAL
{
    public static class MemoryStorage
    {
        static string writePath = @"D:\Sample\Users.json";
        static string writeAwardsPath = @"D:\Sample\Awards.json";
        public static List<User> Users { get; private set; }
        public static List<Award> AwardList { get; private set; }
        static MemoryStorage()
        {
            Users = new List<User>();
            AwardList = new List<Award>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(writePath, FileMode.OpenOrCreate))
            {
                if (new FileInfo(writePath).Length != 0) Users = (List<User>)jsonFormatter.ReadObject(fs);
            }
            DataContractJsonSerializer jsonFormatterAward = new DataContractJsonSerializer(typeof(List<Award>));
            using (FileStream fs = new FileStream(writeAwardsPath, FileMode.OpenOrCreate))
            {
                if (new FileInfo(writeAwardsPath).Length != 0) AwardList = (List<Award>)jsonFormatterAward.ReadObject(fs);
            }
        }
        public static void Add(User user)
        {
            if (Users.Count!=0) user.ID = Users.Last().ID+1;
            else user.ID = 1;
            Users.Add(user);
            WriteToJson(Users);
        }

        public static void AddAward(Award award)
        {
            if (AwardList.Count != 0) award.AwardID = AwardList.Last().AwardID + 1;
            else award.AwardID= 1;
            AwardList.Add(award);
            WriteToJson(AwardList);
        }

        public static void Remove(int id)
        {
            foreach (var n in Users.Where(User => User.ID == id).ToArray()) Users.Remove(n);
            WriteToJson(Users);
        }

        public static void RemoveAward(int id)
        {
            foreach (var n in AwardList.Where(Award => Award.AwardID == id).ToArray()) AwardList.Remove(n);
            WriteToJson(AwardList);
        }

        public static ICollection<User> GetAll()
        {
            return Users;
        }

        public static ICollection<Award> GetAllAwards()
        {
            return AwardList;
        }

        public static void AwardUser(int awardID, int userID)
        {
            foreach (var user in Users.Where(User => User.ID == userID).ToArray())
            {
                foreach (var n in AwardList.Where(Award => Award.AwardID == awardID).ToArray()) user.Awards.Add(n.Title);
            }
            WriteToJson(Users);

        }

        public static void WriteToJson(List<User> users)
        {
            using (FileStream fs = new FileStream(writePath, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
                jsonFormatter.WriteObject(fs, users);
            }
        }

        public static void WriteToJson(List<Award> awards)
        {
            using (FileStream fs = new FileStream(writeAwardsPath, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Award>));
                jsonFormatter.WriteObject(fs, awards);
            }
        }
    }
}
