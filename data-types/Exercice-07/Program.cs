/*
Write a C# Sharp program that takes distance and time as input and displays
    the speed in kilometers per hour and miles per hour
*/
using System;
using System.Collections.Generic;

namespace Exercice_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Takes distance and time as input and displays
the speed in kilometers per hour and miles per hour");

            int distance = GetNumber($"{"Input distance(meters): ",-24}");
            int hour = GetNumber($"{"Input timeSec(hour): ",-24}");
            int min = GetNumber($"{"Input timeSec(minutes): ",-24}");
            int sec = GetNumber($"{"Input timeSec(seconds): ",-24}");

            DisplaySpeed(distance, hour, min, sec);
        }

        static int GetNumber(string msg)
        {
            int userInput;            

            do
            {
                Console.Write(msg);
            } while (!Int32.TryParse(Console.ReadLine(),out userInput));

            return userInput;
        }

        static void DisplaySpeed(int distance, int hour, int min, int sec)
        {
            double totalSec = Convert.ToDouble((hour*3600) + (min*60) + sec);
            double meterSec = distance/totalSec;
            double kmH = (meterSec*3600)/1000;
            double milesH = kmH*0.62;
            
            Console.WriteLine();
            Console.WriteLine($"{"Your speed in meters/sec is ",-28}{meterSec,5:##.##}");
            Console.WriteLine($"{"Your speed in km/h is ",-28}{kmH,5:##.##}");
            Console.WriteLine($"{"Your speed in miles/h is ",-28}{milesH,5:##.##}");
        }
    }
}
