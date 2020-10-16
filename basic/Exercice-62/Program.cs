/*
Write a C# program to reverse the strings contained in each pair of matching parentheses
    in a given string and also remove the parentheses within the given string.
    p(rq)st     =>  pqrst
    (p(rq)st)   =>  tsrqp
*/
using System;

namespace Exercice_62
{
    class Program
    {
        static bool HasParentheses(string stringToCheck)
        {
            return stringToCheck.IndexOf('(') != 1 && stringToCheck.LastIndexOf(')') != -1 ? true : false;
        }
        static string ReversedString(string originalString)
        {
            //string reversedString = string.Empty;
            while(HasParentheses(originalString))
            {
            int firstIndex = originalString.IndexOf('('),
                lastIndex = originalString.LastIndexOf(')');
            
            char[] sub = originalString.Substring(firstIndex, lastIndex).Replace("(","").Replace(")","").Trim().ToCharArray();
            Array.Reverse(sub);

            string reversedString = string.Empty;
            reversedString += originalString[0..firstIndex];
            reversedString += new string(sub);
            reversedString += originalString[(lastIndex+1)..^0];

            reversedString = reversedString.Replace('(',')').Replace(')','(');
            originalString = reversedString;
            }
            
            return originalString;
        }
        static void Main(string[] args)
        {
           Console.WriteLine($"p(rq)st   => {ReversedString("p(rq)st")}");
           Console.WriteLine($"(p(rq)st) => {ReversedString("(p(rq)st)")}");
        }
    }
}
