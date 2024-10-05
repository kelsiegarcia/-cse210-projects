// Reference: Keeps track of the book, chapter, and verse information
// _book: string
// _chapter : int
// _verse : int
// _endVerse : int ?
public class Reference

{
	private string _book;
	private int _chapter;
	private int _verse;
	private int _endVerse;

	public Reference(string book, int chapter, int verse)
	{
		_book = book;
		_chapter = chapter;
		_verse = verse;

	}

	public Reference(string book, int chapter, int verse, int endVerse)
	{
		_book = book;
		_chapter = chapter;
		_verse = verse;
		_endVerse = endVerse;
	}

	public string GetDisplayText()
	{
		return _endVerse > 0 ? $"{_book} {_chapter}:{_verse}-{_endVerse}" : $"{_book} {_chapter}:{_verse}";
	}
}