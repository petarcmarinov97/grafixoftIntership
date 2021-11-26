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

                Student student = new Student()
                {
                    FirstName = tokens[0],
                    LastName = tokens[1],
                    Age = int.Parse(tokens[2]),
                    HomeTown = tokens[3]
                };
                students.Add(student);

                input = Console.ReadLine();
            }

            string townToSearch = Console.ReadLine();

            List<Student> filteredStudents = students
                .Where(x => x.HomeTown == townToSearch)
                .ToList();

            foreach(Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string HomeTown;
    }
}
