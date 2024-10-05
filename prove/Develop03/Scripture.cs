// Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").
// Scripture: Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
using System;
using System.Collections.Generic;
using System.Linq;
public class Scripture

{
	// _reference : Reference
	private Reference _reference;
	// _words : List<Word>
	private List<Word> _words = new List<Word>();

	public Scripture(Reference reference, string text)
	{
		_reference = reference;
		foreach (var word in text.Split(' '))
		{
			_words.Add(new Word(word));
		}
	}

	public void HideRandomWords(int numberToHide)
	{
		Random random = new Random();
		int availableWords = _words.Count(w => !w.IsHidden());

		if (numberToHide > availableWords)
		{
			numberToHide = availableWords;
		}
		int hiddenCount = 0;
		while (hiddenCount < numberToHide)
		{
			int i = random.Next(0, _words.Count);
			if (!_words[i].IsHidden())
			{
				_words[i].Hide();
				hiddenCount++;
			}

			if (availableWords == 0)
			{
				break;
			}
		}
	}
	public string GetDisplayText()
	{
		// Get the reference display text
		string referenceText = _reference.GetDisplayText();

		// Get the processed scripture text with hidden words
		string scriptureText = string.Join(" ", _words.Select(word => word.IsHidden() ? "___" : word.GetDisplayText()));

		// Combine both parts
		return $"\n\n {referenceText} \n {scriptureText} \n";
	}

	public bool IsCompletelyHidden()
	{
		return _words.All(w => w.IsHidden());
	}



}