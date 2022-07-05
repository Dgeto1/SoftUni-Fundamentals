using System;
using System.Collections.Generic;

namespace _06_StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = Console.ReadLine();
            while(command!="end")
            {
                string[] segments = command.Split();
                Box box = new Box(segments[0], segments[1], int.Parse(segments[2]), double.Parse(segments[3], segments[2] * segments[3]);
                boxes.Add(box);
                command = Console.ReadLine();
            }
        }
    }
    class Item
    {
        public string  Name { get; set; }
        public double Price { get; set; }
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double ItemPrice { get; set; }
        public double BoxPrice { get; set; }
        public Box(string serialNumber, string item, int itemQuantity, double itemPrice, double boxPrice)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
            this.ItemPrice = itemPrice;
            this.BoxPrice = itemQuantity * itemPrice;
        }
    }
}

