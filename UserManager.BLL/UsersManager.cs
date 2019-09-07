using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Entities;
using Storage.DAL;


namespace UserManager.BLL
{
    public class UsersManager
    {
        public string ErrorMessage { get; private set; }
        public void AddUser(User user)
        {
            JsonStorage.Add(user);
        }

        public bool RemoveUser(string ID)
        {
            if (int.TryParse(ID, out int id)
                && id > 0
                && id <= JsonStorage.Users.Last().ID)
            {
                JsonStorage.Remove(id);
                return true;
            }
            else
            {
                ErrorMessage = "Input correct ID. User wasn't deleted";
                return false;
            }

        }

        public ICollection<User> GetAllUsers()
        {
            return JsonStorage.GetAll();
        }

    }
}
