public class Fraction
{
	// _top:
	// _bottom:
	private int _top;
	private int _bottom;

	// Fraction()
	// Fraction(wholeNumer: int)
	// Fraction(top: int, bottom: int)
	// get
	// GetTop()
	// SetTop(top: int)
	// set
	public Fraction()
	{
		_top = 1;
		_bottom = 1;
	}

	public Fraction(int wholeNumber)
	{
		_top = wholeNumber;
		_bottom = 1;
	}

	public Fraction(int top, int bottom)
	{
		_top = top;
		_bottom = bottom;
	}

	// methods to return representation of both the fractional and decimal views
	// GetFractionString(): string
	public string GetFractionString()
	{
		string text = $"{_top}/{_bottom}";
		return text;
	}
	// GetDecimalValue(): double
	public double GetDecimalValue()
	{
		return (double)_top / (double)_bottom;
	}
}