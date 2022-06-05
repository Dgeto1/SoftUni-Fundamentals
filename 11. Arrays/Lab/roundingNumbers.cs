using System;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] arr = n.Split(" ");
            double[] nums = new double[arr.Length];
            for(int i=0; i<arr.Length;i++)
            {
                nums[i] = double.Parse(arr[i]);
            }
            for(int i=0; i<nums.Length; i++)
            {
                Console.WriteLine($"{Convert.ToDecimal(nums[i])} => {Math.Round(Convert.ToDecimal(nums[i]),MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

