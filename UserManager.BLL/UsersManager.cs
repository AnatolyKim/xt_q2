using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Entities;


namespace UserManager.BLL
{
    public class UsersManager
    {
        public string ErrorMessage { get; private set; }
        public void AddUser(User user)
        {
            Dependensies.LoosingCouplingObjects.UserStorage.Add(user);
        }

        public bool RemoveUser(string ID)
        {
            if (int.TryParse(ID, out int id)
                && id > 0
                && id <= Dependensies.LoosingCouplingObjects.UserStorage.Users.Last().ID)
            {
                Dependensies.LoosingCouplingObjects.UserStorage.Remove(id);
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
            return Dependensies.LoosingCouplingObjects.UserStorage.GetAll();
        }

        public void AwardUser(int awardID, int userID)
        {
            foreach (var user in Dependensies.LoosingCouplingObjects.UserStorage.Users.Where(User => User.ID == userID).ToArray())
            {
                foreach (var n in Dependensies.LoosingCouplingObjects.AwardStorage.AwardList.Where(Award => Award.AwardID == awardID).ToArray()) user.Awards.Add(n.Title);
            }
            Dependensies.LoosingCouplingObjects.UserStorage.AwardUser(Dependensies.LoosingCouplingObjects.UserStorage.Users);
        }
    }
}
