using System; // Importerar System biblioteket för konsolapplikationer

class Program // Definierar huvudklassen Program
{
    static void Main(string[] args) // Huvudmetoden där programmet startar
    {
        Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök."); // Välkomstmeddelande

        Random random = new Random(); // Tärningen slår ett random nummer ( jag tänker att random är en tärning)
        int number = random.Next(1, 21); // slår en tärning och får ett tal mellan 1 och 20
 
        for (int i = 0; i < 5; i++) // Loop för att ge användaren fem försök att gissa numret
        {
            Console.Write("Gissa ett nummer mellan 1 och 20: "); // Ber användaren att gissa ett nummer
            int guess = int.Parse(Console.ReadLine()); // Läser in användarens gissning

            if (CheckGuess(guess, number))
            {
                Console.WriteLine("Grattis! Du gissade rätt!"); // Meddelande om korrekt gissning
                break; // Avsluta loopen om gissninen var korrekt
            }
            else // Om gissningen var fel
            {
                if (guess < number) // Om gissningen var för låg
                {
                    Console.WriteLine("För lågt! Försök igen."); // Ge svar om gissningen var för låg
                }
                else
                {
                    Console.WriteLine("För högt! Försök igen."); // Ge svar om gissningen var för hög
                }
            }

            if (i == 4) // Om det var sista försöket
            {
                Console.WriteLine("Fel gissning. Försök igen."); // Meddelande om fel gissning efter 5 försök
            }
        }
        
        static bool CheckGuess(int guess, int number) // Metod för att kontrollera om gissningen är korrekt
        {
            return guess == number; // Returnerar true om gissningen är korrekt
        }
    }
}