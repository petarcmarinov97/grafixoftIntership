using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                Student student = new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);
                students.Add(student);

                input = Console.ReadLine();
            }

            string townToSearch = Console.ReadLine();

            List<Student> filteredStudents = students
                .Where(x => x.TownName == townToSearch)
                .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

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

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string TownName { get; private set; }
    }
}
