using System;
using System.Collections.Generic;

namespace StevenHunt.MonoCSharpMvc.Data.Models
{
	/// <summary>
	/// Represents a customer's information.
	/// </summary>
	public class Customer : ModelBase
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		/// <value>The email address.</value>
		public string EmailAddress { get; set; }

		/// <summary>
		/// Gets or sets the postal code.
		/// </summary>
		/// <value>The postal code.</value>
		public string PostalCode { get; set; }

		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City { get; set; }

		/// <summary>
		/// Gets or sets the region.
		/// </summary>
		/// <value>The region.</value>
		public string Region { get; set; }

		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
		public string Country { get; set; }

		/// <summary>
		/// Gets or sets the address.
		/// </summary>
		/// <value>The address.</value>
		public string Address { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the address confirmed.
		/// </summary>
		/// <value><c>true</c> if the address confirmed; otherwise, <c>false</c>.</value>
		public bool IsAddressConfirmed { get; set; }

		/// <summary>
		/// Gets or sets the date created.
		/// </summary>
		/// <value>The date created.</value>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// Represents a collection of orders associated with this customer.
		/// </summary>
		/// <value>The surveys.</value>
		public virtual ICollection<Order> Orders { get; set; }

		/// <summary>
		/// Gets or sets the favorite products.
		/// </summary>
		/// <value>The favorite products.</value>
		public virtual ICollection<Product> FavoriteProducts { get; set; }
	}
}