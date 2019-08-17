using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Entities
{
    public class Award
    {
        public int AwardID { get; set; }
        public string Title { get; private set; }

        public void SetTitle(string input)
        {
            Title = input;
        }
    }
}
