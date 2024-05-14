using System;

class Program
{
    static string ConvertNumber(string number, int fromBase, int toBase)
    {
        int decimalNumber = Convert.ToInt32(number, fromBase);
        string convertedNumber = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % toBase;
            convertedNumber = remainder.ToString() + convertedNumber;
            decimalNumber /= toBase;
        }

        return convertedNumber;
    }

    static void Main()
    {
        Console.WriteLine("Willkommen zur Zahlensystem-Konverter-App!");

        bool continueConversion = true;
        while (continueConversion)
        {
            Console.WriteLine("Bitte geben Sie die zu konvertierende Zahl, die Ausgangsbasis und die Zielbasis ein.");
            Console.Write("Zahl: ");
            string number = Console.ReadLine();

            Console.Write("Ausgangsbasis (2 für Binär, 8 für Oktal, 10 für Dezimal, 16 für Hexadezimal): ");
            int fromBase = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zielbasis (2 für Binär, 8 für Oktal, 10 für Dezimal, 16 für Hexadezimal): ");
            int toBase = Convert.ToInt32(Console.ReadLine());

            try
            {
                string result = ConvertNumber(number, fromBase, toBase);
                Console.WriteLine($"Das Ergebnis der Konvertierung ist: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Fehler: {e.Message}");
            }

            Console.Write("Möchten Sie eine weitere Konvertierung durchführen? (ja/nein): ");
            string input = Console.ReadLine();
            continueConversion = input.ToLower() == "ja" || input.ToLower() == "j";
        }
    }
}