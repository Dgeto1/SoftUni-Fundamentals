using System;

namespace MetersToKms
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            string repLetter = letter;
            if(repLetter.ToUpper()==letter)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

