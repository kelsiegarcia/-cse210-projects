using System;

public class ListingActivity : Activity
{
	public ListingActivity(string name, string description, int duration) : base("Listing", "Listing is a great way to relax and calm your mind.", duration)
	{

	}

	public void GetRandomPrompt()
	{
		string[] prompts = new string[] { "List as many things as you can think of that make you happy.", "List as many things as you can think of that you are grateful for.", "List as many things as you can think of that you are looking forward to.", "List as many things as you can think of that you are proud of.", "List as many things as you can think of that you are struggling with." };
		Random random = new Random();
		int index = random.Next(prompts.Length);
		Console.WriteLine(prompts[index]);
	}

	public void GetListFromUser(int duration)
	{
		List<string> list = new List<string>();
		DateTime endTime = DateTime.Now.AddSeconds(duration);
		Console.WriteLine("You have " + duration + " seconds to list as many items as you can. Start now!");

		while (DateTime.Now < endTime)
		{
			// get input from user
			string input = Console.ReadLine();
			// if the input is not empty, add it to the list
			if (!string.IsNullOrEmpty(input))
			{
				list.Add(input);
			}
			// add a small delay to prevent the loop from running too fast
			System.Threading.Thread.Sleep(100);
		}
		Console.WriteLine();
	}



	public void Run(int seconds)
	{
		DisplayStartingMessage();
		Console.WriteLine();
		Console.WriteLine("Watch for the prompt and list as many things as you can think of...");
		ShowCountdown();
		GetRandomPrompt();
		Console.WriteLine();
		GetListFromUser(seconds);
		DisplayEndingMessage();
	}
}