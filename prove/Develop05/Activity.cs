using System;

public class Activity
{
	protected string _name;
	protected string _description;
	protected int _duration;

	public Activity(string name, string description, int duration)
	{
		_name = name;
		_description = description;
		_duration = duration;
	}

	public void DisplayStartingMessage()
	{
		Console.WriteLine($"{_name} Activity");
		Console.WriteLine();
		Console.WriteLine($"{_description}");
		Console.WriteLine();
		Console.WriteLine($"you will participate for {_duration} seconds");
	}

	public void DisplayEndingMessage()
	{
		Console.WriteLine($"Time is up for now. You chose the {_name} activity for {_duration} seconds. {_description}. Thank you for a wonderful session...");
		Console.WriteLine();
	}

	public void ShowSpinner(int duration)
	{
		List<string> spinner = new List<string> { "|", "/", "-", "\\", "|" };

		for (int i = 0; i < duration; i++)
		{
			Console.Write(spinner[i % spinner.Count]);
			System.Threading.Thread.Sleep(1000);
			Console.Write("\b");
		}
		Console.Write(" ");
		Console.WriteLine();
	}

	public void ShowCountdown()
	{
		for (int i = 5; i > 0; i--)
		{
			Console.Write(i);
			System.Threading.Thread.Sleep(1000);
			Console.Write("\b \b");
		}
	}
}