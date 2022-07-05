using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            string command = Console.ReadLine();

            while(command!="end")
            {
                string[] segments = command.Split("/");
                if (segments[0]=="Truck")
                {
                    Truck truck = new Truck(segments[1], segments[2], int.Parse(segments[3]));
                    trucks.Add(truck);
                }
                else
                {
                    Car car = new Car(segments[1], segments[2], int.Parse(segments[3]));
                    cars.Add(car);   
                }
                command = Console.ReadLine();
            }
            var sortedCars = cars.OrderBy(x => x.Brand);
            var sortderTrucks = trucks.OrderBy(y => y.Brand);
            Console.WriteLine("Cars:");
            foreach (Car x in sortedCars)
            { 
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("Trucks:");
            foreach (Truck x in sortderTrucks)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public override string ToString()
        {
            return $"{this.Brand}: {this.Model} - {this.Weight}kg";
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public override string ToString()
        {
            return $"{this.Brand}: {this.Model} - {this.HorsePower}hp";
        }
    }
    class Catalogue
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
        public Catalogue(List<Truck> trucks, List<Car> cars)
        {
            this.Trucks = trucks;
            this.Cars = cars;
        }
    }
}

