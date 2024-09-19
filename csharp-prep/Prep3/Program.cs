using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 10);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            string input2 = Console.ReadLine();
            guess = int.Parse(input2);


            if (guess == magicNumber)
            {
                Console.WriteLine("That is the correct number!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }


        }

        // string result = (guess == magicNumber) ? "It's a match" : (guess < magicNumber) ? "higher" : "lower

    }
}