/*
Write a C# Sharp program to print Hello and your name in a separate line.
Expected Output :
    Hello: Alexandra Abramov
*/
using System;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Nicolas",
                   lastName = "Wailly";

            Console.WriteLine($"Hello: {firstName} {lastName}");
        }
    }
}
