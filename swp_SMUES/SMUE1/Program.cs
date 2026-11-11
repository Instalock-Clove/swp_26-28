using System.Numerics;

namespace SMUE1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter something: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                HandleNumber(number);
            }
            else
            {
                HandleText(input);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void HandleNumber(int number)
        {
            Console.WriteLine("You entered an integer. Which mathematical operation do you want to perform?");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Multiplication");
            Console.WriteLine("3) Division");
            Console.WriteLine("4) Factorial");
            Console.WriteLine("5) Square root");

            int choice = ReadChoice(5);

            if (choice == 1)
            {
                int second = ReadSecondNumber();
                Console.WriteLine("Result: " + (number + second));
            }
            if (choice == 2)
            {
                int second = ReadSecondNumber();
                Console.WriteLine("Result: " + (number * second));
            }
            if (choice == 3)
            {
                int second = ReadSecondNumber();
                if (second == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                else
                {
                    Console.WriteLine("Result: " + ((double)number / second));
                }
            }
            if (choice == 4)
            {
                if (number < 0)
                {
                    Console.WriteLine("The factorial is not defined for negative numbers.");
                }
                else
                {
                    Console.WriteLine("Result: " + Factorial(number));
                }
            }
            if (choice == 5)
            {
                if (number < 0)
                {
                    Console.WriteLine("The square root of a negative number is not defined.");
                }
                else
                {
                    Console.WriteLine("Result: " + Math.Sqrt(number));
                }
            }
        }

        static void HandleText(string text)
        {
            Console.WriteLine("You entered a string. What do you want to do with it?");
            Console.WriteLine("1) Remove all vowels (a, e, i, o, u)");
            Console.WriteLine("2) Reverse the string (\"Hello\" becomes \"olleH\")");
            Console.WriteLine("3) Output the number of characters");

            int choice = ReadChoice(3);

            if (choice == 1)
            {
                Console.WriteLine("Result: " + RemoveVowels(text));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Result: " + Reverse(text));
            }
            else if (choice == 3)
            {
                Console.WriteLine("Result: " + text.Length);
            }
        }
        static int ReadChoice(int maxChoice)
        {
            Console.Write("Your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > maxChoice)
            {
                Console.Write("Invalid input. Please enter a number between 1 and " + maxChoice + ": ");
            }
            return choice;
        }

        static int ReadSecondNumber()
        {
            Console.Write("Please enter the second number: ");
            int second;
            while (!int.TryParse(Console.ReadLine(), out second))
            {
                Console.Write("Invalid input. Please enter an integer: ");
            }
            return second;
        }

        static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        static string RemoveVowels(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if ("aeiouAEIOU".IndexOf(c) == -1)
                {
                    result = result + c;
                }
            }
            return result;
        }

        static string Reverse(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                result = c + result;
            }
            return result;
        }
    }
}