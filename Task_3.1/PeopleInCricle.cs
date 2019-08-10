using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._1
{
    class PeopleInCircle
    {
        public List<int> people = new List<int> { };

        public List<int> FillCircleByPeopleID(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                people.Add(i);
            }
            return people;
        }
        public List<int> ReduceCircleByEvenNumber(List<int> people)
        {
            while (people.Count > 1)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        people.RemoveAt(i);
                    }
                }
            }
            return people;
        }
    }
}
