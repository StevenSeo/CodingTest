using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CodingTest.Models
{
	public class Db : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Product> Products { get; set; }



		public Db()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static Db Create()
		{
			return new Db();
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}



		#region Clearer Db Exceptions
		public override int SaveChanges()
		{
			// http://stackoverflow.com/questions/15820505/dbentityvalidationexception-how-can-i-easily-tell-what-caused-the-error
			try
			{
				return base.SaveChanges();
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException ex)
			{
				var tuple = parseEntityValidationException(ex);
				// Throw a new DbEntityValidationException with the improved exception message.
				throw new DbEntityValidationException(tuple.Item1, tuple.Item2);
			}
		}

		public override async System.Threading.Tasks.Task<int> SaveChangesAsync()
		{
			try
			{
				return await base.SaveChangesAsync();
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException ex)
			{
				var tuple = parseEntityValidationException(ex);
				// Throw a new DbEntityValidationException with the improved exception message.
				throw new DbEntityValidationException(tuple.Item1, tuple.Item2);
			}
		}

		protected Tuple<string, IEnumerable<DbEntityValidationResult>> parseEntityValidationException(System.Data.Entity.Validation.DbEntityValidationException ex)
		{
			// Retrieve the error messages as a list of strings.
			var errorMessages = ex.EntityValidationErrors
					.SelectMany(x => x.ValidationErrors)
					.Select(x => x.PropertyName + ": " + x.ErrorMessage);
	
			// Join the list to a single string.
			var fullErrorMessage = string.Join(" ", errorMessages);
	
			// Combine the original exception message with the new one.
			var exceptionMessage = string.Concat(ex.Message, " ", fullErrorMessage);

			// Pass the details for a new DbEntityValidationException with the improved exception message.
			return new Tuple<string, IEnumerable<DbEntityValidationResult>>(exceptionMessage, ex.EntityValidationErrors);
		}
		#endregion
	}
}