using System;
using System.Globalization;

namespace KonsolenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte einen String eingeben: ");
            string eingabe = Console.ReadLine();

            if (eingabe != null)
            {
                // Typ der Eingabe bestimmen
                if (int.TryParse(eingabe, out int intWert))
                {
                    Console.WriteLine($"Integer erkannt: {intWert}");
                }
                else if (IstBool(eingabe, out bool boolWert))
                {
                    Console.WriteLine($"Bool erkannt: {boolWert}");
                }
                else if (double.TryParse(eingabe, NumberStyles.Float, CultureInfo.CurrentCulture, out double doubleWert))
                {
                    Console.WriteLine($"Double erkannt: {doubleWert}");
                }
                else
                {
                    Console.WriteLine("Es handelt sich um einen normalen String.");
                }

                // Bisherige Funktion: String umdrehen
                char[] charArray = eingabe.ToCharArray();
                Array.Reverse(charArray);
                string umgedreht = new string(charArray);
                Console.WriteLine($"Ausgabe: {umgedreht}");
                Console.ReadKey();
            }
        }

        // Erkennt true/false sowie wahr/falsch
        static bool IstBool(string text, out bool wert)
        {
            string t = text.Trim().ToLower();

            if (t == "wahr") { wert = true; return true; }
            if (t == "falsch") { wert = false; return true; }

            return bool.TryParse(t, out wert);
        }
    }
}