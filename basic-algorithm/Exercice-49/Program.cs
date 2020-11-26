/*
Write a C# Sharp program to check if three given numbers are in strict increasing order,
    such as 4, 7, 15 or 45, 56, 67 but not 4, 51, 8 or 6, 6, 8.
However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7
*/
using System;

namespace Exercice_49
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput;
            int numberOne = 0,
                numberTwo = 0,
                numberThree = 0;            
            bool isIncreasing = false,
                 output = false;

            Console.WriteLine(@"Check if three given numbers are in strict increasing order,
    such as 4, 7, 15 or 45, 56, 67 but not 4, 51, 8 or 6, 6, 8.
However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7");
        
            Console.Write("Enter 3 numbers + boolean equality checker (x,x,x,false): ");
            userInput = Console.ReadLine().Split(",");

            numberOne = Convert.ToInt32(userInput[0]);
            numberTwo = Convert.ToInt32(userInput[1]);
            numberThree = Convert.ToInt32(userInput[2]);

            isIncreasing = numberOne < numberTwo && numberTwo < numberThree;

            if(isIncreasing) output = true;
            else if(userInput[3].ToLower() == "true")
            {
                if(numberOne == numberTwo && numberThree > numberOne) output = true;    // 0,0,1
                if(numberOne < numberTwo && numberTwo == numberThree) output = true;    // 0,1,1
                if(numberOne == numberTwo && numberTwo == numberThree) output = true;   // 1,1,1
            }

            Console.WriteLine($"Output: {output}");
        }
    }
}
