using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome to the Mindfulness App!");
		Console.WriteLine("1. Breathing");
		Console.WriteLine("2. Listing");
		Console.WriteLine("3. Reflecting");
		Console.WriteLine("4. Quit");
		Console.Write("Enter the number of the activity you would like to run: ");
		int option = int.Parse(Console.ReadLine());

		Console.Write("Enter the duration for the activity in seconds: ");
		int seconds = int.Parse(Console.ReadLine());

		switch (option)
		{
			case 1:
				BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Breathing is a great way to relax and calm your mind.", seconds);
				breathingActivity.Run(seconds);
				break;
			case 2:
				ListingActivity listingActivity = new ListingActivity("Listing", "Listing is a great way to relax and calm your mind.", seconds);
				listingActivity.Run(seconds);
				break;
			case 3:
				ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "Reflecting is a great way to relax and calm your mind.", seconds);
				reflectingActivity.Run(seconds);
				break;
			case 4:
				Console.WriteLine("Goodbye!");
				break;
			default:
				Console.WriteLine("Invalid option. Please try again.");
				break;
		}
	}
}