using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {

            double excellent = double.Parse(Console.ReadLine());

            if (excellent >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else  
            {
                Console.WriteLine();
            }
        }
    }
}
