using System;
using System.Collections.Generic;
public abstract class Activity
{

	protected DateTime Date { get; set; }
	protected int Minutes { get; set; }

	public Activity(string date, int minutes)
	{
		Date = DateTime.Parse(date);
		Minutes = minutes;
	}

	public virtual double CalculateDistance()
	{
		return 0.0;
	}
	public virtual double CalculateSpeed()
	{
		return 0.0;
	}
	public virtual double CalculatePace()
	{
		return 0.0;
	}
	public abstract string GetSummary();
}
