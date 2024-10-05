// Word: Keeps track of a single word and whether it is shown or hidden.
// _text: string
// _isHidden : bool

public class Word
{
	private string _text;
	private bool _isHidden = false;


	public Word(string text)
	{
		_text = text;
		_isHidden = false;
	}

	public void Hide()
	{
		_isHidden = true;
	}

	public void Show()
	{
		_isHidden = false;
	}

	public bool IsHidden()
	{
		return _isHidden;
	}

	public string GetDisplayText()
	{
		if (IsHidden())
		{
			return " ";
		}
		else
		{
			return _text;
		}
	}
}