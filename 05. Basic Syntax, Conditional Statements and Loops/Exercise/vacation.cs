using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            switch (day)
            {
                case "Friday":
                    if(typeGroup=="Students")
                    {
                        if(numberPeople>=30)
                        {
                            double finalSum = 8.45 * numberPeople - 0.15 * (8.45 * numberPeople);
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                        else
                        {
                            double finalSum = 8.45 * numberPeople;
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                    }
                    else if(typeGroup=="Business")
                    {
                        if(numberPeople>=100)
                        {
                            double finalSum = 10.9 * (numberPeople - 10);
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                        else
                        {
                            double finalSum = 10.9 * numberPeople;
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                    }
                    else
                    {
                        if(numberPeople>=10 && numberPeople<=20)
                        {
                            double finalSum = 15 * numberPeople - 0.05 * (15 * numberPeople);
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                        else
                        {
                            double finalSum = 15 * numberPeople;
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                    }
                    break;
                case "Saturday":
                    if (typeGroup == "Students")
                    {
                        if (numberPeople >= 30)
                        {
                            double finalSum = 9.8 * numberPeople - 0.15 * (9.8 * numberPeople);
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                        else
                        {
                            double finalSum = 9.8 * numberPeople;
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                    }
                    else if (typeGroup == "Business")
                    {
                        if (numberPeople >= 100)
                        {
                            double finalSum = 15.6 * (numberPeople - 10);
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                        else
                        {
                            double finalSum = 15.6 * numberPeople;
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                    }
                    else
                    {
                        if (numberPeople >= 10 && numberPeople <= 20)
                        {
                            double finalSum = 20 * numberPeople - 0.05 * (20 * numberPeople);
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                        else
                        {
                            double finalSum = 20 * numberPeople;
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                    }
                    break;
                case "Sunday":
                    if (typeGroup == "Students")
                    {
                        if (numberPeople >= 30)
                        {
                            double finalSum = 10.46 * numberPeople - 0.15 * (10.46 * numberPeople);
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                        else
                        {
                            double finalSum = 10.46 * numberPeople;
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                    }
                    else if (typeGroup == "Business")
                    {
                        if (numberPeople >= 100)
                        {
                            double finalSum = 16 * (numberPeople - 10);
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                        else
                        {
                            double finalSum = 16 * numberPeople;
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                    }
                    else
                    {
                        if (numberPeople >= 10 && numberPeople <= 20)
                        {
                            double finalSum = 22.5 * numberPeople - 0.05 * (22.5 * numberPeople);
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                        else
                        {
                            double finalSum = 22.5 * numberPeople;
                            Console.WriteLine($"Total price: {finalSum:f2}");
                        }
                    }
                    break;
            }
        }
    }
}

