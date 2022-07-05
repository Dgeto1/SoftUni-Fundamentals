using System;
using System.Collections.Generic;

namespace _06_VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string command;
            while((command = Console.ReadLine())!="End")
            {
                string[] segments = command.Split();
                Vehicle vehicle = new Vehicle(segments[0], segments[1], segments[2], int.Parse(segments[3]));
                vehicles.Add(vehicle);
            }
            string secondCommand;
            while((secondCommand=Console.ReadLine())!="Close the Catalogue")
            {
                string carBrand = secondCommand;
                foreach(Vehicle x in vehicles)
                {
                    if(carBrand==x.Model)
                    {
                        Console.WriteLine(x.Print());
                    }
                }
            }
            double averageHPCars = 0, averageHPTrucks = 0;
            int countCars = 0, countTrucks = 0; ;
            foreach(Vehicle x in vehicles)
            {
                if(x.Type=="car")
                {
                    averageHPCars += x.Horsepower;
                    countCars++;
                }
                else
                {
                    averageHPTrucks += x.Horsepower;
                    countTrucks++;
                }
                if(x.Type=="truck")
                {
                    averageHPTrucks += x.Horsepower;
                    countTrucks++;
                }
            }
            averageHPCars /= countCars;
            averageHPTrucks /= countTrucks;
            Console.WriteLine($"Cars have average horsepower of: {averageHPCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHPTrucks:f2}.");
        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }
        public string Print()
        {
            if(this.Type=="car")
            {
                return $"Type: Car\nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.Horsepower}";
            }
            else
            {
                return $"Type: Truck\nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.Horsepower}";
            }
            
        }
    }
}

