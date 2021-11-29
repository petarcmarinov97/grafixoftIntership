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

                int index = IsExisting(students, tokens[0], tokens[1]);
                if (index >= 0)
                {
                    Student student = GetStudent(students,index);
                    student.Age = int.Parse(tokens[2]);
                    student.TownName = tokens[3];
                }
                else
                {
                    Student student = new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);
                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            string searchTown = Console.ReadLine();

            List<Student> filteredStudents = students
                .Where(x => x.TownName == searchTown)
                .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static int IsExisting(List<Student> students, string firstName, string lastName)
        {
            int indexOfStudent = -1;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    indexOfStudent = students.IndexOf(student);
                }
            }

            return indexOfStudent;
        }

        static Student GetStudent(List<Student> students, int index)
        {
            return students[index];
        }
    }

}
