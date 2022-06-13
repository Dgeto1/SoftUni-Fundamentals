using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if(command=="int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number*2);
            }
            else if(command=="real")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{number*1.5:f2}");
            }
            else
            {
                string st = Console.ReadLine();
                Console.WriteLine($"${st}$");
            }
        }
    }
}

