using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Entities;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Storage.DAL
{
    public class AwardJsonStorage:IAwardStorable
    {
        string writeAwardsPath = @"D:\Sample\Awards.json";
        public List<Award> AwardList { get; set; }
        public AwardJsonStorage()
        {
            AwardList = new List<Award>();
            DataContractJsonSerializer jsonFormatterAward = new DataContractJsonSerializer(typeof(List<Award>));
            using (FileStream fs = new FileStream(writeAwardsPath, FileMode.OpenOrCreate))
            {
                if (new FileInfo(writeAwardsPath).Length != 0) AwardList = (List<Award>)jsonFormatterAward.ReadObject(fs);
            }
        }
        public void AddAward(Award award)
        {
            if (AwardList.Count != 0) award.AwardID = AwardList.Last().AwardID + 1;
            else award.AwardID= 1;
            AwardList.Add(award);
            WriteToJson(AwardList);
        }

        public void RemoveAward(int id)
        {
            foreach (var n in AwardList.Where(Award => Award.AwardID == id).ToArray()) AwardList.Remove(n);
            WriteToJson(AwardList);
        }

        public ICollection<Award> GetAllAwards()
        {
            return AwardList;
        }

        public void WriteToJson(List<Award> awards)
        {
            using (FileStream fs = new FileStream(writeAwardsPath, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Award>));
                jsonFormatter.WriteObject(fs, awards);
            }
        }

    }
}
