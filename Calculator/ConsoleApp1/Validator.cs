using System.Collections.Generic;

namespace Calculator
{
    internal class Validator
    {
        static readonly List<string> PossibleChoices = new List<string>() { "a", "s", "m", "d", "o" };

        public static bool IsCorrectOperation(string userText)
        {
            return PossibleChoices.Contains(userText);
        }


    }
}