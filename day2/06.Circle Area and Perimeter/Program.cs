using System;

namespace _06.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(radius, 2);
            double circlePerimeter = 2 * Math.PI * radius;
            Console.WriteLine($"{circleArea:F2}");
            Console.WriteLine($"{circlePerimeter:f2}");

        }
    }
}
