namespace TemperaturSjekker;

class Program
{
    static void Main(string[] args)
    {
        // Leser en tekststreng som brukeren skriver inn i konsollen og konverterer den til en double (desimaltall)
        Console.WriteLine("Angi temperaturen i grader Celsius:");
        double temperatur = Convert.ToDouble(Console.ReadLine());

        // Definer grenseverdier, obs. bruk punktum for desimaltall og ikke komma!
        double lowTreshold = 0.0;
        double highTreshold = 25.0;

        // Sjekk temperaturen og gi info
        if (temperatur < lowTreshold)
        {
            Console.WriteLine("Temperaturen er lav (under 0°C).");
        }
        else if (temperatur > highTreshold)
        {
            Console.WriteLine("Temperaturen er høy (over 25°C).");
        }
        else
        {
            Console.WriteLine("Temperaturen er innenfor normalområdet (0°C - 25°C).");    
        }
    }
}
