using System;
using System.Collections.Generic;

namespace StevenHunt.MonoCSharpMvc.Data.Models
{
	/// <summary>
	/// Represents an order.
	/// </summary>
	public class Order : ModelBase
	{
		/// <summary>
		/// Gets or sets the date created.
		/// </summary>
		/// <value>The date created.</value>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// Gets or sets the customer identifier.
		/// </summary>
		/// <value>The customer identifier.</value>
		public int CustomerId { get; set; }
	
		/// <summary>
		/// Gets or sets the associated customer.
		/// </summary>
		/// <value>The associated customer.</value>
		public virtual Customer Customer { get; set; }

		/// <summary>
		/// Retrieves order lines associated with this order.
		/// </summary>
		/// <value>The symptoms.</value>
		public virtual ICollection<OrderLine> OrderLines { get; set; }
	}
}