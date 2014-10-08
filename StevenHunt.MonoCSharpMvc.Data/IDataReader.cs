using System;
using System.Linq;

using StevenHunt.MonoCSharpMvc4.Data.Models;

namespace StevenHunt.MonoCSharpMvc4.Data
{
	public interface IDataReader
	{
		IQueryable<Profile> Profiles { get; }
		IQueryable<Survey> Surveys { get; }
		IQueryable<Symptom> Symptoms { get; }
	}
}