/*
Write a C# Sharp program to create a new string taking 3 characters
    from the middle of a given string at least 3
 */
using System;

namespace Exercice_75
{
    class Program
    {
        public static string NewString(string original)
        {
            if(original.Length <= 3) return original;
            else
            {
                int middle = original.Length % 2 == 0 ?
                    (original.Length /2) - 2 :
                    (original.Length /2) - 1;
                return original[middle..(middle +3)];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string taking 3 characters\n" +
                              "from the middle of a given string at least 3");

            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Python"));
            Console.WriteLine(NewString("abc"));
        }
    }
}
