using System;

namespace _04._Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberRectangularTables = int.Parse(Console.ReadLine());

            double tablelenght = double.Parse(Console.ReadLine());

            double tableWidth = double.Parse(Console.ReadLine());

            double areaSheets = numberRectangularTables * (tablelenght + 2 * 0.30) * (tableWidth + 2 * 0.30);
            double tableClothes = numberRectangularTables * (tablelenght / 2) * (tablelenght / 2);

            double priceInUSD = areaSheets * 7 + tableClothes * 9;
            double priceInBGN = priceInUSD * 1.85;
           // Console.WriteLine(areaSheets);
           // Console.WriteLine(tableClothes);
            Console.WriteLine($"{priceInUSD:f2} USD");
            Console.WriteLine($"{priceInBGN:f2} BGN");
        }
    }
}
