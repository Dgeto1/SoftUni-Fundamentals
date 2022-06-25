using System;
using System.Linq;

namespace _02_theLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentWagon = 0;
            bool isTrue = false;
            for (int i = 0; i < wagons.Length; i++)
            {
                while (wagons[i] < 4)
                {
                    waitingPeople--;
                    wagons[i]++;
                    if (waitingPeople == 0 && wagons[i]<4)
                    {
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(String.Join(" ", wagons));
                        isTrue = true;
                        break;
                    }
                }
                currentWagon++;
                if (currentWagon == wagons.Length && waitingPeople > 0)
                {
                    Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                    Console.WriteLine(String.Join(" ", wagons));
                    break;
                }
                if (currentWagon == wagons.Length && waitingPeople == 0 && !isTrue)
                {
                    Console.WriteLine(String.Join(" ", wagons));
                    break;
                }
            }
        }
    }
}