using System;

namespace elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevator = int.Parse(Console.ReadLine());
            int countCourses = 0;
            while (people > 0)
            {
                people -= elevator;
                countCourses++;
            }
            Console.WriteLine(countCourses);
        }
    }
}

