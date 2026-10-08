using System;

namespace KonsolenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter something: ");
            string input = Console.ReadLine();

            if (input != null)
            {
                string typeText = GetTypeText(input);
                Console.WriteLine(typeText);

                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray);
                Console.WriteLine("Reversed: " + reversed);

                Console.ReadKey();
            }
        }

        static string GetTypeText(string text)
        {
            if (int.TryParse(text, out int number))
            {
                return "This is an integer: " + number;
            }

            if (TryParseBool(text, out bool yesNo))
            {
                return "This is a bool: " + yesNo;
            }

            if (double.TryParse(text, out double decimalNumber))
            {
                return "This is a double: " + decimalNumber;
            }

            return "This is a normal string.";
        }

        static bool TryParseBool(string text, out bool value)
        {
            string cleaned = text.Trim().ToLower();

            if (cleaned == "wahr")
            {
                value = true;
                return true;
            }

            if (cleaned == "falsch")
            {
                value = false;
                return true;
            }

            return bool.TryParse(cleaned, out value);
        }
    }
}