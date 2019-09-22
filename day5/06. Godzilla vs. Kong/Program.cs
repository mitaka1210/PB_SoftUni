using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            double budge = double.Parse(Console.ReadLine());

            int numberOfPeople = int.Parse(Console.ReadLine());

            double priceForOneCloting = double.Parse(Console.ReadLine());

            double decor = 10 * budge / 100;

            double priceForAllCloting = numberOfPeople * priceForOneCloting;

            double summForFilm = decor + priceForAllCloting;

            double priceForClotingDiscount = priceForAllCloting * 10 / 100;

            double descount = priceForAllCloting - priceForClotingDiscount;

            double priceWithDescount = descount + decor;

            double endSummWithDescount = budge - priceWithDescount;

            double endSUmm = budge - summForFilm;

            double summ = Math.Abs(endSummWithDescount);
            double summ2 = Math.Abs(endSUmm);


            if (numberOfPeople > 150 && budge > priceWithDescount)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {endSummWithDescount:f2} leva left.");
            }
            else if (numberOfPeople < 150 && budge > summForFilm)
            {


                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {endSUmm:f2} leva left.");

            }
            else if (numberOfPeople > 150 && budge < priceWithDescount)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {summ:f2} leva more.");
            }
            else if (numberOfPeople < 150 && budge < summForFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {summ2:f2} leva more.");
            }
        }

    }
}


