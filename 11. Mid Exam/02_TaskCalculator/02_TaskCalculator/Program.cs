using System;
using System.Linq;

namespace _02_TaskCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine().Split(">>").ToArray();
            int allPrice = 0;
            for (int i=0; i<vehicles.Length;i++)
            {
                string segments = vehicles[i];
                string[] oneVehicle = segments.Split();
                string vehicle = oneVehicle[0];
                int taxYears = int.Parse(oneVehicle[1]);
                int km = int.Parse(oneVehicle[2]);
                
                if(vehicle=="family")
                {
                    int tax = 50;
                    while (taxYears>0)
                    {
                        tax -= 5;
                        taxYears--;
                        
                    }
                    int finalTax = tax;
                    finalTax += (km / 3000) * 12;
                    allPrice += finalTax;
                    Console.WriteLine($"A {vehicle} car will pay {finalTax:f2} euros in taxes.");
                }
                else if(vehicle=="heavyDuty")
                {
                    int tax = 80;
                    while(taxYears>0)
                    {
                        tax -= 8;
                        taxYears--;
                    }
                    int finalTax = tax;
                    finalTax += (km / 9000) * 14;
                    allPrice += finalTax;
                    Console.WriteLine($"A {vehicle} car will pay {finalTax:f2} euros in taxes.");
                }
                else if (vehicle == "sports")
                {
                    int tax = 100;
                    while (taxYears > 0)
                    {
                        tax -= 9;
                        taxYears--;
                    }
                    int finalTax = tax;
                    finalTax += (km / 2000) * 18;
                    allPrice += finalTax;
                    Console.WriteLine($"A {vehicle} car will pay {finalTax:f2} euros in taxes.");
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }
            }
            Console.WriteLine($"The National Revenue Agency will collect {allPrice:f2} euros in taxes.");
        }
    }
}

