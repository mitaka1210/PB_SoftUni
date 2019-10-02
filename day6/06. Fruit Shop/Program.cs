using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var dayofWeek = Console.ReadLine();
            var qantity = double.Parse(Console.ReadLine());

            var price = 0.0;

            if (dayofWeek == "Saturday" || dayofWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70;
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                }
            }
            else if (dayofWeek == "Monday" || dayofWeek == "Tuesday" || dayofWeek == "Wednesday" || dayofWeek == "Thursday" || dayofWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50;
                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                }
            }
            if (price > 0)
            {
                Console.WriteLine("{0:F2}", price * qantity);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
