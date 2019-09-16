using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            if (name == "square")
            {


                double number = double.Parse(Console.ReadLine());
                double area = number * number;
                Console.WriteLine($"{area:f3}");
            }

            else if (name == "rectangle")
            {

                double sideA = double.Parse(Console.ReadLine());

                double sideB = double.Parse(Console.ReadLine());

                double area = sideA * sideB;
                Console.WriteLine($"{area:f3}");
            }
            else if (name == "circle")
            {


                double number = double.Parse(Console.ReadLine());
                double faceOfCircle = Math.PI * (number * number);
                Console.WriteLine($"{faceOfCircle:f3}");
            }
            else if (name == "triangle")
            {

                double sideA = double.Parse(Console.ReadLine());

                double height = double.Parse(Console.ReadLine());

                double faceOfTriangle = sideA * height * 0.5;
                Console.WriteLine($"{faceOfTriangle:f3}");

            }
        }
    }
}
