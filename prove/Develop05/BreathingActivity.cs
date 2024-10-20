using System;

public class BreathingActivity : Activity

{
	public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
	{

	}

	public void Run(int duration)
	{
		DisplayStartingMessage();
		Console.Write("Get ready to start your breathing exercises...");
		Console.WriteLine();
		Console.WriteLine("Starting in...");
		Console.WriteLine();
		ShowCountdown();

		DateTime endTime = DateTime.Now.AddSeconds(duration);
		while (DateTime.Now < endTime)
		{
			Console.WriteLine("...Breath in...");
			ShowCountdown();
			Console.WriteLine();
			Console.WriteLine("...Breath out...");
			ShowCountdown();
			Console.WriteLine();
		}
		DisplayEndingMessage();
	}
}