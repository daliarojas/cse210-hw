using System;

class Program
{
    static void Main(string[] args)
    {
        {
            // Generate random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = new Random().Next(1, 101);

            int guess = -1;
            
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int. Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
            } 

        }

        Console.WriteLine("You guessed it!");
    }
}
    
