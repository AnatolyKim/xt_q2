using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._5
{
    public class Employee : User
    {
        private int experience;
        private string position;

        public Employee()
        {
            experience = 0;
        }

        public int Experience
        {
            get { return experience; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Experience can not be negative, in numerical point of view of course :)");
                }
                else experience = value;
            }
        }

        public string Position
        {
            get { return position; }
            set
            {
                char[] forcheck = value.ToCharArray();
                for (int i = 0; i < forcheck.Length; i++)
                {
                    if (char.IsLetter(forcheck[i])!=true)
                    {
                        throw new ArgumentException("Position name can inculde only letters"); ;
                    }
                }
                position = value;
            }
        }

    }
}
