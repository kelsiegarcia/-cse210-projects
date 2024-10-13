using System.IO;
using System;
using System.Collections.Generic;

public class Video
{
	public string _title;
	public string _author;
	public int _length;

	// public List<Video> _videos = new List<Video>();
	public List<Comment> _comments = new List<Comment>();

	public Video(string title, string author, int length)
	{
		_title = title;
		_author = author;
		_length = length;
	}


	public void DisplayVideo()
	{
		Console.WriteLine();
		Console.WriteLine("Video Info:");
		Console.WriteLine($"Title: {_title}");
		Console.WriteLine($"Author: {_author}");
		Console.WriteLine($"Length: {_length} seconds");
		Console.WriteLine();
		Console.WriteLine("Comments:");

		foreach (Comment comment in _comments)
		{
			comment.DisplayComment();
		}
	}
}