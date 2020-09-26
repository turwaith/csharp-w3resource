/*
Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
Test Data:
    Enter your age - 25
Expected Output:
    You look older than 25
*/
using System;

namespace Exercice_11
{
    class Program
    {
        static void Main(string[] args)
        {
           int userAge;

           Console.Write("Enter your age: ");
           userAge = Convert.ToInt32(Console.ReadLine());

           if(userAge >= 18) Console.WriteLine("Hi you ;) You are adult. Take a beer!");
           else Console.WriteLine("Hi you ;) You are minor. Take a juice.!");
        }
    }
}
