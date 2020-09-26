/*
 Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
Test Data:
    Enter a number: 5
Expected Output:
    555
    5 5
    5 5
    5 5
    555
*/
using System;

namespace Exercice_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string userDigit = String.Empty,
                   startEnd = String.Empty,
                   line = String.Empty;

            Console.Write("Enter a number :");
            userDigit = Console.ReadLine();

            //  creation of start and end line
            for(int i = 0; i < 3; i++)
            {
                startEnd += userDigit;
                line += (i == 1 ? " " : userDigit);
            }

            // display the rectangle
            Console.WriteLine(startEnd);

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine(startEnd);
            
        }
    }
}
