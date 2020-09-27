/*
Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
    Test Data:
Enter the amount of celsius: 30
Expected Output:
    Kelvin = 303
    Fahrenheit = 86
kelvin = celsius + 273
fahrenheit = celsius x 18 / 10 + 32
*/
using System;

namespace Exercice_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, kelvin, fahrenheit;

            Console.Write("Enter the amount of celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            kelvin = celsius + 273;
            fahrenheit = ((celsius * 18) / 10) + 32;

            Console.WriteLine($"Kelvin: {kelvin}\nFarhenheit: {fahrenheit}");
        }
    }
}
