using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int count = int.Parse(Console.ReadLine());
            for(int i=1; i<=count;i++)
            {
                string[] segments = Console.ReadLine().Split();
                Student student = new Student(segments[0], segments[1], double.Parse(segments[2]));
                students.Add(student);
            }
            List<Student> sortedStudents = students.OrderByDescending(x => x.Grade).ToList();
            foreach(Student x in sortedStudents)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}

