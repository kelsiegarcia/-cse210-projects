public class Product
{
	private string _prodName;
	private int _prodID;
	private int _price;
	private int _quantity;

	public Product(string prodName, int prodID, int price, int quantity)
	{
		_prodName = prodName;
		_prodID = prodID;
		_price = price;
		_quantity = quantity;
	}

	public int ComputeTotal()
	{
		return _price * _quantity;
	}

	public string GetDisplayText()
	{
		return $"\nProduct Name: {_prodName}, Product ID: {_prodID}, Price: {_price}, Quantity: {_quantity}";
	}


}