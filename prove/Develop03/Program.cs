using System;

class Program
{
	static void Main(string[] args)
	{
		bool isRunning = true;

		// Scripture scripture = new Scripture(new Reference("Ether", 12, 4), "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.");

		Scripture scripture = new Scripture(new Reference("Matthew", 28, 19, 20), "19 Go ye therefore, and teach all nations, baptizing them in the name of the Father, and of the Son, and of the Holy Ghost. 20 Teaching them to observe all things whatsoever I have commanded you: and, lo, I am with you alway, even unto the end of the world. Amen.");

		while (isRunning)

		{
			Console.WriteLine(scripture.GetDisplayText());
			Console.WriteLine("Press enter to continue or type 'quit' to quit");

			switch (Console.ReadLine())
			{
				case "quit":
					isRunning = false;
					Console.WriteLine("Thank you");
					break;

				default:
					scripture.HideRandomWords(3);
					if (scripture.IsCompletelyHidden())
					{
						isRunning = false;
					}
					break;
			}
		}
	}
}