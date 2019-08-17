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
            MemoryStorage.Add(user);
        }
        public void AddAward(Award award)
        {
            MemoryStorage.AddAward(award);
        }

        public bool RemoveUser(string ID)
        {
            if(int.TryParse(ID,out int id) 
                && id>0
                && id <= MemoryStorage.Users.Count)
            {
                MemoryStorage.Remove(id);
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
            return MemoryStorage.GetAll();
        }

        public ICollection<Award> GetAwardList()
        {
            return MemoryStorage.GetAllAwards();
        }

        public void AwardUser(int award, int userID)
        {
            MemoryStorage.AwardUser(award, userID);
        }
    }
}
