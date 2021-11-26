using System;
using System.Linq;
using System.Collections.Generic;

namespace Students2._0
{
    internal class Start
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                if (IsExisting(students, tokens[0], tokens[1]))
                {
                    Student student = GetStudent(students, tokens[0], tokens[1]);
                    student.FirstName = tokens[0];
                    student.LastName = tokens[1];
                    student.Age = int.Parse(tokens[2]);
                    student.HomeTown = tokens[3];
                }
                else
                {
                    Student student = new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);
                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            string townToSearch = Console.ReadLine();

            List<Student> filteredStudents = students
                .Where(x => x.HomeTown == townToSearch)
                .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static bool IsExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }

}
