// Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").
// Scripture: Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.

public class Scripture

{
	// _reference : Reference
	// _words : List<Word>

	public Scripture(ref Reference reference, string text)
	{

	}

	public void HideRandomWords(int numberToHide)
	{

	}
	public string GetDisplayText()
	{
		return "";
	}

	public bool IsCompletelyHidden()
	{
		return;
	}

}