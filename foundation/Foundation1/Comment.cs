using System;
using System.Collections.Generic;
public class Comment
{
	public string _name;
	public string _text;

	public Comment(string name, string text)
	{
		_name = name;
		_text = text;
	}

	public void DisplayComment()
	{
		Console.WriteLine($"Name: {_name}");
		Console.WriteLine($"Text: {_text}");
		Console.WriteLine();
	}
}