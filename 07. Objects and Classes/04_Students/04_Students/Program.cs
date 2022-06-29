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
            string command = Console.ReadLine();
            while(command!="end")
            {
                string[] std = command.Split();

                Student student = new Student(std[0], std[1], int.Parse(std[2]), std[3]);
                students.Add(student);
                
                command = Console.ReadLine();
            }
            for(int i=0; i<students.Count;i++)
            {
                for(int j=1; j<students.Count;j++)
                {
                    if (students[i].FirstName == students[j].FirstName && students[i].LastName == students[j].LastName)
                    {
                        students.Remove(students[i]);
                    }
                }
            }
            string city = Console.ReadLine();

            foreach(Student x in students)
            {
                if (x.HomeTown == city)
                {
                    Console.WriteLine(x.ToString());
                }
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}

