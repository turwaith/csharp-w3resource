/*
Write a C# program to get the absolute value of the difference between two given numbers.
Return double the absolute value of the difference if the first number is greater than second number.
*/
using System;

namespace Exercice_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo;

            Console.Write("Enter the first number: ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetAbsolute(numberOne, numberTwo));
        }

        public static int GetAbsolute(int a, int b)
        {
            if(a > b) return (a-b)*2;
            else return -(a-b);
        }
    }
}
