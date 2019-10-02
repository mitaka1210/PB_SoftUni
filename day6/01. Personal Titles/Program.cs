using System;

namespace _01._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());

            string name = Console.ReadLine();

            if (number < 16 && name == "m")
            {
                Console.WriteLine("Master");
            }
            else if (number < 16 && name == "f")
            {
                Console.WriteLine("Miss");
            }
            else if (number >= 16 && name == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (number >= 16 && name == "f")
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
