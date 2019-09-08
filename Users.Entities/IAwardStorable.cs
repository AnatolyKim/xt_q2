using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Entities
{
    public interface IAwardStorable
    {
        void AddAward(Award award);
        void RemoveAward(int id);
        ICollection<Award> GetAllAwards();
        List<Award> AwardList { get; set; }
    }
}
