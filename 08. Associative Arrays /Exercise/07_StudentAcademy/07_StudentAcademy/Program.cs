using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            Dictionary<string, double> studentsGrades = new Dictionary<string, double>();
            for(int i=1; i<=count; i++)
            {
                string nameStudent = Console.ReadLine();
                double gradeStudent = double.Parse(Console.ReadLine());
                if(studentsGrades.ContainsKey(nameStudent))
                {
                    double averageGrade = gradeStudent + studentsGrades[nameStudent];
                    studentsGrades[nameStudent] = averageGrade / 2;
                }
                else
                {
                    studentsGrades.Add(nameStudent, gradeStudent);
                }
            }
            studentsGrades = studentsGrades.Where(x => x.Value >= 4.5).ToDictionary(x=>x.Key, x=>x.Value);
            foreach(var x in studentsGrades)
            {
                Console.WriteLine($"{x.Key} -> {x.Value:f2}");
            }
        }
    }
}

