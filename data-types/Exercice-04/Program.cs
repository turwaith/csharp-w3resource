/*
Write a C# Sharp program that takes two numbers as input and perform an operation
    (+,-,*,x,/) on them and displays the result of that operation
*/
using System;
using System.Collections.Generic;

namespace Exercice_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Takes two numbers as input and perform an operation
(+,-,*,x,/) on them and displays the result of that operation");

            int a = GetOperand("Input first number: ");
            char operation = GetOperation("Input operation: ");
            int b = GetOperand("Input second number: ");

            Console.WriteLine($"{a} {operation} {b} : {(Compute(a,b,operation))}");
        }

        static int GetOperand(string msg)
        {
            int operand;

            do
            {
                Console.Write(msg);                
            }while(!Int32.TryParse(Console.ReadLine(),out operand));
            
            return operand;
        }

        static char GetOperation(string msg)
        {
            char[] validOperation = {'+', '-', '*', '/'};
            char operation;

            Console.Write(msg);
            operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if(Array.IndexOf(validOperation, operation) != -1)
                return operation;            
            
            return GetOperation(msg);
        }

        static int Compute(int a, int b, char operation)
        {
            int result = 0;
            switch (operation)  
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;                
            }
            return result;
        }
    }
}
