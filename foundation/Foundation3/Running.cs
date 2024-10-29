public class Running : Activity
{
	private double Distance { get; set; }

	public Running(string date, int minutes, double distance) : base(date, minutes)
	{
		Distance = distance;
	}

	public override double CalculateDistance() => Distance;
	public override double CalculateSpeed() => (Distance / Minutes) * 60;
	public override double CalculatePace() => Minutes / Distance;

	public override string GetSummary()
	{
		return $"{Date} Running ({Minutes} min): Distance {Distance} miles, Speed {CalculateSpeed():F1} mph, Pace: {CalculatePace():F1} min per mile";
	}
}