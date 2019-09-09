using System;

namespace _07._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            int dogs = int.Parse(Console.ReadLine());

            int otherAnimals = int.Parse(Console.ReadLine());
            double summ = (dogs * 2.50) + (otherAnimals * 4);

            Console.WriteLine($"{summ:f2} lv.");

        }
    }
}
