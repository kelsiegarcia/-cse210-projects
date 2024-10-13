public class Order
{
	private Customer _customer;
	private List<Product> _products;
	private static int _orderCount = 0;
	private int _orderNumber;
	private int _shippingCost;


	public Order(Customer customer, List<Product> products)
	{
		_customer = customer;
		_products = products;
		_orderNumber = ++_orderCount;
		_shippingCost = 0;
	}

	public int ComputeTotal()
	{
		int total = 0;
		foreach (var product in _products)
		{
			total += product.ComputeTotal();
		}

		if (_customer.IsInUSA())
		{
			_shippingCost = 5;
		}
		else
		{
			_shippingCost = 30;
		}

		total += _shippingCost;
		return total;
	}

	public string GetDisplayText()
	{
		ComputeTotal();
		string productDetails = string.Join(", ", _products.ConvertAll(p => p.GetDisplayText()));
		return $"\nOrder Number: {_orderNumber} \n{_customer.GetDisplayText()} \nProducts: {productDetails}\nShipping: ${_shippingCost}\nTotal: ${ComputeTotal()}\n";
	}
}