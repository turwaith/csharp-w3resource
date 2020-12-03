/*
Write a C# Sharp program to check two given integers and return the value
    whichever value is nearest to 13 without going over.
Return 0 if both numbers go over
*/
using System;

namespace Exercice_58
{
    class Program
    {
        public static int GetNearest(int a,int b)
        {
            if(a > 13 && b > 13) return 0;
            else return Math.Abs(13 - a) <= Math.Abs(13 - b) ? a : b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check two given integers and return the value
    whichever value is nearest to 13 without going over.
Return 0 if both numbers go over");

            Console.WriteLine(GetNearest(4,5));
            Console.WriteLine(GetNearest(7,12));
            Console.WriteLine(GetNearest(10,13));
            Console.WriteLine(GetNearest(17,33));
            Console.WriteLine(GetNearest(8,18));
        }
    }
}
