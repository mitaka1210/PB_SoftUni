using System;

namespace _07._Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceWisky = double.Parse(Console.ReadLine());

            double quantityBeer = double.Parse(Console.ReadLine());

            double quantityWine = double.Parse(Console.ReadLine());

            double quantityRakiq = double.Parse(Console.ReadLine());

            double quantityWisky = double.Parse(Console.ReadLine());

            double priceRakiq = priceWisky / 2;
            double priceWine = priceRakiq - (0.4 * priceRakiq);
            double priceBeer = priceRakiq - (0.8 * priceRakiq);
            double sumRakiq = quantityRakiq * priceRakiq;
            double sumWine = quantityWine * priceWine;
            double sumBeer = quantityBeer * priceBeer;
            double sumWisky = quantityWisky * priceWisky;
            double allSUm = sumBeer + sumRakiq + sumWine + sumWisky;
            Console.WriteLine($"{allSUm:f2}");
        }
    }
}
