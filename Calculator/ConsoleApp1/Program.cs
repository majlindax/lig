using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator.RunCalculator();
            
            Console.WriteLine("Do you want to try again? Type y for yes or any other key for no");
            var tryAgain = Console.ReadLine();
            while (tryAgain.ToLower() == "y")
            {
                Calculator.RunCalculator();
            }
        }

    }
}
