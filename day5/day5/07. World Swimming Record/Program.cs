using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {

            double recordSec = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSec = double.Parse(Console.ReadLine());
            double distanceSec = distanceMeters * timeSec;
            double bonusTime = Math.Floor(distanceMeters / 15) * 12.5; //Math.Floor(distanceMeters / 15 * 12.5)
            double allTime = distanceSec + bonusTime;
            if (recordSec > allTime)
            {
                double needTime = distanceSec + bonusTime;
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", needTime); // ("Yes, he succeeded! The new world record is {0:F2} seconds.", Math.Floor(needTime))
            }
            else
            {
                double left = Math.Abs(allTime - recordSec);
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", left);
            }
        }
    }
}
