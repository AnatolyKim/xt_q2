using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Users.Entities
{
    [DataContract]
    public class Award
    {
        [DataMember]
        public int AwardID { get; set; }
        [DataMember]
        public string Title { get; private set; }

        public void SetTitle(string input)
        {
            Title = input;
        }
    }
}
