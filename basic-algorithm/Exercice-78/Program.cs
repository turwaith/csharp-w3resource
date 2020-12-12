/*
Write a C# Sharp program to concat two given strings (lowercase).
If there are any double character in new string then omit one character
*/
using System;

namespace Exercice_78
{
    class Program
    {
        public static string NewString(string originalOne, string originalTwo)
        {
            return originalOne[^1] == originalTwo[0] ?
                originalOne + originalTwo[1..] :
                originalOne + originalTwo;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Concat two given strings (lowercase).
If there are any double character in new string then omit one character");

            Console.WriteLine(NewString("abc","cat"));
            Console.WriteLine(NewString("python", "php"));
            Console.WriteLine(NewString("php", "php"));            
        }
    }
}
