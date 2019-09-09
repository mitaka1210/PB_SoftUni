using System;

namespace _08._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {


            int greenAreas = int.Parse(Console.ReadLine());

            double totalPrice = greenAreas * 7.61;
            double discount = 0.18 * totalPrice;
            double finalPrice = totalPrice - discount;

            Console.WriteLine($"The final price is: {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
