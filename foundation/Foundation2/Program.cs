using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		// create two orders that has 2-3 products each
		// call methods to get the packaging label, the shipping label, total price of order

		List<Order> orders = new List<Order>();

		Address address1 = new Address("5783 Apple St", "Austin", "TX", true);
		Customer customer1 = new Customer("Kelsie Garcia", address1);

		List<Product> products1 = new List<Product>
		{
			new Product("Pickleball Gear Set", 1, 100, 2),
			new Product("Pickleball Net", 2, 200, 3)
		};
		Order order1 = new Order(customer1, products1);


		Address address2 = new Address("2-2345 Pine St", "Toronto", "Canada", false);
		Customer customer2 = new Customer("David Garcia", address2);

		List<Product> products2 = new List<Product>
		{
			new Product("Pickleball shirt and short set", 3, 150, 1),
			new Product("Pickleball shirt and pants set", 4, 250, 1)
		};
		Order order2 = new Order(customer2, products2);


		orders.Add(order1);
		orders.Add(order2);

		foreach (Order order in orders)
		{
			Console.WriteLine(order.GetDisplayText());
		}



	}
}