using System;
using System.Data.Entity;

namespace StevenHunt.MonoCSharpMvc.Data
{
	public class DataContextConfig : DbConfiguration 
	{ 
		public DataContextConfig() 
		{ 
			this.SetHistoryContext("MySql.Data.MySqlClient", 
				(connection, defaultSchema) => new DataContextHistory(connection, defaultSchema)); 
		} 
	} 
}