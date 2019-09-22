using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int sum = (hour * 60) + min + 15;
            double resulthour = sum / 60;
            if (resulthour >= 24)
            {
                resulthour -= 24;
            }
            double resultmin = sum % 60;

            Console.WriteLine("{0}:{1:00}", resulthour, resultmin);
            
        }

    }
}

