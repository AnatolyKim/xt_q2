using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Entities;
using Storage.DAL;

namespace Dependensies
{
    public static class LoosingCouplingObjects
    {
        public static IUserStorable UserStorage = new UserJsonStorage();
        public static IAwardStorable AwardStorage = new AwardJsonStorage();
    }
}
