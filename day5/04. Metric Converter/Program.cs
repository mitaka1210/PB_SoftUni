using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());

            string metricToEntrance = Console.ReadLine();

            string metricToExit = Console.ReadLine();

            if (metricToEntrance == "cm" && metricToExit == "mm")
            {
                double convert = number * 10;
                Console.WriteLine($"{convert:f3}");
            }
            else if (metricToEntrance == "cm" && metricToExit == "m")
            {
                double convert = number * 0.01;
                Console.WriteLine($"{convert:f3}");
            }
            else if (metricToEntrance == "m" && metricToExit == "cm")
            {
                double convert = number * 100;
                Console.WriteLine($"{convert:f3}");
            }
            else if (metricToEntrance == "m" && metricToExit == "mm")
            {
                double convert = number * 1000;
                Console.WriteLine($"{convert:f3}");
            }
            else if (metricToEntrance == "mm" && metricToExit == "cm")
            {
                double convert = number * 0.1;
                Console.WriteLine($"{convert:f3}");
            }
            else if (metricToEntrance == "mm" && metricToExit == "m")
            {
                double convert = number * 0.001;
                Console.WriteLine($"{convert:f3}");
            }
        }
    }
}
