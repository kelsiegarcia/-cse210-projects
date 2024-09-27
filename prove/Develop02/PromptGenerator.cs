using System;
using System.Collections.Generic;
// should store a list of potential prompts that can select randomly when selected
// _prompts : List<string>
// random class method
public class PromptGenerator
{
	//creates a Random class for the random method below
	public Random random = new Random();

	// create a list of prompts
	public List<string> _prompts = new List<string>(){
		"What is the name of the book you have read that has left an impression on you?", "What do you think or feel when you go outside into nature?", "Who is someone that you are grateful for in your life?", "If you could choose to talk with anyone in history or present time, who would it be?"
	};
	// returns a random prompt from the new class above and list of string _prompts, never the same each time
	// GetRandomPrompt() : string
	public string GetRandomPrompt()
	{
		return _prompts[random.Next(0, _prompts.Count)];
	}
}