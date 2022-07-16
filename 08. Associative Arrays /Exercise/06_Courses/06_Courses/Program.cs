using System;
using System.Collections.Generic;

namespace _06_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> coursesStudents = new Dictionary<string, string>();
            Dictionary<string, int> coursesStudentsCount = new Dictionary<string, int>();
            string command;
            while((command = Console.ReadLine())!="end")
            {
                string[] segments = command.Split(" : ");
                string courseName = segments[0];
                string studentName = segments[1];
                foreach(var x in coursesStudents)
                {
                    if(x.Key!=courseName)
                    {
                        coursesStudents.Add(courseName, studentName);
                    }
                    else
                    {
                        coursesStudents[courseName] = studentName;
                    }
                }
            }
            foreach(var x in courses)
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }
        }
    }
}

