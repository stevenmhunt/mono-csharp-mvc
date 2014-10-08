using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.History;

namespace StevenHunt.MonoCSharpMvc.Data
{
	public class DataContextHistory : HistoryContext
	{
		public DataContextHistory(
			DbConnection existingConnection,
			string defaultSchema)
			: base(existingConnection, defaultSchema)
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// this code handles the issue with MySQL index limitations.
			// [1](http://bit.ly/TWuNyi)
			modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
			modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(200).IsRequired();
		}
	}
}
