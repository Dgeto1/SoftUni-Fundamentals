using System;
using System.Collections.Generic;

namespace _06_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> coursesStudentsCount = new Dictionary<string, int>();
            Dictionary<string, string> coursesStudents = new Dictionary<string, string>();
            char[] chars = { ' ', ':', ' ' };
            string command;
            while((command=Console.ReadLine())!="end")
            {
                string[] segments = Console.ReadLine().Split(chars);
                string courseName = segments[0];
                string student = segments[1];
                if(!coursesStudentsCount.ContainsKey(courseName))
                {
                    coursesStudentsCount[courseName]++;
                    coursesStudents[courseName] = student; 
                }
                else
                {
                    coursesStudentsCount[courseName]++;
                    coursesStudents[courseName] = student;
                }
            }
            foreach(var x in coursesStudentsCount)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            foreach(var x in coursesStudents)
            {
                Console.WriteLine($"-- {x.Value}");
            }
        }
    }
}

