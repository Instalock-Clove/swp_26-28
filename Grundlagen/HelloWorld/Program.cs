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
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static string GetTypeText(string text)
        {
            if (int.TryParse(text, out int number))
            {
                Console.WriteLine("Please choose an operation: 1.Square 2.Root 3.Factorial");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    try
                    {
                        return "Result: " + operation(number, choice);
                    }
                    catch (ArgumentException ex)
                    {
                        return ex.Message;
                    }
                }
                return "Please enter 1, 2 or 3.";
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
        static int operation(int number, int choice)
        {
            switch (choice)
            {
                case 1:
                    return number * number;
                case 2:
                    return (int)Math.Sqrt(number);
                case 3:
                    return Factorial(number);
                default:
                    throw new ArgumentException("Invalid operation choice.");
            }
        }
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
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