using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            if (number <= 100 && number % 2 == 0)
            {
                double bonus = 5 + 1;
                double summ = number + 5 + 1;
                Console.WriteLine(bonus);
                Console.WriteLine(summ);
            }
            else if (number <= 100 && number % 10 == 5)
            {
                double bonus = 5 + 2;
                double summ = number + bonus;
                Console.WriteLine(bonus);
                Console.WriteLine(summ);

            }
            else if (number > 100 && number < 1000 &&  number % 2 == 0)
            {
                double bonus = (number * 20.0 / 100.0) + 1;
                double summ = number + bonus;
                Console.WriteLine(bonus);
                Console.WriteLine(summ);

            }
            else if (number > 100 && number < 1000 && number % 10 == 5)
            {
                double bonus = (number * 20 / 100) + 2;
                double summ = number + bonus;
                Console.WriteLine(bonus);
                Console.WriteLine(summ);

            }
            else if (number > 1000 && number % 2 == 0)
            {
                double bonus = (number * 10 / 100) + 1;
                double summ = number + bonus;
                Console.WriteLine(bonus);
                Console.WriteLine(summ);
            }
            else if (number > 1000 && number % 10 == 5)
            {
                double bonus = (number * 10.0 / 100.0) + 2;
                double summ = number + bonus;
                Console.WriteLine(bonus);
                Console.WriteLine(summ);
            }
            else if (number <= 100)
            {
                double bonus = 5;
                double summ = number + bonus;
                Console.WriteLine(bonus);
                Console.WriteLine(summ);
            }
            else if (number > 100 && number < 1000)
            {
                double bonus = (number * 20.0) / 100.0;
                double summ = number + bonus;
                Console.WriteLine(bonus);
                Console.WriteLine(summ);
            }
            else if (number > 1000)
            {
                double bonus = number * 10.0 / 100.0;
                double summ = number + bonus;
                Console.WriteLine($"{bonus}");
                Console.WriteLine($"{summ}");
            }
        }
    }
}
