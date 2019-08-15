using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Entities;

namespace Storage.DAL
{
    public static class MemoryStorage
    {
        public static List<User> Users { get; private set; }

        static MemoryStorage()
        {
            Users = new List<User>();
        }

        public static void Add(User user)
        {
            Users.Add(user);
        }

        public static void Remove(int id)
        {
            Users.RemoveAt(id);
        }

        public static ICollection<User> GetAll()
        {
            return Users;
        }

    }
}
