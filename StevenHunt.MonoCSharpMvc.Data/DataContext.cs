using System;
using System.Data.Entity;
using System.Linq;

using StevenHunt.MonoCSharpMvc.Data.Models;

namespace StevenHunt.MonoCSharpMvc.Data
{
	/// <summary>
	/// The data context which provides an interface into the MySQL database.
	/// </summary>
	[DbConfigurationType(typeof(DataContextConfig))] 
	public class DataContext : DbContext
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="StevenHunt.MonoCSharpMvc.Data.DataContext"/> class.
		/// </summary>
		public DataContext() : base ("name=SqlConn")
		{
		}

		/// <summary>
		/// Gets or sets the customers.
		/// </summary>
		/// <value>The customers.</value>
		public IDbSet<Customer> Customers { get; set; }

		/// <summary>
		/// Gets or sets the orders.
		/// </summary>
		/// <value>The orders.</value>
		public IDbSet<Order> Orders { get; set; }

		/// <summary>
		/// Gets or sets the products.
		/// </summary>
		/// <value>The products.</value>
		public IDbSet<Product> Products { get; set; }

		/// <summary>
		/// From .Net Framework:
		/// This method is called when the model for a derived context has been initialized, but
		///  before the model has been locked down and used to initialize the context. The default
		///  implementation of this method does nothing, but it can be overridden in a derived class
		///  such that the model can be further configured before it is locked down.
		/// </summary>
		/// <remarks>Typically, this method is called only once when the first instance of a derived context
		///  is created. The model for that context is then cached and is for all further instances of
		///  the context in the app domain. This caching can be disabled by setting the ModelCaching
		///  property on the given ModelBuidler, but note that this can seriously degrade performance.
		///  More control over caching is provided through use of the DbModelBuilder and DbContextFactory
		///  classes directly.</remarks>
		/// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			// example for many-to-many relationship:
			modelBuilder.Entity<Customer>().
			HasMany(customer => customer.FavoriteProducts).
			WithMany(product => product.LoyalCustomers).
			Map(
				m =>
				{
					m.MapLeftKey("CustomerId");
					m.MapRightKey("ProductId");
					m.ToTable("CustomerProductFavorites");
				});
		}
	}
}