/*
Write a C# program to print the odd numbers from 1 to 99. Prints one number per line. 
Sample Output:
    Odd numbers from 1 to 99. Prints one number per line.
    1
    3
    5
    7
    9
    ...
    95
    97
    99
*/
using System;

namespace Exercice_25
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 1; i < 100; i+=2)
           {
               Console.WriteLine(i);
           }
        }
    }
}
