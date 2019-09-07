using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.DAL;
using Users.Entities;

namespace AwardManager.BLL
{
    public class AwardsManager
    {
        public string ErrorMessage { get; private set; }

        public void AddAward(Award award)
        {
            MemoryStorage.AddAward(award);
        }
        public bool RemoveAward(string ID)
        {
            if (int.TryParse(ID, out int id)
                && id > 0
                && id <= MemoryStorage.AwardList.Last().AwardID)
            {
                MemoryStorage.RemoveAward(id);
                return true;
            }
            else
            {
                ErrorMessage = "Input correct ID. Award wasn't deleted";
                return false;
            }

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
