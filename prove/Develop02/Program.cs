using System;

class Program
{
	static void Main(string[] args)
	{

		Journal journal = new Journal();
		int number = -1;

		while (number != 5)
		{
			Console.WriteLine("Thanks for being you!");
			Console.WriteLine("Here are some menu items to choose from: ");
			Console.WriteLine("Thanks for contributing to your future self. You will thank you.");
			Console.WriteLine("1. Random writing prompt");
			Console.WriteLine("2. Display");
			Console.WriteLine("3. Save");
			Console.WriteLine("4. Load");
			Console.WriteLine("5. Quit");
			Console.WriteLine("Enter Number: ");
			number = int.Parse(Console.ReadLine());

			if (number == 1)
			{
				// create a new Entry
				journal.AddEntry();
			}
			else if (number == 2)
			{
				journal.DisplayAll();
			}
			else if (number == 3)
			{
				Console.WriteLine("What would you like to save it as?");
				string filename = Console.ReadLine();
				journal.SaveToFile(filename);
			}
			else if (number == 4)
			{
				Console.WriteLine("What is the name of the file?");
				string filename = Console.ReadLine();
				journal.LoadFromFile(filename);
			}
			else if (number == 5)
			{
				// Quit End Program
				Console.WriteLine("Thanks you for your beatiful contribution.");
				break;
			}
			else
			{
				Console.WriteLine("Invalid response: Please input a valid number");
			}

		}

	}

}