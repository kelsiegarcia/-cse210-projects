using System;

class Program
{
	static void Main(string[] args)
	{
		List<Shape> shapes = new List<Shape>();
		Square s1 = new Square("Red", 5);
		shapes.Add(s1);
		shapes.Add(new Circle("Yellow", 5));
		shapes.Add(new Rectangle("Blue", 5, 10));


		foreach (Shape shape in shapes)
		{
			string color = shape.GetColor();
			double area = shape.GetArea();

			Console.WriteLine($"The {color} shape has an area of {area}");
		}



	}
}