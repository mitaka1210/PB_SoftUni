using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double avgSucc = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socScholar = minSalary * 0.35;
            double xlntSucc = avgSucc * 25;

            if (salary >= minSalary)
            {
                if (avgSucc < 5.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (avgSucc >= 5.50)
                {
                    Console.WriteLine("You get a scholarship for excellent results " + Math.Floor(xlntSucc) + " BGN");
                }
            }
            else if (salary < minSalary)
            {
                if (avgSucc < 4.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (avgSucc > 4.50 && avgSucc < 5.50)
                {
                    Console.WriteLine("You get a Social scholarship " + Math.Floor(socScholar) + " BGN");
                }
                else if (avgSucc >= 5.50 && xlntSucc >= socScholar)
                {
                    Console.WriteLine("You get a scholarship for excellent results " + Math.Floor(xlntSucc) + " BGN");
                }
                else if (avgSucc >= 5.50 && xlntSucc < socScholar)
                {
                    Console.WriteLine("You get a Social scholarship " + Math.Floor(socScholar) + " BGN");
                }
            }
        }
    }
}