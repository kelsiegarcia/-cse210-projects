using System;

class Program
{
	static void Main(string[] args)
	{
		// Entry entry = new Entry();

		Journal journal = new Journal();
		// entry.Display();

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
				// readine and convert data type to string
				Console.WriteLine("Name your file");
				string selection = Convert.ToString(Console.ReadLine());
				// how to get this string variable for the filename?
				journal.SaveToFile("myJournal.txt");
			}
			else if (number == 4)
			{
				// readine and convert data type to string
				journal.LoadFromFile("myJournal.txt");
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