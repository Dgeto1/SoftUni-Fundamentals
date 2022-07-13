using System;

namespace _01_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
           
            while(command != "end")
            {
                char[] symbols = new char[command.Length];
                for(int i=0; i<command.Length; i++)
                {
                    symbols[i] = command[i];
                }
                Array.Reverse(symbols);
                
                Console.WriteLine($"{command} = {string.Join("",symbols)}");
                command = Console.ReadLine();
            }
        }
    }
}

