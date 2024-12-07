namespace Emne_3_05_Krokodillespillet
{
    internal class Program
    {
        static void Main(string[] args)
            //Oppgave: Krokodillespillet
            // For hver runde skal det printes ut til skjermen et random tall mellom 1-11,
            // så et mellomrom og et nytt tall mellom 1-11
            // med en underscore mellom slik at det ser sånn ut: "3 _ 5"
            // Brukeren kan skrive inn "<", ">" eller "="
            // i tilfellet brukeren får 3 _ 5 vil svaret være "<", altså "3 < 5"
            // Tallene må sjekkes om det første er større eller mindre, eller lik det andre tallet,
            // Det må verifiseres om brukeren har valgt riktig alternativ.
            // Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
            // Poengsummen printes til skjermen for hvert svar brukeren har gitt.
            // Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene
        {

            Random randNumb = new Random();
            int score = 0;
            bool firstRound = true;


            while (true)
            {
                if (firstRound)
                {
                    Console.WriteLine(
                        "Welcome to the CrocoGame!\nPress '<', '>' or '=' to guess if the number is lower, bigger or equal");
                    firstRound = false;
                }

                int number1 = randNumb.Next(1, 11); // Trekker ut et random tall til "number1"
                int number2 = randNumb.Next(1, 11); // Trekker ut et random tall til "number2"


                Console.WriteLine(number1 + " _ " + number2);

                string input = Console.ReadLine();

                if (input != "<" && input != ">" && input != "=") // Kun disse tre tegnene er gyldig input.
                {
                    Console.WriteLine(
                        "You must type '<', '>' or '='. Please try again."); // Hvis noe ugyldig blir tastet inn.
                }

                else
                {
                    if ((input == ">" && number1 > number2) // +1 poeng hvis nummer 1 er størst.
                        || (input == "<" && number1 < number2) // +1 poeng hvis nummer 2 er størst.
                        || (input == "=" && number1 == number2)) // +1 poeng hvis begge nummerene er like.
                    {
                        Console.WriteLine("Correct! +1 point");
                        score += 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! -1 point");
                        score -= 1;
                    }
                }

                Console.WriteLine("Your score is: " + score); // Viser poengsum.

                Console.WriteLine("Press 'enter' to continue game, or 'x' to exit");
                string exit = Console.ReadLine();
                if (exit == "x")
                {
                    Console.WriteLine("Game Over! Thanks for playing. Final score: " +
                                      score); // Hvis man trykker 'x'
                    break;
                }
                else
                {
                    Console.WriteLine("Here's the next:");
                }
            }
        }
    }
}
            
        
