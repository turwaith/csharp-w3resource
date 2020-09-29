/*
Write a C# program and compute the sum of the digits of an integer.
Sample Output:
    Input a number(integer): 12
    Sum of the digits of the said integer: 3
*/
using System;

namespace Exercice_27
{
    class Program
    {
        static void Main(string[] args)
        {
           string userInput = String.Empty;
           char[] integers;
           int sum = 0;

           Console.Write("Input a number(integer): ");
           userInput = Console.ReadLine();
           integers = userInput.ToCharArray();

            foreach(char item in integers) sum += Convert.ToInt32(item.ToString());        

            Console.WriteLine($"Sum of the digits of the said integer: {sum}");

        }
    }
}
