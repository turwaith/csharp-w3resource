/*
Write a C# program to get a new string of two characters from a given string. 
The first and second character of the given string must be "P" and "H", so PHP will be "PH". 
    Test Data: PHP
    Sample Output:
    PH
*/
using System;

namespace Exercice_38
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "PHP tutorial";
            string newData = String.Empty;

            if(data.StartsWith("PH"))
            {
                newData += data[0];
                newData += data[1];
            }

            Console.WriteLine(newData);
        }
    }
}
