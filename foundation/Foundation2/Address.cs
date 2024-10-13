using System;

public class Address
{
	private string _street;
	private string _city;
	private string _state;
	private bool _isInUSA;

	public Address(string street, string city, string state, bool isInUSA)
	{
		_street = street;
		_city = city;
		_state = state;
		_isInUSA = isInUSA;
	}

	public bool IsInUSA()
	{
		return _isInUSA;
	}

	public string shippingLabel()
	{
		return $"Shipping to:{_street}\n{_city}, {_state}\n{(_isInUSA ? "USA" : "International")}\n";
	}

	public string packagingLabel()
	{
		return $"\nPackage Label:{_street}\n{_city}, {_state}\n{(_isInUSA ? "USA" : "International")}\n";
	}

	public string GetDisplayText()
	{
		return $"{_street}, {_city}, {_state}, {(_isInUSA ? "USA" : "Not USA")}";

	}
}