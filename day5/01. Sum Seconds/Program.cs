using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstMan = int.Parse(Console.ReadLine());

            int secondMan = int.Parse(Console.ReadLine());

            int threeMan = int.Parse(Console.ReadLine());

            int summ = firstMan + secondMan + +threeMan;

            int min = summ / 60;
            
            int sec = summ % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        
        }
    }
}
