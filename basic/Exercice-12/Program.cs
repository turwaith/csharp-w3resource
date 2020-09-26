/*
Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces),
    and then four times in the next row, with no separation. 
You should do it two times: Use Console. Write and then use {0}.
Test Data:
    Enter a digit: 25
Expected Output:
    25 25 25 25
    25252525
    25 25 25 25
    25252525
*/
using System;

namespace Exercice_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   lineOne = String.Empty,
                   lineTwo = String.Empty;

            Console.Write("Enter a digit: ");
            userInput =Console.ReadLine();

            for(int i = 0; i < 2; i++)
            {
                lineOne = "";
                lineTwo = "";
                
                for(int j = 0; j < 4; j++)
                {
                    lineOne += userInput + (j == 3 ? "" : " ");
                    lineTwo += userInput;
                }
                Console.WriteLine(lineOne);
                Console.WriteLine(lineTwo);
            }
        }
    }
}
