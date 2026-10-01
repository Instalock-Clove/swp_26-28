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
/* Diese Datnetypen kennt C#
 Ganzzahlen
----------
sbyte    System.SByte    8 Bit    -128 bis 127
byte     System.Byte     8 Bit    0 bis 255
short    System.Int16    16 Bit   -32.768 bis 32.767
ushort   System.UInt16   16 Bit   0 bis 65.535
int      System.Int32    32 Bit   ca. -2,1 Mrd. bis 2,1 Mrd.
uint     System.UInt32   32 Bit   0 bis ca. 4,29 Mrd.
long     System.Int64    64 Bit   ca. -9,2 * 10^18 bis 9,2 * 10^18
ulong    System.UInt64   64 Bit   0 bis ca. 1,8 * 10^19
nint     System.IntPtr   32/64 Bit (plattformabhaengig, mit Vorzeichen)
nuint    System.UIntPtr  32/64 Bit (plattformabhaengig, ohne Vorzeichen)
(Int128 / UInt128: 128 Bit, ab .NET 7)
 
Gleitkomma- und Dezimalzahlen
-----------------------------
float    System.Single   32 Bit   ca. 6-9 Stellen     Suffix f (36.6f)
double   System.Double   64 Bit   ca. 15-17 Stellen   Standard fuer Kommazahlen
decimal  System.Decimal  128 Bit  28-29 Stellen       Suffix m (19.99m), ideal fuer Geld
(Half: System.Half, 16 Bit)
 
Sonstige elementare Typen
-------------------------
bool     System.Boolean  true oder false
char     System.Char     ein Unicode-Zeichen (16 Bit), z. B. 'A'
 
 
--------------------------------------------------------------------------
B) NICHT-ELEMENTARE DATENTYPEN (zusammengesetzte Typen)
--------------------------------------------------------------------------
 
Eingebaute Referenztypen
------------------------
string   Zeichenkette (unveraenderlich), z. B. "Hallo"
object   Basistyp aller Typen
dynamic  Typpruefung erst zur Laufzeit
Arrays   feste Anzahl gleicher Elemente: int[], string[,], int[][]
 
Selbst definierbare Typen
-------------------------
class          Referenztyp   Objekt mit Feldern, Eigenschaften, Methoden
record         Referenztyp   Klasse mit Wertvergleich (record class)
struct         Wertetyp      leichtgewichtiger Verbund von Feldern
record struct  Wertetyp      Struct mit Wertvergleich
enum           Wertetyp      Aufzaehlung benannter Konstanten
interface      Referenztyp   Vertrag ohne Implementierung
delegate       Referenztyp   typsicherer Verweis auf eine Methode
Tupel          Wertetyp      (int, string), ValueTuple
Nullable<T>    Wertetyp      T?, Wertetyp der auch null sein darf, z. B. int?
 
Typen aus der Standardbibliothek
--------------------------------
Datum/Zeit:   DateTime, DateOnly, TimeOnly, TimeSpan, DateTimeOffset
Strukturen:   Guid, Index, Range
Sammlungen:   List<T>              dynamische Liste
               Dictionary<K,V>      Schluessel-Wert-Paare
               HashSet<T>           Menge ohne Duplikate
               Queue<T>             Warteschlange (FIFO)
               Stack<T>             Stapel (LIFO)
               LinkedList<T>        doppelt verkettete Liste
               SortedList<K,V>      sortierte Liste
               SortedDictionary<K,V> sortiertes Dictionary
Weitere:      StringBuilder        veraenderbare Zeichenketten
               Action, Func<>, Predicate<>   vordefinierte Delegates
               Exception und Ableitungen
               Task, Task<T>        asynchrone Abloeufe
               Span<T>              speichereffizienter Ausschnitt
 
Zeigertypen (nur im unsafe-Kontext)
-----------------------------------
int*, char*, ...   selten gebraucht
 */

/*
 * WOZU BENÖTIGT C# DATENTYPEN?
 *
 * Datentypen sagen dem Compiler und dem Computer, WAS in einer Variablen
 * steckt. Ohne diese Information wäre ein Speicherbereich nur eine Folge
 * von Nullen und Einsen ohne Bedeutung.
 *
 *
 * 1. Bits haben von sich aus keine Bedeutung
 *    Dieselben 32 Bit können eine Ganzzahl, eine Kommazahl oder vier
 *    Zeichen sein. Erst der Datentyp legt fest, wie sie gelesen werden.
 *
 * 2. Der Compiler weiß, wie viel Speicher er reservieren muss
 *    Ein byte braucht 1 Byte, ein long 8 Byte, ein decimal 16 Byte.
 *    Nur mit dieser Information kann der Compiler den Speicher planen
 *    und sehr schnell darauf zugreifen.
 *
 * 3. Der Typ bestimmt, welche Operationen erlaubt sind
 *    Derselbe Operator + verhält sich je nach Typ anders: Bei Zahlen
 *    addiert er (5 + 3 = 8), bei Strings verkettet er ("5" + "3" = "53").
 *    Unsinn wie "Hallo" * 2 oder true / 3 wird abgelehnt, weil es für
 *    diese Typen keine solche Operation gibt.
 *
 * 4. Fehler werden vor dem Start gefunden
 *    C# prüft die Typen beim KOMPILIEREN, nicht erst beim Ausführen.
 *    Der Fehler fällt dem Entwickler auf, nicht dem Benutzer. In Sprachen
 *    ohne feste Typen (z. B. JavaScript oder Python) treten solche Fehler
 *    oft erst zur Laufzeit auf, manchmal erst beim Kunden.
 *
 * 5. Wertebereich und Genauigkeit lassen sich gezielt wählen
 *    - byte    für Werte von 0 bis 255 (z. B. Farbkanäle)
 *    - int     für normale Zählungen
 *    - decimal für Geld, weil double Rundungsfehler hat
 *              (0.1 + 0.2 ergibt bei double 0.30000000000000004)
 *    Der passende Typ spart Speicher und verhindert Überläufe oder
 *    ungenaue Ergebnisse.
 *
 * 6. Der Typ dokumentiert die Absicht
 *    "DateTime geburtstag" sagt sofort, was gemeint ist. Bei
 *    "object geburtstag" müsste man raten. Dank der Typen bietet die
 *    Entwicklungsumgebung außerdem Autovervollständigung, Fehlerhinweise
 *    und sicheres Umbenennen.
 *
 * 7. Eigene Typen bilden die Wirklichkeit ab
 *    Mit class, struct, enum usw. modelliert man Dinge aus dem eigenen
 *    Problembereich. Der Compiler stellt sicher, dass ein Kunde nicht
 *    versehentlich wie eine Rechnung oder eine Zahl behandelt wird.
 *
 *
 * KURZ GESAGT:
 * Datentypen geben Daten eine Bedeutung, sparen und ordnen Speicher,
 * schränken Operationen auf sinnvolle ein und lassen den Compiler Fehler
 * finden, bevor das Programm läuft.
 */