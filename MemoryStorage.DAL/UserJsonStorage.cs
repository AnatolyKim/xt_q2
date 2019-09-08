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
    public class UserJsonStorage:IUserStorable
    {
        string writePath = @"D:\Sample\Users.json";
        public List<User> Users { get; set; }
        public UserJsonStorage()
        {
            Users = new List<User>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(writePath, FileMode.OpenOrCreate))
            {
                if (new FileInfo(writePath).Length != 0) Users = (List<User>)jsonFormatter.ReadObject(fs);
            }
        }
        public void Add(User user)
        {
            if (Users.Count!=0) user.ID = Users.Last().ID+1;
            else user.ID = 1;
            Users.Add(user);
            WriteToJson(Users);
        }

        public void Remove(int id)
        {
            foreach (var n in Users.Where(User => User.ID == id).ToArray()) Users.Remove(n);
            WriteToJson(Users);
        }

        public ICollection<User> GetAll()
        {
            return Users;
        }

        public void AwardUser(List<User> users)
        {
            WriteToJson(users);
        }

        public void WriteToJson(List<User> users)
        {
            using (FileStream fs = new FileStream(writePath, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
                jsonFormatter.WriteObject(fs, users);
            }
        }
    }
}
