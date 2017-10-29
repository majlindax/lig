using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is a simple calculator. \n Please choose an operation \n");
            Console.WriteLine("Addition - type a, Subtraction - type s, Multiplication - type m, "
                              + "Division - type d and Modulation - type o");
            var operation =  Console.ReadLine();
            AskForOperation(operation);

            Console.WriteLine("Enter first number");
            var firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            var secondNumber = float.Parse(Console.ReadLine());

            var result = Operations.ExecuteSelectedOperation(operation, firstNumber, secondNumber);
            Console.WriteLine($"Result = {result}");
            Console.ReadLine();
        }

        public static void AskForOperation(string operation)
        {
            var isOprationCorrect = Validator.IsCorrectOperation(operation);
            while (isOprationCorrect == false)
            {
                Console.WriteLine("Invalid sign, please try again");
                operation = Console.ReadLine();
                isOprationCorrect = Validator.IsCorrectOperation(operation);
            }
        }

    }
}
