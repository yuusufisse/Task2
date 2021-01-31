using System;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-EN");
            bool stillMore = false;
            double parkingStart;
            double parkingEnd;
            double parkingCharges;
            double parkingTime;
            do
            {
                Console.Write("Parking start: ");
                string givenValue = Console.ReadLine();
                //Type? 
                while (!Double.TryParse(givenValue, out parkingStart) || parkingStart < 07.00)
                {
                    Console.Write("Wrong type or negative value, try again: ");
                    givenValue = Console.ReadLine();
                }

                Console.Write("Parking end: ");
                givenValue = Console.ReadLine();
                //Type? 
                while (!Double.TryParse(givenValue, out parkingEnd) || parkingEnd > 22.00)
                {
                    Console.Write("Wrong type or negative value, try again: ");
                    givenValue = Console.ReadLine();
                }


                parkingTime = parkingEnd - parkingStart;
                parkingCharges = parkingTime * 1.75;

                Console.WriteLine("Parking time is {0:F2}: ", parkingTime);
                Console.WriteLine("Parking charges are {0:F2} euros.", parkingCharges);

                Console.Write("More values? Y/N: ");
                string yourChoice = Console.ReadLine().ToUpper();
                if (yourChoice.StartsWith("Y"))
                    stillMore = true;
                else
                    stillMore = false;

            } while (stillMore);
        }
    }
}
