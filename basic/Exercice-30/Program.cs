/*
Write a C# program to convert a hexadecimal number to decimal number.
Sample Output:
    Hexadecimal number: 4B0
    Convert to-
    Decimal number: 1200
*/
using System;
using System.Collections.Generic;

namespace Exercice_30
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            char[] hexDigits;
            double hexToDec = 0;
            Dictionary<char, int> hexTable = new Dictionary<char, int>()
            {
                {'0', 0},{'1', 1},{'2', 2},{'3', 3},
                {'4', 4},{'5', 5},{'6', 6},{'7', 7},
                {'8', 8},{'9', 9},{'A',10},{'B',11},
                {'C',12},{'D',13},{'E',14},{'F',15},
            };
            
            Console.Write("Enter a hexadecimal number to convert in decimal: ");
            userInput = Console.ReadLine().ToUpper();
            hexDigits = userInput.ToCharArray();

            for(int i = 0; i < hexDigits.Length; i++)
            {
                hexToDec += (hexTable[hexDigits[i]] * Math.Pow(16,hexDigits.Length-i-1));
            }

            Console.WriteLine($"The hex number '{userInput}' in decimal = {hexToDec}");
        }
    }
}
