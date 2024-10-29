public class Swimming : Activity
{
	private int Laps { get; set; }

	public Swimming(string date, int minutes, int laps) : base(date, minutes)
	{
		Laps = laps;
	}

	public override double CalculateDistance() => (Laps * 50) / 1000.0 * 0.62; // Convert meters to miles
	public override double CalculateSpeed() => (CalculateDistance() / Minutes) * 60;
	public override double CalculatePace() => Minutes / CalculateDistance();

	public override string GetSummary()
	{
		return $"{Date} Swimming ({Minutes} min): Distance {CalculateDistance():F1} miles, Speed {CalculateSpeed():F1} mph, Pace: {CalculatePace():F1} min per mile";
	}
}