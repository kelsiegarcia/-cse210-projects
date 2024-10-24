using System;

public class Circle : Shape
{
	public double _radius;

	public Circle(string color, double radius) : base(color)
	{
		_radius = radius;
	}

	public override double GetArea()
	{
		return Math.PI * Math.Pow(_radius, 2);
	}
}