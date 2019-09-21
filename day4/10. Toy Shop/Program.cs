using System;

namespace _10._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceExcursion = double.Parse(Console.ReadLine());

            int numberPuzzles = int.Parse(Console.ReadLine());

            int numberTalkingDolls = int.Parse(Console.ReadLine());

            int numberTeddyBears = int.Parse(Console.ReadLine());

            int numberMinions = int.Parse(Console.ReadLine());

            int numberTrucks = int.Parse(Console.ReadLine());


            double summDiscount = 0;

            double allToySumm = (numberMinions * 8.20) + (numberPuzzles * 2.60) + (numberTalkingDolls * 3.00) + (numberTeddyBears * 4.10) + (numberTrucks * 2);

            int numberToy = numberMinions + numberPuzzles + numberTalkingDolls + numberTeddyBears + numberTrucks;

            if (numberToy >= 50)
            {
                double discout = 25 * allToySumm / 100;
                summDiscount = +discout;


            }
            else if (numberToy < 50)
            {
                
                summDiscount = 0;
            }

            double endSumm = allToySumm - summDiscount;
            double rent = 10 * endSumm / 100;
            double profit = endSumm - rent;

            if (profit > priceExcursion)
            {
                double goOrNot = profit - priceExcursion;
                Console.WriteLine($"Yes! {goOrNot:f2} lv left.");
            }
            else if ( profit < priceExcursion)
            {
                double needMore = priceExcursion - profit;
                Console.WriteLine($"Not enough money! {needMore:f2} lv needed.");
            }
            
        }
    }
}
