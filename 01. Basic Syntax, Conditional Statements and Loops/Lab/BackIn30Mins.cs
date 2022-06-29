using System;

namespace BackIn30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int newMins = hours * 60 + mins + 30;
            int newHours = newMins / 60;
            newMins = newMins % 60;
            if(newHours==24)
            {
                Console.WriteLine($"0:{newMins:d2}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMins:d2}");
            }
        }
    }
}

