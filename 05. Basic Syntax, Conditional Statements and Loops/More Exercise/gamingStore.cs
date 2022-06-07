using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double balance = currentBalance;
            string gameName = string.Empty;
            while((gameName = Console.ReadLine())!="Game Time")
            {
                
                if(gameName=="OutFall 4")
                {
                    if(currentBalance<39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "CS: OG")
                {
                    if (currentBalance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 15.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    if (currentBalance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 19.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "Honored 2")
                {
                    if (currentBalance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 59.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    if (currentBalance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 29.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${balance-currentBalance:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}

