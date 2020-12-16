/*
Write a C# Sharp program to create a new string from a given
    string without the first two characters.
Keep the first character if it is "p" and keep the
    second character if it is "y"
*/
using System;

namespace Exercice_85
{
    class Program
    {
        public static string NewString(string original)
        {
            if(original[0] == 'p' && original[1] == 'y') return original;
            else if(original[0] == 'p') return original[0] + original[2..];
            else if(original[1] == 'y') return original[1..];
            else return original[2..];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new string from a given
    string without the first two characters.
Keep the first character if it is ""p"" and keep the
    second character if it is ""y""");
        
            Console.WriteLine(NewString("abcab"));
            Console.WriteLine(NewString("python"));
            Console.WriteLine(NewString("press"));
            Console.WriteLine(NewString("jython"));
        }
    }
}
