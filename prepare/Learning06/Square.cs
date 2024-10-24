using System;

public class Square : Shape
{
	private double _side;

	// create a constructor for the Square class that accepts the color and side then call the base constructor with the color
	public Square(string color, double side) : base(color)
	{
		_side = side;

	}

	public override double GetArea()
	{
		return _side * _side;
	}
}