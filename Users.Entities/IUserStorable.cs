using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Entities
{
    public interface IUserStorable
    {
        void Add(User user);
        void Remove(int id);
        ICollection<User> GetAll();
        void AwardUser(List<User> users);
        List<User> Users { get; set; }
    }
}
