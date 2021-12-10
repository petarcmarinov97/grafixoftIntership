using System;
using System.Linq;
using System.Collections.Generic;

namespace Students2._0
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string homeTown;

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.TownName = homeTown;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Invalid first name!");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Invalid last name!");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid age input");
                }
                age = value;
            }
        }
        public string TownName
        {
            get => homeTown;
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Invalid home town name!");
                }
                homeTown = value;
            }
        }
        private bool IsValidName(string name)
        {
            bool isValid = name.Length >= 2 && name.Length <= 15;
            foreach (char c in name)
            {
                if (!Char.IsLetter(c))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }
    }
}
