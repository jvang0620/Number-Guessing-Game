namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool PlayAgain = true;
            int MinValue;
            int MaxValue;
            int Guess;
            int NumberGenerated;
            int NumberOfGuesses;
            String Response;

            //Promte user for min and max value
            Console.WriteLine("What would you like your minmual value to be? ");
            MinValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What would you like your minmual value to be? ");
            MaxValue = Convert.ToInt32(Console.ReadLine());

            while (PlayAgain)
            {
                Guess = 0;
                NumberOfGuesses = 0;
                Response = "";
                NumberGenerated = random.Next(MinValue, MaxValue + 1); //generate number between minValue and MaxValue

                while (Guess != NumberGenerated)
                {
                    Console.WriteLine("Guess a number between " + MinValue + " - " + MaxValue + " : ");
                    Guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + Guess);

                    if (Guess > NumberGenerated)
                    {
                        Console.WriteLine(Guess + " is to high!");
                    }
                    else if (Guess < NumberGenerated)
                    {
                        Console.WriteLine(Guess + " is to low!");
                    }
                    NumberOfGuesses++;
                }
                Console.WriteLine("Number: " + NumberGenerated);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + NumberOfGuesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                Response = Console.ReadLine();
                Response = Response.ToUpper();

                if (Response == "Y")
                {
                    PlayAgain = true;
                }
                else
                {
                    PlayAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! Bye Bye Bye!");

            Console.ReadKey();
        }
    }
}
