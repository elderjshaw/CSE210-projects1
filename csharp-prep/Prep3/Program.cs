using System;
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);
        //Console.Write("What is the magic number? ");
        //string magicInput = Console.ReadLine();
        //int magicNum = int.Parse(magicInput);

        Console.Write("What is your lucky guess? ");
        string guessInput = Console.ReadLine();
        int guessNum = int.Parse(guessInput);

        int guessCount = 0;

        while (guessNum != magicNum)
        {
            if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
            Console.WriteLine("What is your lucky guess?");
            string guess = Console.ReadLine();
            guessNum = int.Parse(guess);
            guessCount++;
        }

        Console.WriteLine($"You guessed it in {guessCount} tries!");
        /*
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
        }
        */
    }
}
    


 /*
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        int guessCount = 0;

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNum)
        {
            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            guessCount++;
        }
        Console.WriteLine($"You guessed it in {guessCount}, Great Job!");
        */