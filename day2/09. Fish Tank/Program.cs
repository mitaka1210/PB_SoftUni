using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());

            int width = int.Parse(Console.ReadLine());

            int height = int.Parse(Console.ReadLine());

            double procent = double.Parse(Console.ReadLine());

            double aquariumSize = length * width * height;

            double totalLiters = aquariumSize * 0.001;

            double procentInaquaraium = procent * 0.01;

            double realLitter = totalLiters * (1 - procentInaquaraium);
            Console.WriteLine($"{realLitter:f3}");

        }
    }
}
