using System;
using System.Collections.Generic;

namespace StevenHunt.MonoCSharpMvc.Data.Models
{
	/// <summary>
	/// Represents a product available for purchase.
	/// </summary>
	public class Product : ModelBase
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description { get; set; }

		/// <summary>
		/// The price of the product.
		/// </summary>
		/// <value>The price.</value>
		public decimal UnitPrice { get; set; }

		/// <summary>
		/// Gets or sets the loyal customers.
		/// </summary>
		/// <value>The loyal customers.</value>
		public ICollection<Customer> LoyalCustomers { get; set; }
	}
}