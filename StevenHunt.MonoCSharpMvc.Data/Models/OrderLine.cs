using System;
using System.Collections.Generic;

namespace StevenHunt.MonoCSharpMvc.Data.Models
{
	/// <summary>
	/// Represents an order.
	/// </summary>
	public class OrderLine : ModelBase
	{
		/// <summary>
		/// Gets or sets the date created.
		/// </summary>
		/// <value>The date created.</value>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// Gets or sets the order identifier.
		/// </summary>
		/// <value>The order identifier.</value>
		public int OrderId { get; set; }
	
		/// <summary>
		/// Gets or sets the associated order.
		/// </summary>
		/// <value>The associated order.</value>
		public virtual Order Order { get; set; }


		/// <summary>
		/// Gets or sets the product identifier.
		/// </summary>
		/// <value>The product identifier.</value>
		public int ProductId { get; set; }

		/// <summary>
		/// Gets or sets the associated product.
		/// </summary>
		/// <value>The associated product.</value>
		public virtual Product Product { get; set; }

		/// <summary>
		/// The product quantity.
		/// </summary>
		/// <value>The quantity.</value>
		public int Quantity { get; set; }
	}
}