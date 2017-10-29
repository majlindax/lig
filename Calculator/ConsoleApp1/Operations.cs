using System;

namespace Calculator
{
    internal class Operations
    {
        public static float ExecuteSelectedOperation(string chosenOperation, float firstNumber, float secondNumber)
        {
            switch (chosenOperation)
            {
                case "a":
                    return Addition(firstNumber, secondNumber);
                case "s":
                    return Subtraction(firstNumber, secondNumber);
                case "m":
                    return Multiplication(firstNumber, secondNumber);
                case "d":
                    return Division(firstNumber, secondNumber);
                case "o":
                    return Modulation(firstNumber, secondNumber);
                default:
                    throw new Exception("Invalid operation");
            }
        }

        public static float Addition(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static float Subtraction(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static float Multiplication(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static float Division(float firstNumber, float secondNumber)
        {
            if (Math.Abs(secondNumber) > 0)
            {
                return firstNumber / secondNumber;
            }
            throw new Exception("Cannot divide by 0!!!");
        }

        public static float Modulation(float firstNumber, float secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}