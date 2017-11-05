using System;
using System.Collections.Generic;

namespace CalculatorWithoutMethods
{
    class Program
    {
        static void Main()
        {
            string tryAgain;
            Console.WriteLine("This is a simple calculator. \n Please choose an operation \n");
            do
            {
                Console.WriteLine(
                    "Addition - type +, Subtraction - type -, Multiplication - type *, "
                    + "Division - type / and Modulation - type %");
                var operation = Console.ReadLine();

                var possibleChoices = new List<string> { "+", "-", "*", "/", "%" };
                var isOprationCorrect = possibleChoices.Contains(operation);

                var count = 0;
                while (isOprationCorrect == false)
                {
                    Console.WriteLine("Invalid sign, please try again");
                    operation = Console.ReadLine();
                    isOprationCorrect = possibleChoices.Contains(operation);
                    if (count++ > 5)
                        break;
                }
                Console.WriteLine("Enter first number");
                float.TryParse(Console.ReadLine(), out float firstNumber);

                Console.WriteLine("Enter second number");
                float.TryParse(Console.ReadLine(), out float secondNumber);

                float result;
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                    case "%":
                        result = firstNumber % secondNumber;
                        break;
                    default:
                        throw new Exception("Invalid operation");
                }

                Console.WriteLine($"Result = {result}");

                Console.WriteLine("Do you want to try again? Type y for yes or any other key for no");
                tryAgain = Console.ReadLine();
            }
            while (tryAgain.ToLower() == "y");
        }
    }
}