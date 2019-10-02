using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Търговски_комисионни
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            double result = 0;
            double comission = 0.0;
            if (city == "Sofia")
            {
                if (number >= 0 && number <= 500)
                {
                    comission = 5 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else if (number >= 500 && number <= 1000)
                {
                    comission = 7 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else if (number >= 1000 && number <= 10000)
                {
                    comission = 8 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else if (number >= 10000)

                {

                    comission = 12 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");

                }
                else
                {
                    Console.WriteLine("error");
                }


            }
            else if (city == "Varna")
            {
                if (number >= 0 && number <= 500)
                {
                    comission = 4.5 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else if (number >= 500 && number <= 1000)
                {
                    comission = 7.5 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else if (number >= 1000 && number <= 10000)
                {
                    comission = 10 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else if (number >= 10000)
                {
                    comission = 13 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }


            }
            else if (city == "Plovdiv")
            {
                if (number >= 0 && number <= 500)
                {
                    comission = 5.5 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else if (number >= 500 && number <= 1000)
                {
                    comission = 8 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else if (number >= 1000 && number <= 10000)
                {
                    comission = 12 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                else if (number >= 10000)
                {
                    comission = 14.5 / 100.00;
                    result = comission * number;
                    Console.WriteLine($"{result:f2}");
                }
                
                
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
