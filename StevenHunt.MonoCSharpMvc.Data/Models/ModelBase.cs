using System;

namespace StevenHunt.MonoCSharpMvc.Data.Models
{
	/// <summary>
	/// Provides a base implementation for all code-first models in the data layer.
	/// </summary>
	public abstract class ModelBase
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public int Id { get; set; }
	}
}

