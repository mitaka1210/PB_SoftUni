using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());


            //what does a pastry chef do in a day
            int numberPastryChef = int.Parse(Console.ReadLine());

            int numberCakes = int.Parse(Console.ReadLine());

            int numberCorrugations = int.Parse(Console.ReadLine());

            int numberPancakes = int.Parse(Console.ReadLine());

            int priceCakes = numberCakes * 45;
            double priceCorrugation = numberCorrugations * 5.80;
            double pricePancakes = numberPancakes * 3.20;
            //what does  all a pastry chef do in a day
            double allMoneyForOneDay = (priceCakes + priceCorrugation + pricePancakes) * numberPastryChef;

            double moneyForAllCompany = allMoneyForOneDay * days;

            double coverCosts =moneyForAllCompany - (moneyForAllCompany / 8) ;
            //Console.WriteLine(pricePancakes);
            //Console.WriteLine(priceCorrugation);
            //Console.WriteLine(priceCakes);
            //Console.WriteLine(allMoneyForOneDay);
            //Console.WriteLine(moneyForAllCompany);
            Console.WriteLine($"{coverCosts:f2}");

        }
    }
}
