/*
Write a C# Sharp program to shift an element in left direction and return a new array
*/
using System;
using System.Linq;
namespace Exercice_127
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shift an element in left direction and return a new array");
            int[] test = {1,2,3};

            test.Shifted(); // call the extension method
            Shifted(new int[]{10,20,-30,-40,50}); // call a simple method
        }
        public static void Shifted(int[] numbers){
            int[] flag = new int[numbers.Length];            
            flag = numbers[1..].Concat(numbers[0..1]).ToArray();  
            Console.WriteLine($"{String.Join(",",numbers)} => {String.Join(",",flag)}");
        }
    }
    static class Extension
    {
            public static void Shifted(this int[] numbers){
            int[] flag = new int[numbers.Length];
            flag = numbers[1..].Concat(numbers[0..1]).ToArray();    
            Console.WriteLine($"{String.Join(",",numbers)} => {String.Join(",",flag)}");
        }
    }
}
