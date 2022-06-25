using System;

namespace _01_CompStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            double price = 0, taxes = 0, totalPrice = 0;
            while((command=Console.ReadLine())!="special"||command!="regular")
            {
                double partPrice = double.Parse(command);
                
                if (partPrice <= 0)
                {
                    Console.WriteLine("Invalid price");
                }
                else
                {
                    price += partPrice;
                    taxes += 0.2 * partPrice;
                    totalPrice += partPrice + taxes;
                }
            }
            if(command=="special")
            {
                totalPrice -= totalPrice * 0.1; 
            }
            if(totalPrice==0)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {price:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}

