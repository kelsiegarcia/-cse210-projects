using System;

class Program
{
	static void Main(string[] args)
	{
		List<Video> _videos = new List<Video>();

		Video video1 = new Video(title: "HTML and CSS", author: "Kelsie", length: 600);
		Video video2 = new Video(title: "JavaScript Programming", author: "David", length: 4500);
		Video video3 = new Video(title: "C# Programming", author: "Bowie", length: 7000);

		Comment comment1 = new Comment(name: "Violet", text: "Great video!");
		Comment anotherComment1 = new Comment(name: "Lucas", text: "More Content!");
		Comment moreComment1 = new Comment(name: "Bowie", text: "Super Cool!");

		Comment comment2 = new Comment(name: "Bowie", text: "How do I call an object?");
		Comment anotherComment2 = new Comment(name: "Lucas", text: "Those loops can be tricky");
		Comment moreComment2 = new Comment(name: "David", text: "More tips please");

		Comment comment3 = new Comment(name: "Kelsie", text: "You're doing great!");
		Comment anotherComment3 = new Comment(name: "Violet", text: "Look at all those classes!");
		Comment moreComment3 = new Comment(name: "David", text: "Thanks for explaining that!");


		_videos.Add(video1);
		_videos.Add(video2);
		_videos.Add(video3);

		video1._comments.Add(comment1);
		video1._comments.Add(anotherComment1);
		video1._comments.Add(moreComment1);

		video2._comments.Add(comment2);
		video2._comments.Add(anotherComment2);
		video2._comments.Add(moreComment2);

		video3._comments.Add(comment3);
		video3._comments.Add(anotherComment3);
		video3._comments.Add(moreComment3);

		foreach (Video video in _videos)
		{
			video.DisplayVideo();
		}

	}
}