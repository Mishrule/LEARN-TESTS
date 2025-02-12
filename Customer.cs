using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARN_TESTS
{
	public class Customer
	{
		public string Name => "Mish";
		
		public int Age => 35;

		public int GetOrdersByName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException("Hello");
			}

			return 100;
		}
	}


	public class LoyalCustomer : Customer
	{
		public int Discount
		{
			get;
			set;
		}

		public LoyalCustomer()
		{
			Discount = 101;
		}
	}

	public static class CustomerFactory
	{
		public static Customer CreateCustomerInstance(int orderCount)
		{
			if (orderCount <= 100)
				return new Customer();
			else
				return new LoyalCustomer();
		}
	}


}
