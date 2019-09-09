using System;

namespace _05._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();


            int workOurs = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {workOurs * 3} hours to complete {workOurs} project/s.");
        }
    }
}
