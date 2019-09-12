using System;

namespace _05._Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {

            double length = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());

            double sideWardrobe = double.Parse(Console.ReadLine());

            double areaHall = (length * 100) * (width * 100);

            double sizeWardrobe = (sideWardrobe * 100) * (sideWardrobe * 100);

            double benchSize = areaHall / 10;

            double freeSpace = areaHall - sizeWardrobe - benchSize;

            double dancerNumber = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(dancerNumber));
        }
    }
}
