using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        static void mainFunction()
        {
            DisplayMessage();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int square = SquareNumber(userNumber);

            DisplayResult(userName, square);

        }

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the programe!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }

        static void DisplayResult(string name, int numberSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {numberSquared}");
        }
        mainFunction();
    }

}