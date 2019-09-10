using System;

namespace _01._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {

            double valute = double.Parse(Console.ReadLine());

            double convert = valute * 1.79549;

            Console.WriteLine($"{convert:f2}");
        }
    }
}
