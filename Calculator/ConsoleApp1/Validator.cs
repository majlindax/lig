using System.Collections.Generic;

namespace Calculator
{
    internal class Validator
    {
        private static readonly List<string> PossibleChoices = new List<string> { "+", "-", "*", "/", "%" };

        public static bool IsCorrectOperation(string userText)
        {
            return PossibleChoices.Contains(userText);
        }
    }
}