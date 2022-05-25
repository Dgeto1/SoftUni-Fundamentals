using System;

namespace MetersToKms
{
    class Program
    {
        static void Main(string[] args)
        {
            int centure = int.Parse(Console.ReadLine());
            int years = centure * 100;
            int days = (int)(years * 365.2422);
            int hours = (int)days * 24;
            int mins = hours * 60;
            Console.WriteLine($"{centure} centuries = {years} years = {days} days = {hours} hours = {mins} minutes");
        }
    }
}

