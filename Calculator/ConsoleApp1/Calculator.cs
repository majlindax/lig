using System;

namespace Calculator
{
    internal class Calculator
    {
        public static void RunCalculator()
        {
            Console.WriteLine("This is a simple calculator. \n Please choose an operation \n");
            Console.WriteLine("Addition - type +, Subtraction - type -, Multiplication - type *, "
                              + "Division - type / and Modulation - type %");
            var operation = Console.ReadLine();
            AskForOperation(operation);

            Console.WriteLine("Enter first number");
            float.TryParse(Console.ReadLine(), out float firstNumber);

            Console.WriteLine("Enter second number");
            float.TryParse(Console.ReadLine(), out float secondNumber);

            var result = Operations.ExecuteSelectedOperation(operation, firstNumber, secondNumber);
            Console.WriteLine($"Result = {result}");
        }

        public static void AskForOperation(string operation)
        {
            var isOprationCorrect = Validator.IsCorrectOperation(operation);
            var count = 0;
            while (isOprationCorrect == false)
            {
                Console.WriteLine("Invalid sign, please try again");
                operation = Console.ReadLine();
                isOprationCorrect = Validator.IsCorrectOperation(operation);
                if (count++ > 5)
                    break;
                
            }
        }
    }
}