using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Users.Entities
{
    public class User
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public int Age { get; private set; }

        public string ErrorMessage { get; private set; }

        public bool SetName(string input)
        {
            char[] nameChars=input.ToCharArray();
            foreach(char s in nameChars)
            {
                if (char.IsLetter(s) == false)
                {
                    ErrorMessage = "Input correct name";
                    return false;
                }
                
            }
            Name = input;
            return true;
        }

        public bool SetBirthDate(string input)
        {
            try
            {
                BirthDate=DateTime.ParseExact(input, "dd.MM.yyyy",CultureInfo.InvariantCulture);
                return true;

            }
            catch(FormatException)
            {
                ErrorMessage = "Input date correctly";
                return false;
            }
        }

        public void SetAge(DateTime BirthDate)
        {
            var today = DateTime.Today;
            Age = today.Year - BirthDate.Year;
            if(BirthDate.Date > today.AddYears(-Age))Age--;
        }
    }
}
