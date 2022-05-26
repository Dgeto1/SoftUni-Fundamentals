using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            double sum = 0;
            while((command = Console.ReadLine())!="Start")
            {
                if(double.Parse(command)==0.1 || double.Parse(command) == 0.2 || double.Parse(command) == 0.5 || double.Parse(command) == 1 || double.Parse(command) == 2)
                {
                    sum += double.Parse(command);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {command}");
                }
            }
            string output;
            while((output = Console.ReadLine())!="End")
            { 
                if(output=="Nuts")
                {
                    if(sum<2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 2;
                        Console.WriteLine($"Purchased {output.ToLower()}");
                    }
                }
                else if(output=="Water")
                {

                    if (sum < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 0.7;
                        Console.WriteLine($"Purchased {output.ToLower()}");
                    }
                }
                else if(output=="Crisps")
                {
                    if (sum < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 1.5;
                        Console.WriteLine($"Purchased {output.ToLower()}");
                    }
                }
                else if(output=="Soda")
                {
                    if (sum < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 0.8;
                        Console.WriteLine($"Purchased {output.ToLower()}");
                    }
                }
                else if(output=="Coke")
                {
                    if (sum < 1)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 1;
                        Console.WriteLine($"Purchased {output.ToLower()}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }      
            }
            if(output=="End")
            {
                Console.WriteLine($"Change: {sum:f2}");
            }
        }
    }
}

