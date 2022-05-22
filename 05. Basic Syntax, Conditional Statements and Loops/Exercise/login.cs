using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] password = new char[username.Length];
            bool isBlocked = false;
            for(int i=0; i<username.Length;i++)
            {
                password[i] = username[i];
            }
            Array.Reverse(password);
            string pass = "";
            for(int i=0; i<password.Length;i++)
            {
                pass += password[i];
            }
            string entry;
            int counter = 0;
            while((entry=Console.ReadLine())!=pass)
            {
                counter++;
                if (counter == 4 && entry != pass)
                {
                    Console.WriteLine($"User {username} blocked!");
                    isBlocked = true;
                    break;
                }
                if (entry!=pass)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if(!isBlocked)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}

