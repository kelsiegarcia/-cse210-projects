public class Cycling : Activity
{
	private double _speed;

	public double Speed
	{
		get { return _speed; }
		set { _speed = value; }
	}

	public Cycling(string date, int minutes, double speed) : base(date, minutes)
	{
		Speed = speed;
	}

	public override double CalculateDistance()
	{
		return (Speed * Minutes) / 60;
	}
	public override double CalculateSpeed() => Speed; // shorthand for { return Speed; }	
	public override double CalculatePace() => 60 / Speed;

	public override string GetSummary()
	{
		return $"{Date} Cycling ({Minutes} min): Distance {CalculateDistance():F1} miles, Speed {Speed} mph, Pace: {CalculatePace():F1} min per mile";
	}
}