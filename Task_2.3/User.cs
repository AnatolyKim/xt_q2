using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._3
{
    public class User
    {
        // Объявление основных переменных
        private string name;
        private string surName;
        private string patronymic;
        private int birthYear;
        private int birthMonth;
        private int birthDay;
        private DateTime birthDate;
        private int age;
        // Установка даты рождения в корректном состоянии
        public User()
        {
            birthYear = 1;
            birthMonth = 1;
            birthDay = 1;
        }
        // Объявление свойств с проверкой на допустимые значения
        public string Name
        {
            get { return name;}
            set
            {
                char[] forcheck=value.ToCharArray();
                for (int i = 0; i < forcheck.Length; i++)
                {
                    if (char.IsLetter(forcheck[i])!=true)
                    {
                        throw new ArgumentException("Name can inculde only letters"); ;
                    }
                }
                name = value;
            }
        }

        public string Surname
        {
            get { return surName; }
            set
            {
                char[] forcheck = value.ToCharArray();
                for (int i = 0; i < forcheck.Length; i++)
                {
                    if (char.IsLetter(forcheck[i]) != true)
                    {
                        throw new ArgumentException("Surname can inculde only letters"); ;
                    }
                }
                surName = value;
            }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                char[] forcheck = value.ToCharArray();
                for (int i = 0; i < forcheck.Length; i++)
                {
                    if (char.IsLetter(forcheck[i]) != true)
                    {
                        throw new ArgumentException("Surname can inculde only letters"); ;
                    }
                }
                patronymic = value;
            }
        }
        public int BirthYear
        {
            get { return birthYear; }
            set
            {
                if (value > 1 && value < 10000)
                {
                    birthYear = value;
                }
                else throw new ArgumentException("Input correct year");
            }
        }
        public int BirthMonth
        {
            get { return birthMonth; }
            set
            {
                if (value > 0 && value < 13)
                {
                    birthMonth = value;
                }
                else throw new ArgumentException("Input correct month");
            }
        }
        public int BirthDay
        {
            get { return birthDay; }
            set
            {
                if (value > 0 && value < 32)
                {
                    birthDay = value;
                }
                else throw new ArgumentException("Input correct day");
            }
        }
        public DateTime BirthDate
        {
            get { return birthDate = new DateTime(birthYear, birthMonth, birthDay); }
        }
        public int Age
        {
            get // Вычисление возраста исходя из текущей даты
            {
                var today = DateTime.Today;
                age = today.Year - birthDate.Year;
                if (birthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
