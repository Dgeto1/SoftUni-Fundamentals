using System;

namespace longerLine
{
    class Program
    {
        static string LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstPoint = Math.Abs(x1) + Math.Abs(y1);
            double secondPoint = Math.Abs(x2) + Math.Abs(y2);
            double thirdPoint = Math.Abs(x3) + Math.Abs(y3);
            double fourthPoint = Math.Abs(x4) + Math.Abs(y4);
            double[] x = { x1, x2, x3, x4 };
            double[] y = { y1, y2, y3, y4 };
            double[] points = { firstPoint,secondPoint,thirdPoint,fourthPoint};
            double sum = double.MinValue;
            string output = string.Empty;
            for(int i=0; i<3;i++)
            {
                if(points[i]+points[i+1]>sum)
                {
                    sum = points[i] + points[i + 1];
                    output = $"({x[i]}, {y[i]})({x[i + 1]}, {y[i + 1]})";
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            Console.WriteLine(LongerLine(x1,y1,x2,y2,x3,y3,x4,y4));
        }
    }
}

