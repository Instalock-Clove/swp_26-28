using System;
using System.Linq;

namespace KonsolenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte einen String eingeben: ");
            string eingabe = Console.ReadLine();

            if (eingabe != null)
            {   char[] charArray = eingabe.ToCharArray();
                Array.Reverse(charArray);
                string umgedreht = new string(charArray);
                Console.WriteLine($"Ausgabe: {umgedreht}");
                Console.ReadKey();
            }
        }
    }
}
