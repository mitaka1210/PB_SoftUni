using System;

namespace _08._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());


            string room = Console.ReadLine();


            string services = Console.ReadLine();

            if (room == "room for one person" && services == "positive")
            {
                double price = ((days - 1) * 18.00 * 25 / 100) + (days - 1) * 18.00;
                Console.WriteLine($"{price:f2}");
            }
            else if (room == "room for one person" && services == "negative")
            {
                double price = ((days - 1) * 18.00 * 10 / 100) + (days - 1) * 18.00;
                Console.WriteLine($"{price:f2}");
            }

            if (room == "apartment")
            {
                if (days < 10 && services == "positive")
                {
                    double priceForAlldays = (days - 1) * 25;
                    double priceWithDiscount = priceForAlldays - (priceForAlldays * 30 / 100);

                    double total = (priceWithDiscount * 25 / 100) + priceWithDiscount;
                    Console.WriteLine($"{total:f2}");
                }

                else if (room == "apartment")
                {
                    if (days < 10 && services == "negative")
                    {

                        double priceForAlldays = (days - 1) * 25;
                        double priceWithDiscount = priceForAlldays - (priceForAlldays * 30 / 100);

                        double total = (priceWithDiscount * 10 / 100) + priceWithDiscount;
                        Console.WriteLine($"{total:f2}");
                    }
                }

                if (room == "apartment")
                {
                    if (days > 10 && services == "positive")
                    {
                        if (days < 15)
                        {
                            double priceForAlldays = (days - 1) * 25;
                            double priceWithDiscount = priceForAlldays - (priceForAlldays * 35 / 100);

                            double total = (priceWithDiscount * 25 / 100) + priceWithDiscount;
                            Console.WriteLine($"{total:f2}");
                        }
                    }
                }
                else if (room == "apartment")
                {
                    if (days > 10 && services == "negative")
                    {
                        if (days < 15)
                        {
                            double priceForAlldays = (days - 1) * 25;
                            double priceWithDiscount = priceForAlldays - (priceForAlldays * 35 / 100);

                            double total = (priceWithDiscount * 10 / 100) + priceWithDiscount;
                            Console.WriteLine($"{total:f2}");
                        }
                    }
                }
                if (room == "apartment")
                {
                    if (days > 15 && services == "positive")

                    {
                        double priceForAlldays = (days - 1) * 25;
                        double priceWithDiscount = priceForAlldays - (priceForAlldays * 50 / 100);

                        double total = (priceWithDiscount * 25 / 100) + priceWithDiscount;
                        Console.WriteLine($"{total:f2}");
                    }

                    else if (days > 15 && services == "negative")
                    {
                        double priceForAlldays = (days - 1) * 25;
                        double priceWithDiscount = priceForAlldays - (priceForAlldays * 50 / 100);

                        double total = (priceWithDiscount * 10 / 100) + priceWithDiscount;
                        Console.WriteLine($"{total:f2}");
                    }
                }

            }

            if (room == "president apartment")
            {
                if (days < 10 && services == "positive")
                {
                    double priceForAlldays = (days - 1) * 35;
                    double priceWithDiscount = priceForAlldays - (priceForAlldays * 10 / 100);

                    double total = (priceWithDiscount * 25 / 100) + priceWithDiscount;
                    Console.WriteLine($"{total:f2}");
                }

                else if (room == "president apartment")
                {
                    if (days < 10 && services == "negative")
                    {

                        double priceForAlldays = (days - 1) * 35;
                        double priceWithDiscount = priceForAlldays - (priceForAlldays * 10 / 100);

                        double total = (priceWithDiscount * 10 / 100) + priceWithDiscount;
                        Console.WriteLine($"{total:f2}");
                    }
                }

                if (room == "president apartment")
                {
                    if (days > 10 && services == "positive")
                    {
                        if (days < 15)
                        {
                            double priceForAlldays = (days - 1) * 35;
                            double priceWithDiscount = priceForAlldays - (priceForAlldays * 15 / 100);

                            double total = (priceWithDiscount * 25 / 100) + priceWithDiscount;
                            Console.WriteLine($"{total:f2}");
                        }
                    }
                }
                else if (room == "president apartment")
                {
                    if (days > 10 && services == "negative")
                    {
                        if (days < 15)
                        {
                            double priceForAlldays = (days - 1) * 35;
                            double priceWithDiscount = priceForAlldays - (priceForAlldays * 15 / 100);

                            double total = (priceWithDiscount * 10 / 100) + priceWithDiscount;
                            Console.WriteLine($"{total:f2}");
                        }
                    }
                }
                if (room == "president apartment")
                {
                    if (days > 15 && services == "positive")

                    {
                        double priceForAlldays = (days - 1) * 35;
                        double priceWithDiscount = priceForAlldays - (priceForAlldays * 20 / 100);

                        double total = (priceWithDiscount * 25 / 100) + priceWithDiscount;
                        Console.WriteLine($"{total:f2}");
                    }

                    else if (days > 15 && services == "negative")
                    {
                        double priceForAlldays = (days - 1) * 35;
                        double priceWithDiscount = priceForAlldays - (priceForAlldays * 20 / 100);

                        double total = priceWithDiscount - (priceWithDiscount * 10 / 100);
                        Console.WriteLine($"{total:f2}");
                    }
                }

            }

        }
    }
}


