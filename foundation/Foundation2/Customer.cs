public class Customer
{
	private string _name;
	private Address _address;


	public Customer(string name, Address address)
	{
		_name = name;
		_address = address;
	}

	public string GetDisplayText()
	{
		return $"Name: {_name}\n{_address.shippingLabel()}\n{_address.packagingLabel()}";
	}

	public bool IsInUSA()
	{
		return _address.IsInUSA();
	}
}