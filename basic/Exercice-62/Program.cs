/*
Write a C# program to reverse the strings contained in each pair of matching parentheses
    in a given string and also remove the parentheses within the given string.
    p(rq)st         =>  pqrst
    (p(rq)st)       =>  tsrqp
    ab(cd(ef)gh)ij  =>  abhgefdcij
*/
using System;
using System.Collections;

namespace Exercice_62
{
    class Program
    {
                static string ReversedString(string originalString)
        {            
            int openParentheseIndex = originalString.LastIndexOf('(');

            if(openParentheseIndex == -1) return originalString;
            else
            {
                int closeParentheseIndex = originalString.IndexOf(')',openParentheseIndex);
                char[] temp = originalString.Substring(openParentheseIndex+1,closeParentheseIndex - openParentheseIndex - 1).ToCharArray();
                Array.Reverse(temp);
                string outputString = originalString.Substring(0,openParentheseIndex) +
                                      new string(temp) +
                                      originalString.Substring(closeParentheseIndex+1);
                return ReversedString(outputString);

            }
        }
        static void Main(string[] args)
        {
           Console.WriteLine($"p(rq)st        => {ReversedString("p(rq)st")}");
           Console.WriteLine($"(p(rq)st)      => {ReversedString("(p(rq)st)")}");
           Console.WriteLine($"ab(cd(ef)gh)ij => {ReversedString("ab(cd(ef)gh)ij")}");
        }
    }
}